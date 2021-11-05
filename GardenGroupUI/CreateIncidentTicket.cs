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
    public partial class formNewIncident : Form
    {
        private Ticket newTicket;

        public formNewIncident()
        {
            InitializeComponent();
            
            //add all users to the combo box
            UserService userService = new UserService();
            List<User> users = userService.GetUserCollection();

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

            newTicket.TicketDate = dateTimePicker.Value;
            newTicket.IncidentSubject = textBoxSubjType.Text;
            newTicket.TypeOfIncident = (IncidentType)comboBoxIncidentType.SelectedItem; //this doesnt work
            newTicket.ReportedByUser = comboBoxUsers.SelectedItem.ToString(); //firstname only?

            newTicket.TicketPriority = (Priority)comboBoxPriority.SelectedItem;
            newTicket.TicketDeadline = comboBoxDeadline.SelectedItem.ToString();
            newTicket.TicketDescription = textBoxDescription.Text;

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
            comboBoxUsers.SelectedIndex = -1;
            comboBoxPriority.SelectedIndex = -1;
            comboBoxDeadline.SelectedIndex = -1;
            textBoxDescription.Clear();
        }

        private void bttnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            this.Close();
        }

        private void bttnIncidentManagement_Click(object sender, EventArgs e)
        {
            formNewIncident formNewIncident = new formNewIncident();
            formNewIncident.ShowDialog();
            this.Close();
        }

        private void bttnUserManagement_Click(object sender, EventArgs e)
        {
            UserMangement userMangement = new UserMangement();
            userMangement.ShowDialog();
            this.Close();
        }
    }
}
