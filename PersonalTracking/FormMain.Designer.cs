namespace PersonalTracking
{
    partial class FormMain
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
            btnEmployee = new Button();
            btnTask = new Button();
            btnSalary = new Button();
            btnPermission = new Button();
            btnDepartment = new Button();
            btnPosition = new Button();
            btnLogout = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(255, 128, 0);
            btnEmployee.FlatStyle = FlatStyle.Popup;
            btnEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.Image = Properties.Resources.manager2;
            btnEmployee.Location = new Point(12, 12);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(119, 127);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "Employee";
            btnEmployee.TextAlign = ContentAlignment.BottomCenter;
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnTask
            // 
            btnTask.BackColor = Color.FromArgb(128, 255, 255);
            btnTask.FlatStyle = FlatStyle.Popup;
            btnTask.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTask.Image = Properties.Resources.workplace;
            btnTask.Location = new Point(149, 12);
            btnTask.Name = "btnTask";
            btnTask.Size = new Size(115, 127);
            btnTask.TabIndex = 1;
            btnTask.Text = "Task";
            btnTask.TextAlign = ContentAlignment.BottomCenter;
            btnTask.UseVisualStyleBackColor = false;
            btnTask.Click += btnTask_Click;
            // 
            // btnSalary
            // 
            btnSalary.BackColor = Color.Chartreuse;
            btnSalary.FlatStyle = FlatStyle.Popup;
            btnSalary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalary.Image = Properties.Resources.payment;
            btnSalary.Location = new Point(282, 12);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(115, 127);
            btnSalary.TabIndex = 2;
            btnSalary.Text = "Salary";
            btnSalary.TextAlign = ContentAlignment.BottomCenter;
            btnSalary.UseVisualStyleBackColor = false;
            btnSalary.Click += btnSalary_Click;
            // 
            // btnPermission
            // 
            btnPermission.BackColor = Color.Green;
            btnPermission.FlatStyle = FlatStyle.Popup;
            btnPermission.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPermission.Image = Properties.Resources.privacy;
            btnPermission.Location = new Point(415, 12);
            btnPermission.Name = "btnPermission";
            btnPermission.Size = new Size(119, 127);
            btnPermission.TabIndex = 3;
            btnPermission.Text = "Permission";
            btnPermission.TextAlign = ContentAlignment.BottomCenter;
            btnPermission.UseVisualStyleBackColor = false;
            btnPermission.Click += btnPermission_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.BackColor = Color.FromArgb(255, 192, 192);
            btnDepartment.FlatStyle = FlatStyle.Popup;
            btnDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepartment.Image = Properties.Resources.organization_chart;
            btnDepartment.Location = new Point(16, 174);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(115, 127);
            btnDepartment.TabIndex = 4;
            btnDepartment.Text = "Department";
            btnDepartment.TextAlign = ContentAlignment.BottomCenter;
            btnDepartment.UseVisualStyleBackColor = false;
            btnDepartment.Click += btnDepartment_Click;
            // 
            // btnPosition
            // 
            btnPosition.BackColor = Color.FromArgb(192, 0, 192);
            btnPosition.FlatStyle = FlatStyle.Popup;
            btnPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPosition.Image = Properties.Resources.high_quality;
            btnPosition.Location = new Point(149, 174);
            btnPosition.Name = "btnPosition";
            btnPosition.Size = new Size(115, 127);
            btnPosition.TabIndex = 5;
            btnPosition.Text = "Position";
            btnPosition.TextAlign = ContentAlignment.BottomCenter;
            btnPosition.UseVisualStyleBackColor = false;
            btnPosition.Click += btnPosition_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Yellow;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Image = Properties.Resources.settings;
            btnLogout.Location = new Point(282, 174);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(115, 127);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.BottomCenter;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Image = Properties.Resources.logout;
            btnExit.Location = new Point(415, 174);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(115, 127);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.BottomCenter;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(554, 335);
            Controls.Add(btnExit);
            Controls.Add(btnPosition);
            Controls.Add(btnDepartment);
            Controls.Add(btnPermission);
            Controls.Add(btnLogout);
            Controls.Add(btnSalary);
            Controls.Add(btnTask);
            Controls.Add(btnEmployee);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Main";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmployee;
        private Button btnTask;
        private Button btnSalary;
        private Button btnPermission;
        private Button btnDepartment;
        private Button btnPosition;
        private Button btnLogout;
        private Button btnExit;
    }
}