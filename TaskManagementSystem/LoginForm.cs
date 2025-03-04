using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagementSystem.Model;

namespace TaskManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Attach event handlers
            loginButton.Click += LoginButton_Click;
            registerSubmitButton.Click += RegisterSubmitButton_Click;
            switchToRegisterButton.Click += SwitchToRegisterButton_Click;
            switchToLoginButton.Click += SwitchToLoginButton_Click;
            forgotPasswordLink.Click += ForgotPasswordLink_Click;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (userEmailTextBox.Text != null && userEmailTextBox.Text != ""
                                        && passwordTextBox.Text != null && passwordTextBox.Text != "")
            {
                using var db = new TaskManagementDB();


                var user = db.User.FirstOrDefault(u =>
                    u.Email == userEmailTextBox.Text && u.Password == passwordTextBox.Text);

                if (user != null)
                {
                    TaskManager.UserId = user.Id;

                    var taskManagementForm = new TaskManager();

                    taskManagementForm.FormClosed += (s, args) => this.Close();

                    this.Hide();
                    taskManagementForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void RegisterSubmitButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text != "" && registeruserEmailTextBox.Text != ""
                 && registerPasswordTextBox.Text != ""
                 && registerPasswordTextBox.Text == confirmPasswordTextBox.Text)
            {
                using var db = new TaskManagementDB();
                var user = db.User.FirstOrDefault(u => u.Email == userEmailTextBox.Text);

                if (user == null)
                {
                    User newUser = new()
                    {
                        Name = UserNameTextBox.Text,
                        Email = registeruserEmailTextBox.Text,
                        Password = registerPasswordTextBox.Text
                    };


                    db.User.Add(newUser);
                    db.SaveChanges();

                    MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SwitchToLoginButton_Click(new object(), new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Invalid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SwitchToRegisterButton_Click(object sender, EventArgs e)
        {
            registerPanel.DataBindings.Clear();
            registerPanel.Visible = true;
            loginPanel.Visible = false;
        }

        private void SwitchToLoginButton_Click(object sender, EventArgs e)
        {
            registerPanel.DataBindings.Clear();
            loginPanel.Visible = true;
            registerPanel.Visible = false;
        }

        private void ForgotPasswordLink_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact support.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
