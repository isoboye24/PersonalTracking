namespace PersonalTracking
{
    partial class FormEmployee
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
            chAdmin = new CheckBox();
            btnCheck = new Button();
            txtPassword = new TextBox();
            txtUserNo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            txtSurname = new TextBox();
            label5 = new Label();
            txtImagePath = new TextBox();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnBrowse = new Button();
            label6 = new Label();
            txtSalary = new TextBox();
            cmbPosition = new ComboBox();
            label7 = new Label();
            cmbDepartment = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            txtAddress = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chAdmin);
            panel1.Controls.Add(btnCheck);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUserNo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 58);
            panel1.TabIndex = 0;
            // 
            // chAdmin
            // 
            chAdmin.AutoSize = true;
            chAdmin.Location = new Point(534, 14);
            chAdmin.Name = "chAdmin";
            chAdmin.Size = new Size(103, 25);
            chAdmin.TabIndex = 3;
            chAdmin.Text = "Is Admin?";
            chAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.FlatStyle = FlatStyle.Popup;
            btnCheck.Location = new Point(209, 12);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(82, 29);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(404, 12);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(111, 29);
            txtPassword.TabIndex = 2;
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(95, 12);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(108, 29);
            txtUserNo.TabIndex = 0;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 15);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 6;
            label1.Text = "User No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(118, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(111, 29);
            txtName.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 139);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 6;
            label4.Text = "Surname";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(118, 132);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(111, 29);
            txtSurname.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 173);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 6;
            label5.Text = "Image Path";
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(118, 167);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(111, 29);
            txtImagePath.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(429, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 143);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            btnBrowse.FlatStyle = FlatStyle.Popup;
            btnBrowse.Location = new Point(235, 166);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(82, 29);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 207);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 6;
            label6.Text = "Salary";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(118, 202);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(111, 29);
            txtSalary.TabIndex = 4;
            txtSalary.KeyPress += txtSalary_KeyPress;
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(118, 272);
            cmbPosition.Margin = new Padding(4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(111, 29);
            cmbPosition.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 275);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 10;
            label7.Text = "Position";
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(118, 237);
            cmbDepartment.Margin = new Padding(4);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(111, 29);
            cmbDepartment.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 241);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(102, 21);
            label8.TabIndex = 11;
            label8.Text = "Department";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 309);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(75, 21);
            label9.TabIndex = 10;
            label9.Text = "Birthday";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(117, 307);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(280, 29);
            dateTimePicker1.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 350);
            label10.Name = "label10";
            label10.Size = new Size(70, 21);
            label10.TabIndex = 6;
            label10.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(117, 342);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(520, 64);
            txtAddress.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Salmon;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(365, 429);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 43);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(233, 429);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 43);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 484);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbPosition);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(cmbDepartment);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(btnBrowse);
            Controls.Add(panel1);
            Controls.Add(txtSalary);
            Controls.Add(label6);
            Controls.Add(txtImagePath);
            Controls.Add(label5);
            Controls.Add(txtSurname);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(label10);
            Controls.Add(txtName);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtPassword;
        private TextBox txtUserNo;
        private Label label2;
        private Label label1;
        private CheckBox chAdmin;
        private Button btnCheck;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private TextBox txtSurname;
        private Label label5;
        private TextBox txtImagePath;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button btnBrowse;
        private Label label6;
        private TextBox txtSalary;
        private ComboBox cmbPosition;
        private Label label7;
        private ComboBox cmbDepartment;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private TextBox txtAddress;
        private Button btnClose;
        private Button btnSave;
    }
}