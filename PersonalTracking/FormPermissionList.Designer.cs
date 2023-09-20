namespace PersonalTracking
{
    partial class FormPermissionList
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
            groupBox1 = new GroupBox();
            rbDeliveryDate = new RadioButton();
            rbStartDate = new RadioButton();
            dateTimePickerFinish = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtDayAmount = new TextBox();
            label9 = new Label();
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
            button1 = new Button();
            btnDisapprove = new Button();
            btnAddNew = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panel1.Size = new Size(776, 184);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnClear);
            panel4.Controls.Add(btnSearch);
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(dateTimePickerFinish);
            panel4.Controls.Add(dateTimePickerStart);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtDayAmount);
            panel4.Controls.Add(label9);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel4.Location = new Point(309, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(467, 184);
            panel4.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(346, 144);
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
            btnSearch.Location = new Point(346, 106);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 31);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbDeliveryDate);
            groupBox1.Controls.Add(rbStartDate);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(319, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(136, 81);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // rbDeliveryDate
            // 
            rbDeliveryDate.AutoSize = true;
            rbDeliveryDate.Location = new Point(6, 53);
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
            dateTimePickerFinish.Location = new Point(132, 81);
            dateTimePickerFinish.Name = "dateTimePickerFinish";
            dateTimePickerFinish.Size = new Size(174, 23);
            dateTimePickerFinish.TabIndex = 1;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerStart.Location = new Point(132, 43);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(174, 23);
            dateTimePickerStart.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 90);
            label8.Name = "label8";
            label8.Size = new Size(55, 21);
            label8.TabIndex = 5;
            label8.Text = "Finish";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 51);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 6;
            label7.Text = "Start";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 16);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 7;
            label6.Text = "Task Date";
            // 
            // txtDayAmount
            // 
            txtDayAmount.Location = new Point(132, 116);
            txtDayAmount.Name = "txtDayAmount";
            txtDayAmount.Size = new Size(174, 29);
            txtDayAmount.TabIndex = 2;
            txtDayAmount.KeyPress += txtDayAmount_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 128);
            label9.Name = "label9";
            label9.Size = new Size(106, 21);
            label9.TabIndex = 21;
            label9.Text = "Day Amount";
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
            panel3.Size = new Size(309, 184);
            panel3.TabIndex = 0;
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(133, 146);
            cmbPosition.Margin = new Padding(4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(152, 29);
            cmbPosition.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 149);
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
            cmbDepartment.Location = new Point(133, 112);
            cmbDepartment.Margin = new Padding(4);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(152, 29);
            cmbDepartment.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 118);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 23;
            label4.Text = "Department";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(133, 76);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(152, 29);
            txtSurname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 84);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 19;
            label3.Text = "Surname";
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 29);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 49);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 20;
            label2.Text = "Name";
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(133, 6);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(152, 29);
            txtUserNo.TabIndex = 0;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 14);
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
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnDisapprove);
            panel2.Controls.Add(btnAddNew);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 367);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 77);
            panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(621, 22);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 43);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(510, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 43);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(399, 22);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 43);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(54, 22);
            button1.Name = "button1";
            button1.Size = new Size(98, 43);
            button1.TabIndex = 0;
            button1.Text = "Approve";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnDisapprove
            // 
            btnDisapprove.FlatStyle = FlatStyle.Popup;
            btnDisapprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDisapprove.Location = new Point(165, 22);
            btnDisapprove.Name = "btnDisapprove";
            btnDisapprove.Size = new Size(110, 43);
            btnDisapprove.TabIndex = 1;
            btnDisapprove.Text = "Disapprove";
            btnDisapprove.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.FlatStyle = FlatStyle.Popup;
            btnAddNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNew.Location = new Point(288, 22);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(98, 43);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 183);
            dataGridView1.TabIndex = 2;
            // 
            // FormPermissionList
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 444);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormPermissionList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permission List";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button button1;
        private Button btnDisapprove;
        private Button btnAddNew;
        private Panel panel4;
        private Panel panel3;
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
        private GroupBox groupBox1;
        private RadioButton rbDeliveryDate;
        private RadioButton rbStartDate;
        private DateTimePicker dateTimePickerFinish;
        private DateTimePicker dateTimePickerStart;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtDayAmount;
        private Label label9;
        private Button btnClear;
        private Button btnSearch;
    }
}