using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GardenGroupUI
{
    public partial class LogoMenu : Form
    {
        public LogoMenu()
        {
            InitializeComponent();
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
    }
}
