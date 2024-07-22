namespace RestaurantManager
{
    partial class Personalinformation
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
            tbxUsername = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            tbxDisplayName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            txbPassword = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbNewPass = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txbReEnterPass = new TextBox();
            label5 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(128, 22);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.ReadOnly = true;
            tbxUsername.Size = new Size(295, 27);
            tbxUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 22);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // panel2
            // 
            panel2.Controls.Add(tbxUsername);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 64);
            panel2.TabIndex = 1;
            // 
            // tbxDisplayName
            // 
            tbxDisplayName.Location = new Point(128, 22);
            tbxDisplayName.Name = "tbxDisplayName";
            tbxDisplayName.Size = new Size(295, 27);
            tbxDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 22);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // panel1
            // 
            panel1.Controls.Add(tbxDisplayName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 64);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassword);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(432, 64);
            panel3.TabIndex = 3;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(128, 22);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(295, 27);
            txbPassword.TabIndex = 1;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 22);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbNewPass);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 222);
            panel4.Name = "panel4";
            panel4.Size = new Size(432, 64);
            panel4.TabIndex = 4;
            // 
            // txbNewPass
            // 
            txbNewPass.Location = new Point(128, 22);
            txbNewPass.Name = "txbNewPass";
            txbNewPass.Size = new Size(295, 27);
            txbNewPass.TabIndex = 1;
            txbNewPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 22);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 0;
            label4.Text = "New Password";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReEnterPass);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(11, 292);
            panel5.Name = "panel5";
            panel5.Size = new Size(432, 64);
            panel5.TabIndex = 5;
            // 
            // txbReEnterPass
            // 
            txbReEnterPass.Location = new Point(128, 22);
            txbReEnterPass.Name = "txbReEnterPass";
            txbReEnterPass.Size = new Size(295, 27);
            txbReEnterPass.TabIndex = 1;
            txbReEnterPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 22);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 0;
            label5.Text = "Re-enter Pass";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(114, 362);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(237, 362);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Personalinformation
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(455, 406);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Personalinformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal Information";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbxUsername;
        private Label label1;
        private Panel panel2;
        private TextBox tbxDisplayName;
        private Label label2;
        private Panel panel1;
        private Panel panel3;
        private TextBox txbPassword;
        private Label label3;
        private Panel panel4;
        private TextBox txbNewPass;
        private Label label4;
        private Panel panel5;
        private TextBox txbReEnterPass;
        private Label label5;
        private Button btnUpdate;
        private Button btnExit;
    }
}