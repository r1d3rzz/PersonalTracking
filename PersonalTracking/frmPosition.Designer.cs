namespace PersonalTracking
{
    partial class frmPosition
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
            label1 = new Label();
            label2 = new Label();
            positionName = new TextBox();
            departmentList = new ComboBox();
            closeBtn = new Button();
            Save = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 31);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 73);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 0;
            label2.Text = "Department";
            // 
            // positionName
            // 
            positionName.Location = new Point(141, 31);
            positionName.Name = "positionName";
            positionName.Size = new Size(153, 27);
            positionName.TabIndex = 1;
            // 
            // departmentList
            // 
            departmentList.FormattingEnabled = true;
            departmentList.Location = new Point(141, 70);
            departmentList.Name = "departmentList";
            departmentList.Size = new Size(151, 28);
            departmentList.TabIndex = 2;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(170, 127);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(94, 29);
            closeBtn.TabIndex = 4;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // Save
            // 
            Save.Location = new Point(50, 127);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 3;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            // 
            // frmPosition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 181);
            Controls.Add(closeBtn);
            Controls.Add(Save);
            Controls.Add(departmentList);
            Controls.Add(positionName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPosition";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPosition";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox positionName;
        private ComboBox departmentList;
        private Button closeBtn;
        private Button Save;
    }
}