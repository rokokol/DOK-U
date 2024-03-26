using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DOK_U
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            content = new SplitContainer();
            buttonsPanel = new TableLayoutPanel();
            infoButton = new Button();
            recordBookButton = new Button();
            diaryButton = new Button();
            iconBox = new PictureBox();
            profileButton = new Button();
            contentTabs = new TabControl();
            diary = new TabPage();
            groupPanel = new Panel();
            groupBox = new ComboBox();
            groupLabel = new Label();
            diaryTable = new TableLayoutPanel();
            lectureBox5 = new ComboBox();
            lectureBox4 = new ComboBox();
            lectureBox3 = new ComboBox();
            lectureBox6 = new ComboBox();
            time6 = new Label();
            time5 = new Label();
            time4 = new Label();
            time3 = new Label();
            time2 = new Label();
            cabinetBox6 = new ComboBox();
            cabinetBox5 = new ComboBox();
            cabinetBox4 = new ComboBox();
            cabinetBox3 = new ComboBox();
            cabinetBox2 = new ComboBox();
            cabinetBox1 = new ComboBox();
            time1 = new Label();
            cabinetLable = new Label();
            lectureLabel = new Label();
            timeLabel = new Label();
            lectureBox1 = new ComboBox();
            lectureBox2 = new ComboBox();
            days = new TableLayoutPanel();
            st = new Button();
            fr = new Button();
            th = new Button();
            wd = new Button();
            tu = new Button();
            mn = new Button();
            todayTomorrow = new TableLayoutPanel();
            tommorow = new Button();
            today = new Button();
            profile = new TabPage();
            myProfileLable = new Label();
            logOutButton = new Button();
            extraCodesButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupContent = new Label();
            sexContent = new Label();
            birthdayContent = new Label();
            loginContent = new Label();
            nameContent = new Label();
            nameLabel = new Label();
            groupLable = new Label();
            sexLable = new Label();
            dirthdayLable = new Label();
            loginLable = new Label();
            recordBook = new TabPage();
            recordsTable = new TableLayoutPanel();
            recordLectureBox7 = new ComboBox();
            markBox7 = new ComboBox();
            markBox6 = new ComboBox();
            recordLectureBox6 = new ComboBox();
            markBox5 = new ComboBox();
            recordLectureBox5 = new ComboBox();
            markBox4 = new ComboBox();
            recordLectureBox4 = new ComboBox();
            markBox3 = new ComboBox();
            recordLectureBox3 = new ComboBox();
            markBox2 = new ComboBox();
            recordLectureBox2 = new ComboBox();
            markBox1 = new ComboBox();
            markLable = new Label();
            recordLectureLabel = new Label();
            recordLectureBox1 = new ComboBox();
            semesterPanel = new Panel();
            studentBox = new ComboBox();
            studentLabel = new Label();
            semesterBox = new ComboBox();
            semesterLabel = new Label();
            info = new TabPage();
            exitButton = new Button();
            aboutLabel = new Label();
            notifyIcon = new NotifyIcon(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            saveFileDialog = new SaveFileDialog();
            ((ISupportInitialize)content).BeginInit();
            content.Panel1.SuspendLayout();
            content.Panel2.SuspendLayout();
            content.SuspendLayout();
            buttonsPanel.SuspendLayout();
            ((ISupportInitialize)iconBox).BeginInit();
            contentTabs.SuspendLayout();
            diary.SuspendLayout();
            groupPanel.SuspendLayout();
            diaryTable.SuspendLayout();
            days.SuspendLayout();
            todayTomorrow.SuspendLayout();
            profile.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            recordBook.SuspendLayout();
            recordsTable.SuspendLayout();
            semesterPanel.SuspendLayout();
            info.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // content
            // 
            content.Dock = DockStyle.Fill;
            content.Location = new Point(0, 0);
            content.Margin = new Padding(4, 3, 4, 3);
            content.Name = "content";
            // 
            // content.Panel1
            // 
            content.Panel1.Controls.Add(buttonsPanel);
            content.Panel1MinSize = 230;
            // 
            // content.Panel2
            // 
            content.Panel2.Controls.Add(contentTabs);
            content.Panel2MinSize = 600;
            content.Size = new Size(997, 659);
            content.SplitterDistance = 269;
            content.SplitterWidth = 5;
            content.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            buttonsPanel.BackColor = SystemColors.AppWorkspace;
            buttonsPanel.ColumnCount = 1;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            buttonsPanel.Controls.Add(infoButton, 0, 4);
            buttonsPanel.Controls.Add(recordBookButton, 0, 3);
            buttonsPanel.Controls.Add(diaryButton, 0, 2);
            buttonsPanel.Controls.Add(iconBox, 0, 0);
            buttonsPanel.Controls.Add(profileButton, 0, 1);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Location = new Point(0, 0);
            buttonsPanel.Margin = new Padding(4, 3, 4, 3);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 5;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            buttonsPanel.Size = new Size(269, 659);
            buttonsPanel.TabIndex = 0;
            // 
            // infoButton
            // 
            infoButton.BackColor = Color.FromArgb(232, 232, 232);
            infoButton.Dock = DockStyle.Fill;
            infoButton.FlatAppearance.BorderColor = Color.Black;
            infoButton.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            infoButton.Location = new Point(4, 527);
            infoButton.Margin = new Padding(4, 3, 4, 3);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(261, 129);
            infoButton.TabIndex = 4;
            infoButton.Text = "О программе";
            infoButton.TextAlign = ContentAlignment.MiddleLeft;
            infoButton.UseVisualStyleBackColor = false;
            infoButton.Click += infoButton_Click;
            // 
            // recordBookButton
            // 
            recordBookButton.BackColor = Color.FromArgb(232, 232, 232);
            recordBookButton.Dock = DockStyle.Fill;
            recordBookButton.FlatAppearance.BorderColor = Color.Black;
            recordBookButton.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            recordBookButton.Location = new Point(4, 396);
            recordBookButton.Margin = new Padding(4, 3, 4, 3);
            recordBookButton.Name = "recordBookButton";
            recordBookButton.Size = new Size(261, 125);
            recordBookButton.TabIndex = 3;
            recordBookButton.Text = "Зачетная книжка";
            recordBookButton.TextAlign = ContentAlignment.MiddleLeft;
            recordBookButton.UseVisualStyleBackColor = false;
            recordBookButton.Click += recordBookButton_Click;
            // 
            // diaryButton
            // 
            diaryButton.BackColor = Color.FromArgb(232, 232, 232);
            diaryButton.Dock = DockStyle.Fill;
            diaryButton.Enabled = false;
            diaryButton.FlatAppearance.BorderColor = Color.Black;
            diaryButton.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            diaryButton.Location = new Point(4, 265);
            diaryButton.Margin = new Padding(4, 3, 4, 3);
            diaryButton.Name = "diaryButton";
            diaryButton.Size = new Size(261, 125);
            diaryButton.TabIndex = 2;
            diaryButton.Text = "Электронный дневник";
            diaryButton.TextAlign = ContentAlignment.MiddleLeft;
            diaryButton.UseVisualStyleBackColor = false;
            diaryButton.Click += diaryButton_Click;
            // 
            // iconBox
            // 
            iconBox.BackColor = Color.FromArgb(232, 232, 232);
            iconBox.Dock = DockStyle.Fill;
            iconBox.Image = (Image)resources.GetObject("iconBox.Image");
            iconBox.Location = new Point(4, 3);
            iconBox.Margin = new Padding(4, 3, 4, 3);
            iconBox.Name = "iconBox";
            iconBox.Size = new Size(261, 125);
            iconBox.SizeMode = PictureBoxSizeMode.Zoom;
            iconBox.TabIndex = 0;
            iconBox.TabStop = false;
            // 
            // profileButton
            // 
            profileButton.BackColor = Color.FromArgb(232, 232, 232);
            profileButton.Dock = DockStyle.Fill;
            profileButton.FlatAppearance.BorderColor = Color.Black;
            profileButton.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            profileButton.Location = new Point(4, 134);
            profileButton.Margin = new Padding(4, 3, 4, 3);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(261, 125);
            profileButton.TabIndex = 1;
            profileButton.Text = "Мой профиль";
            profileButton.TextAlign = ContentAlignment.MiddleLeft;
            profileButton.UseVisualStyleBackColor = false;
            profileButton.Click += profileButton_Click;
            // 
            // contentTabs
            // 
            contentTabs.Appearance = TabAppearance.Buttons;
            contentTabs.Controls.Add(diary);
            contentTabs.Controls.Add(profile);
            contentTabs.Controls.Add(recordBook);
            contentTabs.Controls.Add(info);
            contentTabs.Dock = DockStyle.Fill;
            contentTabs.Font = new Font("Consolas", 8.25F);
            contentTabs.ItemSize = new Size(0, 10);
            contentTabs.Location = new Point(0, 0);
            contentTabs.Margin = new Padding(4, 3, 4, 3);
            contentTabs.Multiline = true;
            contentTabs.Name = "contentTabs";
            contentTabs.SelectedIndex = 0;
            contentTabs.Size = new Size(723, 659);
            contentTabs.TabIndex = 0;
            // 
            // diary
            // 
            diary.BackColor = SystemColors.ActiveBorder;
            diary.Controls.Add(groupPanel);
            diary.Controls.Add(diaryTable);
            diary.Controls.Add(days);
            diary.Controls.Add(todayTomorrow);
            diary.Location = new Point(4, 14);
            diary.Margin = new Padding(4, 3, 4, 3);
            diary.Name = "diary";
            diary.Padding = new Padding(4, 3, 4, 3);
            diary.Size = new Size(715, 641);
            diary.TabIndex = 1;
            diary.Text = "Diary";
            // 
            // groupPanel
            // 
            groupPanel.Controls.Add(groupBox);
            groupPanel.Controls.Add(groupLabel);
            groupPanel.Dock = DockStyle.Bottom;
            groupPanel.Location = new Point(4, 595);
            groupPanel.Margin = new Padding(4, 3, 4, 3);
            groupPanel.Name = "groupPanel";
            groupPanel.Size = new Size(707, 43);
            groupPanel.TabIndex = 3;
            // 
            // groupBox
            // 
            groupBox.Enabled = false;
            groupBox.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox.FormattingEnabled = true;
            groupBox.ItemHeight = 19;
            groupBox.Location = new Point(132, 3);
            groupBox.Margin = new Padding(4, 3, 4, 3);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(124, 27);
            groupBox.TabIndex = 1;
            groupBox.SelectedIndexChanged += groupBox_SelectedIndexChanged;
            // 
            // groupLabel
            // 
            groupLabel.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupLabel.Location = new Point(4, 3);
            groupLabel.Margin = new Padding(4, 0, 4, 0);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new Size(121, 33);
            groupLabel.TabIndex = 0;
            groupLabel.Text = "Группа №";
            // 
            // diaryTable
            // 
            diaryTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            diaryTable.BackColor = Color.FromArgb(232, 232, 232);
            diaryTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            diaryTable.ColumnCount = 3;
            diaryTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            diaryTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            diaryTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            diaryTable.Controls.Add(lectureBox5, 1, 5);
            diaryTable.Controls.Add(lectureBox4, 1, 4);
            diaryTable.Controls.Add(lectureBox3, 1, 3);
            diaryTable.Controls.Add(lectureBox6, 0, 6);
            diaryTable.Controls.Add(time6, 0, 6);
            diaryTable.Controls.Add(time5, 0, 5);
            diaryTable.Controls.Add(time4, 0, 4);
            diaryTable.Controls.Add(time3, 0, 3);
            diaryTable.Controls.Add(time2, 0, 2);
            diaryTable.Controls.Add(cabinetBox6, 2, 6);
            diaryTable.Controls.Add(cabinetBox5, 2, 5);
            diaryTable.Controls.Add(cabinetBox4, 2, 4);
            diaryTable.Controls.Add(cabinetBox3, 2, 3);
            diaryTable.Controls.Add(cabinetBox2, 2, 2);
            diaryTable.Controls.Add(cabinetBox1, 2, 1);
            diaryTable.Controls.Add(time1, 0, 1);
            diaryTable.Controls.Add(cabinetLable, 2, 0);
            diaryTable.Controls.Add(lectureLabel, 1, 0);
            diaryTable.Controls.Add(timeLabel, 0, 0);
            diaryTable.Controls.Add(lectureBox1, 1, 1);
            diaryTable.Controls.Add(lectureBox2, 1, 2);
            diaryTable.Location = new Point(7, 74);
            diaryTable.Margin = new Padding(4, 3, 4, 3);
            diaryTable.Name = "diaryTable";
            diaryTable.RowCount = 7;
            diaryTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            diaryTable.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            diaryTable.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            diaryTable.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            diaryTable.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            diaryTable.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            diaryTable.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            diaryTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            diaryTable.Size = new Size(698, 497);
            diaryTable.TabIndex = 2;
            // 
            // lectureBox5
            // 
            lectureBox5.BackColor = Color.FromArgb(232, 232, 232);
            lectureBox5.Dock = DockStyle.Top;
            lectureBox5.Enabled = false;
            lectureBox5.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lectureBox5.FormattingEnabled = true;
            lectureBox5.Location = new Point(75, 347);
            lectureBox5.Name = "lectureBox5";
            lectureBox5.Size = new Size(430, 27);
            lectureBox5.TabIndex = 42;
            lectureBox5.SelectedIndexChanged += lectureBox5_SelectedIndexChanged;
            // 
            // lectureBox4
            // 
            lectureBox4.BackColor = Color.FromArgb(232, 232, 232);
            lectureBox4.Dock = DockStyle.Top;
            lectureBox4.Enabled = false;
            lectureBox4.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lectureBox4.FormattingEnabled = true;
            lectureBox4.Location = new Point(75, 273);
            lectureBox4.Name = "lectureBox4";
            lectureBox4.Size = new Size(430, 27);
            lectureBox4.TabIndex = 41;
            lectureBox4.SelectedIndexChanged += lectureBox4_SelectedIndexChanged;
            // 
            // lectureBox3
            // 
            lectureBox3.BackColor = Color.FromArgb(232, 232, 232);
            lectureBox3.Dock = DockStyle.Top;
            lectureBox3.Enabled = false;
            lectureBox3.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lectureBox3.FormattingEnabled = true;
            lectureBox3.Location = new Point(75, 199);
            lectureBox3.Name = "lectureBox3";
            lectureBox3.Size = new Size(430, 27);
            lectureBox3.TabIndex = 40;
            lectureBox3.SelectedIndexChanged += lectureBox3_SelectedIndexChanged;
            // 
            // lectureBox6
            // 
            lectureBox6.BackColor = Color.FromArgb(232, 232, 232);
            lectureBox6.Dock = DockStyle.Top;
            lectureBox6.Enabled = false;
            lectureBox6.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lectureBox6.FormattingEnabled = true;
            lectureBox6.Location = new Point(75, 421);
            lectureBox6.Name = "lectureBox6";
            lectureBox6.Size = new Size(430, 27);
            lectureBox6.TabIndex = 38;
            lectureBox6.SelectedIndexChanged += lectureBox6_SelectedIndexChanged;
            // 
            // time6
            // 
            time6.BackColor = Color.FromArgb(232, 232, 232);
            time6.Dock = DockStyle.Fill;
            time6.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            time6.Location = new Point(5, 418);
            time6.Margin = new Padding(4, 0, 4, 0);
            time6.Name = "time6";
            time6.Size = new Size(62, 78);
            time6.TabIndex = 36;
            time6.Text = "19:10\r\n-\r\n20:40";
            time6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // time5
            // 
            time5.BackColor = Color.FromArgb(232, 232, 232);
            time5.Dock = DockStyle.Fill;
            time5.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            time5.Location = new Point(5, 344);
            time5.Margin = new Padding(4, 0, 4, 0);
            time5.Name = "time5";
            time5.Size = new Size(62, 73);
            time5.TabIndex = 35;
            time5.Text = "17:30\r\n-\r\n19:00";
            time5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // time4
            // 
            time4.BackColor = Color.FromArgb(232, 232, 232);
            time4.Dock = DockStyle.Fill;
            time4.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            time4.Location = new Point(5, 270);
            time4.Margin = new Padding(4, 0, 4, 0);
            time4.Name = "time4";
            time4.Size = new Size(62, 73);
            time4.TabIndex = 34;
            time4.Text = "13:50\r\n-\r\n15:20";
            time4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // time3
            // 
            time3.BackColor = Color.FromArgb(232, 232, 232);
            time3.Dock = DockStyle.Fill;
            time3.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            time3.Location = new Point(5, 196);
            time3.Margin = new Padding(4, 0, 4, 0);
            time3.Name = "time3";
            time3.Size = new Size(62, 73);
            time3.TabIndex = 33;
            time3.Text = "12:10\r\n-\r\n13:40";
            time3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // time2
            // 
            time2.BackColor = Color.FromArgb(232, 232, 232);
            time2.Dock = DockStyle.Fill;
            time2.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            time2.Location = new Point(5, 122);
            time2.Margin = new Padding(4, 0, 4, 0);
            time2.Name = "time2";
            time2.Size = new Size(62, 73);
            time2.TabIndex = 32;
            time2.Text = "10:10\r\n-\r\n11:40";
            time2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cabinetBox6
            // 
            cabinetBox6.BackColor = Color.FromArgb(232, 232, 232);
            cabinetBox6.Dock = DockStyle.Top;
            cabinetBox6.Enabled = false;
            cabinetBox6.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cabinetBox6.FormattingEnabled = true;
            cabinetBox6.ItemHeight = 19;
            cabinetBox6.Location = new Point(513, 421);
            cabinetBox6.Margin = new Padding(4, 3, 4, 3);
            cabinetBox6.Name = "cabinetBox6";
            cabinetBox6.Size = new Size(180, 27);
            cabinetBox6.TabIndex = 31;
            cabinetBox6.SelectedIndexChanged += cabinetBox6_SelectedIndexChanged;
            // 
            // cabinetBox5
            // 
            cabinetBox5.BackColor = Color.FromArgb(232, 232, 232);
            cabinetBox5.Dock = DockStyle.Top;
            cabinetBox5.Enabled = false;
            cabinetBox5.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cabinetBox5.FormattingEnabled = true;
            cabinetBox5.ItemHeight = 19;
            cabinetBox5.Location = new Point(513, 347);
            cabinetBox5.Margin = new Padding(4, 3, 4, 3);
            cabinetBox5.Name = "cabinetBox5";
            cabinetBox5.Size = new Size(180, 27);
            cabinetBox5.TabIndex = 29;
            cabinetBox5.SelectedIndexChanged += cabinetBox5_SelectedIndexChanged;
            // 
            // cabinetBox4
            // 
            cabinetBox4.BackColor = Color.FromArgb(232, 232, 232);
            cabinetBox4.Dock = DockStyle.Top;
            cabinetBox4.Enabled = false;
            cabinetBox4.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cabinetBox4.FormattingEnabled = true;
            cabinetBox4.ItemHeight = 19;
            cabinetBox4.Location = new Point(513, 273);
            cabinetBox4.Margin = new Padding(4, 3, 4, 3);
            cabinetBox4.Name = "cabinetBox4";
            cabinetBox4.Size = new Size(180, 27);
            cabinetBox4.TabIndex = 27;
            cabinetBox4.SelectedIndexChanged += cabinetBox4_SelectedIndexChanged;
            // 
            // cabinetBox3
            // 
            cabinetBox3.BackColor = Color.FromArgb(232, 232, 232);
            cabinetBox3.Dock = DockStyle.Top;
            cabinetBox3.Enabled = false;
            cabinetBox3.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cabinetBox3.FormattingEnabled = true;
            cabinetBox3.ItemHeight = 19;
            cabinetBox3.Location = new Point(513, 199);
            cabinetBox3.Margin = new Padding(4, 3, 4, 3);
            cabinetBox3.Name = "cabinetBox3";
            cabinetBox3.Size = new Size(180, 27);
            cabinetBox3.TabIndex = 25;
            cabinetBox3.SelectedIndexChanged += cabinetBox3_SelectedIndexChanged;
            // 
            // cabinetBox2
            // 
            cabinetBox2.BackColor = Color.FromArgb(232, 232, 232);
            cabinetBox2.Dock = DockStyle.Top;
            cabinetBox2.Enabled = false;
            cabinetBox2.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cabinetBox2.FormattingEnabled = true;
            cabinetBox2.ItemHeight = 19;
            cabinetBox2.Location = new Point(513, 125);
            cabinetBox2.Margin = new Padding(4, 3, 4, 3);
            cabinetBox2.Name = "cabinetBox2";
            cabinetBox2.Size = new Size(180, 27);
            cabinetBox2.TabIndex = 23;
            cabinetBox2.SelectedIndexChanged += cabinetBox2_SelectedIndexChanged;
            // 
            // cabinetBox1
            // 
            cabinetBox1.BackColor = Color.FromArgb(232, 232, 232);
            cabinetBox1.Dock = DockStyle.Top;
            cabinetBox1.Enabled = false;
            cabinetBox1.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cabinetBox1.FormattingEnabled = true;
            cabinetBox1.ItemHeight = 19;
            cabinetBox1.Location = new Point(513, 51);
            cabinetBox1.Margin = new Padding(4, 3, 4, 3);
            cabinetBox1.Name = "cabinetBox1";
            cabinetBox1.Size = new Size(180, 27);
            cabinetBox1.TabIndex = 20;
            cabinetBox1.SelectedIndexChanged += cabinetBox1_SelectedIndexChanged;
            // 
            // time1
            // 
            time1.BackColor = Color.FromArgb(232, 232, 232);
            time1.Dock = DockStyle.Fill;
            time1.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            time1.Location = new Point(5, 48);
            time1.Margin = new Padding(4, 0, 4, 0);
            time1.Name = "time1";
            time1.Size = new Size(62, 73);
            time1.TabIndex = 3;
            time1.Text = "8:30\r\n-\r\n10:00";
            time1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cabinetLable
            // 
            cabinetLable.Dock = DockStyle.Fill;
            cabinetLable.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cabinetLable.Location = new Point(513, 1);
            cabinetLable.Margin = new Padding(4, 0, 4, 0);
            cabinetLable.Name = "cabinetLable";
            cabinetLable.Size = new Size(180, 46);
            cabinetLable.TabIndex = 2;
            cabinetLable.Text = "Кабинет";
            cabinetLable.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lectureLabel
            // 
            lectureLabel.Dock = DockStyle.Fill;
            lectureLabel.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lectureLabel.Location = new Point(76, 1);
            lectureLabel.Margin = new Padding(4, 0, 4, 0);
            lectureLabel.Name = "lectureLabel";
            lectureLabel.Size = new Size(428, 46);
            lectureLabel.TabIndex = 1;
            lectureLabel.Text = "Кабинет";
            lectureLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // timeLabel
            // 
            timeLabel.Dock = DockStyle.Fill;
            timeLabel.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            timeLabel.Location = new Point(5, 1);
            timeLabel.Margin = new Padding(4, 0, 4, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(62, 46);
            timeLabel.TabIndex = 0;
            timeLabel.Text = "Время";
            timeLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lectureBox1
            // 
            lectureBox1.BackColor = Color.FromArgb(232, 232, 232);
            lectureBox1.Dock = DockStyle.Top;
            lectureBox1.Enabled = false;
            lectureBox1.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lectureBox1.FormattingEnabled = true;
            lectureBox1.Location = new Point(75, 51);
            lectureBox1.Name = "lectureBox1";
            lectureBox1.Size = new Size(430, 27);
            lectureBox1.TabIndex = 37;
            lectureBox1.SelectedIndexChanged += lectureBox1_SelectedIndexChanged;
            // 
            // lectureBox2
            // 
            lectureBox2.BackColor = Color.FromArgb(232, 232, 232);
            lectureBox2.Dock = DockStyle.Top;
            lectureBox2.Enabled = false;
            lectureBox2.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lectureBox2.FormattingEnabled = true;
            lectureBox2.Location = new Point(75, 125);
            lectureBox2.Name = "lectureBox2";
            lectureBox2.Size = new Size(430, 27);
            lectureBox2.TabIndex = 39;
            lectureBox2.SelectedIndexChanged += lectureBox2_SelectedIndexChanged;
            // 
            // days
            // 
            days.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            days.ColumnCount = 6;
            days.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            days.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            days.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            days.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            days.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            days.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            days.Controls.Add(st, 5, 0);
            days.Controls.Add(fr, 4, 0);
            days.Controls.Add(th, 3, 0);
            days.Controls.Add(wd, 2, 0);
            days.Controls.Add(tu, 1, 0);
            days.Controls.Add(mn, 0, 0);
            days.Location = new Point(320, 7);
            days.Margin = new Padding(4, 3, 4, 3);
            days.Name = "days";
            days.RowCount = 1;
            days.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            days.Size = new Size(385, 60);
            days.TabIndex = 1;
            // 
            // st
            // 
            st.Dock = DockStyle.Fill;
            st.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            st.Location = new Point(324, 3);
            st.Margin = new Padding(4, 3, 4, 3);
            st.Name = "st";
            st.Size = new Size(57, 54);
            st.TabIndex = 5;
            st.Text = "СБ";
            st.UseVisualStyleBackColor = true;
            st.Click += st_Click;
            // 
            // fr
            // 
            fr.Dock = DockStyle.Fill;
            fr.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            fr.Location = new Point(260, 3);
            fr.Margin = new Padding(4, 3, 4, 3);
            fr.Name = "fr";
            fr.Size = new Size(56, 54);
            fr.TabIndex = 4;
            fr.Text = "ПТ";
            fr.UseVisualStyleBackColor = true;
            fr.Click += fr_Click;
            // 
            // th
            // 
            th.Dock = DockStyle.Fill;
            th.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            th.Location = new Point(196, 3);
            th.Margin = new Padding(4, 3, 4, 3);
            th.Name = "th";
            th.Size = new Size(56, 54);
            th.TabIndex = 3;
            th.Text = "ЧТ";
            th.UseVisualStyleBackColor = true;
            th.Click += th_Click;
            // 
            // wd
            // 
            wd.Dock = DockStyle.Fill;
            wd.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            wd.Location = new Point(132, 3);
            wd.Margin = new Padding(4, 3, 4, 3);
            wd.Name = "wd";
            wd.Size = new Size(56, 54);
            wd.TabIndex = 2;
            wd.Text = "СР";
            wd.UseVisualStyleBackColor = true;
            wd.Click += wd_Click;
            // 
            // tu
            // 
            tu.Dock = DockStyle.Fill;
            tu.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tu.Location = new Point(68, 3);
            tu.Margin = new Padding(4, 3, 4, 3);
            tu.Name = "tu";
            tu.Size = new Size(56, 54);
            tu.TabIndex = 1;
            tu.Text = "ВТ";
            tu.UseVisualStyleBackColor = true;
            tu.Click += tu_Click;
            // 
            // mn
            // 
            mn.Dock = DockStyle.Fill;
            mn.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mn.Location = new Point(4, 3);
            mn.Margin = new Padding(4, 3, 4, 3);
            mn.Name = "mn";
            mn.Size = new Size(56, 54);
            mn.TabIndex = 0;
            mn.Text = "ПН";
            mn.UseVisualStyleBackColor = true;
            mn.Click += mn_Click;
            // 
            // todayTomorrow
            // 
            todayTomorrow.ColumnCount = 2;
            todayTomorrow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            todayTomorrow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            todayTomorrow.Controls.Add(tommorow, 0, 0);
            todayTomorrow.Controls.Add(today, 0, 0);
            todayTomorrow.Location = new Point(7, 7);
            todayTomorrow.Margin = new Padding(4, 3, 4, 3);
            todayTomorrow.Name = "todayTomorrow";
            todayTomorrow.RowCount = 1;
            todayTomorrow.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            todayTomorrow.Size = new Size(229, 60);
            todayTomorrow.TabIndex = 0;
            // 
            // tommorow
            // 
            tommorow.Dock = DockStyle.Fill;
            tommorow.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tommorow.Location = new Point(118, 3);
            tommorow.Margin = new Padding(4, 3, 4, 3);
            tommorow.Name = "tommorow";
            tommorow.Size = new Size(107, 54);
            tommorow.TabIndex = 1;
            tommorow.Text = "Завтра";
            tommorow.UseVisualStyleBackColor = true;
            tommorow.Click += tommorow_Click;
            // 
            // today
            // 
            today.Dock = DockStyle.Fill;
            today.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            today.Location = new Point(4, 3);
            today.Margin = new Padding(4, 3, 4, 3);
            today.Name = "today";
            today.Size = new Size(106, 54);
            today.TabIndex = 0;
            today.Text = "Сегодня";
            today.UseVisualStyleBackColor = true;
            today.Click += today_Click;
            // 
            // profile
            // 
            profile.BackColor = SystemColors.ActiveBorder;
            profile.Controls.Add(myProfileLable);
            profile.Controls.Add(logOutButton);
            profile.Controls.Add(extraCodesButton);
            profile.Controls.Add(tableLayoutPanel1);
            profile.Location = new Point(4, 14);
            profile.Margin = new Padding(4, 3, 4, 3);
            profile.Name = "profile";
            profile.Padding = new Padding(4, 3, 4, 3);
            profile.Size = new Size(715, 641);
            profile.TabIndex = 0;
            profile.Text = "Profile";
            // 
            // myProfileLable
            // 
            myProfileLable.Dock = DockStyle.Top;
            myProfileLable.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            myProfileLable.Location = new Point(4, 3);
            myProfileLable.Margin = new Padding(4, 0, 4, 0);
            myProfileLable.Name = "myProfileLable";
            myProfileLable.Size = new Size(707, 55);
            myProfileLable.TabIndex = 8;
            myProfileLable.Text = "Мой профиль";
            // 
            // logOutButton
            // 
            logOutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            logOutButton.BackColor = Color.FromArgb(232, 232, 232);
            logOutButton.FlatAppearance.BorderColor = Color.Black;
            logOutButton.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            logOutButton.Location = new Point(439, 513);
            logOutButton.Margin = new Padding(4, 3, 4, 3);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(262, 115);
            logOutButton.TabIndex = 7;
            logOutButton.Text = "Выйти из аккаунта";
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_Click;
            // 
            // extraCodesButton
            // 
            extraCodesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            extraCodesButton.BackColor = Color.FromArgb(232, 232, 232);
            extraCodesButton.FlatAppearance.BorderColor = Color.Black;
            extraCodesButton.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            extraCodesButton.Location = new Point(13, 513);
            extraCodesButton.Margin = new Padding(4, 3, 4, 3);
            extraCodesButton.Name = "extraCodesButton";
            extraCodesButton.Size = new Size(262, 115);
            extraCodesButton.TabIndex = 6;
            extraCodesButton.Text = "Получить резервный код";
            extraCodesButton.UseVisualStyleBackColor = false;
            extraCodesButton.Click += extraCodesButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = SystemColors.ActiveBorder;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(groupContent, 1, 4);
            tableLayoutPanel1.Controls.Add(sexContent, 1, 3);
            tableLayoutPanel1.Controls.Add(birthdayContent, 1, 2);
            tableLayoutPanel1.Controls.Add(loginContent, 1, 1);
            tableLayoutPanel1.Controls.Add(nameContent, 1, 0);
            tableLayoutPanel1.Controls.Add(nameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(groupLable, 0, 4);
            tableLayoutPanel1.Controls.Add(sexLable, 0, 3);
            tableLayoutPanel1.Controls.Add(dirthdayLable, 0, 2);
            tableLayoutPanel1.Controls.Add(loginLable, 0, 1);
            tableLayoutPanel1.Location = new Point(8, 83);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(698, 393);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // groupContent
            // 
            groupContent.BackColor = Color.FromArgb(232, 232, 232);
            groupContent.BorderStyle = BorderStyle.FixedSingle;
            groupContent.Dock = DockStyle.Fill;
            groupContent.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupContent.Location = new Point(143, 312);
            groupContent.Margin = new Padding(4, 0, 4, 0);
            groupContent.Name = "groupContent";
            groupContent.Size = new Size(551, 81);
            groupContent.TabIndex = 43;
            groupContent.TextAlign = ContentAlignment.MiddleLeft;
            groupContent.Click += groupContent_Click;
            // 
            // sexContent
            // 
            sexContent.BackColor = Color.FromArgb(232, 232, 232);
            sexContent.BorderStyle = BorderStyle.FixedSingle;
            sexContent.Dock = DockStyle.Fill;
            sexContent.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sexContent.Location = new Point(143, 234);
            sexContent.Margin = new Padding(4, 0, 4, 0);
            sexContent.Name = "sexContent";
            sexContent.Size = new Size(551, 78);
            sexContent.TabIndex = 42;
            sexContent.TextAlign = ContentAlignment.MiddleLeft;
            sexContent.Click += sexContent_Click;
            // 
            // birthdayContent
            // 
            birthdayContent.BackColor = Color.FromArgb(232, 232, 232);
            birthdayContent.BorderStyle = BorderStyle.FixedSingle;
            birthdayContent.Dock = DockStyle.Fill;
            birthdayContent.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            birthdayContent.Location = new Point(143, 156);
            birthdayContent.Margin = new Padding(4, 0, 4, 0);
            birthdayContent.Name = "birthdayContent";
            birthdayContent.Size = new Size(551, 78);
            birthdayContent.TabIndex = 41;
            birthdayContent.TextAlign = ContentAlignment.MiddleLeft;
            birthdayContent.Click += birthdayContent_Click;
            // 
            // loginContent
            // 
            loginContent.BackColor = Color.FromArgb(232, 232, 232);
            loginContent.BorderStyle = BorderStyle.FixedSingle;
            loginContent.Dock = DockStyle.Fill;
            loginContent.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginContent.Location = new Point(143, 78);
            loginContent.Margin = new Padding(4, 0, 4, 0);
            loginContent.Name = "loginContent";
            loginContent.Size = new Size(551, 78);
            loginContent.TabIndex = 40;
            loginContent.TextAlign = ContentAlignment.MiddleLeft;
            loginContent.Click += loginContent_Click;
            // 
            // nameContent
            // 
            nameContent.BackColor = Color.FromArgb(232, 232, 232);
            nameContent.BorderStyle = BorderStyle.FixedSingle;
            nameContent.Dock = DockStyle.Fill;
            nameContent.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameContent.Location = new Point(143, 0);
            nameContent.Margin = new Padding(4, 0, 4, 0);
            nameContent.Name = "nameContent";
            nameContent.Size = new Size(551, 78);
            nameContent.TabIndex = 39;
            nameContent.TextAlign = ContentAlignment.MiddleLeft;
            nameContent.Click += nameContent_Click;
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Dock = DockStyle.Fill;
            nameLabel.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(4, 0);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(131, 78);
            nameLabel.TabIndex = 38;
            nameLabel.Text = "ФИО";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupLable
            // 
            groupLable.BackColor = SystemColors.ActiveBorder;
            groupLable.Dock = DockStyle.Fill;
            groupLable.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupLable.Location = new Point(4, 312);
            groupLable.Margin = new Padding(4, 0, 4, 0);
            groupLable.Name = "groupLable";
            groupLable.Size = new Size(131, 81);
            groupLable.TabIndex = 35;
            groupLable.Text = "Группа";
            groupLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sexLable
            // 
            sexLable.BackColor = SystemColors.ActiveBorder;
            sexLable.Dock = DockStyle.Fill;
            sexLable.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sexLable.Location = new Point(4, 234);
            sexLable.Margin = new Padding(4, 0, 4, 0);
            sexLable.Name = "sexLable";
            sexLable.Size = new Size(131, 78);
            sexLable.TabIndex = 34;
            sexLable.Text = "Пол";
            sexLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dirthdayLable
            // 
            dirthdayLable.BackColor = SystemColors.ActiveBorder;
            dirthdayLable.Dock = DockStyle.Fill;
            dirthdayLable.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dirthdayLable.Location = new Point(4, 156);
            dirthdayLable.Margin = new Padding(4, 0, 4, 0);
            dirthdayLable.Name = "dirthdayLable";
            dirthdayLable.Size = new Size(131, 78);
            dirthdayLable.TabIndex = 33;
            dirthdayLable.Text = "Дата рождения";
            dirthdayLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginLable
            // 
            loginLable.BackColor = SystemColors.ActiveBorder;
            loginLable.Dock = DockStyle.Fill;
            loginLable.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginLable.Location = new Point(4, 78);
            loginLable.Margin = new Padding(4, 0, 4, 0);
            loginLable.Name = "loginLable";
            loginLable.Size = new Size(131, 78);
            loginLable.TabIndex = 32;
            loginLable.Text = "Логин";
            loginLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // recordBook
            // 
            recordBook.BackColor = SystemColors.ActiveBorder;
            recordBook.Controls.Add(recordsTable);
            recordBook.Controls.Add(semesterPanel);
            recordBook.Location = new Point(4, 14);
            recordBook.Margin = new Padding(4, 3, 4, 3);
            recordBook.Name = "recordBook";
            recordBook.Padding = new Padding(4, 3, 4, 3);
            recordBook.Size = new Size(715, 641);
            recordBook.TabIndex = 2;
            recordBook.Text = "recordBook";
            // 
            // recordsTable
            // 
            recordsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            recordsTable.BackColor = Color.FromArgb(232, 232, 232);
            recordsTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            recordsTable.ColumnCount = 2;
            recordsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            recordsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            recordsTable.Controls.Add(recordLectureBox7, 0, 7);
            recordsTable.Controls.Add(markBox7, 0, 7);
            recordsTable.Controls.Add(markBox6, 1, 6);
            recordsTable.Controls.Add(recordLectureBox6, 0, 6);
            recordsTable.Controls.Add(markBox5, 1, 5);
            recordsTable.Controls.Add(recordLectureBox5, 0, 5);
            recordsTable.Controls.Add(markBox4, 1, 4);
            recordsTable.Controls.Add(recordLectureBox4, 0, 4);
            recordsTable.Controls.Add(markBox3, 1, 3);
            recordsTable.Controls.Add(recordLectureBox3, 0, 3);
            recordsTable.Controls.Add(markBox2, 1, 2);
            recordsTable.Controls.Add(recordLectureBox2, 0, 2);
            recordsTable.Controls.Add(markBox1, 1, 1);
            recordsTable.Controls.Add(markLable, 1, 0);
            recordsTable.Controls.Add(recordLectureLabel, 0, 0);
            recordsTable.Controls.Add(recordLectureBox1, 0, 1);
            recordsTable.Location = new Point(8, 70);
            recordsTable.Margin = new Padding(4, 3, 4, 3);
            recordsTable.Name = "recordsTable";
            recordsTable.RowCount = 8;
            recordsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            recordsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            recordsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            recordsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            recordsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            recordsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            recordsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            recordsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            recordsTable.Size = new Size(698, 497);
            recordsTable.TabIndex = 5;
            // 
            // recordLectureBox7
            // 
            recordLectureBox7.BackColor = Color.FromArgb(232, 232, 232);
            recordLectureBox7.Dock = DockStyle.Top;
            recordLectureBox7.Enabled = false;
            recordLectureBox7.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            recordLectureBox7.FormattingEnabled = true;
            recordLectureBox7.ItemHeight = 19;
            recordLectureBox7.Location = new Point(5, 435);
            recordLectureBox7.Margin = new Padding(4, 3, 4, 3);
            recordLectureBox7.Name = "recordLectureBox7";
            recordLectureBox7.Size = new Size(478, 27);
            recordLectureBox7.TabIndex = 33;
            recordLectureBox7.SelectedIndexChanged += recordLectureBox7_SelectedIndexChanged;
            // 
            // markBox7
            // 
            markBox7.BackColor = Color.FromArgb(232, 232, 232);
            markBox7.Dock = DockStyle.Top;
            markBox7.Enabled = false;
            markBox7.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            markBox7.FormattingEnabled = true;
            markBox7.ItemHeight = 19;
            markBox7.Location = new Point(492, 435);
            markBox7.Margin = new Padding(4, 3, 4, 3);
            markBox7.Name = "markBox7";
            markBox7.Size = new Size(201, 27);
            markBox7.TabIndex = 32;
            markBox7.SelectedIndexChanged += markBox7_SelectedIndexChanged;
            // 
            // markBox6
            // 
            markBox6.BackColor = Color.FromArgb(232, 232, 232);
            markBox6.Dock = DockStyle.Top;
            markBox6.Enabled = false;
            markBox6.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            markBox6.FormattingEnabled = true;
            markBox6.ItemHeight = 19;
            markBox6.Location = new Point(492, 371);
            markBox6.Margin = new Padding(4, 3, 4, 3);
            markBox6.Name = "markBox6";
            markBox6.Size = new Size(201, 27);
            markBox6.TabIndex = 31;
            markBox6.SelectedIndexChanged += markBox6_SelectedIndexChanged;
            // 
            // recordLectureBox6
            // 
            recordLectureBox6.BackColor = Color.FromArgb(232, 232, 232);
            recordLectureBox6.Dock = DockStyle.Top;
            recordLectureBox6.Enabled = false;
            recordLectureBox6.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            recordLectureBox6.FormattingEnabled = true;
            recordLectureBox6.ItemHeight = 19;
            recordLectureBox6.Location = new Point(5, 371);
            recordLectureBox6.Margin = new Padding(4, 3, 4, 3);
            recordLectureBox6.Name = "recordLectureBox6";
            recordLectureBox6.Size = new Size(478, 27);
            recordLectureBox6.TabIndex = 30;
            recordLectureBox6.SelectedIndexChanged += recordLectureBox6_SelectedIndexChanged;
            // 
            // markBox5
            // 
            markBox5.BackColor = Color.FromArgb(232, 232, 232);
            markBox5.Dock = DockStyle.Top;
            markBox5.Enabled = false;
            markBox5.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            markBox5.FormattingEnabled = true;
            markBox5.ItemHeight = 19;
            markBox5.Location = new Point(492, 307);
            markBox5.Margin = new Padding(4, 3, 4, 3);
            markBox5.Name = "markBox5";
            markBox5.Size = new Size(201, 27);
            markBox5.TabIndex = 29;
            markBox5.SelectedIndexChanged += markBox5_SelectedIndexChanged;
            // 
            // recordLectureBox5
            // 
            recordLectureBox5.BackColor = Color.FromArgb(232, 232, 232);
            recordLectureBox5.Dock = DockStyle.Top;
            recordLectureBox5.Enabled = false;
            recordLectureBox5.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            recordLectureBox5.FormattingEnabled = true;
            recordLectureBox5.ItemHeight = 19;
            recordLectureBox5.Location = new Point(5, 307);
            recordLectureBox5.Margin = new Padding(4, 3, 4, 3);
            recordLectureBox5.Name = "recordLectureBox5";
            recordLectureBox5.Size = new Size(478, 27);
            recordLectureBox5.TabIndex = 28;
            recordLectureBox5.SelectedIndexChanged += recordLectureBox5_SelectedIndexChanged;
            // 
            // markBox4
            // 
            markBox4.BackColor = Color.FromArgb(232, 232, 232);
            markBox4.Dock = DockStyle.Top;
            markBox4.Enabled = false;
            markBox4.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            markBox4.FormattingEnabled = true;
            markBox4.ItemHeight = 19;
            markBox4.Location = new Point(492, 243);
            markBox4.Margin = new Padding(4, 3, 4, 3);
            markBox4.Name = "markBox4";
            markBox4.Size = new Size(201, 27);
            markBox4.TabIndex = 27;
            markBox4.SelectedIndexChanged += markBox4_SelectedIndexChanged;
            // 
            // recordLectureBox4
            // 
            recordLectureBox4.BackColor = Color.FromArgb(232, 232, 232);
            recordLectureBox4.Dock = DockStyle.Top;
            recordLectureBox4.Enabled = false;
            recordLectureBox4.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            recordLectureBox4.FormattingEnabled = true;
            recordLectureBox4.ItemHeight = 19;
            recordLectureBox4.Location = new Point(5, 243);
            recordLectureBox4.Margin = new Padding(4, 3, 4, 3);
            recordLectureBox4.Name = "recordLectureBox4";
            recordLectureBox4.Size = new Size(478, 27);
            recordLectureBox4.TabIndex = 26;
            recordLectureBox4.SelectedIndexChanged += recordLectureBox4_SelectedIndexChanged;
            // 
            // markBox3
            // 
            markBox3.BackColor = Color.FromArgb(232, 232, 232);
            markBox3.DisplayMember = "5";
            markBox3.Dock = DockStyle.Top;
            markBox3.Enabled = false;
            markBox3.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            markBox3.FormattingEnabled = true;
            markBox3.ItemHeight = 19;
            markBox3.Location = new Point(492, 179);
            markBox3.Margin = new Padding(4, 3, 4, 3);
            markBox3.Name = "markBox3";
            markBox3.Size = new Size(201, 27);
            markBox3.TabIndex = 25;
            markBox3.SelectedIndexChanged += markBox3_SelectedIndexChanged;
            // 
            // recordLectureBox3
            // 
            recordLectureBox3.BackColor = Color.FromArgb(232, 232, 232);
            recordLectureBox3.Dock = DockStyle.Top;
            recordLectureBox3.Enabled = false;
            recordLectureBox3.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            recordLectureBox3.FormattingEnabled = true;
            recordLectureBox3.ItemHeight = 19;
            recordLectureBox3.Location = new Point(5, 179);
            recordLectureBox3.Margin = new Padding(4, 3, 4, 3);
            recordLectureBox3.Name = "recordLectureBox3";
            recordLectureBox3.Size = new Size(478, 27);
            recordLectureBox3.TabIndex = 24;
            recordLectureBox3.SelectedIndexChanged += recordLectureBox3_SelectedIndexChanged;
            // 
            // markBox2
            // 
            markBox2.BackColor = Color.FromArgb(232, 232, 232);
            markBox2.Dock = DockStyle.Top;
            markBox2.Enabled = false;
            markBox2.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            markBox2.FormattingEnabled = true;
            markBox2.ItemHeight = 19;
            markBox2.Location = new Point(492, 115);
            markBox2.Margin = new Padding(4, 3, 4, 3);
            markBox2.Name = "markBox2";
            markBox2.Size = new Size(201, 27);
            markBox2.TabIndex = 23;
            markBox2.SelectedIndexChanged += markBox2_SelectedIndexChanged;
            // 
            // recordLectureBox2
            // 
            recordLectureBox2.BackColor = Color.FromArgb(232, 232, 232);
            recordLectureBox2.Dock = DockStyle.Top;
            recordLectureBox2.Enabled = false;
            recordLectureBox2.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            recordLectureBox2.FormattingEnabled = true;
            recordLectureBox2.ItemHeight = 19;
            recordLectureBox2.Location = new Point(5, 115);
            recordLectureBox2.Margin = new Padding(4, 3, 4, 3);
            recordLectureBox2.Name = "recordLectureBox2";
            recordLectureBox2.Size = new Size(478, 27);
            recordLectureBox2.TabIndex = 22;
            recordLectureBox2.SelectedIndexChanged += recordLectureBox2_SelectedIndexChanged;
            // 
            // markBox1
            // 
            markBox1.BackColor = Color.FromArgb(232, 232, 232);
            markBox1.DisplayMember = "1";
            markBox1.Dock = DockStyle.Top;
            markBox1.Enabled = false;
            markBox1.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            markBox1.FormattingEnabled = true;
            markBox1.ItemHeight = 19;
            markBox1.Location = new Point(492, 51);
            markBox1.Margin = new Padding(4, 3, 4, 3);
            markBox1.Name = "markBox1";
            markBox1.Size = new Size(201, 27);
            markBox1.TabIndex = 20;
            markBox1.SelectedIndexChanged += markBox1_SelectedIndexChanged;
            // 
            // markLable
            // 
            markLable.Dock = DockStyle.Fill;
            markLable.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            markLable.Location = new Point(492, 1);
            markLable.Margin = new Padding(4, 0, 4, 0);
            markLable.Name = "markLable";
            markLable.Size = new Size(201, 46);
            markLable.TabIndex = 2;
            markLable.Text = "Баллы";
            markLable.TextAlign = ContentAlignment.BottomLeft;
            // 
            // recordLectureLabel
            // 
            recordLectureLabel.Dock = DockStyle.Fill;
            recordLectureLabel.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            recordLectureLabel.Location = new Point(5, 1);
            recordLectureLabel.Margin = new Padding(4, 0, 4, 0);
            recordLectureLabel.Name = "recordLectureLabel";
            recordLectureLabel.Size = new Size(478, 46);
            recordLectureLabel.TabIndex = 1;
            recordLectureLabel.Text = "Предмет";
            recordLectureLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // recordLectureBox1
            // 
            recordLectureBox1.AllowDrop = true;
            recordLectureBox1.BackColor = Color.FromArgb(232, 232, 232);
            recordLectureBox1.Dock = DockStyle.Top;
            recordLectureBox1.Enabled = false;
            recordLectureBox1.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            recordLectureBox1.FormattingEnabled = true;
            recordLectureBox1.ItemHeight = 19;
            recordLectureBox1.Location = new Point(5, 51);
            recordLectureBox1.Margin = new Padding(4, 3, 4, 3);
            recordLectureBox1.Name = "recordLectureBox1";
            recordLectureBox1.Size = new Size(478, 27);
            recordLectureBox1.TabIndex = 19;
            recordLectureBox1.SelectedIndexChanged += recordLectureBox1_SelectedIndexChanged;
            // 
            // semesterPanel
            // 
            semesterPanel.Controls.Add(studentBox);
            semesterPanel.Controls.Add(studentLabel);
            semesterPanel.Controls.Add(semesterBox);
            semesterPanel.Controls.Add(semesterLabel);
            semesterPanel.Dock = DockStyle.Top;
            semesterPanel.Location = new Point(4, 3);
            semesterPanel.Margin = new Padding(4, 3, 4, 3);
            semesterPanel.Name = "semesterPanel";
            semesterPanel.Size = new Size(707, 43);
            semesterPanel.TabIndex = 4;
            // 
            // studentBox
            // 
            studentBox.AllowDrop = true;
            studentBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            studentBox.Enabled = false;
            studentBox.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            studentBox.FormattingEnabled = true;
            studentBox.ItemHeight = 19;
            studentBox.Location = new Point(391, 3);
            studentBox.Margin = new Padding(4, 3, 4, 3);
            studentBox.Name = "studentBox";
            studentBox.Size = new Size(307, 27);
            studentBox.TabIndex = 3;
            studentBox.SelectedIndexChanged += studentBox_SelectedIndexChanged;
            // 
            // studentLabel
            // 
            studentLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            studentLabel.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            studentLabel.Location = new Point(285, 3);
            studentLabel.Margin = new Padding(4, 0, 4, 0);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new Size(99, 33);
            studentLabel.TabIndex = 2;
            studentLabel.Text = "Студент:";
            // 
            // semesterBox
            // 
            semesterBox.AllowDrop = true;
            semesterBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            semesterBox.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            semesterBox.FormattingEnabled = true;
            semesterBox.ItemHeight = 19;
            semesterBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            semesterBox.Location = new Point(155, 3);
            semesterBox.Margin = new Padding(4, 3, 4, 3);
            semesterBox.Name = "semesterBox";
            semesterBox.Size = new Size(88, 27);
            semesterBox.TabIndex = 1;
            semesterBox.SelectedIndexChanged += semesterBox_SelectedIndexChanged;
            // 
            // semesterLabel
            // 
            semesterLabel.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            semesterLabel.Location = new Point(4, 3);
            semesterLabel.Margin = new Padding(4, 0, 4, 0);
            semesterLabel.Name = "semesterLabel";
            semesterLabel.Size = new Size(134, 33);
            semesterLabel.TabIndex = 0;
            semesterLabel.Text = "Семестр №";
            // 
            // info
            // 
            info.BackColor = SystemColors.ActiveBorder;
            info.Controls.Add(exitButton);
            info.Controls.Add(aboutLabel);
            info.Location = new Point(4, 14);
            info.Margin = new Padding(4, 3, 4, 3);
            info.Name = "info";
            info.Padding = new Padding(4, 3, 4, 3);
            info.Size = new Size(715, 641);
            info.TabIndex = 3;
            info.Text = "info";
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            exitButton.BackColor = Color.FromArgb(232, 232, 232);
            exitButton.FlatAppearance.BorderColor = Color.Black;
            exitButton.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(212, 513);
            exitButton.Margin = new Padding(4, 3, 4, 3);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(262, 115);
            exitButton.TabIndex = 5;
            exitButton.Text = "Закрыть программу";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // aboutLabel
            // 
            aboutLabel.BackColor = Color.Transparent;
            aboutLabel.Dock = DockStyle.Top;
            aboutLabel.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            aboutLabel.Location = new Point(4, 3);
            aboutLabel.Margin = new Padding(4, 0, 4, 0);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new Size(707, 248);
            aboutLabel.TabIndex = 4;
            aboutLabel.Text = "DOK'U - Diary Of the Kazan' University\r\nУдобный электронный дневник для студентов\r\nПо предложениям писать на почту: dokuemail@yandex.ru";
            aboutLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // notifyIcon
            // 
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "DOK'U";
            notifyIcon.MouseClick += notifyIcon_MouseClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(label1, 0, 6);
            tableLayoutPanel2.Controls.Add(label2, 0, 5);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(232, 232, 232);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 65);
            label1.Name = "label1";
            label1.Size = new Size(54, 66);
            label1.TabIndex = 36;
            label1.Text = "19:10\r\n-\r\n20:40";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(232, 232, 232);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 65);
            label2.TabIndex = 35;
            label2.Text = "17:30\r\n-\r\n19:00";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(232, 232, 232);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 65);
            label3.TabIndex = 34;
            label3.Text = "13:50\r\n-\r\n15:20";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.FileName = "backup-code.txt";
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(997, 659);
            Controls.Add(content);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(989, 698);
            Name = "MainForm";
            Text = "DOK'U";
            content.Panel1.ResumeLayout(false);
            content.Panel2.ResumeLayout(false);
            ((ISupportInitialize)content).EndInit();
            content.ResumeLayout(false);
            buttonsPanel.ResumeLayout(false);
            ((ISupportInitialize)iconBox).EndInit();
            contentTabs.ResumeLayout(false);
            diary.ResumeLayout(false);
            groupPanel.ResumeLayout(false);
            diaryTable.ResumeLayout(false);
            days.ResumeLayout(false);
            todayTomorrow.ResumeLayout(false);
            profile.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            recordBook.ResumeLayout(false);
            recordsTable.ResumeLayout(false);
            semesterPanel.ResumeLayout(false);
            info.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label myProfileLable;

        private System.Windows.Forms.Button extraCodesButton;
        private System.Windows.Forms.Button logOutButton;

        private System.Windows.Forms.Label nameContent;
        private System.Windows.Forms.Label loginContent;
        private System.Windows.Forms.Label birthdayContent;
        private System.Windows.Forms.Label sexContent;
        private System.Windows.Forms.Label groupContent;

        private System.Windows.Forms.Label nameLabel;

        private System.Windows.Forms.Label sexLable;
        private System.Windows.Forms.Label dirthdayLable;
        private System.Windows.Forms.Label loginLable;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label groupLable;

        private System.Windows.Forms.ComboBox semesterBox;

        private System.Windows.Forms.ComboBox studentBox;

        private System.Windows.Forms.Label studentLabel;

        private System.Windows.Forms.ComboBox markBox7;
        private System.Windows.Forms.ComboBox recordLectureBox7;

        private System.Windows.Forms.TableLayoutPanel recordsTable;
        private System.Windows.Forms.ComboBox markBox6;
        private System.Windows.Forms.ComboBox recordLectureBox6;
        private System.Windows.Forms.ComboBox markBox5;
        private System.Windows.Forms.ComboBox recordLectureBox5;
        private System.Windows.Forms.ComboBox markBox4;
        private System.Windows.Forms.ComboBox recordLectureBox4;
        private System.Windows.Forms.ComboBox markBox3;
        private System.Windows.Forms.ComboBox recordLectureBox3;
        private System.Windows.Forms.ComboBox markBox2;
        private System.Windows.Forms.ComboBox recordLectureBox2;
        private System.Windows.Forms.ComboBox markBox1;
        private System.Windows.Forms.Label markLable;
        private System.Windows.Forms.Label recordLectureLabel;
        private System.Windows.Forms.ComboBox recordLectureBox1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Panel semesterPanel;
        private System.Windows.Forms.Label semesterLabel;

        private System.Windows.Forms.Button exitButton;

        private System.Windows.Forms.Label aboutLabel;

        private System.Windows.Forms.ComboBox cabinetBox1;
        private System.Windows.Forms.ComboBox cabinetBox2;
        private System.Windows.Forms.ComboBox cabinetBox3;
        private System.Windows.Forms.ComboBox cabinetBox4;
        private System.Windows.Forms.ComboBox cabinetBox5;
        private System.Windows.Forms.ComboBox cabinetBox6;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.Label time3;
        private System.Windows.Forms.Label time4;
        private System.Windows.Forms.Label time5;
        private System.Windows.Forms.Label time6;

        private System.Windows.Forms.Label lectureLabel;

        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Label cabinetLable;

        private System.Windows.Forms.Label timeLabel;

        private System.Windows.Forms.ComboBox groupBox;

        private System.Windows.Forms.Panel groupPanel;
        private System.Windows.Forms.Label groupLabel;

        private System.Windows.Forms.NotifyIcon notifyIcon;

        private System.Windows.Forms.TableLayoutPanel diaryTable;

        private System.Windows.Forms.Button tommorow;

        private System.Windows.Forms.Button tu;
        private System.Windows.Forms.Button wd;
        private System.Windows.Forms.Button th;
        private System.Windows.Forms.Button fr;
        private System.Windows.Forms.Button st;

        private System.Windows.Forms.Button today;

        private System.Windows.Forms.Button mn;

        private System.Windows.Forms.TableLayoutPanel todayTomorrow;

        private System.Windows.Forms.TableLayoutPanel days;

        private System.Windows.Forms.TabPage recordBook;
        private System.Windows.Forms.TabPage info;

        private System.Windows.Forms.Button diaryButton;
        private System.Windows.Forms.Button recordBookButton;
        private System.Windows.Forms.Button infoButton;

        private System.Windows.Forms.Button profileButton;

        private System.Windows.Forms.TabControl contentTabs;
        private System.Windows.Forms.TabPage profile;
        private System.Windows.Forms.TabPage diary;

        private System.Windows.Forms.PictureBox iconBox;

        private System.Windows.Forms.TableLayoutPanel buttonsPanel;

        private System.Windows.Forms.SplitContainer content;

        #endregion

        private ComboBox lectureBox1;
        private ComboBox lectureBox5;
        private ComboBox lectureBox4;
        private ComboBox lectureBox3;
        private ComboBox lectureBox6;
        private ComboBox lectureBox2;
        private SaveFileDialog saveFileDialog;
    }
}