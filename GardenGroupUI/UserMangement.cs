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
                
        private void btnFilterEmail_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (email != "")
            { 
                User user = userService.GetEmail(email);
                if (user != null)
                {
                    lvUserManagement.Items.Clear();
                    ListViewItem li = new ListViewItem(user.Id.ToString());
                    li.SubItems.Add(user.Email);
                    li.SubItems.Add(user.FirstName);
                    li.SubItems.Add(user.LastName);
                    lvUserManagement.Items.Add(li);
                }
                else
                {
                    MessageBox.Show("Fill in the full email correctly");
                }
            }
            else if(email== "")
            {
                MessageBox.Show("Textfield was empty");
            }

        }             
        private void UserCollection()
        {
                lvUserManagement.Items.Clear();
                users = userService.GetUserCollection();
                tickets = TicketService.GetTicketCollection();


                foreach (User u in users)
                {
                  int  NumberOfTickets = 0;
                    ListViewItem li = new ListViewItem(u.Id.ToString());
                    li.SubItems.Add(u.Email);
                    li.SubItems.Add(u.FirstName);
                    li.SubItems.Add(u.LastName);

                    foreach (Ticket t in tickets)
                    {
                        if (t.ReportedByUser == u.FirstName)
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
            User user = (User)lvUserManagement.SelectedItems[0].Tag;
                ObjectId userid = user.Id;
                userService.RemoveUser(userid);
                UserCollection();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            UserCollection();
            txtEmail.Clear();
        }

        private void btnAddingUser_Click(object sender, EventArgs e)
        {
            AddUsers adding = new AddUsers(null,true);
            adding.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddUsers Update = new AddUsers((User)lvUserManagement.SelectedItems[0].Tag,false);
            Update.Show();
            this.Hide();
        }
    }
}