using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GardenGroupModel;
using GardenGroupLogic;

namespace GardenGroupUI
{
    public partial class CreateTickets : Form
    {
        private Ticket newTicket;
        private List<User> users;

        public CreateTickets()
        {
            InitializeComponent();

            //add all users to the combo box
            UserService userService = new UserService();
            users = userService.GetUserCollection();

            foreach (User usr in users)
            {
                comboBoxUsers.Items.Add(usr.FirstName);
            }

            //putting all enums in the combo box
            comboBoxIncidentType.DataSource = (Enum.GetValues(typeof(IncidentType)));
            comboBoxPriority.DataSource = (Enum.GetValues(typeof(Priority)));
            comboBoxIncidentType.SelectedIndex = -1;
            comboBoxPriority.SelectedIndex = -1;
        }

        private void bttnSubmitTicket_Click(object sender, EventArgs e)
        {
            TicketService ticketService = new TicketService();
            newTicket = new Ticket();

            //ticket status for new ticket
            newTicket.TicketStatus = TicketStatus.Open;

            newTicket.TicketDate = dateTimePicker.Value;
            newTicket.IncidentSubject = textBoxSubjType.Text;
            newTicket.TypeOfIncident = (IncidentType)comboBoxIncidentType.SelectedItem; 
            newTicket.ReportedByUser = comboBoxUsers.SelectedItem.ToString(); 

            newTicket.TicketPriority = (Priority)comboBoxPriority.SelectedItem;
            newTicket.TicketDeadline = dateTimePicker2.Value;
            newTicket.TicketDescription = textBoxDescription.Text;
            newTicket.EmailUser = lblEmailUserEmpty.Text;
            newTicket.TicketStatus = TicketStatus.Open;

            //send ticket to database
            ticketService.AddTicket(newTicket);
            
            MessageBox.Show("Ticket Added!");
            CleanForm();

        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void CleanForm() 
        {
            //dateTimePicker
            textBoxSubjType.Clear();
            comboBoxIncidentType.SelectedIndex = -1;
            //comboBoxUsers
            comboBoxPriority.SelectedIndex = -1;
            lblEmailUserEmpty.Text = "";
            textBoxDescription.Clear();
        }

        private void bttnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void bttnIncidentManagement_Click(object sender, EventArgs e)
        {
            CreateTickets createTickets = new CreateTickets();
            createTickets.Show();
            this.Hide();
        }

        private void bttnUserManagement_Click(object sender, EventArgs e)
        {
            UserMangement userMangement = new UserMangement();
            userMangement.Show();
            this.Hide();
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBoxUsers.SelectedItem.ToString();
            foreach (User usr in users)
            {
                //get user by email
                if (usr.FirstName == name)
                {
                    lblEmailUserEmpty.Text = usr.Email;
                }
            }
        }
    }
}
