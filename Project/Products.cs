using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class ProductsForm : Form
    {
      
        private MainForm_Admin adminForm;
        private MainForm_Employee employeeForm;
        public ProductsForm()
        {
            InitializeComponent();
        }


        public ProductsForm(MainForm_Admin form, string fullName)
        {
            InitializeComponent();
            adminForm = form;
            lbl_AdminName.Text = $"Welcome, {fullName}";
        }

        public ProductsForm(MainForm_Employee form, string fullName)
        {
            InitializeComponent();
            employeeForm = form;
            lbl_AdminName.Text = $"Welcome, {fullName}";
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if (adminForm != null)
                adminForm.Show();

            if (employeeForm != null)
                employeeForm.Show();

            this.Close();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
