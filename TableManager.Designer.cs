namespace RestaurantManager
{
    partial class TableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            accountInformationToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            txbTotalPrice = new TextBox();
            cbSwitchTable = new ComboBox();
            bttnDiscountt = new Button();
            nmDiscount = new NumericUpDown();
            btnSwitchTable = new Button();
            btnCheck = new Button();
            panel4 = new Panel();
            nmFoodCount = new NumericUpDown();
            bttnAdd = new Button();
            cbFood = new ComboBox();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, accountInformationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1019, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // accountInformationToolStripMenuItem
            // 
            accountInformationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem });
            accountInformationToolStripMenuItem.Name = "accountInformationToolStripMenuItem";
            accountInformationToolStripMenuItem.Size = new Size(159, 24);
            accountInformationToolStripMenuItem.Text = "Account information";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(224, 26);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(580, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 431);
            panel2.TabIndex = 0;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(3, 3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(421, 424);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Food Name";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Number";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Unit price";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Total";
            columnHeader4.Width = 120;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbTotalPrice);
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(bttnDiscountt);
            panel3.Controls.Add(nmDiscount);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(btnCheck);
            panel3.Location = new Point(580, 539);
            panel3.Name = "panel3";
            panel3.Size = new Size(427, 78);
            panel3.TabIndex = 0;
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbTotalPrice.Location = new Point(192, 21);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.RightToLeft = RightToLeft.No;
            txbTotalPrice.Size = new Size(123, 30);
            txbTotalPrice.TabIndex = 5;
            txbTotalPrice.TabStop = false;
            txbTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(3, 36);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(102, 28);
            cbSwitchTable.TabIndex = 4;
            // 
            // bttnDiscountt
            // 
            bttnDiscountt.Location = new Point(111, 3);
            bttnDiscountt.Name = "bttnDiscountt";
            bttnDiscountt.Size = new Size(75, 29);
            bttnDiscountt.TabIndex = 3;
            bttnDiscountt.Text = "Discount";
            bttnDiscountt.UseVisualStyleBackColor = true;
            // 
            // nmDiscount
            // 
            nmDiscount.Location = new Point(111, 37);
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new Size(75, 27);
            nmDiscount.TabIndex = 2;
            nmDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Location = new Point(3, 3);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(102, 29);
            btnSwitchTable.TabIndex = 3;
            btnSwitchTable.Text = "Switch Table";
            btnSwitchTable.UseVisualStyleBackColor = true;
            btnSwitchTable.Click += btnSwitchTable_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(321, 3);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(103, 62);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(nmFoodCount);
            panel4.Controls.Add(bttnAdd);
            panel4.Controls.Add(cbFood);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(580, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(427, 65);
            panel4.TabIndex = 2;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new Point(293, 34);
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(131, 27);
            nmFoodCount.TabIndex = 2;
            nmFoodCount.TextAlign = HorizontalAlignment.Right;
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // bttnAdd
            // 
            bttnAdd.Location = new Point(293, 3);
            bttnAdd.Name = "bttnAdd";
            bttnAdd.Size = new Size(131, 29);
            bttnAdd.TabIndex = 1;
            bttnAdd.Text = "Add";
            bttnAdd.UseVisualStyleBackColor = true;
            bttnAdd.Click += bttnAdd_Click;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(0, 34);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(287, 28);
            cbFood.TabIndex = 0;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(0, 0);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(287, 28);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 31);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(562, 586);
            flpTable.TabIndex = 3;
            // 
            // TableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 629);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Restaurant Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem accountInformationToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private ListView lsvBill;
        private Panel panel4;
        private ComboBox cbFood;
        private ComboBox cbCategory;
        private NumericUpDown nmFoodCount;
        private Button bttnAdd;
        private Button btnCheck;
        private FlowLayoutPanel flpTable;
        private NumericUpDown nmDiscount;
        private Button bttnDiscountt;
        private ComboBox cbSwitchTable;
        private Button btnSwitchTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbTotalPrice;
    }
}