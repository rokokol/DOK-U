namespace DOK_U.Forms
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            content = new SplitContainer();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            loginPanel = new Panel();
            groupBox = new ComboBox();
            groupLabel = new Label();
            female = new RadioButton();
            male = new RadioButton();
            sexLabel = new Label();
            birthdayLabel = new Label();
            birthdayPicker = new DateTimePicker();
            surnamePanel = new Panel();
            surnameBox = new TextBox();
            pictureBox7 = new PictureBox();
            lastNamePanel = new Panel();
            lastNameBox = new TextBox();
            pictureBox6 = new PictureBox();
            enterButton = new Button();
            firstNamePanel = new Panel();
            firstNameBox = new TextBox();
            loginPicture = new PictureBox();
            infoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)content).BeginInit();
            content.Panel1.SuspendLayout();
            content.Panel2.SuspendLayout();
            content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            loginPanel.SuspendLayout();
            surnamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            lastNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            firstNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loginPicture).BeginInit();
            SuspendLayout();
            // 
            // content
            // 
            content.BorderStyle = BorderStyle.FixedSingle;
            content.Dock = DockStyle.Fill;
            content.FixedPanel = FixedPanel.Panel1;
            content.IsSplitterFixed = true;
            content.Location = new Point(0, 0);
            content.Margin = new Padding(4, 3, 4, 3);
            content.Name = "content";
            // 
            // content.Panel1
            // 
            content.Panel1.BackColor = SystemColors.ButtonShadow;
            content.Panel1.Controls.Add(pictureBox1);
            content.Panel1.Controls.Add(pictureBox2);
            content.Panel1.Controls.Add(pictureBox3);
            content.Panel1.Controls.Add(pictureBox4);
            content.Panel1.Controls.Add(pictureBox5);
            // 
            // content.Panel2
            // 
            content.Panel2.BackColor = SystemColors.ActiveBorder;
            content.Panel2.Controls.Add(loginPanel);
            content.Size = new Size(611, 457);
            content.SplitterDistance = 120;
            content.SplitterWidth = 1;
            content.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(0, 365);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 93);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLight;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(0, 273);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 95);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ControlLight;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(0, 185);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(121, 95);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ControlLight;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(0, 92);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(121, 95);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(232, 232, 232);
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = (Image)resources.GetObject("pictureBox5.InitialImage");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(121, 95);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(groupBox);
            loginPanel.Controls.Add(groupLabel);
            loginPanel.Controls.Add(female);
            loginPanel.Controls.Add(male);
            loginPanel.Controls.Add(sexLabel);
            loginPanel.Controls.Add(birthdayLabel);
            loginPanel.Controls.Add(birthdayPicker);
            loginPanel.Controls.Add(surnamePanel);
            loginPanel.Controls.Add(lastNamePanel);
            loginPanel.Controls.Add(enterButton);
            loginPanel.Controls.Add(firstNamePanel);
            loginPanel.Controls.Add(infoLabel);
            loginPanel.Location = new Point(68, 61);
            loginPanel.Margin = new Padding(4, 3, 4, 3);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(363, 364);
            loginPanel.TabIndex = 1;
            // 
            // groupBox
            // 
            groupBox.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox.FormattingEnabled = true;
            groupBox.ItemHeight = 16;
            groupBox.Location = new Point(139, 277);
            groupBox.Margin = new Padding(4, 3, 4, 3);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(218, 24);
            groupBox.TabIndex = 10;
            // 
            // groupLabel
            // 
            groupLabel.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupLabel.Location = new Point(4, 277);
            groupLabel.Margin = new Padding(4, 0, 4, 0);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new Size(134, 23);
            groupLabel.TabIndex = 9;
            groupLabel.Text = "Группа:";
            // 
            // female
            // 
            female.AutoSize = true;
            female.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold);
            female.Location = new Point(222, 255);
            female.Name = "female";
            female.Size = new Size(77, 20);
            female.TabIndex = 8;
            female.Text = "Женский";
            female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Checked = true;
            male.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold);
            male.Location = new Point(139, 255);
            male.Name = "male";
            male.Size = new Size(79, 20);
            male.TabIndex = 7;
            male.TabStop = true;
            male.Text = "Мужской";
            male.UseVisualStyleBackColor = true;
            // 
            // sexLabel
            // 
            sexLabel.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sexLabel.Location = new Point(4, 255);
            sexLabel.Margin = new Padding(4, 0, 4, 0);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new Size(134, 23);
            sexLabel.TabIndex = 6;
            sexLabel.Text = "Пол:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            birthdayLabel.Location = new Point(4, 232);
            birthdayLabel.Margin = new Padding(4, 0, 4, 0);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(134, 23);
            birthdayLabel.TabIndex = 5;
            birthdayLabel.Text = "Дата рождения:";
            // 
            // birthdayPicker
            // 
            birthdayPicker.CalendarFont = new Font("Microsoft YaHei", 8.25F, FontStyle.Bold);
            birthdayPicker.CalendarMonthBackground = SystemColors.ButtonShadow;
            birthdayPicker.Location = new Point(139, 229);
            birthdayPicker.Name = "birthdayPicker";
            birthdayPicker.Size = new Size(218, 23);
            birthdayPicker.TabIndex = 4;
            // 
            // surnamePanel
            // 
            surnamePanel.BackColor = SystemColors.ButtonShadow;
            surnamePanel.Controls.Add(surnameBox);
            surnamePanel.Controls.Add(pictureBox7);
            surnamePanel.Location = new Point(1, 167);
            surnamePanel.Margin = new Padding(4, 3, 4, 3);
            surnamePanel.Name = "surnamePanel";
            surnamePanel.Size = new Size(362, 59);
            surnamePanel.TabIndex = 2;
            // 
            // surnameBox
            // 
            surnameBox.BackColor = SystemColors.ControlDark;
            surnameBox.BorderStyle = BorderStyle.None;
            surnameBox.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            surnameBox.Location = new Point(68, 18);
            surnameBox.Margin = new Padding(4, 3, 4, 3);
            surnameBox.MaxLength = 16;
            surnameBox.Name = "surnameBox";
            surnameBox.PlaceholderText = "Ваше отчество";
            surnameBox.ScrollBars = ScrollBars.Vertical;
            surnameBox.Size = new Size(289, 32);
            surnameBox.TabIndex = 1;
            surnameBox.Tag = "";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.Margin = new Padding(4, 3, 4, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(61, 59);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // lastNamePanel
            // 
            lastNamePanel.BackColor = SystemColors.ButtonShadow;
            lastNamePanel.Controls.Add(lastNameBox);
            lastNamePanel.Controls.Add(pictureBox6);
            lastNamePanel.Location = new Point(0, 102);
            lastNamePanel.Margin = new Padding(4, 3, 4, 3);
            lastNamePanel.Name = "lastNamePanel";
            lastNamePanel.Size = new Size(362, 59);
            lastNamePanel.TabIndex = 2;
            // 
            // lastNameBox
            // 
            lastNameBox.BackColor = SystemColors.ControlDark;
            lastNameBox.BorderStyle = BorderStyle.None;
            lastNameBox.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameBox.Location = new Point(68, 18);
            lastNameBox.Margin = new Padding(4, 3, 4, 3);
            lastNameBox.MaxLength = 16;
            lastNameBox.Name = "lastNameBox";
            lastNameBox.PlaceholderText = "Ваша фамилия";
            lastNameBox.ScrollBars = ScrollBars.Vertical;
            lastNameBox.Size = new Size(289, 32);
            lastNameBox.TabIndex = 1;
            lastNameBox.Tag = "";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(61, 59);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // enterButton
            // 
            enterButton.BackColor = SystemColors.InactiveCaptionText;
            enterButton.FlatAppearance.BorderColor = Color.Gray;
            enterButton.FlatAppearance.MouseDownBackColor = Color.Black;
            enterButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 35, 35);
            enterButton.FlatStyle = FlatStyle.Flat;
            enterButton.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterButton.ForeColor = SystemColors.ButtonFace;
            enterButton.Location = new Point(0, 314);
            enterButton.Margin = new Padding(4, 3, 4, 3);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(363, 50);
            enterButton.TabIndex = 3;
            enterButton.Text = "Изменить";
            enterButton.UseVisualStyleBackColor = false;
            enterButton.Click += enterButton_Click;
            // 
            // firstNamePanel
            // 
            firstNamePanel.BackColor = SystemColors.ButtonShadow;
            firstNamePanel.Controls.Add(firstNameBox);
            firstNamePanel.Controls.Add(loginPicture);
            firstNamePanel.Location = new Point(0, 37);
            firstNamePanel.Margin = new Padding(4, 3, 4, 3);
            firstNamePanel.Name = "firstNamePanel";
            firstNamePanel.Size = new Size(362, 59);
            firstNamePanel.TabIndex = 1;
            // 
            // firstNameBox
            // 
            firstNameBox.BackColor = SystemColors.ControlDark;
            firstNameBox.BorderStyle = BorderStyle.None;
            firstNameBox.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameBox.Location = new Point(68, 18);
            firstNameBox.Margin = new Padding(4, 3, 4, 3);
            firstNameBox.MaxLength = 16;
            firstNameBox.Name = "firstNameBox";
            firstNameBox.PlaceholderText = "Ваше имя";
            firstNameBox.ScrollBars = ScrollBars.Vertical;
            firstNameBox.Size = new Size(289, 32);
            firstNameBox.TabIndex = 1;
            firstNameBox.Tag = "";
            // 
            // loginPicture
            // 
            loginPicture.Image = (Image)resources.GetObject("loginPicture.Image");
            loginPicture.Location = new Point(0, 0);
            loginPicture.Margin = new Padding(4, 3, 4, 3);
            loginPicture.Name = "loginPicture";
            loginPicture.Size = new Size(61, 59);
            loginPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            loginPicture.TabIndex = 0;
            loginPicture.TabStop = false;
            // 
            // infoLabel
            // 
            infoLabel.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            infoLabel.Location = new Point(0, 0);
            infoLabel.Margin = new Padding(4, 0, 4, 0);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(362, 33);
            infoLabel.TabIndex = 0;
            infoLabel.Text = "Дайте больше информации о себе";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(611, 457);
            Controls.Add(content);
            Name = "RegistrationForm";
            ShowIcon = false;
            Text = "Дополнительная информация";
            content.Panel1.ResumeLayout(false);
            content.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)content).EndInit();
            content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            surnamePanel.ResumeLayout(false);
            surnamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            lastNamePanel.ResumeLayout(false);
            lastNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            firstNamePanel.ResumeLayout(false);
            firstNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loginPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer content;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Panel loginPanel;
        private Button enterButton;
        private Panel firstNamePanel;
        private TextBox firstNameBox;
        private PictureBox loginPicture;
        private Label infoLabel;
        private Panel surnamePanel;
        private TextBox surnameBox;
        private PictureBox pictureBox7;
        private Panel lastNamePanel;
        private TextBox lastNameBox;
        private PictureBox pictureBox6;
        private Label sexLabel;
        private Label birthdayLabel;
        private DateTimePicker birthdayPicker;
        private RadioButton female;
        private RadioButton male;
        private Label groupLabel;
        private ComboBox groupBox;
    }
}