namespace amal_calendar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            emailLabel = new Label();
            passwordLabel = new Label();
            emailTextbox = new TextBox();
            passwordTextbox = new TextBox();
            registerButton = new Button();
            loginButton = new Button();
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = SystemColors.ActiveCaptionText;
            emailLabel.Location = new Point(33, 89);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(80, 35);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(33, 143);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(125, 35);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password:";
            // 
            // emailTextbox
            // 
            emailTextbox.BackColor = Color.NavajoWhite;
            emailTextbox.Location = new Point(164, 97);
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(230, 27);
            emailTextbox.TabIndex = 2;
            // 
            // passwordTextbox
            // 
            passwordTextbox.BackColor = Color.NavajoWhite;
            passwordTextbox.Location = new Point(164, 151);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(230, 27);
            passwordTextbox.TabIndex = 3;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Ivory;
            registerButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.Location = new Point(33, 235);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(175, 52);
            registerButton.TabIndex = 4;
            registerButton.Text = "Register!";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Ivory;
            loginButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(220, 235);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(174, 52);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login!";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(434, 404);
            Controls.Add(loginButton);
            Controls.Add(registerButton);
            Controls.Add(passwordTextbox);
            Controls.Add(emailTextbox);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Login/Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emailLabel;
        private Label passwordLabel;
        private TextBox emailTextbox;
        private TextBox passwordTextbox;
        private Button registerButton;
        private Button loginButton;
    }
}