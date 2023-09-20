namespace PersonalTracking
{
    partial class FormSalaryList
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
            panel4 = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            panel5 = new Panel();
            rbEquals = new RadioButton();
            rbLess = new RadioButton();
            rbMore = new RadioButton();
            cmbMonth = new ComboBox();
            label8 = new Label();
            txtYear = new TextBox();
            label7 = new Label();
            txtSalary = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            cmbPosition = new ComboBox();
            label5 = new Label();
            cmbDepartment = new ComboBox();
            label4 = new Label();
            txtSurname = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtUserNo = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAddNew = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 190);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnClear);
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(cmbMonth);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(txtYear);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txtSalary);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(321, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(518, 190);
            panel4.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(398, 141);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 31);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(279, 141);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 31);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(rbEquals);
            panel5.Controls.Add(rbLess);
            panel5.Controls.Add(rbMore);
            panel5.Location = new Point(261, 14);
            panel5.Name = "panel5";
            panel5.Size = new Size(245, 100);
            panel5.TabIndex = 32;
            // 
            // rbEquals
            // 
            rbEquals.AutoSize = true;
            rbEquals.Location = new Point(151, 72);
            rbEquals.Name = "rbEquals";
            rbEquals.Size = new Size(78, 25);
            rbEquals.TabIndex = 2;
            rbEquals.TabStop = true;
            rbEquals.Text = "Equals";
            rbEquals.UseVisualStyleBackColor = true;
            // 
            // rbLess
            // 
            rbLess.AutoSize = true;
            rbLess.Location = new Point(77, 72);
            rbLess.Name = "rbLess";
            rbLess.Size = new Size(59, 25);
            rbLess.TabIndex = 1;
            rbLess.TabStop = true;
            rbLess.Text = "Less";
            rbLess.UseVisualStyleBackColor = true;
            // 
            // rbMore
            // 
            rbMore.AutoSize = true;
            rbMore.Location = new Point(3, 70);
            rbMore.Name = "rbMore";
            rbMore.Size = new Size(68, 25);
            rbMore.TabIndex = 0;
            rbMore.TabStop = true;
            rbMore.Text = "More";
            rbMore.UseVisualStyleBackColor = true;
            // 
            // cmbMonth
            // 
            cmbMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(85, 48);
            cmbMonth.Margin = new Padding(4);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(152, 29);
            cmbMonth.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(16, 51);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 31;
            label8.Text = "Month";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(85, 11);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(152, 29);
            txtYear.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 14);
            label7.Name = "label7";
            label7.Size = new Size(43, 21);
            label7.TabIndex = 29;
            label7.Text = "Year";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(85, 85);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(152, 29);
            txtSalary.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 88);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 30;
            label6.Text = "Salary";
            // 
            // panel3
            // 
            panel3.Controls.Add(cmbPosition);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(cmbDepartment);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtSurname);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtUserNo);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 190);
            panel3.TabIndex = 0;
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(138, 148);
            cmbPosition.Margin = new Padding(4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(152, 29);
            cmbPosition.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 151);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 22;
            label5.Text = "Position";
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(138, 114);
            cmbDepartment.Margin = new Padding(4);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(152, 29);
            cmbDepartment.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 120);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 23;
            label4.Text = "Department";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(138, 78);
            txtSurname.Name = "txtSurname";
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
            txtName.Location = new Point(138, 43);
            txtName.Name = "txtName";
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
            txtUserNo.Location = new Point(138, 8);
            txtUserNo.Name = "txtUserNo";
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
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAddNew);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 365);
            panel2.Name = "panel2";
            panel2.Size = new Size(839, 75);
            panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(544, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 43);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(428, 16);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 43);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(312, 16);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 43);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.FlatStyle = FlatStyle.Popup;
            btnAddNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNew.Location = new Point(196, 16);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(98, 43);
            btnAddNew.TabIndex = 0;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(839, 175);
            dataGridView1.TabIndex = 2;
            // 
            // FormSalaryList
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 440);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormSalaryList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary List";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dataGridView1;
        private ComboBox cmbPosition;
        private Label label5;
        private ComboBox cmbDepartment;
        private Label label4;
        private TextBox txtSurname;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtUserNo;
        private Label label1;
        private ComboBox cmbMonth;
        private Label label8;
        private TextBox txtYear;
        private Label label7;
        private TextBox txtSalary;
        private Label label6;
        private Panel panel5;
        private RadioButton rbEquals;
        private RadioButton rbLess;
        private RadioButton rbMore;
        private Button btnClear;
        private Button btnSearch;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAddNew;
    }
}