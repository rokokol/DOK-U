using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;

namespace DOK_U
{
    public partial class MainForm : Form
    {
        #region Consts

        public static MainForm FORM { private set; get; }
        private static Person? currentUser;
        public static readonly string INITIAL_FILE = "../../Source/Initial.json";

        #endregion
        
        
        public MainForm()
        {
            InitializeComponent();
            notifyIcon.Click += notifyIcon_MouseClick;
            FormClosing += MainForm_FormClosing;
            FORM = this;
            diaryButton.Enabled = false;
            if (!CheckAuthorized())
            {
                Authorize();
            }
        }

        private void Authorize()
        {
            Enabled = false;
            var authorize = new AuthorizeForm();
            authorize.Show();
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
        }
        
        private bool CheckAuthorized()
        {
            if (currentUser != null)
            {
                return true;
            }
            
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
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}