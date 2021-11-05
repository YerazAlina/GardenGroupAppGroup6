using GardenGroupLogic;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GardenGroupUI
{
    public partial class AddUsers : Form
    {
        UserService userService;
        User user;

        public AddUsers(User user,bool CheckAddORUpdate)
        {

            InitializeComponent();
            userService = new UserService();
            this.user = user;
            CmbTypeOfUser.DataSource = (Enum.GetValues(typeof(TypeOfUser)));
            CmbBranch.DataSource = (Enum.GetValues(typeof(Branch)));
            CmbTypeOfUser.SelectedIndex = -1;
            CmbBranch.SelectedIndex = -1;

            if (!CheckAddORUpdate)
            {
                Update();
             
            }
        
        }
        public void Update()
        {
            btnAdd.Hide();
            lblCheck.Text = "Update User";
            txtFirstName.Text = user.FirstName.ToString();
            txtLastName.Text = user.LastName.ToString();
            CmbTypeOfUser.Text= user.TypeOfUser.ToString();
            txtEmail.Text = user.Email.ToString();
            txtPhone.Text = user.Phone.ToString();
            CmbBranch.Text = user.Branch.ToString();
            txtPassword.Text = user.Password.ToString();
           
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            User addUser = new User();
            addUser.FirstName = txtFirstName.Text.ToString();
            addUser.LastName = txtLastName.Text.ToString();
            addUser.TypeOfUser = (TypeOfUser)CmbTypeOfUser.SelectedItem;
            addUser.Email = txtEmail.Text.ToString();
            addUser.Phone = txtPhone.Text.ToString();
            addUser.Branch = (Branch)CmbBranch.SelectedItem;
            addUser.Password = txtPassword.Text.ToString();
            userService.AddUser(addUser);
            CleaningForm();
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            UserMangement mangement = new UserMangement();
            mangement.Show();
            this.Hide();
        }

        public void CleaningForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            CmbTypeOfUser.DataSource = (Enum.GetValues(typeof(TypeOfUser)));
            CmbBranch.DataSource = (Enum.GetValues(typeof(Branch)));
            CmbTypeOfUser.SelectedIndex = -1;
            CmbBranch.SelectedIndex = -1;
            txtEmail.Clear();
            txtPhone.Clear();
            txtPassword.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            user.FirstName = txtFirstName.Text.ToString();
            user.LastName = txtLastName.Text.ToString();
            user.TypeOfUser = (TypeOfUser)CmbTypeOfUser.SelectedItem;
            user.Email = txtEmail.Text.ToString();
            user.Phone = txtPhone.Text.ToString();
            user.Branch = (Branch)CmbBranch.SelectedItem;
            user.Password = txtPassword.Text.ToString();
            userService.UpdateUser(user);

        }
    }
}
