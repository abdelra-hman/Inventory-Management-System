using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Project;
using System.Linq;
using Project.Models;

namespace Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var db = new InventoryDBContext())
            {
                string username = txt_username.Text;
                string password = txt_password.Text;

                var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (user != null)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Proceed to the next form or main application window
                    if (user.Role == "Admin")
                    {

                        Console.WriteLine("Admin login successful!");
                        MainForm_Admin mainFormAdmin = new MainForm_Admin(user.FullName);
                        mainFormAdmin.Show();
                    }
                    else
                    {
                        Console.WriteLine("User login successful!");
                        MainForm_Employee mainForm_Employee = new MainForm_Employee(user.FullName);
                        mainForm_Employee.Show();
                    }
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
