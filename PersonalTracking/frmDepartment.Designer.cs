namespace PersonalTracking
{
    partial class frmDepartment
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
            departmentName = new TextBox();
            Save = new Button();
            closeBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // departmentName
            // 
            departmentName.Location = new Point(109, 34);
            departmentName.Name = "departmentName";
            departmentName.Size = new Size(199, 27);
            departmentName.TabIndex = 0;
            // 
            // Save
            // 
            Save.Location = new Point(67, 89);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 1;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(187, 89);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(94, 29);
            closeBtn.TabIndex = 2;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 34);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // frmDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 141);
            Controls.Add(label1);
            Controls.Add(closeBtn);
            Controls.Add(Save);
            Controls.Add(departmentName);
            Name = "frmDepartment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox departmentName;
        private Button Save;
        private Button closeBtn;
        private Label label1;
    }
}