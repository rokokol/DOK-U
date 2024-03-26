using DOK_U.Classes;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;


namespace DOK_U.Forms
{
    public partial class ChangeLoginForm : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public ChangeLoginForm()
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

        private void enterButton_Click(object sender, EventArgs e)
        {
            var login = loginBox.Text;
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

            db.Users.Find(MainForm.currentUser.Id).Login = login;
            db.SaveChanges();

            var user = JsonSerializer.Deserialize<Person>
                        (File.ReadAllText(MainForm.INITIAL_FILE));
            user.Login = login;
            File.WriteAllText(MainForm.INITIAL_FILE,
                        JsonSerializer.Serialize<Person>(user, AuthorizeForm.OPTIONS));
            MainForm.currentUser.Login = login;

            MessageBox.Show("Ваш логин успешно обновлен\n",
                "Логин обновлен!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Close();
        }
    }
}
