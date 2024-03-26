using DOK_U.Classes;
using Microsoft.EntityFrameworkCore;


namespace DOK_U
{
    public partial class ResetPasswordForm : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public ResetPasswordForm()
        {
            InitializeComponent();
            LoadDB();
        }

        private void LoadDB()
        {
            db.Database.EnsureCreated();
            db.Users.Load();
            DataContext = db.Users.Local.ToObservableCollection();
        }

        private void showPasswordButton_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordButton.Checked;
            passwordConfirmTextBox.UseSystemPasswordChar = !showPasswordButton.Checked;
        }

        private void recoverButton_Click(object sender, EventArgs e)
        {
            var password = passwordConfirmTextBox.Text;
            if (password != passwordTextBox.Text || password.Length < 8 || password.Length > 16)
            {
                MessageBox.Show("Пароли не совпадают или длина введенного пароля меньше 8 символов или больше 16",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            var user = db.Users.FromSqlRaw(
                "SELECT * FROM Users " +
                "WHERE " +
                $"   Login = '{loginBox.Text}' " +
                $"LIMIT 1").ToList();

            // "Неверный логин или резервный код"
            var code = codeTextBox.Text;
            if (user.Count == 0 || user[0].ReserveCode != code || code.Length < 8)
            {
                MessageBox.Show(user[0].ReserveCode,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            user[0].Password = password;
            user[0].ReserveCode = "--";
            db.SaveChanges();
            MessageBox.Show("Ваш пароль успешно обновлен\n" +
                "Не забудьте создать новый резервный код в личном кабинете! Он одноразовый и тот, что вы ввели уже потерял свою силу",
                "Пароль обновлен!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Close();
        }
    }
}