using DOK_U.Classes;
using DOK_U.Forms;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace DOK_U
{
    public partial class AuthorizeForm : Form
    {
        #region Vars

        private bool isEnterMode = true;
        private bool askToClose = true;
        private DatabaseContext db = new DatabaseContext();
        public static JsonSerializerOptions OPTIONS = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        public static string sex;
        public static int groupId;
        public static DateTime birthday;
        public static string firstName;
        public static string lastName;
        public static string surname;
        public static bool registrate = false;

        #endregion

        public AuthorizeForm()
        {
            InitializeComponent();
            loginTextBox.Click += TextBoxOnClick;
            passwordTextBox.Click += TextBoxOnClick;
            FormClosing += Authorize_FormClosing;
            LoadDB();
        }

        public void forgetPasswordTool_MouseHover(object sender, EventArgs args)
        {
            HighlightText(sender, args, Color.CornflowerBlue);
        }

        public void forgetPasswordTool_MouseLeave(object sender, EventArgs args)
        {
            HighlightText(sender, args, Color.Black);
        }

        private void LoadDB()
        {
            db.Database.EnsureCreated();
            db.Users.Load();
            db.Marks.Load();
            DataContext = db.Users.Local.ToObservableCollection();
        }

        private void HighlightText(object sender, EventArgs args, Color color)
        {
            var label = (Label)sender;
            label.ForeColor = color;
        }

        private void TextBoxOnClick(object sender, EventArgs eventArgs)
        {
            var textBox = (TextBox)sender;
            textBox.SelectAll();
            textBox.Focus();
        }

        private void ChangeMode()
        {
            isEnterMode = !isEnterMode;
            passwordTextBox.UseSystemPasswordChar = true;
            showPasswordButton.Checked = false;
            loginTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            if (isEnterMode)
            {
                Text = "Вход";
                forgetPasswordTool.Show();
                loginTextBox.PlaceholderText = "Ваш логин";
                passwordTextBox.PlaceholderText = "Ваш пароль";
                changeModeButton.Text = "Регистрация";
                enterButton.Text = "Войти";
            }
            else
            {
                Text = "Регистрация";
                forgetPasswordTool.Hide();
                loginTextBox.PlaceholderText = "Придумайте логин";
                passwordTextBox.PlaceholderText = "Придумайте пароль";
                changeModeButton.Text = "Вход";
                enterButton.Text = "Зарегестрироваться";
            }
        }

        private void changeModeButton_Click(object sender, EventArgs e)
        {
            ChangeMode();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (isEnterMode)
            {
                Authorize();
            }
            else
            {
                Registrate();
            }
        }

        private void Registrate()
        {
            var login = loginTextBox.Text;
            if (login.Length < 4 || login.Length > 16)
            {
                MessageBox.Show("Длина логина должна быть больше 4 и меньше 16 символов",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            var count = db.Users.FromSqlRaw(
                "SELECT * FROM Users " +
                "WHERE " +
                $"  Login = '{login}' " +
                "LIMIT 1").Count();

            if (count > 0)
            {
                MessageBox.Show("Данный логин уже занят, попробуйте какой-нибудь другой",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            var password = passwordTextBox.Text;
            if (password.Length < 8 || password.Length > 16)
            {
                MessageBox.Show("Длина пароля должна быть больше 8 и меньше 16 символов",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            var reg = new RegistrationForm();
            reg.ShowDialog();
            if (registrate)
            {
                var user = new Person(
                    db.Users.Count() + 1,
                    firstName,
                    lastName,
                    surname,
                    sex,
                    false,
                    login,
                    password,
                    birthday,
                    groupId,
                    "--");


                var indent = db.Marks.Count();
                for (int i = 0; i < 8 * 7; i++)
                {
                    db.Marks.Add(new Mark(indent + i + 1, user.Id, 1, i % 8 + 1, "--"));
                }

                db.Users.Add(user);
                db.SaveChanges();
                ChangeMode();
                registrate = false;

                MessageBox.Show("Регистрация прошла успешно. Пожалуйста, войдите в систему",
               "Успех",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void Authorize()
        {
            var user = db.Users.FromSqlRaw(
                "SELECT * FROM Users " +
                "WHERE " +
                $"  Login = '{loginTextBox.Text}' AND " +
                $"  Password = '{passwordTextBox.Text}' " +
                $"LIMIT 1").ToList();
            if (user.Count() > 0)
            {
                try
                {
                    user[0].Password = string.Empty;
                    user[0].ReserveCode = string.Empty;

                    File.WriteAllText(MainForm.INITIAL_FILE,
                        JsonSerializer.Serialize<Person>(user[0], OPTIONS));
                    askToClose = false;
                    MessageBox.Show("Вход выполнен успешно",
                        "Вход",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.StackTrace,
                        "IO Exception",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (JsonException ex)
                {
                    MessageBox.Show(ex.StackTrace,
                        "Initial file esception",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Authorize_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (askToClose)
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    askToClose = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void showPasswordButton_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordButton.Checked;
        }

        private void forgetPasswordTool_Click(object sender, EventArgs e)
        {
            var resetForm = new ResetPasswordForm();
            resetForm.ShowDialog();
            db.Users.Load();
        }
    }
}