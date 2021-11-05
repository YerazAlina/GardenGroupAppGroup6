using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GardenGroupModel;
using GardenGroupDAL;
using GardenGroupDAO;
using GardenGroupLogic;
using GardenGroupUI;

namespace GardenGroupUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtBoxPassword.PasswordChar = '●';
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            string email = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

           
            UserService userService = new UserService();
            User user = userService.GetEmail(email);


            if (email.Length < 1 || password.Length < 1)
            {
                MessageBox.Show("Missing credentials");
            }
            else if (user == null || email != user.Email)
            {
                MessageBox.Show("Incorrect username, please try again.");
           
            }
            else if(user.Password != password)
            {
                MessageBox.Show("Incorrect password, please try again.");
            }
            else
            {
                if(RememberMeBox.Checked == true)
                {
                    Properties.Settings.Default.Username = email;
                    Properties.Settings.Default.Password = password;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Username = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                }

                if(user.TypeOfUser == TypeOfUser.Employee)
                {
                    AddUsers addingUsers = new AddUsers(user,true);
                    addingUsers.Show();
                    this.Hide();

                }
                else if(user.TypeOfUser == TypeOfUser.ServiceDesk)
                {
                    CreateTickets newIncident = new CreateTickets();
                    newIncident.Show();
                    this.Hide();
                }
                else
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username != null)
            {
                txtBoxUsername.Text = Properties.Settings.Default.Username;
                txtBoxPassword.Text = Properties.Settings.Default.Password;
            }
        }

        private void lblForgotLoginDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
