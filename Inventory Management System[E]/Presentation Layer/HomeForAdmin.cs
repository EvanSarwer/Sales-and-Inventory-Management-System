using Sales_and_Inventory_Management_System.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System_E_.Presentation_Layer
{
    public partial class HomeForAdmin : Form
    {
        string username;
        public HomeForAdmin(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void HomeForAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            CategoryManagement categoryManagement = new CategoryManagement(username);
            categoryManagement.Show();
            this.Hide();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement(username);
            productManagement.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void EmployeeManagementButton_Click(object sender, EventArgs e)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement(username);
            employeeManagement.Show();
            this.Hide();
        }

        private void HomeForAdmin_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            AdminNamelinkLabel.Text = userService.GetName(username);
        }

        private void AdminNamelinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminAccountManagement adminAccountManagement = new AdminAccountManagement(username);
            adminAccountManagement.Show();
            this.Hide();
        }
    }
}
