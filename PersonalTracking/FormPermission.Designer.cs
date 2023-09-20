namespace PersonalTracking
{
    partial class FormPermission
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
            txtUserNo = new TextBox();
            label1 = new Label();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            txtDayAmount = new TextBox();
            label3 = new Label();
            txtExplanation = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtUserNo
            // 
            txtUserNo.BackColor = Color.FromArgb(224, 224, 224);
            txtUserNo.Location = new Point(129, 23);
            txtUserNo.Margin = new Padding(4);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.ReadOnly = true;
            txtUserNo.Size = new Size(156, 29);
            txtUserNo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 17;
            label1.Text = "User No.";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerEnd.Location = new Point(129, 103);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(156, 23);
            dateTimePickerEnd.TabIndex = 2;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerStart.Location = new Point(129, 66);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(156, 23);
            dateTimePickerStart.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 108);
            label8.Name = "label8";
            label8.Size = new Size(79, 21);
            label8.TabIndex = 19;
            label8.Text = "End Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 67);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 20;
            label7.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 149);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 17;
            label2.Text = "Day Amount";
            // 
            // txtDayAmount
            // 
            txtDayAmount.BackColor = Color.FromArgb(224, 224, 224);
            txtDayAmount.Location = new Point(129, 140);
            txtDayAmount.Margin = new Padding(4);
            txtDayAmount.Name = "txtDayAmount";
            txtDayAmount.ReadOnly = true;
            txtDayAmount.Size = new Size(156, 29);
            txtDayAmount.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 190);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 17;
            label3.Text = "Explanation";
            // 
            // txtExplanation
            // 
            txtExplanation.BackColor = Color.FromArgb(224, 224, 224);
            txtExplanation.Location = new Point(129, 192);
            txtExplanation.Margin = new Padding(4);
            txtExplanation.Multiline = true;
            txtExplanation.Name = "txtExplanation";
            txtExplanation.Size = new Size(303, 132);
            txtExplanation.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(276, 349);
            btnSave.Margin = new Padding(6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 45);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Salmon;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(156, 349);
            btnClose.Margin = new Padding(6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(99, 45);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FormPermission
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(479, 409);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtExplanation);
            Controls.Add(label3);
            Controls.Add(txtDayAmount);
            Controls.Add(label2);
            Controls.Add(txtUserNo);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormPermission";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permission";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserNo;
        private Label label1;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private Label label8;
        private Label label7;
        private Label label2;
        private TextBox txtDayAmount;
        private Label label3;
        private TextBox txtExplanation;
        private Button btnSave;
        private Button btnClose;
    }
}