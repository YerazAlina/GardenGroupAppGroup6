using GardenGroupLogic;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GardenGroupLogic;

namespace GardenGroupUI
{
    public partial class AddingUsers : Form
    {
        UserService userService = new UserService();
        public AddingUsers()
        {
            InitializeComponent();
            CmbTypeOfUser.DataSource = (Enum.GetValues(typeof(TypeOfUser)));
            CmbBranch.DataSource = (Enum.GetValues(typeof(Branch)));

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            User user = new User();
            user.FirstName = txtFirstName.Text.ToString();
            user.LastName = txtLastName.Text.ToString();
            user.TypeOfUser = (TypeOfUser)CmbTypeOfUser.SelectedItem;
            user.Email = txtEmail.Text.ToString();
            user.Phone = txtPhone.Text.ToString();
            user.Branch = (Branch)CmbBranch.SelectedItem;

            userService.AddUser(user);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
