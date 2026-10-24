namespace Project
{
    partial class MainForm_Employee
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
            label1 = new Label();
            panel2 = new Panel();
            btn_logout = new Button();
            btn_reports = new Button();
            btn_sales = new Button();
            btn_purchases = new Button();
            btn_customers = new Button();
            btn_suppliers = new Button();
            btn_categories = new Button();
            btn_Products = new Button();
            label2 = new Label();
            pnl_content = new Panel();
            pnl_recent_activites = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            lbl_AdminName = new Label();
            lbl_page_title = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnl_content.SuspendLayout();
            pnl_recent_activites.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 58);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 14);
            label1.Name = "label1";
            label1.Size = new Size(277, 28);
            label1.TabIndex = 1;
            label1.Text = "INVENTORY MANAGEMENT";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_logout);
            panel2.Controls.Add(btn_reports);
            panel2.Controls.Add(btn_sales);
            panel2.Controls.Add(btn_purchases);
            panel2.Controls.Add(btn_customers);
            panel2.Controls.Add(btn_suppliers);
            panel2.Controls.Add(btn_categories);
            panel2.Controls.Add(btn_Products);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(217, 392);
            panel2.TabIndex = 1;
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(12, 345);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(134, 35);
            btn_logout.TabIndex = 20;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_reports
            // 
            btn_reports.Location = new Point(12, 248);
            btn_reports.Name = "btn_reports";
            btn_reports.Size = new Size(190, 26);
            btn_reports.TabIndex = 19;
            btn_reports.Text = "Reports";
            btn_reports.UseVisualStyleBackColor = true;
            // 
            // btn_sales
            // 
            btn_sales.Location = new Point(12, 216);
            btn_sales.Name = "btn_sales";
            btn_sales.Size = new Size(190, 26);
            btn_sales.TabIndex = 18;
            btn_sales.Text = "Sales";
            btn_sales.UseVisualStyleBackColor = true;
            // 
            // btn_purchases
            // 
            btn_purchases.Location = new Point(12, 184);
            btn_purchases.Name = "btn_purchases";
            btn_purchases.Size = new Size(190, 26);
            btn_purchases.TabIndex = 17;
            btn_purchases.Text = "Purchases";
            btn_purchases.UseVisualStyleBackColor = true;
            // 
            // btn_customers
            // 
            btn_customers.Location = new Point(12, 152);
            btn_customers.Name = "btn_customers";
            btn_customers.Size = new Size(190, 26);
            btn_customers.TabIndex = 16;
            btn_customers.Text = "Customers";
            btn_customers.UseVisualStyleBackColor = true;
            // 
            // btn_suppliers
            // 
            btn_suppliers.Location = new Point(12, 120);
            btn_suppliers.Name = "btn_suppliers";
            btn_suppliers.Size = new Size(190, 26);
            btn_suppliers.TabIndex = 15;
            btn_suppliers.Text = "Suppliers     ";
            btn_suppliers.UseVisualStyleBackColor = true;
            // 
            // btn_categories
            // 
            btn_categories.Location = new Point(12, 83);
            btn_categories.Name = "btn_categories";
            btn_categories.Size = new Size(190, 26);
            btn_categories.TabIndex = 14;
            btn_categories.Text = "Categories    ";
            btn_categories.UseVisualStyleBackColor = true;
            // 
            // btn_Products
            // 
            btn_Products.Location = new Point(12, 49);
            btn_Products.Name = "btn_Products";
            btn_Products.Size = new Size(190, 28);
            btn_Products.TabIndex = 13;
            btn_Products.Text = "Products";
            btn_Products.UseVisualStyleBackColor = true;
            btn_Products.Click += btn_Products_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 7);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 11;
            label2.Text = "EMPLOYEE PANEL";
            // 
            // pnl_content
            // 
            pnl_content.Controls.Add(pnl_recent_activites);
            pnl_content.Controls.Add(label7);
            pnl_content.Controls.Add(label6);
            pnl_content.Controls.Add(label5);
            pnl_content.Controls.Add(label4);
            pnl_content.Controls.Add(panel4);
            pnl_content.Dock = DockStyle.Fill;
            pnl_content.Location = new Point(217, 58);
            pnl_content.Name = "pnl_content";
            pnl_content.Size = new Size(583, 392);
            pnl_content.TabIndex = 2;
            // 
            // pnl_recent_activites
            // 
            pnl_recent_activites.Controls.Add(label10);
            pnl_recent_activites.Controls.Add(label9);
            pnl_recent_activites.Controls.Add(label8);
            pnl_recent_activites.Controls.Add(label3);
            pnl_recent_activites.Location = new Point(23, 170);
            pnl_recent_activites.Name = "pnl_recent_activites";
            pnl_recent_activites.Size = new Size(366, 152);
            pnl_recent_activites.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(279, 45);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 3;
            label10.Text = "Details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(146, 45);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 2;
            label9.Text = "Action";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 45);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 1;
            label8.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 0;
            label3.Text = "Recnt Activities";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(302, 120);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 6;
            label7.Text = "Total Users";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(302, 57);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 5;
            label6.Text = "Total Sales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 117);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 4;
            label5.Text = "Low Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 57);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 3;
            label4.Text = "Total Products";
            // 
            // panel4
            // 
            panel4.Controls.Add(lbl_AdminName);
            panel4.Controls.Add(lbl_page_title);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(583, 36);
            panel4.TabIndex = 0;
            // 
            // lbl_AdminName
            // 
            lbl_AdminName.AutoSize = true;
            lbl_AdminName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminName.Location = new Point(302, 7);
            lbl_AdminName.Name = "lbl_AdminName";
            lbl_AdminName.Size = new Size(144, 23);
            lbl_AdminName.TabIndex = 3;
            lbl_AdminName.Text = "Welcome , Admin";
            // 
            // lbl_page_title
            // 
            lbl_page_title.AutoSize = true;
            lbl_page_title.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_page_title.Location = new Point(23, 7);
            lbl_page_title.Name = "lbl_page_title";
            lbl_page_title.Size = new Size(97, 23);
            lbl_page_title.TabIndex = 1;
            lbl_page_title.Text = "Dashboard";
            // 
            // MainForm_Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_content);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm_Employee";
            Text = "Employee Dashboard";
            Load += MainForm_Employee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnl_content.ResumeLayout(false);
            pnl_content.PerformLayout();
            pnl_recent_activites.ResumeLayout(false);
            pnl_recent_activites.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnl_content;
        private Label label1;
        private Panel panel4;
        private Label lbl_page_title;
        private Label label2;
        private Label lbl_AdminName;
        private Button btn_Products;
        private Button btn_categories;
        private Button btn_suppliers;
        private Button btn_customers;
        private Button btn_purchases;
        private Button btn_sales;
        private Button btn_reports;
        private Button btn_logout;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel pnl_recent_activites;
        private Label label3;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}