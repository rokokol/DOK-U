using DOK_U.Classes;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;


namespace DOK_U.Forms
{
    public partial class RegistrationForm : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public RegistrationForm()
        {
            InitializeComponent();
            LoadDB();
            LoadContent();
        }

        private void LoadContent()
        {
            var groups = db.Groups.ToList();
            foreach (var group in groups)
            {
                var number = group.GroupNumber;
                if (number != "--")
                    groupBox.Items.Add(group.GroupNumber);
            }
        }

        private void LoadDB()
        {
            db.Database.EnsureCreated();
            db.Users.Load();
            db.Groups.Load();
            DataContext = db.Users.Local.ToObservableCollection();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            var firstName = firstNameBox.Text;
            var lastName = lastNameBox.Text;
            var surname = surnameBox.Text;
            if (firstName == string.Empty || lastName == string.Empty || surname == string.Empty)
            {
                MessageBox.Show("Введите ваши имя, фамилию и отчество",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            if (firstName.Split(" ").Count() > 1 || lastName.Split(" ").Count() > 1 || surname.Split(" ").Count() > 1)
            {
                MessageBox.Show("Имя, фамилия или отчество должны состоять из одного слова",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            if (groupBox.SelectedItem == null)
            {
                MessageBox.Show("Выберете группу",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }


            AuthorizeForm.firstName = firstName;
            AuthorizeForm.lastName = lastName;
            AuthorizeForm.surname = surname;
            AuthorizeForm.birthday = birthdayPicker.Value;
            AuthorizeForm.sex = male.Checked ? "М" : "Ж";
            AuthorizeForm.groupId = db.Groups.FromSqlRaw(
                "SELECT * FROM Groups " +
                "WHERE " +
                $"  GroupNumber = '{groupBox.SelectedItem}' " +
                $"LIMIT 1").ToList()[0].Id;
            AuthorizeForm.registrate = true;

            Close();
        }
    }
}
