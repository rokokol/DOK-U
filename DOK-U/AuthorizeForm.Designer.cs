namespace DOK_U
{
    partial class AuthorizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizeForm));
            this.formContainer = new System.Windows.Forms.SplitContainer();
            this.blank4 = new System.Windows.Forms.PictureBox();
            this.blank3 = new System.Windows.Forms.PictureBox();
            this.blank2 = new System.Windows.Forms.PictureBox();
            this.blank1 = new System.Windows.Forms.PictureBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.autorizeMenu = new System.Windows.Forms.Panel();
            this.forgetPasswordTool = new System.Windows.Forms.Label();
            this.changeModeButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordPicture = new System.Windows.Forms.PictureBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginPicture = new System.Windows.Forms.PictureBox();
            this.enterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.formContainer)).BeginInit();
            this.formContainer.Panel1.SuspendLayout();
            this.formContainer.Panel2.SuspendLayout();
            this.formContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blank4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blank3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blank2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blank1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.autorizeMenu.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).BeginInit();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // formContainer
            // 
            this.formContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.formContainer.IsSplitterFixed = true;
            this.formContainer.Location = new System.Drawing.Point(0, 0);
            this.formContainer.Name = "formContainer";
            // 
            // formContainer.Panel1
            // 
            this.formContainer.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.formContainer.Panel1.Controls.Add(this.blank4);
            this.formContainer.Panel1.Controls.Add(this.blank3);
            this.formContainer.Panel1.Controls.Add(this.blank2);
            this.formContainer.Panel1.Controls.Add(this.blank1);
            this.formContainer.Panel1.Controls.Add(this.picture);
            // 
            // formContainer.Panel2
            // 
            this.formContainer.Panel2.Controls.Add(this.autorizeMenu);
            this.formContainer.Size = new System.Drawing.Size(627, 395);
            this.formContainer.SplitterDistance = 103;
            this.formContainer.SplitterWidth = 1;
            this.formContainer.TabIndex = 0;
            // 
            // blank4
            // 
            this.blank4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.blank4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blank4.Location = new System.Drawing.Point(0, 316);
            this.blank4.Name = "blank4";
            this.blank4.Size = new System.Drawing.Size(104, 81);
            this.blank4.TabIndex = 4;
            this.blank4.TabStop = false;
            // 
            // blank3
            // 
            this.blank3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.blank3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blank3.Location = new System.Drawing.Point(0, 237);
            this.blank3.Name = "blank3";
            this.blank3.Size = new System.Drawing.Size(104, 83);
            this.blank3.TabIndex = 3;
            this.blank3.TabStop = false;
            // 
            // blank2
            // 
            this.blank2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.blank2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blank2.Location = new System.Drawing.Point(0, 160);
            this.blank2.Name = "blank2";
            this.blank2.Size = new System.Drawing.Size(104, 83);
            this.blank2.TabIndex = 3;
            this.blank2.TabStop = false;
            // 
            // blank1
            // 
            this.blank1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.blank1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blank1.Location = new System.Drawing.Point(0, 80);
            this.blank1.Name = "blank1";
            this.blank1.Size = new System.Drawing.Size(104, 83);
            this.blank1.TabIndex = 3;
            this.blank1.TabStop = false;
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.InitialImage = ((System.Drawing.Image)(resources.GetObject("picture.InitialImage")));
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(104, 83);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // autorizeMenu
            // 
            this.autorizeMenu.Controls.Add(this.forgetPasswordTool);
            this.autorizeMenu.Controls.Add(this.changeModeButton);
            this.autorizeMenu.Controls.Add(this.enterButton);
            this.autorizeMenu.Controls.Add(this.passwordPanel);
            this.autorizeMenu.Controls.Add(this.loginPanel);
            this.autorizeMenu.Controls.Add(this.enterLabel);
            this.autorizeMenu.Location = new System.Drawing.Point(124, 80);
            this.autorizeMenu.Name = "autorizeMenu";
            this.autorizeMenu.Size = new System.Drawing.Size(311, 228);
            this.autorizeMenu.TabIndex = 1;
            // 
            // forgetPasswordTool
            // 
            this.forgetPasswordTool.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forgetPasswordTool.ForeColor = System.Drawing.SystemColors.ControlText;
            this.forgetPasswordTool.Location = new System.Drawing.Point(183, 203);
            this.forgetPasswordTool.Name = "forgetPasswordTool";
            this.forgetPasswordTool.Size = new System.Drawing.Size(123, 23);
            this.forgetPasswordTool.TabIndex = 5;
            this.forgetPasswordTool.Text = "Забыли пароль?";
            // 
            // changeModeButton
            // 
            this.changeModeButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.changeModeButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.changeModeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.changeModeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.changeModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeModeButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeModeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.changeModeButton.Location = new System.Drawing.Point(202, 3);
            this.changeModeButton.Name = "changeModeButton";
            this.changeModeButton.Size = new System.Drawing.Size(108, 26);
            this.changeModeButton.TabIndex = 4;
            this.changeModeButton.Text = "Регистрация";
            this.changeModeButton.UseVisualStyleBackColor = false;
            this.changeModeButton.Click += new System.EventHandler(this.changeModeButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.enterButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.enterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.enterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enterButton.Location = new System.Drawing.Point(0, 157);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(311, 43);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.passwordPanel.Controls.Add(this.passwordTextBox);
            this.passwordPanel.Controls.Add(this.passwordPicture);
            this.passwordPanel.Location = new System.Drawing.Point(1, 89);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(310, 51);
            this.passwordPanel.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(57, 16);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.passwordTextBox.Size = new System.Drawing.Size(248, 32);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "Ваш пароль";
            // 
            // passwordPicture
            // 
            this.passwordPicture.Location = new System.Drawing.Point(-1, 0);
            this.passwordPicture.Name = "passwordPicture";
            this.passwordPicture.Size = new System.Drawing.Size(52, 51);
            this.passwordPicture.TabIndex = 1;
            this.passwordPicture.TabStop = false;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.loginPanel.Controls.Add(this.loginTextBox);
            this.loginPanel.Controls.Add(this.loginPicture);
            this.loginPanel.Location = new System.Drawing.Point(0, 32);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(310, 51);
            this.loginPanel.TabIndex = 1;
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTextBox.Location = new System.Drawing.Point(58, 16);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.loginTextBox.Size = new System.Drawing.Size(248, 32);
            this.loginTextBox.TabIndex = 1;
            this.loginTextBox.Text = "Ваш логин";
            // 
            // loginPicture
            // 
            this.loginPicture.Location = new System.Drawing.Point(0, 0);
            this.loginPicture.Name = "loginPicture";
            this.loginPicture.Size = new System.Drawing.Size(52, 51);
            this.loginPicture.TabIndex = 0;
            this.loginPicture.TabStop = false;
            // 
            // enterLabel
            // 
            this.enterLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLabel.Location = new System.Drawing.Point(0, 0);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(63, 29);
            this.enterLabel.TabIndex = 0;
            this.enterLabel.Text = "Вход";
            // 
            // AuthorizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(627, 395);
            this.Controls.Add(this.formContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DOK\'U";
            this.formContainer.Panel1.ResumeLayout(false);
            this.formContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formContainer)).EndInit();
            this.formContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blank4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blank3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blank2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blank1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.autorizeMenu.ResumeLayout(false);
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label forgetPasswordTool;

        private System.Windows.Forms.Button changeModeButton;

        private System.Windows.Forms.Button enterButton;

        private System.Windows.Forms.TextBox passwordTextBox;

        private System.Windows.Forms.PictureBox passwordPicture;
        private System.Windows.Forms.TextBox loginTextBox;

        private System.Windows.Forms.PictureBox loginPicture;

        private System.Windows.Forms.Panel passwordPanel;

        private System.Windows.Forms.Panel loginPanel;

        private System.Windows.Forms.Panel autorizeMenu;

        private System.Windows.Forms.Label enterLabel;

        private System.Windows.Forms.PictureBox blank4;

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox blank1;
        private System.Windows.Forms.PictureBox blank2;
        private System.Windows.Forms.PictureBox blank3;

        private System.Windows.Forms.SplitContainer formContainer;

        #endregion
    }
}