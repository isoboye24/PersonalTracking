namespace PersonalTracking
{
    partial class FormTaskList
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
            panel3 = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            comboBox1 = new ComboBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            rbDeliveryDate = new RadioButton();
            rbStartDate = new RadioButton();
            dateTimePickerFinish = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panelAdmin = new Panel();
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
            btnApprove = new Button();
            btnAddNew = new Button();
            dataGridViewTasklist = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panelAdmin.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasklist).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panelAdmin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 199);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(dateTimePickerFinish);
            panel3.Controls.Add(dateTimePickerStart);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(319, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(501, 199);
            panel3.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(359, 162);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 31);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(359, 124);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 31);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(108, 117);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(226, 25);
            comboBox1.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(18, 120);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 21);
            label9.TabIndex = 12;
            label9.Text = "Task State";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbDeliveryDate);
            groupBox1.Controls.Add(rbStartDate);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(353, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(136, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // rbDeliveryDate
            // 
            rbDeliveryDate.AutoSize = true;
            rbDeliveryDate.Location = new Point(6, 62);
            rbDeliveryDate.Name = "rbDeliveryDate";
            rbDeliveryDate.Size = new Size(119, 23);
            rbDeliveryDate.TabIndex = 1;
            rbDeliveryDate.TabStop = true;
            rbDeliveryDate.Text = "Delivery Date";
            rbDeliveryDate.UseVisualStyleBackColor = true;
            // 
            // rbStartDate
            // 
            rbStartDate.AutoSize = true;
            rbStartDate.Location = new Point(6, 24);
            rbStartDate.Name = "rbStartDate";
            rbStartDate.Size = new Size(94, 23);
            rbStartDate.TabIndex = 0;
            rbStartDate.TabStop = true;
            rbStartDate.Text = "Start Date";
            rbStartDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFinish
            // 
            dateTimePickerFinish.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerFinish.Location = new Point(108, 79);
            dateTimePickerFinish.Name = "dateTimePickerFinish";
            dateTimePickerFinish.Size = new Size(226, 23);
            dateTimePickerFinish.TabIndex = 1;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerStart.Location = new Point(108, 41);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(226, 23);
            dateTimePickerStart.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 88);
            label8.Name = "label8";
            label8.Size = new Size(55, 21);
            label8.TabIndex = 0;
            label8.Text = "Finish";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 48);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 0;
            label7.Text = "Start";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 13);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 0;
            label6.Text = "Task Date";
            // 
            // panelAdmin
            // 
            panelAdmin.Controls.Add(cmbPosition);
            panelAdmin.Controls.Add(label5);
            panelAdmin.Controls.Add(cmbDepartment);
            panelAdmin.Controls.Add(label4);
            panelAdmin.Controls.Add(txtSurname);
            panelAdmin.Controls.Add(label3);
            panelAdmin.Controls.Add(txtName);
            panelAdmin.Controls.Add(label2);
            panelAdmin.Controls.Add(txtUserNo);
            panelAdmin.Controls.Add(label1);
            panelAdmin.Dock = DockStyle.Left;
            panelAdmin.Location = new Point(0, 0);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(319, 199);
            panelAdmin.TabIndex = 0;
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(142, 150);
            cmbPosition.Margin = new Padding(4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(152, 29);
            cmbPosition.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 153);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 12;
            label5.Text = "Position";
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(142, 116);
            cmbDepartment.Margin = new Padding(4);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(152, 29);
            cmbDepartment.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 122);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 13;
            label4.Text = "Department";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(142, 80);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(152, 29);
            txtSurname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 88);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 7;
            label3.Text = "Surname";
            // 
            // txtName
            // 
            txtName.Location = new Point(142, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 29);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 53);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(142, 10);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(152, 29);
            txtUserNo.TabIndex = 0;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 9;
            label1.Text = "User No.";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnApprove);
            panel2.Controls.Add(btnAddNew);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 396);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 80);
            panel2.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(579, 25);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 43);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(463, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 43);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(347, 25);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 43);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnApprove
            // 
            btnApprove.FlatStyle = FlatStyle.Popup;
            btnApprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnApprove.Location = new Point(115, 25);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(98, 43);
            btnApprove.TabIndex = 0;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.FlatStyle = FlatStyle.Popup;
            btnAddNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNew.Location = new Point(231, 25);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(98, 43);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // dataGridViewTasklist
            // 
            dataGridViewTasklist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasklist.Dock = DockStyle.Fill;
            dataGridViewTasklist.Location = new Point(0, 199);
            dataGridViewTasklist.Name = "dataGridViewTasklist";
            dataGridViewTasklist.RowTemplate.Height = 25;
            dataGridViewTasklist.Size = new Size(820, 197);
            dataGridViewTasklist.TabIndex = 1;
            // 
            // FormTaskList
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 476);
            Controls.Add(dataGridViewTasklist);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormTaskList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task List";
            Load += FormTaskList_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasklist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewTasklist;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAddNew;
        private Panel panel3;
        private Panel panelAdmin;
        private Button btnApprove;
        private TextBox txtSurname;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtUserNo;
        private Label label1;
        private Label label6;
        private ComboBox cmbPosition;
        private Label label5;
        private ComboBox cmbDepartment;
        private Label label4;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePickerFinish;
        private DateTimePicker dateTimePickerStart;
        private Label label8;
        private Label label7;
        private RadioButton rbDeliveryDate;
        private RadioButton rbStartDate;
        private ComboBox comboBox1;
        private Label label9;
        private Button btnClear;
        private Button btnSearch;
    }
}