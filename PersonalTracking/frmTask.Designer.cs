namespace PersonalTracking
{
    partial class frmTask
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
            panel1 = new Panel();
            positionsList = new ComboBox();
            departmentsList = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            surname = new TextBox();
            name = new TextBox();
            userNo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            taskStatusList = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            title = new TextBox();
            label8 = new Label();
            content = new TextBox();
            closeBtn = new Button();
            saveBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(positionsList);
            panel1.Controls.Add(departmentsList);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(550, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 0;
            // 
            // positionsList
            // 
            positionsList.FormattingEnabled = true;
            positionsList.Location = new Point(16, 99);
            positionsList.Name = "positionsList";
            positionsList.Size = new Size(164, 28);
            positionsList.TabIndex = 8;
            // 
            // departmentsList
            // 
            departmentsList.FormattingEnabled = true;
            departmentsList.Location = new Point(16, 33);
            departmentsList.Name = "departmentsList";
            departmentsList.Size = new Size(164, 28);
            departmentsList.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 76);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 5;
            label5.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 10);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 6;
            label4.Text = "Department";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(250, 303);
            dataGridView1.TabIndex = 0;
            // 
            // surname
            // 
            surname.Location = new Point(99, 91);
            surname.Name = "surname";
            surname.ReadOnly = true;
            surname.Size = new Size(164, 27);
            surname.TabIndex = 8;
            // 
            // name
            // 
            name.Location = new Point(99, 49);
            name.Name = "name";
            name.ReadOnly = true;
            name.Size = new Size(164, 27);
            name.TabIndex = 7;
            // 
            // userNo
            // 
            userNo.Location = new Point(99, 7);
            userNo.Name = "userNo";
            userNo.ReadOnly = true;
            userNo.Size = new Size(164, 27);
            userNo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 4;
            label3.Text = "Surname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 6;
            label1.Text = "User No";
            // 
            // taskStatusList
            // 
            taskStatusList.FormattingEnabled = true;
            taskStatusList.Location = new Point(99, 132);
            taskStatusList.Name = "taskStatusList";
            taskStatusList.Size = new Size(164, 28);
            taskStatusList.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 135);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 22;
            label7.Text = "Task Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 180);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 4;
            label6.Text = "Title";
            // 
            // title
            // 
            title.Location = new Point(99, 173);
            title.Name = "title";
            title.Size = new Size(164, 27);
            title.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 215);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 4;
            label8.Text = "Content";
            // 
            // content
            // 
            content.Location = new Point(99, 212);
            content.Multiline = true;
            content.Name = "content";
            content.Size = new Size(341, 139);
            content.TabIndex = 8;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(298, 378);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(142, 51);
            closeBtn.TabIndex = 24;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(99, 378);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(142, 51);
            saveBtn.TabIndex = 23;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // frmTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(saveBtn);
            Controls.Add(taskStatusList);
            Controls.Add(label7);
            Controls.Add(content);
            Controls.Add(title);
            Controls.Add(surname);
            Controls.Add(name);
            Controls.Add(userNo);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "frmTask";
            Text = "frmTask";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private ComboBox positionsList;
        private ComboBox departmentsList;
        private Label label5;
        private Label label4;
        private TextBox surname;
        private TextBox name;
        private TextBox userNo;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox taskStatusList;
        private Label label7;
        private Label label6;
        private TextBox title;
        private Label label8;
        private TextBox content;
        private Button closeBtn;
        private Button saveBtn;
    }
}