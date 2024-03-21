using System.Text.Json;
using DOK_U.Classes;
using Microsoft.EntityFrameworkCore;

namespace DOK_U
{
    public partial class MainForm : Form
    {
        #region Vars

        private Person currentUser;
        public static readonly string INITIAL_FILE = "../../../Source/Initial.json";
        private DatabaseContext db = new DatabaseContext();

        #region Boxes

        private ListBox[] lectureBoxes;
        private ListBox[] cabinetBoxes;
        private ListBox[] recordLectureBoxes;
        private ListBox[] markBoxes;

        #endregion

        #endregion

        public MainForm()
        {
            InitializeComponent();
            contentTabs.SizeMode = TabSizeMode.Fixed;
            FormClosing += MainForm_FormClosing;
            FillArrays();
            notifyIcon.ContextMenuStrip = new ContextMenuStrip();
            notifyIcon.ContextMenuStrip.Items.Add("Закрыть приложение", null,
                delegate { Application.Exit(); });
            Authorize();
            LoadDB();
        }

        private void LoadDB()
        {
            db.Database.EnsureCreated();
            db.Users.Load();
            db.Groups.Load();
            DataContext = db.Users.Local.ToObservableCollection();
        }

        private void Authorize()
        {
            if (!TryAuthorize())
            {
                var authorize = new AuthorizeForm();
                authorize.ShowDialog();
                TryAuthorize();
            }

            notifyIcon.Visible = true;
            SetupUser(currentUser);
        }

        private void SetupUser(Person user)
        {
            if (user != null)
            {
                nameContent.Text = $"{user.LastName} {user.FirstName} {user.Surname}";
                loginContent.Text = user.Login;
                birthdayContent.Text = $"{user.Birthday.Day:D2}.{user.Birthday.Month:D2}.{user.Birthday.Year}";
                sexContent.Text = user.Sex == "М" ? "Мужской" : "Женский";
                groupContent.Text = db.Groups.Find(currentUser.GroupId).GroupNumber;

                if (user.IsAdmin)
                {
                    ToggleAdminSettings();
                }
            }
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                e.Cancel = true;
            }
        }
        
        private bool TryAuthorize()
        {
            if (File.Exists(INITIAL_FILE))
            {
                try
                {
                    currentUser = JsonSerializer.Deserialize<Person>
                        (File.ReadAllText(INITIAL_FILE));
                    return true;
                }
                catch (IOException e)
                {
                    return false;
                }
                catch (JsonException e)
                {
                    return false;
                }
            }

            return false;
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            contentTabs.SelectTab("profile");
            profileButton.Enabled = false;
            diaryButton.Enabled = true;
            recordBookButton.Enabled = true;
            infoButton.Enabled = true;
        }

        private void diaryButton_Click(object sender, EventArgs e)
        {
            contentTabs.SelectTab("diary");
            profileButton.Enabled = true;
            diaryButton.Enabled = false;
            recordBookButton.Enabled = true;
            infoButton.Enabled = true;
        }

        private void recordBookButton_Click(object sender, EventArgs e)
        {
            contentTabs.SelectTab("recordBook");
            profileButton.Enabled = true;
            diaryButton.Enabled = true;
            recordBookButton.Enabled = false;
            infoButton.Enabled = true;
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            contentTabs.SelectTab("info");
            profileButton.Enabled = true;
            diaryButton.Enabled = true;
            recordBookButton.Enabled = true;
            infoButton.Enabled = false;
        }

        private void notifyIcon_MouseClick(object sender, EventArgs eventArgs)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
            }
            
            Activate();
        }

        private void FillArrays()
        {
            lectureBoxes = new[]
            {
                lectureBox1,
                lectureBox2,
                lectureBox3,
                lectureBox4,
                lectureBox5,
                lectureBox6
            };

            cabinetBoxes = new[]
            {
                cabinetBox1,
                cabinetBox2,
                cabinetBox3,
                cabinetBox4,
                cabinetBox5,
                cabinetBox6
            };

            recordLectureBoxes = new[]
            {
                recordLectureBox1,
                recordLectureBox2,
                recordLectureBox3,
                recordLectureBox4,
                recordLectureBox5,
                recordLectureBox6,
                recordLectureBox7
            };

            markBoxes = new[]
            {
                markBox1,
                markBox2,
                markBox3,
                markBox4,
                markBox5,
                markBox6,
                markBox7
            };
        }
        
        private void ToggleAdminSettings()
        {
            foreach (var box in lectureBoxes)
            {
                box.Enabled = !box.Enabled;
            }

            foreach (var box in cabinetBoxes)
            {
                box.Enabled = !box.Enabled;
            }

            foreach (var box in recordLectureBoxes)
            {
                box.Enabled = !box.Enabled;
            }

            foreach (var box in markBoxes)
            {
                box.Enabled = !box.Enabled;
            }

            groupBox.Enabled = !groupBox.Enabled;
            studentBox.Enabled = !studentBox.Enabled;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти?", 
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти из учетной записи?", 
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                File.Delete(INITIAL_FILE);
                Authorize();
            }
        }
    }
}