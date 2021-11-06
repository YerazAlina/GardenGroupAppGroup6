﻿using System;
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

        public CreateTickets(Ticket ticket, bool addOrUpdate)
        {
            InitializeComponent();
            newTicket = ticket;
            //add all users to the combo box
            UserService userService = new UserService();
            users = userService.GetUserCollection();
            if (!addOrUpdate)
            {
                Update();

            }
            foreach (User usr in users)
            {
                comboBoxUsers.Items.Add(usr.FirstName);
            }

            //putting all enums in the combo box
            comboBoxIncidentType.DataSource = (Enum.GetValues(typeof(IncidentType)));
            comboBoxPriority.DataSource = (Enum.GetValues(typeof(Priority)));
            CmbStatus.DataSource = (Enum.GetValues(typeof(TicketStatus)));
            comboBoxIncidentType.SelectedIndex = -1;
            comboBoxPriority.SelectedIndex = -1;
            CmbStatus.SelectedIndex = -1;
        }
        public void Update()
        {
            bttnSubmitTicket.Hide();
            lblTitleCreateIcident.Text = "Update incident ticket";
            dateTimePicker.Text = newTicket.TicketDate.ToString();
            textBoxSubjType.Text = newTicket.IncidentSubject;
            comboBoxIncidentType.Text = newTicket.TypeOfIncident.ToString();
            comboBoxUsers.Text = newTicket.ReportedByUser;
            lblEmailUser.Text = newTicket.EmailUser;
            comboBoxPriority.Text = newTicket.TicketPriority.ToString();
            dateTimePicker2.Text = newTicket.TicketDeadline.ToString();
            textBoxDescription.Text = newTicket.TicketDescription;
        }

        private void bttnSubmitTicket_Click(object sender, EventArgs e)
        {
            TicketService ticketService = new TicketService();
            

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
            newTicket.TicketStatus = (TicketStatus)CmbStatus.SelectedItem;

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
            dashboard.ShowDialog();
            this.Hide();
        }

        private void bttnIncidentManagement_Click(object sender, EventArgs e)
        {
            CreateTickets createTickets = new CreateTickets(null, true);
            createTickets.ShowDialog();
            this.Hide();
        }

        private void bttnUserManagement_Click(object sender, EventArgs e)
        {
            UserMangement userMangement = new UserMangement();
            userMangement.ShowDialog();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            newTicket.TicketDate = dateTimePicker.Value;
            newTicket.IncidentSubject = textBoxSubjType.Text;
            newTicket.TypeOfIncident = (IncidentType)comboBoxIncidentType.SelectedItem;
            newTicket.ReportedByUser = comboBoxUsers.SelectedItem.ToString();

            newTicket.TicketPriority = (Priority)comboBoxPriority.SelectedItem;
            newTicket.TicketDeadline = dateTimePicker2.Value;
            newTicket.TicketDescription = textBoxDescription.Text;

            newTicket.EmailUser = lblEmailUserEmpty.Text;
            TicketService ticketService = new TicketService();
            ticketService.UpdateTicket(newTicket);
        }
    }
}
