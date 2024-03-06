namespace PersonalTracking
{
    partial class frmMain
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
            employeeBtn = new Button();
            taskBtn = new Button();
            salaryBtn = new Button();
            permissionBtn = new Button();
            departmentBtn = new Button();
            positionBtn = new Button();
            exitBtn = new Button();
            logoutBtn = new Button();
            SuspendLayout();
            // 
            // employeeBtn
            // 
            employeeBtn.BackColor = Color.Orange;
            employeeBtn.Location = new Point(12, 12);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Size = new Size(136, 122);
            employeeBtn.TabIndex = 0;
            employeeBtn.Text = "Employee";
            employeeBtn.UseVisualStyleBackColor = false;
            // 
            // taskBtn
            // 
            taskBtn.BackColor = Color.FromArgb(255, 192, 192);
            taskBtn.Location = new Point(189, 12);
            taskBtn.Name = "taskBtn";
            taskBtn.Size = new Size(136, 122);
            taskBtn.TabIndex = 0;
            taskBtn.Text = "Tasks";
            taskBtn.UseVisualStyleBackColor = false;
            // 
            // salaryBtn
            // 
            salaryBtn.BackColor = Color.FromArgb(0, 192, 0);
            salaryBtn.Location = new Point(362, 12);
            salaryBtn.Name = "salaryBtn";
            salaryBtn.Size = new Size(136, 122);
            salaryBtn.TabIndex = 0;
            salaryBtn.Text = "Salary";
            salaryBtn.UseVisualStyleBackColor = false;
            // 
            // permissionBtn
            // 
            permissionBtn.BackColor = Color.FromArgb(255, 128, 0);
            permissionBtn.Location = new Point(12, 163);
            permissionBtn.Name = "permissionBtn";
            permissionBtn.Size = new Size(136, 122);
            permissionBtn.TabIndex = 0;
            permissionBtn.Text = "Permission";
            permissionBtn.UseVisualStyleBackColor = false;
            // 
            // departmentBtn
            // 
            departmentBtn.BackColor = Color.FromArgb(128, 255, 128);
            departmentBtn.Location = new Point(189, 163);
            departmentBtn.Name = "departmentBtn";
            departmentBtn.Size = new Size(136, 122);
            departmentBtn.TabIndex = 0;
            departmentBtn.Text = "Department";
            departmentBtn.UseVisualStyleBackColor = false;
            // 
            // positionBtn
            // 
            positionBtn.BackColor = Color.FromArgb(128, 128, 255);
            positionBtn.Location = new Point(362, 163);
            positionBtn.Name = "positionBtn";
            positionBtn.Size = new Size(136, 122);
            positionBtn.TabIndex = 0;
            positionBtn.Text = "Position";
            positionBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Green;
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(251, 316);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(136, 122);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Yellow;
            logoutBtn.Location = new Point(74, 316);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(136, 122);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 466);
            Controls.Add(positionBtn);
            Controls.Add(logoutBtn);
            Controls.Add(exitBtn);
            Controls.Add(departmentBtn);
            Controls.Add(salaryBtn);
            Controls.Add(permissionBtn);
            Controls.Add(taskBtn);
            Controls.Add(employeeBtn);
            Name = "frmMain";
            Text = "frmMain";
            ResumeLayout(false);
        }

        #endregion

        private Button employeeBtn;
        private Button taskBtn;
        private Button salaryBtn;
        private Button permissionBtn;
        private Button departmentBtn;
        private Button positionBtn;
        private Button exitBtn;
        private Button logoutBtn;
    }
}