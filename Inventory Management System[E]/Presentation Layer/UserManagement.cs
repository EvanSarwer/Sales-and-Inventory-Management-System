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
    public partial class UserManagement : Form
    {
        int id = 0;
        string username;
        public UserManagement(string username)
        {
            this.username = username;
            InitializeComponent();
            updateUserInfoButton.Click += this.RefreshGridView;
        }

        private void HomeForUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HomeForUser_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            id = userService.GetUserId(username);
            
            userService = new UserService();
            nameTextBox.Text=NameLabel.Text = userService.GetUserName(id);
            userService = new UserService();
            useNameTextBox.Text=UsernameLabel.Text = userService.GetUserUsername(id);
            userService = new UserService();
            passwordTextBox.Text = userService.GetUserPassword(id);
            userService = new UserService();
            emailTextBox.Text=EmailLabel.Text = userService.GetUserEmail(id);
            userService = new UserService();
            dateOfBirthTimePicker.Text=DateOfBirthLabel.Text = userService.GetUserDateOfBirth(id);
            userService = new UserService();
            genderComboBox.Text=GenderLabel.Text = userService.GetUserGender(id);


        }
        void RefreshGridView(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            id = userService.GetUserId(username);
            
            userService = new UserService();
            nameTextBox.Text=NameLabel.Text = userService.GetUserName(id);
            userService = new UserService();
            useNameTextBox.Text=UsernameLabel.Text = userService.GetUserUsername(id);
            userService = new UserService();
            passwordTextBox.Text = userService.GetUserPassword(id);
            userService = new UserService();
            emailTextBox.Text=EmailLabel.Text = userService.GetUserEmail(id);
            userService = new UserService();
            dateOfBirthTimePicker.Text=DateOfBirthLabel.Text = userService.GetUserDateOfBirth(id);
            userService = new UserService();
            genderComboBox.Text = GenderLabel.Text = userService.GetUserGender(id);
        }

        private void updateUserInfoButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            int result = userService.UpdateUser(id, nameTextBox.Text, useNameTextBox.Text, passwordTextBox.Text, emailTextBox.Text, dateOfBirthTimePicker.Text, genderComboBox.Text);
            if (result > 0)
            {
                MessageBox.Show("User updated successfully");
            }
            else
            {
                MessageBox.Show("Error updating user");
            }
        }


        private void BackToHomeButton_Click(object sender, EventArgs e)
        {
            HomeForUser homeForUser = new HomeForUser(username);
            homeForUser.Show();
            this.Hide();
        }
    }
}
