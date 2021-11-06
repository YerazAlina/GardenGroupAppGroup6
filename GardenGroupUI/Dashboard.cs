using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GardenGroupLogic;
using GardenGroupModel;

namespace GardenGroupUI
{
    public partial class Dashboard : Form
    {
        private int solvedtickets;
        private int RemainingTickets;
        private TicketService ticketService;
        private List<Ticket> unsolvedTickets;
        private List<Ticket> deadLine;
        public Dashboard()
        {
            InitializeComponent();

            ticketService = new TicketService();

            unsolvedTickets = ticketService.UnsolvedTicket();

            solvedtickets = ticketService.ReadAllTickets().Count - unsolvedTickets.Count;
            deadLine = ticketService.PastDeadline();
            RemainingTickets = ticketService.ReadAllTickets().Count - deadLine.Count;

            //total nr of incidents
            chartUnresolvedIncidents.Series["Unsolved incidents"].Points.AddXY("Solved Ticket", solvedtickets);
            //unresolved nr of incidents
            chartUnresolvedIncidents.Series["Unsolved incidents"].Points.AddXY("Unsolved Ticket", unsolvedTickets.Count);

            //tickets over deadline
            PastDeadlineChart.Series["Deadline"].Points.AddXY("Past deadline", deadLine.Count);

            //tickets not over deadline
            PastDeadlineChart.Series["Deadline"].Points.AddXY("Remaining", RemainingTickets);
        }

        private void bttnIncidentManagement_Click(object sender, EventArgs e)
        {
            TicketOverview ticketOverview = new TicketOverview();
            ticketOverview.ShowDialog();
            this.Hide();
        }

        private void bttnUserManagement_Click(object sender, EventArgs e)
        {
            UserMangement userMangement = new UserMangement();
            userMangement.ShowDialog();
            this.Hide();
        }

        private void bttnShowLists_Click(object sender, EventArgs e)
        {
            TicketOverview ticketOverview = new TicketOverview();
            ticketOverview.ShowDialog();
            this.Hide();
        }
    }
}
