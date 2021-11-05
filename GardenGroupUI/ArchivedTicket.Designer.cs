
namespace GardenGroupUI
{
    partial class ArchivedTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnTicketOverview = new System.Windows.Forms.Button();
            this.lvTicketsArchived = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TicketSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TicketName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TicketDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLicenseInfo = new System.Windows.Forms.Label();
            this.lblNoDesk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(219, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tickets Archived";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(224, 377);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(162, 45);
            this.btnRestore.TabIndex = 10;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click_1);
            // 
            // btnTicketOverview
            // 
            this.btnTicketOverview.Location = new System.Drawing.Point(485, 68);
            this.btnTicketOverview.Name = "btnTicketOverview";
            this.btnTicketOverview.Size = new System.Drawing.Size(109, 20);
            this.btnTicketOverview.TabIndex = 14;
            this.btnTicketOverview.Text = "Ticket Overview";
            this.btnTicketOverview.UseVisualStyleBackColor = true;
            this.btnTicketOverview.Click += new System.EventHandler(this.btnTicketOverview_Click);
            // 
            // lvTicketsArchived
            // 
            this.lvTicketsArchived.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.TicketSubject,
            this.TicketName,
            this.TicketDate,
            this.Priority});
            this.lvTicketsArchived.FullRowSelect = true;
            this.lvTicketsArchived.HideSelection = false;
            this.lvTicketsArchived.Location = new System.Drawing.Point(28, 94);
            this.lvTicketsArchived.Name = "lvTicketsArchived";
            this.lvTicketsArchived.Size = new System.Drawing.Size(614, 277);
            this.lvTicketsArchived.TabIndex = 15;
            this.lvTicketsArchived.UseCompatibleStateImageBehavior = false;
            this.lvTicketsArchived.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // TicketSubject
            // 
            this.TicketSubject.Text = "Subject";
            this.TicketSubject.Width = 200;
            // 
            // TicketName
            // 
            this.TicketName.Text = "Name";
            this.TicketName.Width = 100;
            // 
            // TicketDate
            // 
            this.TicketDate.Text = "Date";
            this.TicketDate.Width = 200;
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            // 
            // lblLicenseInfo
            // 
            this.lblLicenseInfo.AutoSize = true;
            this.lblLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblLicenseInfo.Location = new System.Drawing.Point(472, 46);
            this.lblLicenseInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLicenseInfo.Name = "lblLicenseInfo";
            this.lblLicenseInfo.Size = new System.Drawing.Size(215, 19);
            this.lblLicenseInfo.TabIndex = 19;
            this.lblLicenseInfo.Text = "Licensed to: The Garden Group";
            // 
            // lblNoDesk
            // 
            this.lblNoDesk.AutoSize = true;
            this.lblNoDesk.Font = new System.Drawing.Font("Segoe UI", 26.14286F, System.Drawing.FontStyle.Bold);
            this.lblNoDesk.Location = new System.Drawing.Point(538, 2);
            this.lblNoDesk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoDesk.Name = "lblNoDesk";
            this.lblNoDesk.Size = new System.Drawing.Size(149, 47);
            this.lblNoDesk.TabIndex = 18;
            this.lblNoDesk.Text = "NoDesk";
            // 
            // ArchivedTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 457);
            this.Controls.Add(this.lblLicenseInfo);
            this.Controls.Add(this.lblNoDesk);
            this.Controls.Add(this.lvTicketsArchived);
            this.Controls.Add(this.btnTicketOverview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestore);
            this.Name = "ArchivedTicket";
            this.Text = "ArchivedTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnTicketOverview;
        private System.Windows.Forms.ListView lvTicketsArchived;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader TicketSubject;
        private System.Windows.Forms.ColumnHeader TicketName;
        private System.Windows.Forms.ColumnHeader TicketDate;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.Label lblLicenseInfo;
        private System.Windows.Forms.Label lblNoDesk;
    }
}