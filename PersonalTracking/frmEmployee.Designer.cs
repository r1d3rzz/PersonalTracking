namespace PersonalTracking
{
    partial class frmEmployee
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
            isAdmin = new CheckBox();
            checkBtn = new Button();
            userPassword = new TextBox();
            userNo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox8 = new TextBox();
            label10 = new Label();
            openFileDialog1 = new OpenFileDialog();
            browseBtn = new Button();
            positionsList = new ComboBox();
            departmentsList = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            saveBtn = new Button();
            closeBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(isAdmin);
            panel1.Controls.Add(checkBtn);
            panel1.Controls.Add(userPassword);
            panel1.Controls.Add(userNo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 54);
            panel1.TabIndex = 0;
            // 
            // isAdmin
            // 
            isAdmin.AutoSize = true;
            isAdmin.Location = new Point(662, 17);
            isAdmin.Name = "isAdmin";
            isAdmin.Size = new Size(96, 24);
            isAdmin.TabIndex = 3;
            isAdmin.Text = "Is Admin?";
            isAdmin.UseVisualStyleBackColor = true;
            // 
            // checkBtn
            // 
            checkBtn.Location = new Point(221, 12);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(94, 29);
            checkBtn.TabIndex = 1;
            checkBtn.Text = "Check";
            checkBtn.UseVisualStyleBackColor = true;
            // 
            // userPassword
            // 
            userPassword.Location = new Point(415, 13);
            userPassword.Name = "userPassword";
            userPassword.Size = new Size(161, 27);
            userPassword.TabIndex = 2;
            userPassword.TextChanged += userPassword_TextChanged;
            // 
            // userNo
            // 
            userNo.Location = new Point(90, 12);
            userNo.Name = "userNo";
            userNo.Size = new Size(125, 27);
            userNo.TabIndex = 0;
            userNo.KeyPress += userNo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 15);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "UserNo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 87);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 0;
            label3.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 27);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += userNo_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 27);
            textBox2.TabIndex = 1;
            textBox2.KeyPress += userNo_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 127);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 0;
            label4.Text = "Surname";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(134, 210);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 27);
            textBox3.TabIndex = 4;
            textBox3.KeyPress += userNo_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 213);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 0;
            label5.Text = "Salary";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(134, 165);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 27);
            textBox4.TabIndex = 2;
            textBox4.KeyPress += userNo_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 168);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 0;
            label6.Text = "Image Path";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 256);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 0;
            label7.Text = "Department";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 303);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 0;
            label8.Text = "Position";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 346);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 0;
            label9.Text = "Birthday";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(134, 393);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(413, 109);
            textBox8.TabIndex = 8;
            textBox8.TextChanged += textBox8_TextChanged;
            textBox8.KeyPress += userNo_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 393);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 0;
            label10.Text = "Address";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(341, 165);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(94, 29);
            browseBtn.TabIndex = 3;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = true;
            // 
            // positionsList
            // 
            positionsList.FormattingEnabled = true;
            positionsList.Location = new Point(134, 300);
            positionsList.Name = "positionsList";
            positionsList.Size = new Size(201, 28);
            positionsList.TabIndex = 6;
            // 
            // departmentsList
            // 
            departmentsList.FormattingEnabled = true;
            departmentsList.Location = new Point(134, 253);
            departmentsList.Name = "departmentsList";
            departmentsList.Size = new Size(201, 28);
            departmentsList.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(134, 346);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(571, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 197);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(636, 377);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(122, 52);
            saveBtn.TabIndex = 9;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(636, 447);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(122, 55);
            closeBtn.TabIndex = 10;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 534);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(positionsList);
            Controls.Add(departmentsList);
            Controls.Add(panel1);
            Controls.Add(closeBtn);
            Controls.Add(saveBtn);
            Controls.Add(browseBtn);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(textBox8);
            Controls.Add(textBox1);
            Name = "frmEmployee";
            Text = "Employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button checkBtn;
        private TextBox userPassword;
        private TextBox userNo;
        private Label label2;
        private Label label1;
        private CheckBox isAdmin;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox8;
        private Label label10;
        private OpenFileDialog openFileDialog1;
        private Button browseBtn;
        private ComboBox positionsList;
        private ComboBox departmentsList;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private Button saveBtn;
        private Button closeBtn;
    }
}