using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class MainForm_Admin : Form
    {
        public MainForm_Admin()
        {
            InitializeComponent();
        }
        private string fullName;
        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to logout?",
            "Logout Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void MainForm_Admin_Load(object sender, EventArgs e)
        {

        }
        public MainForm_Admin(string fullName)
        {
            InitializeComponent();

            this.fullName = fullName;
            lbl_AdminName.Text = $"Welcome, {fullName}";
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            ProductsForm products = new ProductsForm(this, this.fullName);
            products.Show();
            this.Hide();
        }
    }
}
