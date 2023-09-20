namespace PersonalTracking
{
    partial class FormEmployeeList
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
            btnClear = new Button();
            btnSearch = new Button();
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
            dataGridViewEmployee = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(cmbPosition);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbDepartment);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSurname);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUserNo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 125);
            panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(539, 57);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 43);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(539, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 43);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(372, 47);
            cmbPosition.Margin = new Padding(4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(142, 29);
            cmbPosition.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(262, 53);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 5;
            label5.Text = "Position";
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(372, 13);
            cmbDepartment.Margin = new Padding(4);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(142, 29);
            cmbDepartment.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(262, 19);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 5;
            label4.Text = "Department";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(96, 82);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(152, 29);
            txtSurname.TabIndex = 2;
            txtSurname.TextChanged += txtUserNo_TextChanged;
            txtSurname.KeyPress += txtUserNo_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 3;
            label3.Text = "Surname";
            // 
            // txtName
            // 
            txtName.Location = new Point(96, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 29);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtUserNo_TextChanged;
            txtName.KeyPress += txtUserNo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 55);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(96, 12);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(152, 29);
            txtUserNo.TabIndex = 0;
            txtUserNo.TextChanged += txtUserNo_TextChanged;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 3;
            label1.Text = "User No.";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAddNew);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 324);
            panel2.Name = "panel2";
            panel2.Size = new Size(681, 78);
            panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(489, 18);
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
            btnDelete.Location = new Point(357, 18);
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
            btnUpdate.Location = new Point(225, 18);
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
            btnAddNew.Location = new Point(93, 18);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(98, 43);
            btnAddNew.TabIndex = 0;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // dataGridViewEmployee
            // 
            dataGridViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployee.Dock = DockStyle.Fill;
            dataGridViewEmployee.Location = new Point(0, 125);
            dataGridViewEmployee.Name = "dataGridViewEmployee";
            dataGridViewEmployee.RowTemplate.Height = 25;
            dataGridViewEmployee.Size = new Size(681, 199);
            dataGridViewEmployee.TabIndex = 0;
            // 
            // FormEmployeeList
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 402);
            Controls.Add(dataGridViewEmployee);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormEmployeeList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee List";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewEmployee;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAddNew;
        private TextBox txtUserNo;
        private Label label1;
        private TextBox txtSurname;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Button btnClear;
        private Button btnSearch;
        private ComboBox cmbPosition;
        private Label label5;
        private ComboBox cmbDepartment;
        private Label label4;
    }
}