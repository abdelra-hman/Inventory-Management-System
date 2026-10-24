namespace Project
{
    partial class ProductsForm
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
            label6 = new Label();
            label4 = new Label();
            btn_logout = new Button();
            btn_reports = new Button();
            btn_sales = new Button();
            btn_purchases = new Button();
            btn_customers = new Button();
            btn_suppliers = new Button();
            btn_categories = new Button();
            lbl_AdminName = new Label();
            lbl_page_title = new Label();
            panel3 = new Panel();
            label5 = new Label();
            pnl_sidebar = new Panel();
            btn_dashboard = new Button();
            label1 = new Label();
            pnl_content = new Panel();
            pnl_header = new Panel();
            panel3.SuspendLayout();
            pnl_sidebar.SuspendLayout();
            pnl_content.SuspendLayout();
            pnl_header.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(297, 21);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 2;
            label6.Text = "Total Sales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 21);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 0;
            label4.Text = "Total Products";
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(12, 345);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(134, 35);
            btn_logout.TabIndex = 9;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            // 
            // btn_reports
            // 
            btn_reports.Location = new Point(12, 239);
            btn_reports.Name = "btn_reports";
            btn_reports.Size = new Size(190, 26);
            btn_reports.TabIndex = 8;
            btn_reports.Text = "Reports";
            btn_reports.UseVisualStyleBackColor = true;
            // 
            // btn_sales
            // 
            btn_sales.Location = new Point(12, 207);
            btn_sales.Name = "btn_sales";
            btn_sales.Size = new Size(190, 26);
            btn_sales.TabIndex = 6;
            btn_sales.Text = "Sales";
            btn_sales.UseVisualStyleBackColor = true;
            // 
            // btn_purchases
            // 
            btn_purchases.Location = new Point(12, 175);
            btn_purchases.Name = "btn_purchases";
            btn_purchases.Size = new Size(190, 26);
            btn_purchases.TabIndex = 5;
            btn_purchases.Text = "Purchases";
            btn_purchases.UseVisualStyleBackColor = true;
            // 
            // btn_customers
            // 
            btn_customers.Location = new Point(12, 143);
            btn_customers.Name = "btn_customers";
            btn_customers.Size = new Size(190, 26);
            btn_customers.TabIndex = 4;
            btn_customers.Text = "Customers";
            btn_customers.UseVisualStyleBackColor = true;
            // 
            // btn_suppliers
            // 
            btn_suppliers.Location = new Point(12, 111);
            btn_suppliers.Name = "btn_suppliers";
            btn_suppliers.Size = new Size(190, 26);
            btn_suppliers.TabIndex = 3;
            btn_suppliers.Text = "Suppliers     ";
            btn_suppliers.UseVisualStyleBackColor = true;
            // 
            // btn_categories
            // 
            btn_categories.Location = new Point(12, 74);
            btn_categories.Name = "btn_categories";
            btn_categories.Size = new Size(190, 26);
            btn_categories.TabIndex = 2;
            btn_categories.Text = "Categories    ";
            btn_categories.UseVisualStyleBackColor = true;
            // 
            // lbl_AdminName
            // 
            lbl_AdminName.AutoSize = true;
            lbl_AdminName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminName.Location = new Point(297, 9);
            lbl_AdminName.Name = "lbl_AdminName";
            lbl_AdminName.Size = new Size(144, 23);
            lbl_AdminName.TabIndex = 2;
            lbl_AdminName.Text = "Welcome , Admin";
            // 
            // lbl_page_title
            // 
            lbl_page_title.AutoSize = true;
            lbl_page_title.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_page_title.Location = new Point(31, 9);
            lbl_page_title.Name = "lbl_page_title";
            lbl_page_title.Size = new Size(80, 23);
            lbl_page_title.TabIndex = 0;
            lbl_page_title.Text = "Products";
            // 
            // panel3
            // 
            panel3.Controls.Add(lbl_AdminName);
            panel3.Controls.Add(lbl_page_title);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(223, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(577, 40);
            panel3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 77);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 1;
            label5.Text = "Low Stock";
            // 
            // pnl_sidebar
            // 
            pnl_sidebar.Controls.Add(btn_logout);
            pnl_sidebar.Controls.Add(btn_reports);
            pnl_sidebar.Controls.Add(btn_sales);
            pnl_sidebar.Controls.Add(btn_purchases);
            pnl_sidebar.Controls.Add(btn_customers);
            pnl_sidebar.Controls.Add(btn_suppliers);
            pnl_sidebar.Controls.Add(btn_categories);
            pnl_sidebar.Controls.Add(btn_dashboard);
            pnl_sidebar.Dock = DockStyle.Left;
            pnl_sidebar.Location = new Point(0, 58);
            pnl_sidebar.Name = "pnl_sidebar";
            pnl_sidebar.Size = new Size(223, 392);
            pnl_sidebar.TabIndex = 6;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Location = new Point(12, 40);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(190, 28);
            btn_dashboard.TabIndex = 1;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 28);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY MANAGEMENT";
            // 
            // pnl_content
            // 
            pnl_content.Controls.Add(label6);
            pnl_content.Controls.Add(label5);
            pnl_content.Controls.Add(label4);
            pnl_content.Dock = DockStyle.Fill;
            pnl_content.Location = new Point(0, 58);
            pnl_content.Name = "pnl_content";
            pnl_content.Size = new Size(800, 392);
            pnl_content.TabIndex = 8;
            // 
            // pnl_header
            // 
            pnl_header.Controls.Add(label1);
            pnl_header.Dock = DockStyle.Top;
            pnl_header.Location = new Point(0, 0);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(800, 58);
            pnl_header.TabIndex = 5;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(pnl_sidebar);
            Controls.Add(pnl_content);
            Controls.Add(pnl_header);
            Name = "ProductsForm";
            Text = "Products";
            Load += ProductsForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnl_sidebar.ResumeLayout(false);
            pnl_content.ResumeLayout(false);
            pnl_content.PerformLayout();
            pnl_header.ResumeLayout(false);
            pnl_header.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label6;
        private Label label4;
        private Button btn_logout;
        private Button btn_reports;
        private Button btn_sales;
        private Button btn_purchases;
        private Button btn_customers;
        private Button btn_suppliers;
        private Button btn_categories;
        private Label lbl_AdminName;
        private Label lbl_page_title;
        private Panel panel3;
        private Label label5;
        private Panel pnl_sidebar;
        private Button btn_dashboard;
        private Label label1;
        private Panel pnl_content;
        private Panel pnl_header;
    }
}