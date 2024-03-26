using System.ComponentModel;

namespace DOK_U
{
    partial class ResetPasswordForm
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ResetPasswordForm));
            formContainer = new SplitContainer();
            blank4 = new PictureBox();
            blank3 = new PictureBox();
            blank2 = new PictureBox();
            blank1 = new PictureBox();
            picture = new PictureBox();
            autorizeMenu = new Panel();
            passwordPanel = new Panel();
            loginPanel = new Panel();
            loginTextBox = new TextBox();
            content = new SplitContainer();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureDoku = new PictureBox();
            resetPanel = new Panel();
            passwordConfirmTextpanel = new Panel();
            passwordConfirmTextBox = new TextBox();
            passwordConfirmPicture = new PictureBox();
            passwordBoxPanel = new Panel();
            passwordTextBox = new TextBox();
            passwordPicture = new PictureBox();
            codePanel = new Panel();
            codeTextBox = new TextBox();
            codePicture = new PictureBox();
            showPasswordButton = new CheckBox();
            recoverButton = new Button();
            loginPanelBox = new Panel();
            loginBox = new TextBox();
            loginPicture = new PictureBox();
            recoverLabel = new Label();
            ((ISupportInitialize)formContainer).BeginInit();
            formContainer.Panel1.SuspendLayout();
            formContainer.Panel2.SuspendLayout();
            formContainer.SuspendLayout();
            ((ISupportInitialize)blank4).BeginInit();
            ((ISupportInitialize)blank3).BeginInit();
            ((ISupportInitialize)blank2).BeginInit();
            ((ISupportInitialize)blank1).BeginInit();
            ((ISupportInitialize)picture).BeginInit();
            autorizeMenu.SuspendLayout();
            loginPanel.SuspendLayout();
            ((ISupportInitialize)content).BeginInit();
            content.Panel1.SuspendLayout();
            content.Panel2.SuspendLayout();
            content.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            ((ISupportInitialize)pictureDoku).BeginInit();
            resetPanel.SuspendLayout();
            passwordConfirmTextpanel.SuspendLayout();
            ((ISupportInitialize)passwordConfirmPicture).BeginInit();
            passwordBoxPanel.SuspendLayout();
            ((ISupportInitialize)passwordPicture).BeginInit();
            codePanel.SuspendLayout();
            ((ISupportInitialize)codePicture).BeginInit();
            loginPanelBox.SuspendLayout();
            ((ISupportInitialize)loginPicture).BeginInit();
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
            formContainer.Size = new Size(749, 459);
            formContainer.SplitterDistance = 120;
            formContainer.SplitterWidth = 1;
            formContainer.TabIndex = 1;
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
            autorizeMenu.Controls.Add(passwordPanel);
            autorizeMenu.Controls.Add(loginPanel);
            autorizeMenu.Location = new Point(145, 92);
            autorizeMenu.Margin = new Padding(4, 3, 4, 3);
            autorizeMenu.Name = "autorizeMenu";
            autorizeMenu.Size = new Size(363, 263);
            autorizeMenu.TabIndex = 1;
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = SystemColors.ButtonShadow;
            passwordPanel.Location = new Point(1, 103);
            passwordPanel.Margin = new Padding(4, 3, 4, 3);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(362, 59);
            passwordPanel.TabIndex = 2;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = SystemColors.ButtonShadow;
            loginPanel.Controls.Add(loginTextBox);
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
            loginTextBox.ScrollBars = ScrollBars.Vertical;
            loginTextBox.Size = new Size(289, 32);
            loginTextBox.TabIndex = 1;
            loginTextBox.Tag = "Ваш логин";
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
            content.Panel1.Controls.Add(pictureDoku);
            // 
            // content.Panel2
            // 
            content.Panel2.BackColor = SystemColors.ActiveBorder;
            content.Panel2.Controls.Add(resetPanel);
            content.Size = new Size(749, 459);
            content.SplitterDistance = 120;
            content.SplitterWidth = 1;
            content.TabIndex = 2;
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
            // pictureDoku
            // 
            pictureDoku.BackColor = Color.FromArgb(232, 232, 232);
            pictureDoku.BorderStyle = BorderStyle.FixedSingle;
            pictureDoku.Image = (Image)resources.GetObject("pictureDoku.Image");
            pictureDoku.InitialImage = (Image)resources.GetObject("pictureDoku.InitialImage");
            pictureDoku.Location = new Point(0, 0);
            pictureDoku.Margin = new Padding(4, 3, 4, 3);
            pictureDoku.Name = "pictureDoku";
            pictureDoku.Size = new Size(121, 95);
            pictureDoku.SizeMode = PictureBoxSizeMode.Zoom;
            pictureDoku.TabIndex = 2;
            pictureDoku.TabStop = false;
            // 
            // resetPanel
            // 
            resetPanel.Controls.Add(passwordConfirmTextpanel);
            resetPanel.Controls.Add(passwordBoxPanel);
            resetPanel.Controls.Add(codePanel);
            resetPanel.Controls.Add(showPasswordButton);
            resetPanel.Controls.Add(recoverButton);
            resetPanel.Controls.Add(loginPanelBox);
            resetPanel.Controls.Add(recoverLabel);
            resetPanel.Location = new Point(145, 51);
            resetPanel.Margin = new Padding(4, 3, 4, 3);
            resetPanel.Name = "resetPanel";
            resetPanel.Size = new Size(363, 372);
            resetPanel.TabIndex = 1;
            // 
            // passwordConfirmTextpanel
            // 
            passwordConfirmTextpanel.BackColor = SystemColors.ButtonShadow;
            passwordConfirmTextpanel.Controls.Add(passwordConfirmTextBox);
            passwordConfirmTextpanel.Controls.Add(passwordConfirmPicture);
            passwordConfirmTextpanel.Location = new Point(1, 224);
            passwordConfirmTextpanel.Margin = new Padding(4, 3, 4, 3);
            passwordConfirmTextpanel.Name = "passwordConfirmTextpanel";
            passwordConfirmTextpanel.Size = new Size(362, 59);
            passwordConfirmTextpanel.TabIndex = 5;
            // 
            // passwordConfirmTextBox
            // 
            passwordConfirmTextBox.BackColor = SystemColors.ControlDark;
            passwordConfirmTextBox.BorderStyle = BorderStyle.None;
            passwordConfirmTextBox.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordConfirmTextBox.Location = new Point(66, 18);
            passwordConfirmTextBox.Margin = new Padding(4, 3, 4, 3);
            passwordConfirmTextBox.MaxLength = 16;
            passwordConfirmTextBox.Name = "passwordConfirmTextBox";
            passwordConfirmTextBox.PlaceholderText = "Подтвердите пароль";
            passwordConfirmTextBox.ScrollBars = ScrollBars.Vertical;
            passwordConfirmTextBox.Size = new Size(289, 32);
            passwordConfirmTextBox.TabIndex = 2;
            passwordConfirmTextBox.UseSystemPasswordChar = true;
            // 
            // passwordConfirmPicture
            // 
            passwordConfirmPicture.Image = (Image)resources.GetObject("passwordConfirmPicture.Image");
            passwordConfirmPicture.Location = new Point(-1, 0);
            passwordConfirmPicture.Margin = new Padding(4, 3, 4, 3);
            passwordConfirmPicture.Name = "passwordConfirmPicture";
            passwordConfirmPicture.Size = new Size(61, 59);
            passwordConfirmPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordConfirmPicture.TabIndex = 1;
            passwordConfirmPicture.TabStop = false;
            // 
            // passwordBoxPanel
            // 
            passwordBoxPanel.BackColor = SystemColors.ButtonShadow;
            passwordBoxPanel.Controls.Add(passwordTextBox);
            passwordBoxPanel.Controls.Add(passwordPicture);
            passwordBoxPanel.Location = new Point(1, 162);
            passwordBoxPanel.Margin = new Padding(4, 3, 4, 3);
            passwordBoxPanel.Name = "passwordBoxPanel";
            passwordBoxPanel.Size = new Size(362, 59);
            passwordBoxPanel.TabIndex = 4;
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
            passwordTextBox.PlaceholderText = "Новый пароль";
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
            // codePanel
            // 
            codePanel.BackColor = SystemColors.ButtonShadow;
            codePanel.Controls.Add(codeTextBox);
            codePanel.Controls.Add(codePicture);
            codePanel.Location = new Point(0, 99);
            codePanel.Margin = new Padding(4, 3, 4, 3);
            codePanel.Name = "codePanel";
            codePanel.Size = new Size(362, 59);
            codePanel.TabIndex = 3;
            // 
            // codeTextBox
            // 
            codeTextBox.BackColor = SystemColors.ControlDark;
            codeTextBox.BorderStyle = BorderStyle.None;
            codeTextBox.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            codeTextBox.Location = new Point(66, 18);
            codeTextBox.Margin = new Padding(4, 3, 4, 3);
            codeTextBox.MaxLength = 16;
            codeTextBox.Name = "codeTextBox";
            codeTextBox.PlaceholderText = "Резервный код";
            codeTextBox.ScrollBars = ScrollBars.Vertical;
            codeTextBox.Size = new Size(289, 32);
            codeTextBox.TabIndex = 2;
            // 
            // codePicture
            // 
            codePicture.Image = (Image)resources.GetObject("codePicture.Image");
            codePicture.Location = new Point(0, 0);
            codePicture.Margin = new Padding(4, 3, 4, 3);
            codePicture.Name = "codePicture";
            codePicture.Size = new Size(61, 59);
            codePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            codePicture.TabIndex = 1;
            codePicture.TabStop = false;
            // 
            // showPasswordButton
            // 
            showPasswordButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            showPasswordButton.Location = new Point(1, 346);
            showPasswordButton.Margin = new Padding(4, 3, 4, 3);
            showPasswordButton.Name = "showPasswordButton";
            showPasswordButton.Size = new Size(189, 22);
            showPasswordButton.TabIndex = 2;
            showPasswordButton.Text = "Показать пароль";
            showPasswordButton.UseVisualStyleBackColor = true;
            showPasswordButton.CheckedChanged += showPasswordButton_CheckedChanged;
            // 
            // recoverButton
            // 
            recoverButton.BackColor = SystemColors.InactiveCaptionText;
            recoverButton.FlatAppearance.BorderColor = Color.Gray;
            recoverButton.FlatAppearance.MouseDownBackColor = Color.Black;
            recoverButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 35, 35);
            recoverButton.FlatStyle = FlatStyle.Flat;
            recoverButton.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recoverButton.ForeColor = SystemColors.ButtonFace;
            recoverButton.Location = new Point(1, 290);
            recoverButton.Margin = new Padding(4, 3, 4, 3);
            recoverButton.Name = "recoverButton";
            recoverButton.Size = new Size(363, 50);
            recoverButton.TabIndex = 3;
            recoverButton.Text = "Восстановить";
            recoverButton.UseVisualStyleBackColor = false;
            recoverButton.Click += recoverButton_Click;
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
            loginBox.PlaceholderText = "Ваш логин";
            loginBox.ScrollBars = ScrollBars.Vertical;
            loginBox.Size = new Size(289, 32);
            loginBox.TabIndex = 1;
            loginBox.Tag = "Ваш логин";
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
            // recoverLabel
            // 
            recoverLabel.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recoverLabel.Location = new Point(0, 0);
            recoverLabel.Margin = new Padding(4, 0, 4, 0);
            recoverLabel.Name = "recoverLabel";
            recoverLabel.Size = new Size(292, 33);
            recoverLabel.TabIndex = 0;
            recoverLabel.Text = "Восстановить пароль";
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 459);
            Controls.Add(content);
            Controls.Add(formContainer);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResetPasswordForm";
            ShowIcon = false;
            Text = "Восстановить пароль";
            formContainer.Panel1.ResumeLayout(false);
            formContainer.Panel2.ResumeLayout(false);
            ((ISupportInitialize)formContainer).EndInit();
            formContainer.ResumeLayout(false);
            ((ISupportInitialize)blank4).EndInit();
            ((ISupportInitialize)blank3).EndInit();
            ((ISupportInitialize)blank2).EndInit();
            ((ISupportInitialize)blank1).EndInit();
            ((ISupportInitialize)picture).EndInit();
            autorizeMenu.ResumeLayout(false);
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            content.Panel1.ResumeLayout(false);
            content.Panel2.ResumeLayout(false);
            ((ISupportInitialize)content).EndInit();
            content.ResumeLayout(false);
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ((ISupportInitialize)pictureDoku).EndInit();
            resetPanel.ResumeLayout(false);
            passwordConfirmTextpanel.ResumeLayout(false);
            passwordConfirmTextpanel.PerformLayout();
            ((ISupportInitialize)passwordConfirmPicture).EndInit();
            passwordBoxPanel.ResumeLayout(false);
            passwordBoxPanel.PerformLayout();
            ((ISupportInitialize)passwordPicture).EndInit();
            codePanel.ResumeLayout(false);
            codePanel.PerformLayout();
            ((ISupportInitialize)codePicture).EndInit();
            loginPanelBox.ResumeLayout(false);
            loginPanelBox.PerformLayout();
            ((ISupportInitialize)loginPicture).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox passwordPicture;
        private System.Windows.Forms.PictureBox passwordConfirmPicture;
        private System.Windows.Forms.Panel passwordBoxPanel;
        private System.Windows.Forms.Panel passwordConfirmTextpanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox passwordConfirmTextBox;

        private System.Windows.Forms.SplitContainer content;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureDoku;
        private System.Windows.Forms.Panel resetPanel;
        private System.Windows.Forms.CheckBox showPasswordButton;
        private System.Windows.Forms.Panel codePanel;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.PictureBox codePicture;
        private System.Windows.Forms.Panel loginPanelBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.PictureBox loginPicture;

        private System.Windows.Forms.SplitContainer formContainer;
        private System.Windows.Forms.PictureBox blank4;
        private System.Windows.Forms.PictureBox blank3;
        private System.Windows.Forms.PictureBox blank2;
        private System.Windows.Forms.PictureBox blank1;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Panel autorizeMenu;
        private System.Windows.Forms.Button recoverButton;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label recoverLabel;

        #endregion
    }
}