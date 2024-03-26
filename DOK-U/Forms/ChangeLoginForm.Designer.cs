namespace DOK_U.Forms
{
    partial class ChangeLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeLoginForm));
            content = new SplitContainer();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            loginPanel = new Panel();
            enterButton = new Button();
            loginPanelBox = new Panel();
            loginBox = new TextBox();
            loginPicture = new PictureBox();
            loginLabel = new Label();
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
            loginPanelBox.SuspendLayout();
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
            content.Size = new Size(628, 274);
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
            loginPanel.Controls.Add(enterButton);
            loginPanel.Controls.Add(loginPanelBox);
            loginPanel.Controls.Add(loginLabel);
            loginPanel.Location = new Point(68, 61);
            loginPanel.Margin = new Padding(4, 3, 4, 3);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(363, 161);
            loginPanel.TabIndex = 1;
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
            enterButton.Location = new Point(0, 102);
            enterButton.Margin = new Padding(4, 3, 4, 3);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(363, 50);
            enterButton.TabIndex = 3;
            enterButton.Text = "Изменить";
            enterButton.UseVisualStyleBackColor = false;
            enterButton.Click += enterButton_Click;
            // 
            // loginPanelBox
            // 
            loginPanelBox.BackColor = SystemColors.ButtonShadow;
            loginPanelBox.Controls.Add(loginBox);
            loginPanelBox.Controls.Add(loginPicture);
            loginPanelBox.Location = new Point(0, 37);
            loginPanelBox.Margin = new Padding(4, 3, 4, 3);
            loginPanelBox.Name = "loginPanelBox";
            loginPanelBox.Size = new Size(362, 59);
            loginPanelBox.TabIndex = 1;
            // 
            // loginBox
            // 
            loginBox.BackColor = SystemColors.ControlDark;
            loginBox.BorderStyle = BorderStyle.None;
            loginBox.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBox.Location = new Point(68, 18);
            loginBox.Margin = new Padding(4, 3, 4, 3);
            loginBox.MaxLength = 16;
            loginBox.Name = "loginBox";
            loginBox.PlaceholderText = "Новый логин";
            loginBox.ScrollBars = ScrollBars.Vertical;
            loginBox.Size = new Size(289, 32);
            loginBox.TabIndex = 1;
            loginBox.Tag = "";
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
            // loginLabel
            // 
            loginLabel.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.Location = new Point(0, 0);
            loginLabel.Margin = new Padding(4, 0, 4, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(292, 33);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Изменить логин";
            // 
            // ChangeLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(628, 274);
            Controls.Add(content);
            Name = "ChangeLoginForm";
            ShowIcon = false;
            Text = "Изменение логина пользователя";
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
            loginPanelBox.ResumeLayout(false);
            loginPanelBox.PerformLayout();
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
        private Panel loginPanelBox;
        private TextBox loginBox;
        private PictureBox loginPicture;
        private Label loginLabel;
    }
}