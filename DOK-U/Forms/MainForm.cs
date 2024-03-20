using System;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;

namespace DOK_U
{
    public partial class MainForm : Form
    {
        #region Constants

        public static MainForm FORM { private set; get; }
        private static Person currentUser;
        public static readonly string INITIAL_FILE = "../../Source/Initial.json";

        #endregion

        private ListBox[] lectureBoxes;
        private ListBox[] cabinetBoxes;
        private ListBox[] recordLectureBoxes;
        private ListBox[] markBoxes;
        
        public MainForm()
        {
            InitializeComponent();
            notifyIcon.Click += notifyIcon_MouseClick;
            FormClosing += MainForm_FormClosing;
            FORM = this;
            contentTabs.SizeMode = TabSizeMode.Fixed;
            diaryButton.Enabled = false;
            FillArrays();
            Authorize();
        }

        private void Authorize()
        {
            if (!TryAuthorize())
            {
                Enabled = false;
                var authorize = new AuthorizeForm();
                authorize.ShowDialog();
                TryAuthorize();
            }
            SetupUser(currentUser);
        }

        private void SetupUser(Person user)
        {
            nameContent.Text = $"{user.LastName} {user.FirstName} {user.Surname}";
            loginContent.Text = user.Login;
            birthdayContent.Text = $"{user.Birthday.Day}.{user.Birthday.Month}.{user.Birthday.Year}";
            sexContent.Text = user.Sex == "M" ? "Мужской" : "Женский";
            groupContent.Text = user.Group;
            
            if (user.IsAdmin)
            {
                ToggleAdminSettings();
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
                    var user = JsonSerializer.Deserialize<Person>
                        (File.ReadAllText(INITIAL_FILE));
                    if (user.Login == "test" && Person.ByteArrayToString(user.Password) == "password")
                    {
                        currentUser = user;
                        return true;
                    }
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