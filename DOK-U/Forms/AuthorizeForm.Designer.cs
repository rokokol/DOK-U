using System;
using System.Drawing;

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
            formContainer = new SplitContainer();
            blank4 = new PictureBox();
            blank3 = new PictureBox();
            blank2 = new PictureBox();
            blank1 = new PictureBox();
            picture = new PictureBox();
            autorizeMenu = new Panel();
            showPasswordButton = new CheckBox();
            forgetPasswordTool = new Label();
            changeModeButton = new Button();
            enterButton = new Button();
            passwordPanel = new Panel();
            passwordTextBox = new TextBox();
            passwordPicture = new PictureBox();
            loginPanel = new Panel();
            loginTextBox = new TextBox();
            loginPicture = new PictureBox();
            enterLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)formContainer).BeginInit();
            formContainer.Panel1.SuspendLayout();
            formContainer.Panel2.SuspendLayout();
            formContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)blank4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blank3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blank2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blank1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            autorizeMenu.SuspendLayout();
            passwordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordPicture).BeginInit();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loginPicture).BeginInit();
            SuspendLayout();
            // 
            // formContainer
            // 
            formContainer.BorderStyle = BorderStyle.FixedSingle;
            formContainer.Dock = DockStyle.Fill;
            formContainer.FixedPanel = FixedPanel.Panel1;
            formContainer.IsSplitterFixed = true;
            formContainer.Location = new Point(0, 0);
            formContainer.Margin = new Padding(4, 3, 4, 3);
            formContainer.Name = "formContainer";
            // 
            // formContainer.Panel1
            // 
            formContainer.Panel1.BackColor = SystemColors.ButtonShadow;
            formContainer.Panel1.Controls.Add(blank4);
            formContainer.Panel1.Controls.Add(blank3);
            formContainer.Panel1.Controls.Add(blank2);
            formContainer.Panel1.Controls.Add(blank1);
            formContainer.Panel1.Controls.Add(picture);
            // 
            // formContainer.Panel2
            // 
            formContainer.Panel2.Controls.Add(autorizeMenu);
            formContainer.Size = new Size(732, 456);
            formContainer.SplitterDistance = 120;
            formContainer.SplitterWidth = 1;
            formContainer.TabIndex = 0;
            // 
            // blank4
            // 
            blank4.BackColor = SystemColors.ControlLight;
            blank4.BorderStyle = BorderStyle.FixedSingle;
            blank4.Location = new Point(0, 365);
            blank4.Margin = new Padding(4, 3, 4, 3);
            blank4.Name = "blank4";
            blank4.Size = new Size(121, 93);
            blank4.TabIndex = 4;
            blank4.TabStop = false;
            // 
            // blank3
            // 
            blank3.BackColor = SystemColors.ControlLight;
            blank3.BorderStyle = BorderStyle.FixedSingle;
            blank3.Location = new Point(0, 273);
            blank3.Margin = new Padding(4, 3, 4, 3);
            blank3.Name = "blank3";
            blank3.Size = new Size(121, 95);
            blank3.TabIndex = 3;
            blank3.TabStop = false;
            // 
            // blank2
            // 
            blank2.BackColor = SystemColors.ControlLight;
            blank2.BorderStyle = BorderStyle.FixedSingle;
            blank2.Location = new Point(0, 185);
            blank2.Margin = new Padding(4, 3, 4, 3);
            blank2.Name = "blank2";
            blank2.Size = new Size(121, 95);
            blank2.TabIndex = 3;
            blank2.TabStop = false;
            // 
            // blank1
            // 
            blank1.BackColor = SystemColors.ControlLight;
            blank1.BorderStyle = BorderStyle.FixedSingle;
            blank1.Location = new Point(0, 92);
            blank1.Margin = new Padding(4, 3, 4, 3);
            blank1.Name = "blank1";
            blank1.Size = new Size(121, 95);
            blank1.TabIndex = 3;
            blank1.TabStop = false;
            // 
            // picture
            // 
            picture.BackColor = Color.FromArgb(232, 232, 232);
            picture.BorderStyle = BorderStyle.FixedSingle;
            picture.Image = (Image)resources.GetObject("picture.Image");
            picture.InitialImage = (Image)resources.GetObject("picture.InitialImage");
            picture.Location = new Point(0, 0);
            picture.Margin = new Padding(4, 3, 4, 3);
            picture.Name = "picture";
            picture.Size = new Size(121, 95);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.TabIndex = 2;
            picture.TabStop = false;
            // 
            // autorizeMenu
            // 
            autorizeMenu.Controls.Add(showPasswordButton);
            autorizeMenu.Controls.Add(forgetPasswordTool);
            autorizeMenu.Controls.Add(changeModeButton);
            autorizeMenu.Controls.Add(enterButton);
            autorizeMenu.Controls.Add(passwordPanel);
            autorizeMenu.Controls.Add(loginPanel);
            autorizeMenu.Controls.Add(enterLabel);
            autorizeMenu.Location = new Point(145, 92);
            autorizeMenu.Margin = new Padding(4, 3, 4, 3);
            autorizeMenu.Name = "autorizeMenu";
            autorizeMenu.Size = new Size(363, 263);
            autorizeMenu.TabIndex = 1;
            // 
            // showPasswordButton
            // 
            showPasswordButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            showPasswordButton.Location = new Point(4, 234);
            showPasswordButton.Margin = new Padding(4, 3, 4, 3);
            showPasswordButton.Name = "showPasswordButton";
            showPasswordButton.Size = new Size(189, 22);
            showPasswordButton.TabIndex = 2;
            showPasswordButton.Text = "Показать пароль";
            showPasswordButton.UseVisualStyleBackColor = true;
            showPasswordButton.CheckedChanged += showPasswordButton_CheckedChanged;
            // 
            // forgetPasswordTool
            // 
            forgetPasswordTool.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 204);
            forgetPasswordTool.ForeColor = SystemColors.ControlText;
            forgetPasswordTool.Location = new Point(218, 234);
            forgetPasswordTool.Margin = new Padding(4, 0, 4, 0);
            forgetPasswordTool.Name = "forgetPasswordTool";
            forgetPasswordTool.Size = new Size(141, 27);
            forgetPasswordTool.TabIndex = 5;
            forgetPasswordTool.Text = "Забыли пароль?";
            forgetPasswordTool.MouseHover += forgetPasswordTool_MouseHover;
            forgetPasswordTool.MouseLeave += forgetPasswordTool_MouseLeave;
            // 
            // changeModeButton
            // 
            changeModeButton.BackColor = SystemColors.ScrollBar;
            changeModeButton.FlatAppearance.BorderColor = Color.DarkGray;
            changeModeButton.FlatAppearance.MouseDownBackColor = Color.LightGray;
            changeModeButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            changeModeButton.FlatStyle = FlatStyle.Flat;
            changeModeButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            changeModeButton.ForeColor = SystemColors.ControlText;
            changeModeButton.Location = new Point(236, 3);
            changeModeButton.Margin = new Padding(4, 3, 4, 3);
            changeModeButton.Name = "changeModeButton";
            changeModeButton.Size = new Size(126, 30);
            changeModeButton.TabIndex = 4;
            changeModeButton.Text = "Регистрация";
            changeModeButton.UseVisualStyleBackColor = false;
            changeModeButton.Click += changeModeButton_Click;
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
            enterButton.Location = new Point(0, 181);
            enterButton.Margin = new Padding(4, 3, 4, 3);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(363, 50);
            enterButton.TabIndex = 3;
            enterButton.Text = "Войти";
            enterButton.UseVisualStyleBackColor = false;
            enterButton.Click += enterButton_Click;
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = SystemColors.ButtonShadow;
            passwordPanel.Controls.Add(passwordTextBox);
            passwordPanel.Controls.Add(passwordPicture);
            passwordPanel.Location = new Point(1, 103);
            passwordPanel.Margin = new Padding(4, 3, 4, 3);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(362, 59);
            passwordPanel.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.ControlDark;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordTextBox.Location = new Point(66, 18);
            passwordTextBox.Margin = new Padding(4, 3, 4, 3);
            passwordTextBox.MaxLength = 16;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Ваш пароль";
            passwordTextBox.ScrollBars = ScrollBars.Vertical;
            passwordTextBox.Size = new Size(289, 32);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordPicture
            // 
            passwordPicture.Image = (Image)resources.GetObject("passwordPicture.Image");
            passwordPicture.Location = new Point(-1, 0);
            passwordPicture.Margin = new Padding(4, 3, 4, 3);
            passwordPicture.Name = "passwordPicture";
            passwordPicture.Size = new Size(61, 59);
            passwordPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordPicture.TabIndex = 1;
            passwordPicture.TabStop = false;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = SystemColors.ButtonShadow;
            loginPanel.Controls.Add(loginTextBox);
            loginPanel.Controls.Add(loginPicture);
            loginPanel.Location = new Point(0, 37);
            loginPanel.Margin = new Padding(4, 3, 4, 3);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(362, 59);
            loginPanel.TabIndex = 1;
            // 
            // loginTextBox
            // 
            loginTextBox.BackColor = SystemColors.ControlDark;
            loginTextBox.BorderStyle = BorderStyle.None;
            loginTextBox.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginTextBox.Location = new Point(68, 18);
            loginTextBox.Margin = new Padding(4, 3, 4, 3);
            loginTextBox.MaxLength = 16;
            loginTextBox.Name = "loginTextBox";
            loginTextBox.PlaceholderText = "Ваш логин";
            loginTextBox.ScrollBars = ScrollBars.Vertical;
            loginTextBox.Size = new Size(289, 32);
            loginTextBox.TabIndex = 1;
            loginTextBox.Tag = "Ваш логин";
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
            // enterLabel
            // 
            enterLabel.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterLabel.Location = new Point(0, 0);
            enterLabel.Margin = new Padding(4, 0, 4, 0);
            enterLabel.Name = "enterLabel";
            enterLabel.Size = new Size(74, 33);
            enterLabel.TabIndex = 0;
            enterLabel.Text = "Вход";
            // 
            // AuthorizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(732, 456);
            Controls.Add(formContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthorizeForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Вход";
            formContainer.Panel1.ResumeLayout(false);
            formContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)formContainer).EndInit();
            formContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)blank4).EndInit();
            ((System.ComponentModel.ISupportInitialize)blank3).EndInit();
            ((System.ComponentModel.ISupportInitialize)blank2).EndInit();
            ((System.ComponentModel.ISupportInitialize)blank1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            autorizeMenu.ResumeLayout(false);
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordPicture).EndInit();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loginPicture).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox showPasswordButton;

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