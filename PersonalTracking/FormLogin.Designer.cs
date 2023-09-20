namespace PersonalTracking
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            btnEnter = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUserNo = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Salmon;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(26, 138);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 32);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(156, 138);
            btnEnter.Margin = new Padding(4);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(103, 32);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 38);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 1;
            label1.Text = "User No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 83);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtUserNo
            // 
            txtUserNo.Location = new Point(107, 30);
            txtUserNo.Name = "txtUserNo";
            txtUserNo.Size = new Size(152, 29);
            txtUserNo.TabIndex = 0;
            txtUserNo.TextChanged += txtUserNo_TextChanged;
            txtUserNo.KeyPress += txtUserNo_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(107, 75);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(152, 29);
            txtPassword.TabIndex = 1;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 208);
            Controls.Add(txtPassword);
            Controls.Add(txtUserNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEnter);
            Controls.Add(btnExit);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnEnter;
        private Label label1;
        private Label label2;
        private TextBox txtUserNo;
        private TextBox txtPassword;
    }
}