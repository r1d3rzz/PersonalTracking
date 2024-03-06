namespace PersonalTracking
{
    partial class FrmLogin
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
            userNo = new Label();
            userNumber = new TextBox();
            UserPassword = new TextBox();
            password = new Label();
            exitBtn = new Button();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // userNo
            // 
            userNo.AutoSize = true;
            userNo.Location = new Point(37, 39);
            userNo.Name = "userNo";
            userNo.Size = new Size(65, 20);
            userNo.TabIndex = 0;
            userNo.Text = "User No.";
            // 
            // userNumber
            // 
            userNumber.Location = new Point(119, 39);
            userNumber.Name = "userNumber";
            userNumber.Size = new Size(240, 27);
            userNumber.TabIndex = 0;
            userNumber.KeyPress += userNumber_KeyPress;
            // 
            // UserPassword
            // 
            UserPassword.Location = new Point(119, 94);
            UserPassword.Name = "UserPassword";
            UserPassword.Size = new Size(240, 27);
            UserPassword.TabIndex = 1;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(37, 97);
            password.Name = "password";
            password.Size = new Size(70, 20);
            password.TabIndex = 0;
            password.Text = "Password";
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(96, 148);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(211, 148);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 29);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 204);
            Controls.Add(loginBtn);
            Controls.Add(exitBtn);
            Controls.Add(UserPassword);
            Controls.Add(userNumber);
            Controls.Add(password);
            Controls.Add(userNo);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNo;
        private TextBox userNumber;
        private TextBox UserPassword;
        private Label password;
        private Button exitBtn;
        private Button loginBtn;
    }
}
