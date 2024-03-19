using System;
using System.Drawing;
using System.Windows.Forms;

namespace DOK_U
{
    public partial class MainForm : Form
    {
        public static MainForm FORM { private set; get; }
        public MainForm()
        {
            InitializeComponent();
            notifyIcon.Click += notifyIcon_MouseClick;
            FORM = this;
            diaryButton.Enabled = false;

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
    }
}