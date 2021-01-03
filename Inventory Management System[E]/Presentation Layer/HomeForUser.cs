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
    public partial class HomeForUser : Form
    {
        string username;
        public HomeForUser(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void HomeForUser_FormClosing(object sender, FormClosingEventArgs e)
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

        private void EmployeeAccountUpdateButton_Click(object sender, EventArgs e)
        {
            
        }

        private void HomeForUser_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            EmployeeNameLinkLabel.Text = userService.GetName(username);
        }

        private void EmployeeNameLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserManagement userManagement = new UserManagement(username);
            userManagement.Show();
            this.Hide();
        }
    }
}
