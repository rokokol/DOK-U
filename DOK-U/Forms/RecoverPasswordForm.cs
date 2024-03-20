using System;
using System.Windows.Forms;

namespace DOK_U
{
    public partial class RecoverPasswordForm : Form
    {
        public RecoverPasswordForm()
        {
            InitializeComponent();
        }

        private void showPasswordButton_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordButton.Checked;
            passwordConfirmTextBox.UseSystemPasswordChar = !showPasswordButton.Checked;
        }
    }
}