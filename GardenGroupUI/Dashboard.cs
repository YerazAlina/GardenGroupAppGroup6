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
        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void lvTickets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            TicketOverview ticketOverview = new TicketOverview();
            ticketOverview.ShowDialog();
        }

        private void bttnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void bttnIncidentManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            TicketOverview ticketOverview = new TicketOverview();
            ticketOverview.ShowDialog();
        }

        private void bttnUserManagement_Click(object sender, EventArgs e)
        {
            UserMangement userMangement = new UserMangement();
            userMangement.ShowDialog();
            this.Close();
        }
    }
}
