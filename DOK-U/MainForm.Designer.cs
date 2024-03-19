using System.ComponentModel;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.content = new System.Windows.Forms.SplitContainer();
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.infoButton = new System.Windows.Forms.Button();
            this.recordBookButton = new System.Windows.Forms.Button();
            this.diaryButton = new System.Windows.Forms.Button();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.profileButton = new System.Windows.Forms.Button();
            this.contentTabs = new System.Windows.Forms.TabControl();
            this.diary = new System.Windows.Forms.TabPage();
            this.groupPanel = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.ListBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.time6 = new System.Windows.Forms.Label();
            this.time5 = new System.Windows.Forms.Label();
            this.time4 = new System.Windows.Forms.Label();
            this.time3 = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.Label();
            this.cabinetBox6 = new System.Windows.Forms.ListBox();
            this.lectureBox6 = new System.Windows.Forms.ListBox();
            this.cabinetBox5 = new System.Windows.Forms.ListBox();
            this.lectureBox5 = new System.Windows.Forms.ListBox();
            this.cabinetBox4 = new System.Windows.Forms.ListBox();
            this.lectureBox4 = new System.Windows.Forms.ListBox();
            this.cabinetBox3 = new System.Windows.Forms.ListBox();
            this.lectureBox3 = new System.Windows.Forms.ListBox();
            this.cabinetBox2 = new System.Windows.Forms.ListBox();
            this.lectureBox2 = new System.Windows.Forms.ListBox();
            this.cabinetBox1 = new System.Windows.Forms.ListBox();
            this.time1 = new System.Windows.Forms.Label();
            this.cabinetLable = new System.Windows.Forms.Label();
            this.lectureLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.lectureBox1 = new System.Windows.Forms.ListBox();
            this.days = new System.Windows.Forms.TableLayoutPanel();
            this.st = new System.Windows.Forms.Button();
            this.fr = new System.Windows.Forms.Button();
            this.th = new System.Windows.Forms.Button();
            this.wd = new System.Windows.Forms.Button();
            this.tu = new System.Windows.Forms.Button();
            this.mn = new System.Windows.Forms.Button();
            this.todayTomorrow = new System.Windows.Forms.TableLayoutPanel();
            this.tommorow = new System.Windows.Forms.Button();
            this.today = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.TabPage();
            this.recordBook = new System.Windows.Forms.TabPage();
            this.info = new System.Windows.Forms.TabPage();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.content)).BeginInit();
            this.content.Panel1.SuspendLayout();
            this.content.Panel2.SuspendLayout();
            this.content.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.contentTabs.SuspendLayout();
            this.diary.SuspendLayout();
            this.groupPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.days.SuspendLayout();
            this.todayTomorrow.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            // 
            // content.Panel1
            // 
            this.content.Panel1.Controls.Add(this.buttonsPanel);
            this.content.Panel1MinSize = 230;
            // 
            // content.Panel2
            // 
            this.content.Panel2.Controls.Add(this.contentTabs);
            this.content.Panel2MinSize = 600;
            this.content.Size = new System.Drawing.Size(855, 559);
            this.content.SplitterDistance = 231;
            this.content.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonsPanel.ColumnCount = 1;
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsPanel.Controls.Add(this.infoButton, 0, 4);
            this.buttonsPanel.Controls.Add(this.recordBookButton, 0, 3);
            this.buttonsPanel.Controls.Add(this.diaryButton, 0, 2);
            this.buttonsPanel.Controls.Add(this.iconBox, 0, 0);
            this.buttonsPanel.Controls.Add(this.profileButton, 0, 1);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.RowCount = 5;
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.buttonsPanel.Size = new System.Drawing.Size(231, 559);
            this.buttonsPanel.TabIndex = 0;
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.infoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.infoButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoButton.Location = new System.Drawing.Point(3, 447);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(225, 109);
            this.infoButton.TabIndex = 4;
            this.infoButton.Text = "О программе";
            this.infoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // recordBookButton
            // 
            this.recordBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.recordBookButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordBookButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.recordBookButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recordBookButton.Location = new System.Drawing.Point(3, 336);
            this.recordBookButton.Name = "recordBookButton";
            this.recordBookButton.Size = new System.Drawing.Size(225, 105);
            this.recordBookButton.TabIndex = 3;
            this.recordBookButton.Text = "Зачетная книжка";
            this.recordBookButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recordBookButton.UseVisualStyleBackColor = false;
            this.recordBookButton.Click += new System.EventHandler(this.recordBookButton_Click);
            // 
            // diaryButton
            // 
            this.diaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.diaryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diaryButton.Enabled = false;
            this.diaryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.diaryButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diaryButton.Location = new System.Drawing.Point(3, 225);
            this.diaryButton.Name = "diaryButton";
            this.diaryButton.Size = new System.Drawing.Size(225, 105);
            this.diaryButton.TabIndex = 2;
            this.diaryButton.Text = "Электронный дневник";
            this.diaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.diaryButton.UseVisualStyleBackColor = false;
            this.diaryButton.Click += new System.EventHandler(this.diaryButton_Click);
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.iconBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconBox.Image = ((System.Drawing.Image)(resources.GetObject("iconBox.Image")));
            this.iconBox.Location = new System.Drawing.Point(3, 3);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(225, 105);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBox.TabIndex = 0;
            this.iconBox.TabStop = false;
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.profileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.profileButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileButton.Location = new System.Drawing.Point(3, 114);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(225, 105);
            this.profileButton.TabIndex = 1;
            this.profileButton.Text = "Мой профиль";
            this.profileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // contentTabs
            // 
            this.contentTabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.contentTabs.Controls.Add(this.diary);
            this.contentTabs.Controls.Add(this.profile);
            this.contentTabs.Controls.Add(this.recordBook);
            this.contentTabs.Controls.Add(this.info);
            this.contentTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTabs.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.contentTabs.ItemSize = new System.Drawing.Size(0, 10);
            this.contentTabs.Location = new System.Drawing.Point(0, 0);
            this.contentTabs.Multiline = true;
            this.contentTabs.Name = "contentTabs";
            this.contentTabs.SelectedIndex = 0;
            this.contentTabs.Size = new System.Drawing.Size(620, 559);
            this.contentTabs.TabIndex = 0;
            // 
            // diary
            // 
            this.diary.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.diary.Controls.Add(this.groupPanel);
            this.diary.Controls.Add(this.tableLayoutPanel1);
            this.diary.Controls.Add(this.days);
            this.diary.Controls.Add(this.todayTomorrow);
            this.diary.Location = new System.Drawing.Point(4, 14);
            this.diary.Name = "diary";
            this.diary.Padding = new System.Windows.Forms.Padding(3);
            this.diary.Size = new System.Drawing.Size(612, 541);
            this.diary.TabIndex = 1;
            this.diary.Text = "Diary";
            // 
            // groupPanel
            // 
            this.groupPanel.Controls.Add(this.groupBox);
            this.groupPanel.Controls.Add(this.groupLabel);
            this.groupPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel.Location = new System.Drawing.Point(3, 501);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.Size = new System.Drawing.Size(606, 37);
            this.groupPanel.TabIndex = 3;
            // 
            // groupBox
            // 
            this.groupBox.Enabled = false;
            this.groupBox.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.FormattingEnabled = true;
            this.groupBox.ItemHeight = 19;
            this.groupBox.Items.AddRange(new object[] { "09-321(1)", "09-321(2)", "09-322(1)", "09-322(2)" });
            this.groupBox.Location = new System.Drawing.Point(113, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(107, 23);
            this.groupBox.TabIndex = 1;
            // 
            // groupLabel
            // 
            this.groupLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupLabel.Location = new System.Drawing.Point(3, 3);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(104, 29);
            this.groupLabel.TabIndex = 0;
            this.groupLabel.Text = "Группа №";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.time6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.time5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.time4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.time3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.time2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cabinetBox6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lectureBox6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cabinetBox5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lectureBox5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cabinetBox4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lectureBox4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cabinetBox3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lectureBox3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cabinetBox2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lectureBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cabinetBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.time1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cabinetLable, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lectureLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lectureBox1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 431);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // time6
            // 
            this.time6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.time6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time6.Location = new System.Drawing.Point(3, 365);
            this.time6.Name = "time6";
            this.time6.Size = new System.Drawing.Size(54, 66);
            this.time6.TabIndex = 36;
            this.time6.Text = "19:10\r\n-\r\n20:40";
            this.time6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time5
            // 
            this.time5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.time5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time5.Location = new System.Drawing.Point(3, 300);
            this.time5.Name = "time5";
            this.time5.Size = new System.Drawing.Size(54, 65);
            this.time5.TabIndex = 35;
            this.time5.Text = "17:30\r\n-\r\n19:00";
            this.time5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time4
            // 
            this.time4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.time4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time4.Location = new System.Drawing.Point(3, 235);
            this.time4.Name = "time4";
            this.time4.Size = new System.Drawing.Size(54, 65);
            this.time4.TabIndex = 34;
            this.time4.Text = "13:50\r\n-\r\n15:20";
            this.time4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time3
            // 
            this.time3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.time3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time3.Location = new System.Drawing.Point(3, 170);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(54, 65);
            this.time3.TabIndex = 33;
            this.time3.Text = "12:10\r\n-\r\n13:40";
            this.time3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time2
            // 
            this.time2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.time2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time2.Location = new System.Drawing.Point(3, 105);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(54, 65);
            this.time2.TabIndex = 32;
            this.time2.Text = "10:10\r\n-\r\n11:40";
            this.time2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cabinetBox6
            // 
            this.cabinetBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.cabinetBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cabinetBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cabinetBox6.Enabled = false;
            this.cabinetBox6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cabinetBox6.FormattingEnabled = true;
            this.cabinetBox6.ItemHeight = 19;
            this.cabinetBox6.Items.AddRange(new object[] { "Матан" });
            this.cabinetBox6.Location = new System.Drawing.Point(439, 368);
            this.cabinetBox6.Name = "cabinetBox6";
            this.cabinetBox6.Size = new System.Drawing.Size(156, 60);
            this.cabinetBox6.TabIndex = 31;
            // 
            // lectureBox6
            // 
            this.lectureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.lectureBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lectureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lectureBox6.Enabled = false;
            this.lectureBox6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lectureBox6.FormattingEnabled = true;
            this.lectureBox6.ItemHeight = 19;
            this.lectureBox6.Items.AddRange(new object[] { "Матан" });
            this.lectureBox6.Location = new System.Drawing.Point(63, 368);
            this.lectureBox6.Name = "lectureBox6";
            this.lectureBox6.Size = new System.Drawing.Size(370, 60);
            this.lectureBox6.TabIndex = 30;
            // 
            // cabinetBox5
            // 
            this.cabinetBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.cabinetBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cabinetBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cabinetBox5.Enabled = false;
            this.cabinetBox5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cabinetBox5.FormattingEnabled = true;
            this.cabinetBox5.ItemHeight = 19;
            this.cabinetBox5.Items.AddRange(new object[] { "Матан" });
            this.cabinetBox5.Location = new System.Drawing.Point(439, 303);
            this.cabinetBox5.Name = "cabinetBox5";
            this.cabinetBox5.Size = new System.Drawing.Size(156, 59);
            this.cabinetBox5.TabIndex = 29;
            // 
            // lectureBox5
            // 
            this.lectureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.lectureBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lectureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lectureBox5.Enabled = false;
            this.lectureBox5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lectureBox5.FormattingEnabled = true;
            this.lectureBox5.ItemHeight = 19;
            this.lectureBox5.Items.AddRange(new object[] { "Матан" });
            this.lectureBox5.Location = new System.Drawing.Point(63, 303);
            this.lectureBox5.Name = "lectureBox5";
            this.lectureBox5.Size = new System.Drawing.Size(370, 59);
            this.lectureBox5.TabIndex = 28;
            // 
            // cabinetBox4
            // 
            this.cabinetBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.cabinetBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cabinetBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cabinetBox4.Enabled = false;
            this.cabinetBox4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cabinetBox4.FormattingEnabled = true;
            this.cabinetBox4.ItemHeight = 19;
            this.cabinetBox4.Items.AddRange(new object[] { "Матан" });
            this.cabinetBox4.Location = new System.Drawing.Point(439, 238);
            this.cabinetBox4.Name = "cabinetBox4";
            this.cabinetBox4.Size = new System.Drawing.Size(156, 59);
            this.cabinetBox4.TabIndex = 27;
            // 
            // lectureBox4
            // 
            this.lectureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.lectureBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lectureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lectureBox4.Enabled = false;
            this.lectureBox4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lectureBox4.FormattingEnabled = true;
            this.lectureBox4.ItemHeight = 19;
            this.lectureBox4.Items.AddRange(new object[] { "Матан" });
            this.lectureBox4.Location = new System.Drawing.Point(63, 238);
            this.lectureBox4.Name = "lectureBox4";
            this.lectureBox4.Size = new System.Drawing.Size(370, 59);
            this.lectureBox4.TabIndex = 26;
            // 
            // cabinetBox3
            // 
            this.cabinetBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.cabinetBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cabinetBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cabinetBox3.Enabled = false;
            this.cabinetBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cabinetBox3.FormattingEnabled = true;
            this.cabinetBox3.ItemHeight = 19;
            this.cabinetBox3.Items.AddRange(new object[] { "Матан" });
            this.cabinetBox3.Location = new System.Drawing.Point(439, 173);
            this.cabinetBox3.Name = "cabinetBox3";
            this.cabinetBox3.Size = new System.Drawing.Size(156, 59);
            this.cabinetBox3.TabIndex = 25;
            // 
            // lectureBox3
            // 
            this.lectureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.lectureBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lectureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lectureBox3.Enabled = false;
            this.lectureBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lectureBox3.FormattingEnabled = true;
            this.lectureBox3.ItemHeight = 19;
            this.lectureBox3.Items.AddRange(new object[] { "Матан" });
            this.lectureBox3.Location = new System.Drawing.Point(63, 173);
            this.lectureBox3.Name = "lectureBox3";
            this.lectureBox3.Size = new System.Drawing.Size(370, 59);
            this.lectureBox3.TabIndex = 24;
            // 
            // cabinetBox2
            // 
            this.cabinetBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.cabinetBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cabinetBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cabinetBox2.Enabled = false;
            this.cabinetBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cabinetBox2.FormattingEnabled = true;
            this.cabinetBox2.ItemHeight = 19;
            this.cabinetBox2.Items.AddRange(new object[] { "Матан" });
            this.cabinetBox2.Location = new System.Drawing.Point(439, 108);
            this.cabinetBox2.Name = "cabinetBox2";
            this.cabinetBox2.Size = new System.Drawing.Size(156, 59);
            this.cabinetBox2.TabIndex = 23;
            // 
            // lectureBox2
            // 
            this.lectureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.lectureBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lectureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lectureBox2.Enabled = false;
            this.lectureBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lectureBox2.FormattingEnabled = true;
            this.lectureBox2.ItemHeight = 19;
            this.lectureBox2.Items.AddRange(new object[] { "Матан" });
            this.lectureBox2.Location = new System.Drawing.Point(63, 108);
            this.lectureBox2.Name = "lectureBox2";
            this.lectureBox2.Size = new System.Drawing.Size(370, 59);
            this.lectureBox2.TabIndex = 22;
            // 
            // cabinetBox1
            // 
            this.cabinetBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.cabinetBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cabinetBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cabinetBox1.Enabled = false;
            this.cabinetBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cabinetBox1.FormattingEnabled = true;
            this.cabinetBox1.ItemHeight = 19;
            this.cabinetBox1.Items.AddRange(new object[] { "Матан" });
            this.cabinetBox1.Location = new System.Drawing.Point(439, 43);
            this.cabinetBox1.Name = "cabinetBox1";
            this.cabinetBox1.Size = new System.Drawing.Size(156, 59);
            this.cabinetBox1.TabIndex = 20;
            // 
            // time1
            // 
            this.time1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.time1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time1.Location = new System.Drawing.Point(3, 40);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(54, 65);
            this.time1.TabIndex = 3;
            this.time1.Text = "8:30\r\n-\r\n10:00";
            this.time1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cabinetLable
            // 
            this.cabinetLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cabinetLable.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cabinetLable.Location = new System.Drawing.Point(439, 0);
            this.cabinetLable.Name = "cabinetLable";
            this.cabinetLable.Size = new System.Drawing.Size(156, 40);
            this.cabinetLable.TabIndex = 2;
            this.cabinetLable.Text = "Кабинет";
            this.cabinetLable.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lectureLabel
            // 
            this.lectureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lectureLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lectureLabel.Location = new System.Drawing.Point(63, 0);
            this.lectureLabel.Name = "lectureLabel";
            this.lectureLabel.Size = new System.Drawing.Size(370, 40);
            this.lectureLabel.TabIndex = 1;
            this.lectureLabel.Text = "Кабинет";
            this.lectureLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // timeLabel
            // 
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(3, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(54, 40);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Время";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lectureBox1
            // 
            this.lectureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.lectureBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lectureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lectureBox1.Enabled = false;
            this.lectureBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lectureBox1.FormattingEnabled = true;
            this.lectureBox1.ItemHeight = 19;
            this.lectureBox1.Items.AddRange(new object[] { "Матан" });
            this.lectureBox1.Location = new System.Drawing.Point(63, 43);
            this.lectureBox1.Name = "lectureBox1";
            this.lectureBox1.Size = new System.Drawing.Size(370, 59);
            this.lectureBox1.TabIndex = 19;
            // 
            // days
            // 
            this.days.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.days.ColumnCount = 6;
            this.days.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.days.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.days.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.days.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.days.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.days.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.days.Controls.Add(this.st, 5, 0);
            this.days.Controls.Add(this.fr, 4, 0);
            this.days.Controls.Add(this.th, 3, 0);
            this.days.Controls.Add(this.wd, 2, 0);
            this.days.Controls.Add(this.tu, 1, 0);
            this.days.Controls.Add(this.mn, 0, 0);
            this.days.Location = new System.Drawing.Point(274, 6);
            this.days.Name = "days";
            this.days.RowCount = 1;
            this.days.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.days.Size = new System.Drawing.Size(330, 52);
            this.days.TabIndex = 1;
            // 
            // st
            // 
            this.st.Dock = System.Windows.Forms.DockStyle.Fill;
            this.st.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.st.Location = new System.Drawing.Point(273, 3);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(54, 46);
            this.st.TabIndex = 5;
            this.st.Text = "СБ";
            this.st.UseVisualStyleBackColor = true;
            // 
            // fr
            // 
            this.fr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fr.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fr.Location = new System.Drawing.Point(219, 3);
            this.fr.Name = "fr";
            this.fr.Size = new System.Drawing.Size(48, 46);
            this.fr.TabIndex = 4;
            this.fr.Text = "ПТ";
            this.fr.UseVisualStyleBackColor = true;
            // 
            // th
            // 
            this.th.Dock = System.Windows.Forms.DockStyle.Fill;
            this.th.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.th.Location = new System.Drawing.Point(165, 3);
            this.th.Name = "th";
            this.th.Size = new System.Drawing.Size(48, 46);
            this.th.TabIndex = 3;
            this.th.Text = "ЧТ";
            this.th.UseVisualStyleBackColor = true;
            // 
            // wd
            // 
            this.wd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wd.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wd.Location = new System.Drawing.Point(111, 3);
            this.wd.Name = "wd";
            this.wd.Size = new System.Drawing.Size(48, 46);
            this.wd.TabIndex = 2;
            this.wd.Text = "СР";
            this.wd.UseVisualStyleBackColor = true;
            // 
            // tu
            // 
            this.tu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tu.Location = new System.Drawing.Point(57, 3);
            this.tu.Name = "tu";
            this.tu.Size = new System.Drawing.Size(48, 46);
            this.tu.TabIndex = 1;
            this.tu.Text = "ВТ";
            this.tu.UseVisualStyleBackColor = true;
            // 
            // mn
            // 
            this.mn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mn.Location = new System.Drawing.Point(3, 3);
            this.mn.Name = "mn";
            this.mn.Size = new System.Drawing.Size(48, 46);
            this.mn.TabIndex = 0;
            this.mn.Text = "ПН";
            this.mn.UseVisualStyleBackColor = true;
            // 
            // todayTomorrow
            // 
            this.todayTomorrow.ColumnCount = 2;
            this.todayTomorrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.todayTomorrow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.todayTomorrow.Controls.Add(this.tommorow, 0, 0);
            this.todayTomorrow.Controls.Add(this.today, 0, 0);
            this.todayTomorrow.Location = new System.Drawing.Point(6, 6);
            this.todayTomorrow.Name = "todayTomorrow";
            this.todayTomorrow.RowCount = 1;
            this.todayTomorrow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.todayTomorrow.Size = new System.Drawing.Size(196, 52);
            this.todayTomorrow.TabIndex = 0;
            // 
            // tommorow
            // 
            this.tommorow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tommorow.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tommorow.Location = new System.Drawing.Point(101, 3);
            this.tommorow.Name = "tommorow";
            this.tommorow.Size = new System.Drawing.Size(92, 46);
            this.tommorow.TabIndex = 1;
            this.tommorow.Text = "Завтра";
            this.tommorow.UseVisualStyleBackColor = true;
            // 
            // today
            // 
            this.today.Dock = System.Windows.Forms.DockStyle.Fill;
            this.today.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.today.Location = new System.Drawing.Point(3, 3);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(92, 46);
            this.today.TabIndex = 0;
            this.today.Text = "Сегодня";
            this.today.UseVisualStyleBackColor = true;
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.profile.Location = new System.Drawing.Point(4, 14);
            this.profile.Name = "profile";
            this.profile.Padding = new System.Windows.Forms.Padding(3);
            this.profile.Size = new System.Drawing.Size(612, 541);
            this.profile.TabIndex = 0;
            this.profile.Text = "Profile";
            // 
            // recordBook
            // 
            this.recordBook.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.recordBook.Location = new System.Drawing.Point(4, 14);
            this.recordBook.Name = "recordBook";
            this.recordBook.Padding = new System.Windows.Forms.Padding(3);
            this.recordBook.Size = new System.Drawing.Size(612, 541);
            this.recordBook.TabIndex = 2;
            this.recordBook.Text = "recordBook";
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.info.Location = new System.Drawing.Point(4, 14);
            this.info.Name = "info";
            this.info.Padding = new System.Windows.Forms.Padding(3);
            this.info.Size = new System.Drawing.Size(612, 541);
            this.info.TabIndex = 3;
            this.info.Text = "info";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "DOK\'U";
            this.notifyIcon.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(855, 559);
            this.Controls.Add(this.content);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DOK\'U";
            this.content.Panel1.ResumeLayout(false);
            this.content.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.content)).EndInit();
            this.content.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.contentTabs.ResumeLayout(false);
            this.diary.ResumeLayout(false);
            this.groupPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.days.ResumeLayout(false);
            this.todayTomorrow.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox lectureBox2;

        private System.Windows.Forms.ListBox cabinetBox1;
        private System.Windows.Forms.ListBox lectureBox3;
        private System.Windows.Forms.ListBox cabinetBox2;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox cabinetBox3;
        private System.Windows.Forms.ListBox lectureBox4;
        private System.Windows.Forms.ListBox cabinetBox4;
        private System.Windows.Forms.ListBox lectureBox5;
        private System.Windows.Forms.ListBox cabinetBox5;
        private System.Windows.Forms.ListBox lectureBox6;
        private System.Windows.Forms.ListBox cabinetBox6;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.Label time3;
        private System.Windows.Forms.Label time4;
        private System.Windows.Forms.Label time5;
        private System.Windows.Forms.Label time6;

        private System.Windows.Forms.Label lectureLabel;

        private System.Windows.Forms.ListBox lectureBox1;

        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Label cabinetLable;

        private System.Windows.Forms.Label timeLabel;

        private System.Windows.Forms.ListBox groupBox;

        private System.Windows.Forms.Panel groupPanel;
        private System.Windows.Forms.Label groupLabel;

        private System.Windows.Forms.NotifyIcon notifyIcon;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

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
    }
}