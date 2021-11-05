﻿using GardenGroupLogic;
using GardenGroupModel;
using MongoDB.Bson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace GardenGroupUI
{
    public partial class TicketOverview : Form
    {
        private TicketService ticketService;
        private TicketArchiverService ticketArchiverService;
        private List<Ticket> tickets;
        private ListViewColumnSorter lvwColumnSorter;
        List<ListViewItem> masterlist;

        public TicketOverview()
        {
            InitializeComponent();
            masterlist = new List<ListViewItem>();
            ticketService = new TicketService();
            ticketArchiverService = new TicketArchiverService();
            TicketCollection();
            lvwColumnSorter = new ListViewColumnSorter();
            this.lvTickets.ListViewItemSorter = lvwColumnSorter;
        }

        public void TicketCollection()
        {
            lvTickets.Items.Clear();
            tickets = ticketService.GetTicketCollection();
            foreach (Ticket ticket in tickets)
            {
                ListViewItem li = new ListViewItem(ticket.TicketId.ToString());
                li.SubItems.Add(ticket.IncidentSubject);
                li.SubItems.Add(ticket.ReportedByUser);
                li.SubItems.Add(ticket.TicketDate.ToString());
                li.SubItems.Add(ticket.TicketPriority.ToString());
                li.Tag = ticket;

                lvTickets.Items.Add(li);
                
            }
            masterlist.Clear();
            
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            tickets = ticketService.GetTicketCollection();
            foreach (Ticket ticket in tickets)
            {
                if (ticket.TicketDate <= DateTime.Now.AddYears(-2))
                {
                    ObjectId ticketid = ticket.TicketId;
                    ticketArchiverService.TicketArchiver(ticket);
                    ticketService.RemoveTicket(ticketid);
                }
            }
            TicketCollection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            formNewIncident formNewIncident = new formNewIncident();
            formNewIncident.ShowDialog();
        }

        private void lvTickets_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {

                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {

                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }


            this.lvTickets.Sort();

        }
        private class ListViewColumnSorter : IComparer
        {

            private int ColumnToSort;


            private SortOrder OrderOfSort;


            private CaseInsensitiveComparer ObjectCompare;


            public ListViewColumnSorter()
            {

                ColumnToSort = 0;


                OrderOfSort = SortOrder.None;


                ObjectCompare = new CaseInsensitiveComparer();
            }


            public int Compare(object x, object y)
            {
                int compareResult;
                ListViewItem listviewX, listviewY;


                listviewX = (ListViewItem)x;
                listviewY = (ListViewItem)y;


                compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);


                if (OrderOfSort == SortOrder.Ascending)
                {

                    return compareResult;
                }
                else if (OrderOfSort == SortOrder.Descending)
                {

                    return (-compareResult);
                }
                else
                {

                    return 0;
                }
            }


            public int SortColumn
            {
                set
                {
                    ColumnToSort = value;
                }
                get
                {
                    return ColumnToSort;
                }
            }


            public SortOrder Order
            {
                set
                {
                    OrderOfSort = value;
                }
                get
                {
                    return OrderOfSort;
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


            if (textBox1.Text == "")
            {

                TicketCollection();


            }
            else
            {
                foreach (ListViewItem item in lvTickets.Items)
                {
                    if (!item.SubItems[1].ToString().ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        lvTickets.Items.Remove(item);
                    }
                }
            }
        }

        private void lvTickets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}