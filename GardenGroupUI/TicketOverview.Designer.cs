
namespace GardenGroupUI
{
    partial class TicketOverview
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
            this.btnArchive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArchiveWindow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TicketSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TicketName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TicketDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTickets = new System.Windows.Forms.ListView();
            this.bttnTransfer = new System.Windows.Forms.Button();
            this.btnUpdateTicket = new System.Windows.Forms.Button();
            this.btnRemoveTicket = new System.Windows.Forms.Button();
            this.comboBoxCommonKeyWords = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(12, 336);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(162, 45);
            this.btnArchive.TabIndex = 0;
            this.btnArchive.Text = "Archive Ticket";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(65, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Overview Tickets";
            // 
            // btnArchiveWindow
            // 
            this.btnArchiveWindow.Location = new System.Drawing.Point(614, -89);
            this.btnArchiveWindow.Name = "btnArchiveWindow";
            this.btnArchiveWindow.Size = new System.Drawing.Size(109, 20);
            this.btnArchiveWindow.TabIndex = 10;
            this.btnArchiveWindow.Text = "Achive Tickets View";
            this.btnArchiveWindow.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 20);
            this.button1.TabIndex = 11;
            this.button1.Text = "Create Incidents";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // lvTickets
            // 
            this.lvTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.TicketSubject,
            this.TicketName,
            this.TicketDate,
            this.Priority});
            this.lvTickets.FullRowSelect = true;
            this.lvTickets.HideSelection = false;
            this.lvTickets.Location = new System.Drawing.Point(65, 98);
            this.lvTickets.Name = "lvTickets";
            this.lvTickets.Size = new System.Drawing.Size(524, 232);
            this.lvTickets.TabIndex = 5;
            this.lvTickets.UseCompatibleStateImageBehavior = false;
            this.lvTickets.View = System.Windows.Forms.View.Details;
            this.lvTickets.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvTickets_ColumnClick);
            this.lvTickets.SelectedIndexChanged += new System.EventHandler(this.lvTickets_SelectedIndexChanged);
            // 
            // bttnTransfer
            // 
            this.bttnTransfer.Location = new System.Drawing.Point(179, 336);
            this.bttnTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.bttnTransfer.Name = "bttnTransfer";
            this.bttnTransfer.Size = new System.Drawing.Size(162, 45);
            this.bttnTransfer.TabIndex = 14;
            this.bttnTransfer.Text = "Transfer Ticket";
            this.bttnTransfer.UseVisualStyleBackColor = true;
            this.bttnTransfer.Click += new System.EventHandler(this.bttnTransfer_Click);
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.Location = new System.Drawing.Point(345, 334);
            this.btnUpdateTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.Size = new System.Drawing.Size(162, 45);
            this.btnUpdateTicket.TabIndex = 16;
            this.btnUpdateTicket.Text = "Update Ticket";
            this.btnUpdateTicket.UseVisualStyleBackColor = true;
            this.btnUpdateTicket.Click += new System.EventHandler(this.btnUpdateTicket_Click);
            // 
            // btnRemoveTicket
            // 
            this.btnRemoveTicket.Location = new System.Drawing.Point(511, 334);
            this.btnRemoveTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveTicket.Name = "btnRemoveTicket";
            this.btnRemoveTicket.Size = new System.Drawing.Size(162, 45);
            this.btnRemoveTicket.TabIndex = 17;
            this.btnRemoveTicket.Text = "Remove Ticket";
            this.btnRemoveTicket.UseVisualStyleBackColor = true;
            this.btnRemoveTicket.Click += new System.EventHandler(this.btnRemoveTicket_Click);
            // 
            // comboBoxCommonKeyWords
            // 
            this.comboBoxCommonKeyWords.FormattingEnabled = true;
            this.comboBoxCommonKeyWords.Location = new System.Drawing.Point(290, 63);
            this.comboBoxCommonKeyWords.Name = "comboBoxCommonKeyWords";
            this.comboBoxCommonKeyWords.Size = new System.Drawing.Size(164, 21);
            this.comboBoxCommonKeyWords.TabIndex = 18;
            this.comboBoxCommonKeyWords.SelectedIndexChanged += new System.EventHandler(this.comboBoxKeywords_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filter By Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Filter By Keyword:";
            // 
            // TicketOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCommonKeyWords);
            this.Controls.Add(this.btnRemoveTicket);
            this.Controls.Add(this.btnUpdateTicket);
            this.Controls.Add(this.bttnTransfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnArchiveWindow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvTickets);
            this.Controls.Add(this.btnArchive);
            this.Name = "TicketOverview";
            this.Text = "TicketOverview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader TypeOfIncident;
        private System.Windows.Forms.ColumnHeader DeadLine;
        private System.Windows.Forms.Button btnArchiveWindow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader TicketSubject;
        private System.Windows.Forms.ColumnHeader TicketName;
        private System.Windows.Forms.ColumnHeader TicketDate;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.ListView lvTickets;
        private System.Windows.Forms.Button bttnTransfer;
        private System.Windows.Forms.Button btnUpdateTicket;
        private System.Windows.Forms.Button btnRemoveTicket;
        private System.Windows.Forms.ComboBox comboBoxCommonKeyWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}