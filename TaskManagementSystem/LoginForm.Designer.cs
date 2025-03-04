namespace TaskManagementSystem
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            loginPanel = new Panel();
            registerPanel = new Panel();
            label4 = new Label();
            UserNameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            registerSubmitButton = new Button();
            confirmPasswordTextBox = new TextBox();
            registerPasswordTextBox = new TextBox();
            registeruserEmailTextBox = new TextBox();
            switchToLoginButton = new Button();
            titleLabel = new Label();
            userEmailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            forgotPasswordLink = new LinkLabel();
            switchToRegisterButton = new Button();
            loginPanel.SuspendLayout();
            registerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.WhiteSmoke;
            loginPanel.Controls.Add(registerPanel);
            loginPanel.Controls.Add(titleLabel);
            loginPanel.Controls.Add(userEmailTextBox);
            loginPanel.Controls.Add(passwordTextBox);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(forgotPasswordLink);
            loginPanel.Controls.Add(switchToRegisterButton);
            loginPanel.Location = new Point(0, 0);
            loginPanel.Margin = new Padding(4, 5, 4, 5);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(533, 769);
            loginPanel.TabIndex = 0;
            // 
            // registerPanel
            // 
            registerPanel.BackColor = Color.WhiteSmoke;
            registerPanel.Controls.Add(label4);
            registerPanel.Controls.Add(UserNameTextBox);
            registerPanel.Controls.Add(label3);
            registerPanel.Controls.Add(label2);
            registerPanel.Controls.Add(label1);
            registerPanel.Controls.Add(registerSubmitButton);
            registerPanel.Controls.Add(confirmPasswordTextBox);
            registerPanel.Controls.Add(registerPasswordTextBox);
            registerPanel.Controls.Add(registeruserEmailTextBox);
            registerPanel.Controls.Add(switchToLoginButton);
            registerPanel.Location = new Point(3, 3);
            registerPanel.Margin = new Padding(4, 5, 4, 5);
            registerPanel.Name = "registerPanel";
            registerPanel.Size = new Size(533, 769);
            registerPanel.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 91);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 9;
            label4.Text = "Enter Name";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameTextBox.Location = new Point(100, 116);
            UserNameTextBox.Margin = new Padding(4, 5, 4, 5);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(332, 34);
            UserNameTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 324);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 7;
            label3.Text = "ReEnter Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 247);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 6;
            label2.Text = "Enter Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 170);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 5;
            label1.Text = "Enter Email";
            // 
            // registerSubmitButton
            // 
            registerSubmitButton.BackColor = Color.FromArgb(0, 120, 215);
            registerSubmitButton.FlatAppearance.BorderSize = 0;
            registerSubmitButton.FlatStyle = FlatStyle.Flat;
            registerSubmitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerSubmitButton.ForeColor = Color.White;
            registerSubmitButton.Location = new Point(100, 415);
            registerSubmitButton.Margin = new Padding(4, 5, 4, 5);
            registerSubmitButton.Name = "registerSubmitButton";
            registerSubmitButton.Size = new Size(333, 62);
            registerSubmitButton.TabIndex = 4;
            registerSubmitButton.Text = "Register";
            registerSubmitButton.UseVisualStyleBackColor = false;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordTextBox.Location = new Point(100, 349);
            confirmPasswordTextBox.Margin = new Padding(4, 5, 4, 5);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(332, 34);
            confirmPasswordTextBox.TabIndex = 3;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // registerPasswordTextBox
            // 
            registerPasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerPasswordTextBox.Location = new Point(100, 272);
            registerPasswordTextBox.Margin = new Padding(4, 5, 4, 5);
            registerPasswordTextBox.Name = "registerPasswordTextBox";
            registerPasswordTextBox.Size = new Size(332, 34);
            registerPasswordTextBox.TabIndex = 2;
            registerPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // registeruserEmailTextBox
            // 
            registeruserEmailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registeruserEmailTextBox.Location = new Point(100, 195);
            registeruserEmailTextBox.Margin = new Padding(4, 5, 4, 5);
            registeruserEmailTextBox.Name = "registeruserEmailTextBox";
            registeruserEmailTextBox.Size = new Size(332, 34);
            registeruserEmailTextBox.TabIndex = 1;
            // 
            // switchToLoginButton
            // 
            switchToLoginButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            switchToLoginButton.Location = new Point(200, 615);
            switchToLoginButton.Margin = new Padding(4, 5, 4, 5);
            switchToLoginButton.Name = "switchToLoginButton";
            switchToLoginButton.Size = new Size(133, 46);
            switchToLoginButton.TabIndex = 0;
            switchToLoginButton.Text = "Back to Login";
            switchToLoginButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(64, 64, 64);
            titleLabel.Location = new Point(111, 77);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(297, 54);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Welcome Back";
            // 
            // userEmailTextBox
            // 
            userEmailTextBox.BackColor = Color.White;
            userEmailTextBox.BorderStyle = BorderStyle.None;
            userEmailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userEmailTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            userEmailTextBox.Location = new Point(100, 231);
            userEmailTextBox.Margin = new Padding(4, 5, 4, 5);
            userEmailTextBox.Name = "userEmailTextBox";
            userEmailTextBox.PlaceholderText = "Enter your email";
            userEmailTextBox.Size = new Size(332, 27);
            userEmailTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            passwordTextBox.Location = new Point(100, 308);
            passwordTextBox.Margin = new Padding(4, 5, 4, 5);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Enter your password";
            passwordTextBox.Size = new Size(332, 27);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(0, 120, 215);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(100, 415);
            loginButton.Margin = new Padding(4, 5, 4, 5);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(333, 62);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // forgotPasswordLink
            // 
            forgotPasswordLink.AutoSize = true;
            forgotPasswordLink.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgotPasswordLink.LinkColor = Color.FromArgb(0, 120, 215);
            forgotPasswordLink.Location = new Point(200, 508);
            forgotPasswordLink.Margin = new Padding(4, 0, 4, 0);
            forgotPasswordLink.Name = "forgotPasswordLink";
            forgotPasswordLink.Size = new Size(143, 23);
            forgotPasswordLink.TabIndex = 4;
            forgotPasswordLink.TabStop = true;
            forgotPasswordLink.Text = "Forgot Password?";
            // 
            // switchToRegisterButton
            // 
            switchToRegisterButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            switchToRegisterButton.Location = new Point(200, 615);
            switchToRegisterButton.Margin = new Padding(4, 5, 4, 5);
            switchToRegisterButton.Name = "switchToRegisterButton";
            switchToRegisterButton.Size = new Size(133, 46);
            switchToRegisterButton.TabIndex = 5;
            switchToRegisterButton.Text = "Register";
            switchToRegisterButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(533, 769);
            Controls.Add(loginPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            registerPanel.ResumeLayout(false);
            registerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox userEmailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel forgotPasswordLink;
        private System.Windows.Forms.Button switchToRegisterButton;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Button registerSubmitButton;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox registerPasswordTextBox;
        private System.Windows.Forms.TextBox registeruserEmailTextBox;
        private System.Windows.Forms.Button switchToLoginButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox UserNameTextBox;
    }
}