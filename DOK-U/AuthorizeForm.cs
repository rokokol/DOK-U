using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace DOK_U
{
    public partial class AuthorizeForm : Form
    {
        private bool isEnterMode = true;
        
        public AuthorizeForm()
        {
            InitializeComponent();
            loginTextBox.AccessibleDescription = "Ваш логин";
            loginTextBox.Click += TextBoxOnClick;
            passwordTextBox.Click += TextBoxOnClick;
            forgetPasswordTool.MouseHover += delegate(object sender, EventArgs args)
                { HighlightText(sender, args, Color.CornflowerBlue); };
            forgetPasswordTool.MouseLeave += delegate(object sender, EventArgs args)
                { HighlightText(sender, args, Color.Black); };
            Closing += delegate(object sender, CancelEventArgs args)
            {
                if (!MainForm.FORM.Enabled)
                {
                    Application.Exit();
                }
            };
        }
        
        private void HighlightText(object sender, EventArgs args, Color color)
        {
            var label = (Label) sender;
            label.ForeColor = color;
        }
        
        private void TextBoxOnClick(object sender, EventArgs eventArgs)
        {
            var textBox = (TextBox) sender;
            textBox.SelectAll();
            textBox.Focus();
        }

        private void changeModeButton_Click(object sender, EventArgs e)
        {
            isEnterMode = !isEnterMode;
            passwordTextBox.UseSystemPasswordChar = true;
            showPasswordButton.Checked = false;
            if (isEnterMode)
            {
                Text = "Вход";
                forgetPasswordTool.Show();
                // loginTextBox.Text = "Ваш логин";
                // passwordTextBox.Text = "Ваш пароль";
                changeModeButton.Text = "Регистрация";
                enterButton.Text = "Войти";
            }
            else
            {
                Text = "Регистрация";
                forgetPasswordTool.Hide();
                // loginTextBox.Text = "Придумайте логин";
                // passwordTextBox.Text = "Придумайте пароль";
                changeModeButton.Text = "Вход";
                enterButton.Text = "Зарегестрироваться";
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (isEnterMode)
            {
                if (passwordTextBox.Text == "password" && loginTextBox.Text == "test")
                {
                    try
                    {
                        Person user = new Person(0,
                            "Илья",
                            "Лещенко",
                            "Федорович",
                            "М",
                            false,
                            "test",
                            Person.StringToByteArray("password"),
                            new DateTime(2005, 12, 29));
                        var options = new JsonSerializerOptions
                        {
                            WriteIndented = true
                        };

                        File.WriteAllText(MainForm.INITIAL_FILE,
                            JsonSerializer.Serialize<Person>(user, options));
                        MainForm.FORM.Enabled = true;
                        Close();
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("IO Exception",
                            ex.StackTrace,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    catch (JsonException ex)
                    {
                        MessageBox.Show("Initial file esception",
                            ex.StackTrace,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }


        private void showPasswordButton_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordButton.Checked;
        }
    }
}