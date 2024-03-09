namespace PersonalTracking
{
    partial class frmEmployeesList
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            userNo = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            closeBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            dataGridView1 = new DataGridView();
            departmentsList = new ComboBox();
            positionsList = new ComboBox();
            searchBtn = new Button();
            clearBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(positionsList);
            panel1.Controls.Add(departmentsList);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(searchBtn);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(userNo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 158);
            panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 27);
            textBox2.TabIndex = 2;
            textBox2.KeyPress += userNo_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += userNo_KeyPress;
            // 
            // userNo
            // 
            userNo.Location = new Point(145, 21);
            userNo.Name = "userNo";
            userNo.Size = new Size(164, 27);
            userNo.TabIndex = 0;
            userNo.KeyPress += userNo_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 69);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 0;
            label5.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 108);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 0;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(375, 27);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 0;
            label4.Text = "Department";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 66);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 24);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "User No";
            // 
            // panel2
            // 
            panel2.Controls.Add(closeBtn);
            panel2.Controls.Add(deleteBtn);
            panel2.Controls.Add(updateBtn);
            panel2.Controls.Add(addBtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 438);
            panel2.Name = "panel2";
            panel2.Size = new Size(990, 77);
            panel2.TabIndex = 1;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(668, 16);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(134, 49);
            closeBtn.TabIndex = 7;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(509, 16);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(134, 49);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(346, 16);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(134, 49);
            updateBtn.TabIndex = 5;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(181, 16);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(134, 49);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(990, 280);
            dataGridView1.TabIndex = 2;
            // 
            // departmentsList
            // 
            departmentsList.FormattingEnabled = true;
            departmentsList.Location = new Point(479, 21);
            departmentsList.Name = "departmentsList";
            departmentsList.Size = new Size(164, 28);
            departmentsList.TabIndex = 3;
            // 
            // positionsList
            // 
            positionsList.FormattingEnabled = true;
            positionsList.Location = new Point(479, 66);
            positionsList.Name = "positionsList";
            positionsList.Size = new Size(164, 28);
            positionsList.TabIndex = 4;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(746, 21);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(134, 49);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(746, 83);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(134, 49);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // frmEmployeesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 515);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmEmployeesList";
            Text = "Employees List";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox userNo;
        private Label label1;
        private Button closeBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private ComboBox positionsList;
        private ComboBox departmentsList;
        private Button clearBtn;
        private Button searchBtn;
    }
}