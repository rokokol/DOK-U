using DOK_U.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;

namespace DOK_U
{
    public partial class AuthorizeForm : Form
    {
        #region Vars

        private bool isEnterMode = true;
        private bool askToClose = true;
        private DatabaseContext db = new DatabaseContext();

        #endregion

        public AuthorizeForm()
        {
            InitializeComponent();
            loginTextBox.AccessibleDescription = "Ваш логин";
            loginTextBox.Click += TextBoxOnClick;
            passwordTextBox.Click += TextBoxOnClick;
            FormClosing += Authorize_FormClosing;
            //db.Database.EnsureDeleted();
            LoadDB();
            //var user = new Person(1,
            //            "Диана",
            //            "Логинова",
            //            "Романовна",
            //            "Ж",
            //            false,
            //            "SLDR",
            //            "12345678",
            //            new DateTime(2005, 04, 25),
            //            1,
            //            "password");
            //db.Users.Add(user);
            //var group = new Group(1, "09-321(1)");
            //db.Groups.Add(group);
            //db.SaveChanges();
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
            db.Groups.Load();
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

        private void changeModeButton_Click(object sender, EventArgs e)
        {
            isEnterMode = !isEnterMode;
            passwordTextBox.UseSystemPasswordChar = true;
            showPasswordButton.Checked = false;
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

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Length < 8)
            {
                MessageBox.Show("Минимальная длина пароля - 8 символов",
                    "Пароль слишком короткий",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

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

        }

        private void Authorize()
        {
            var user = db.Users.FromSqlRaw(
                "SELECT * FROM Users " +
                "WHERE " +
                $"Login = '{loginTextBox.Text}' " +
                $"AND " +
                $"Password = '{passwordTextBox.Text}' " +
                $"LIMIT 1").ToList();
            if (user.Count() > 0)
            {
                try
                {
                    user[0].Password =  string.Empty;
                    user[0].ReserveCode = string.Empty;
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };

                    File.WriteAllText(MainForm.INITIAL_FILE,
                        JsonSerializer.Serialize<Person>(user[0], options));
                    askToClose = false;
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
    }
}