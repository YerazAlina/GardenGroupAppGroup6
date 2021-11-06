using GardenGroupLogic;
using GardenGroupModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MongoDB.Bson;

namespace GardenGroupUI
{
    public partial class UserMangement : Form
    {
        private UserService userService;
        private List<User> users;
        private List<Ticket> tickets;
        private TicketService TicketService;
        public UserMangement()
        {
            InitializeComponent();
            userService = new UserService();
            TicketService = new TicketService();
            UserCollection();
        }


        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                UserCollection();
            }
            else
            {
                foreach (ListViewItem item in lvUserManagement.Items)
                {
                    if (!item.SubItems[1].ToString().ToLower().Contains(txtEmail.Text.ToLower()))
                    {
                        lvUserManagement.Items.Remove(item);
                    }
                }
            }
        }

        private void UserCollection()
        {
            lvUserManagement.Items.Clear();
            users = userService.GetUserCollection();
            tickets = TicketService.GetTicketCollection();


            foreach (User u in users)
            {
                int NumberOfTickets = 0;
                ListViewItem li = new ListViewItem(u.Id.ToString());
                li.SubItems.Add(u.Email);
                li.SubItems.Add(u.FirstName);
                li.SubItems.Add(u.LastName);

                foreach (Ticket t in tickets)
                {
                    if (t.EmailUser == u.Email)
                    {
                        NumberOfTickets++;
                    }
                }
                li.Tag = u;
                li.SubItems.Add(NumberOfTickets.ToString());
                lvUserManagement.Items.Add(li);
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            try
            {
                User user = (User)lvUserManagement.SelectedItems[0].Tag;
                ObjectId userid = user.Id;
                userService.RemoveUser(userid);
                UserCollection();
            }
            catch (Exception a)
            {
                MessageBox.Show("User needs to be selected.");
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            UserCollection();
            txtEmail.Clear();
        }

        private void btnAddingUser_Click(object sender, EventArgs e)
        {
            AddUsers adding = new AddUsers(null, true);
            adding.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                AddUsers Update = new AddUsers((User)lvUserManagement.SelectedItems[0].Tag, false);
                Update.Show();
                this.Hide();
            }
            catch (Exception a)
            {
                MessageBox.Show("User needs to be selected.");
            }
          
        }

        private void bttnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void bttnIncidentManagement_Click(object sender, EventArgs e)
        {
            CreateTickets createTickets = new CreateTickets(null, true);
            createTickets.Show();
            this.Hide();
        }

        private void bttnUserManagement_Click(object sender, EventArgs e)
        {
            UserMangement userMangement = new UserMangement();
            userMangement.Show();
            this.Hide();
        }
    }
  }
