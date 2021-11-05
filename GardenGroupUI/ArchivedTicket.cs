using GardenGroupLogic;
using GardenGroupModel;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GardenGroupUI
{
   
    public partial class ArchivedTicket : Form
    {
        private TicketService ticketService;
        private TicketArchiverService ticketArchiverService;
        private List<Ticket> archivedTickets;

        public ArchivedTicket()
        {
            InitializeComponent();
            ticketService = new TicketService();
            ticketArchiverService = new TicketArchiverService();
            ArchivedTicketCollection();
        }

        public void ArchivedTicketCollection()
        {
            lvTicketsArchived.Items.Clear();
            archivedTickets = ticketArchiverService.GetArchivedTicketCollection();
            foreach (Ticket ticket in archivedTickets)
            {
                ListViewItem li = new ListViewItem(ticket.TicketId.ToString());
                li.SubItems.Add(ticket.IncidentSubject);
                li.SubItems.Add(ticket.ReportedByUser);
                li.SubItems.Add(ticket.TicketDate.ToString());
                li.SubItems.Add(ticket.TicketPriority.ToString());
                li.Tag = ticket;

                lvTicketsArchived.Items.Add(li);
            }
        }
        private void btnTicketOverview_Click(object sender, EventArgs e)
        {
            TicketOverview ticketOverview = new TicketOverview();
            ticketOverview.ShowDialog();
            this.Hide();
        }

        private void btnRestore_Click_1(object sender, EventArgs e)
        {
            Ticket ticket = (Ticket)lvTicketsArchived.SelectedItems[0].Tag;
            ObjectId ticketid = ticket.TicketId;
            ticketService.AddTicket(ticket);
            ticketArchiverService.RemoveArchivedTicket(ticketid);
            ArchivedTicketCollection();
        }
    }
}
