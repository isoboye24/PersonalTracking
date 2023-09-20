namespace PersonalTracking
{
    partial class FormSalary
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            cmbPosition = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cmbDepartment = new ComboBox();
            txtSurname = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtUserNo = new TextBox();
            label1 = new Label();
            txtSalary = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtYear = new TextBox();
            cmbMonth = new ComboBox();
            label8 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(434, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 390);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(236, 255);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbPosition);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cmbDepartment);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 135);
            panel2.TabIndex = 0;
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(28, 94);
            cmbPosition.Margin = new Padding(4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(152, 29);
            cmbPosition.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 11);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 21;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 69);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 20;
            label5.Text = "Position";
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(28, 36);
            cmbDepartment.Margin = new Padding(4);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(152, 29);
            cmbDepartment.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(111, 83);
            txtSurname.Name = "txtSurname";
            txtSurname.ReadOnly = true;
            txtSurname.Size = new Size(152, 29);
            txtSurname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 86);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 19;
            label3.Text = "Surname";
            // 
            // txtName
            // 
            txtName.Location = new Point(111, 48);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(152, 29);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 51);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 20;
            label2.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(111, 13);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.ReadOnly = true;
            txtUserNo.Size = new Size(152, 29);
            txtUserNo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 16);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 21;
            label1.Text = "User No.";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(111, 118);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(152, 29);
            txtSalary.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 121);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 23;
            label6.Text = "Salary";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 156);
            label7.Name = "label7";
            label7.Size = new Size(43, 21);
            label7.TabIndex = 23;
            label7.Text = "Year";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(111, 153);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(152, 29);
            txtYear.TabIndex = 4;
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(111, 192);
            cmbMonth.Margin = new Padding(4);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(152, 29);
            cmbMonth.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(18, 195);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 25;
            label8.Text = "Month";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(203, 253);
            btnSave.Margin = new Padding(6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 45);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Salmon;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(73, 253);
            btnClose.Margin = new Padding(6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(99, 45);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FormSalary
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 390);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(cmbMonth);
            Controls.Add(label8);
            Controls.Add(txtYear);
            Controls.Add(label7);
            Controls.Add(txtSalary);
            Controls.Add(label6);
            Controls.Add(txtSurname);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtUserNo);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormSalary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private ComboBox cmbPosition;
        private Label label4;
        private Label label5;
        private ComboBox cmbDepartment;
        private TextBox txtSurname;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtUserNo;
        private Label label1;
        private TextBox txtSalary;
        private Label label6;
        private Label label7;
        private TextBox txtYear;
        private ComboBox cmbMonth;
        private Label label8;
        private Button btnSave;
        private Button btnClose;
    }
}