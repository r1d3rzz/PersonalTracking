namespace PersonalTracking
{
    partial class frmTasksList
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
            panel2 = new Panel();
            closeBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            appriveBtn = new Button();
            addBtn = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            clearBtn = new Button();
            searchBtn = new Button();
            startDateRadio = new RadioButton();
            deliveryDateRadio = new RadioButton();
            groupBox1 = new GroupBox();
            taskStatusList = new ComboBox();
            finishDate = new DateTimePicker();
            startDate = new DateTimePicker();
            label7 = new Label();
            label4 = new Label();
            label9 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            userNo = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            departmentsList = new ComboBox();
            positionsList = new ComboBox();
            adminPanel = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            adminPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(closeBtn);
            panel2.Controls.Add(deleteBtn);
            panel2.Controls.Add(updateBtn);
            panel2.Controls.Add(appriveBtn);
            panel2.Controls.Add(addBtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 375);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 75);
            panel2.TabIndex = 2;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(643, 14);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(134, 49);
            closeBtn.TabIndex = 4;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(493, 14);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(134, 49);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(341, 14);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(134, 49);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // appriveBtn
            // 
            appriveBtn.Location = new Point(22, 14);
            appriveBtn.Name = "appriveBtn";
            appriveBtn.Size = new Size(134, 49);
            appriveBtn.TabIndex = 0;
            appriveBtn.Text = "Approve";
            appriveBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(180, 14);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(134, 49);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 295);
            dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(searchBtn);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(taskStatusList);
            panel1.Controls.Add(finishDate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(startDate);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(adminPanel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 155);
            panel1.TabIndex = 0;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(699, 117);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 29);
            clearBtn.TabIndex = 4;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(599, 117);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // startDateRadio
            // 
            startDateRadio.AutoSize = true;
            startDateRadio.Location = new Point(23, 17);
            startDateRadio.Name = "startDateRadio";
            startDateRadio.Size = new Size(97, 24);
            startDateRadio.TabIndex = 0;
            startDateRadio.TabStop = true;
            startDateRadio.Text = "Start Date";
            startDateRadio.UseVisualStyleBackColor = true;
            // 
            // deliveryDateRadio
            // 
            deliveryDateRadio.AutoSize = true;
            deliveryDateRadio.Location = new Point(23, 47);
            deliveryDateRadio.Name = "deliveryDateRadio";
            deliveryDateRadio.Size = new Size(120, 24);
            deliveryDateRadio.TabIndex = 1;
            deliveryDateRadio.TabStop = true;
            deliveryDateRadio.Text = "Delivery Date";
            deliveryDateRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deliveryDateRadio);
            groupBox1.Controls.Add(startDateRadio);
            groupBox1.Location = new Point(599, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(149, 81);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            // 
            // taskStatusList
            // 
            taskStatusList.FormattingEnabled = true;
            taskStatusList.Location = new Point(426, 118);
            taskStatusList.Name = "taskStatusList";
            taskStatusList.Size = new Size(167, 28);
            taskStatusList.TabIndex = 2;
            // 
            // finishDate
            // 
            finishDate.Location = new Point(426, 85);
            finishDate.Name = "finishDate";
            finishDate.Size = new Size(167, 27);
            finishDate.TabIndex = 1;
            // 
            // startDate
            // 
            startDate.Location = new Point(426, 52);
            startDate.Name = "startDate";
            startDate.Size = new Size(167, 27);
            startDate.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(342, 121);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 20;
            label7.Text = "Task Status";
            label7.Click += label9_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 92);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 20;
            label4.Text = "Finish";
            label4.Click += label9_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(342, 59);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 20;
            label9.Text = "Start";
            label9.Click += label9_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(341, 17);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 19;
            label3.Text = "Task Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 20;
            label1.Text = "User No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 49);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 19;
            label2.Text = "Name";
            // 
            // userNo
            // 
            userNo.Location = new Point(124, 16);
            userNo.Name = "userNo";
            userNo.Size = new Size(164, 27);
            userNo.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 85);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 23;
            label6.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 113);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 22;
            label5.Text = "Position";
            // 
            // departmentsList
            // 
            departmentsList.FormattingEnabled = true;
            departmentsList.Location = new Point(124, 79);
            departmentsList.Name = "departmentsList";
            departmentsList.Size = new Size(164, 28);
            departmentsList.TabIndex = 2;
            // 
            // positionsList
            // 
            positionsList.FormattingEnabled = true;
            positionsList.Location = new Point(124, 112);
            positionsList.Name = "positionsList";
            positionsList.Size = new Size(164, 28);
            positionsList.TabIndex = 3;
            // 
            // adminPanel
            // 
            adminPanel.Controls.Add(positionsList);
            adminPanel.Controls.Add(departmentsList);
            adminPanel.Controls.Add(label5);
            adminPanel.Controls.Add(label6);
            adminPanel.Controls.Add(textBox1);
            adminPanel.Controls.Add(userNo);
            adminPanel.Controls.Add(label2);
            adminPanel.Controls.Add(label1);
            adminPanel.Dock = DockStyle.Left;
            adminPanel.Location = new Point(0, 0);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(314, 155);
            adminPanel.TabIndex = 18;
            // 
            // frmTasksList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "frmTasksList";
            Text = "frmTasksList";
            Load += frmTasksList_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            adminPanel.ResumeLayout(false);
            adminPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button closeBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
        private Button appriveBtn;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button clearBtn;
        private Button searchBtn;
        private GroupBox groupBox1;
        private RadioButton deliveryDateRadio;
        private RadioButton startDateRadio;
        private ComboBox taskStatusList;
        private DateTimePicker finishDate;
        private Label label7;
        private Label label4;
        private DateTimePicker startDate;
        private Label label9;
        private Label label3;
        private Panel adminPanel;
        private ComboBox positionsList;
        private ComboBox departmentsList;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox userNo;
        private Label label2;
        private Label label1;
    }
}