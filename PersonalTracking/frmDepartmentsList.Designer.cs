namespace PersonalTracking
{
    partial class frmDepartmentsList
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
            departmentsList = new DataGridView();
            panel1 = new Panel();
            closeBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)departmentsList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // departmentsList
            // 
            departmentsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            departmentsList.Dock = DockStyle.Top;
            departmentsList.Location = new Point(0, 0);
            departmentsList.Name = "departmentsList";
            departmentsList.RowHeadersWidth = 51;
            departmentsList.Size = new Size(652, 349);
            departmentsList.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(deleteBtn);
            panel1.Controls.Add(updateBtn);
            panel1.Controls.Add(addBtn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 319);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 95);
            panel1.TabIndex = 1;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(499, 25);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(134, 49);
            closeBtn.TabIndex = 3;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(340, 25);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(134, 49);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(177, 25);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(134, 49);
            updateBtn.TabIndex = 1;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(12, 25);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(134, 49);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // frmDepartmentsList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 414);
            Controls.Add(panel1);
            Controls.Add(departmentsList);
            Name = "frmDepartmentsList";
            Text = "Departments List";
            ((System.ComponentModel.ISupportInitialize)departmentsList).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView departmentsList;
        private Panel panel1;
        private Button closeBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
    }
}