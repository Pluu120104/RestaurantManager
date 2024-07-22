namespace RestaurantManager
{
    partial class Admin
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
            tbBill = new TabPage();
            panel1 = new Panel();
            dtgvBill = new DataGridView();
            panel2 = new Panel();
            dtpkFromDate = new DateTimePicker();
            dtpkToDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            btnViewBill = new Button();
            tcAdmin = new TabControl();
            tbBill.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            panel2.SuspendLayout();
            tcAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // tbBill
            // 
            tbBill.Controls.Add(panel2);
            tbBill.Controls.Add(panel1);
            tbBill.Location = new Point(4, 29);
            tbBill.Name = "tbBill";
            tbBill.Padding = new Padding(3);
            tbBill.Size = new Size(875, 544);
            tbBill.TabIndex = 0;
            tbBill.Text = "Revenue";
            tbBill.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvBill);
            panel1.Location = new Point(3, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 490);
            panel1.TabIndex = 0;
            // 
            // dtgvBill
            // 
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(3, 3);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 51;
            dtgvBill.Size = new Size(860, 484);
            dtgvBill.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnViewBill);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtpkToDate);
            panel2.Controls.Add(dtpkFromDate);
            panel2.Location = new Point(3, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(866, 36);
            panel2.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(84, 4);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(250, 27);
            dtpkFromDate.TabIndex = 0;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(422, 4);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(250, 27);
            dtpkToDate.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 8);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 1;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 8);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 2;
            label2.Text = "To";
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(732, 4);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(94, 29);
            btnViewBill.TabIndex = 3;
            btnViewBill.Text = "View";
            btnViewBill.UseVisualStyleBackColor = true;
            btnViewBill.Click += btnViewBill_Click;
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tbBill);
            tcAdmin.Location = new Point(12, 12);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(883, 577);
            tcAdmin.TabIndex = 0;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 601);
            Controls.Add(tcAdmin);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tbBill.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tcAdmin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tbBill;
        private Panel panel2;
        private Button btnViewBill;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private Panel panel1;
        private DataGridView dtgvBill;
        private TabControl tcAdmin;
    }
}