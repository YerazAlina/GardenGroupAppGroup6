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

namespace GardenGroupUI
{
    public partial class TransferTicket : Form
    {
        private Ticket currentTicket;
        private List<User> users;

        public TransferTicket(Ticket currentTicket)
        {
            InitializeComponent();

            this.currentTicket = currentTicket;
            FillForm();

            //add all users to the combo box
            UserService userService = new UserService();
            users = userService.GetUserCollection();

            foreach (User usr in users)
            {
                comboBoxUsers.Items.Add(usr.FirstName);
            }
        }

        private void FillForm()
        {
            //fill with current ticket
            lblDateTimeReportedEmpty.Text = currentTicket.TicketDate.ToString();
            lblSubjIncidentEmpty.Text = currentTicket.IncidentSubject.ToString();
            lblIncidentTypeEmpty.Text = currentTicket.TypeOfIncident.ToString();
            lblReportedByUserEmpty.Text = currentTicket.ReportedByUser.ToString();
            lblPriorityEmpty.Text = currentTicket.TicketPriority.ToString();
            lblDeadlineEmpty.Text = currentTicket.TicketDeadline.ToString();
            lblDescriptionEmpty.Text = currentTicket.TicketDescription.ToString();
        }

        private void bttnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            this.Hide();
        }

        private void bttnIncidentManagement_Click(object sender, EventArgs e)
        {
            CreateTickets createTickets = new CreateTickets(null,true);
            createTickets.ShowDialog();
            this.Hide();
        }

        private void bttnUserManagement_Click(object sender, EventArgs e)
        {
            UserMangement userMangement = new UserMangement();
            userMangement.ShowDialog();
            this.Hide();
        }

        private void bttnTransferTicket_Click(object sender, EventArgs e)
        {
            //send ticket to database
            TicketService ticketService = new TicketService();
            ticketService.UpdateTicket(currentTicket);

            MessageBox.Show("User on ticket changed to: " + currentTicket.ReportedByUser);

            TicketOverview ticketOverview = new TicketOverview();
            ticketOverview.Show();
            this.Close();
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBoxUsers.SelectedItem.ToString();
            currentTicket.ReportedByUser = name;
            
            foreach (User usr in users)
            {
                if (usr.FirstName == name)
                {
                    currentTicket.EmailUser = usr.Email;
                }

            }
            //email..
        }
    }
}
