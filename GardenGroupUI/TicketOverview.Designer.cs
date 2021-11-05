
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
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.TicketSubject = new System.Windows.Forms.ColumnHeader();
            this.TicketName = new System.Windows.Forms.ColumnHeader();
            this.TicketDate = new System.Windows.Forms.ColumnHeader();
            this.Priority = new System.Windows.Forms.ColumnHeader();
            this.lvTickets = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(242, 386);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(189, 52);
            this.btnArchive.TabIndex = 0;
            this.btnArchive.Text = "Archive Ticket";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Overview Tickets";
            // 
            // btnArchiveWindow
            // 
            this.btnArchiveWindow.Location = new System.Drawing.Point(716, -103);
            this.btnArchiveWindow.Name = "btnArchiveWindow";
            this.btnArchiveWindow.Size = new System.Drawing.Size(127, 23);
            this.btnArchiveWindow.TabIndex = 10;
            this.btnArchiveWindow.Text = "Achive Tickets View";
            this.btnArchiveWindow.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Create Incidents";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filter By Subject:";
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
            this.lvTickets.Location = new System.Drawing.Point(76, 113);
            this.lvTickets.Name = "lvTickets";
            this.lvTickets.Size = new System.Drawing.Size(611, 267);
            this.lvTickets.TabIndex = 5;
            this.lvTickets.UseCompatibleStateImageBehavior = false;
            this.lvTickets.View = System.Windows.Forms.View.Details;
            this.lvTickets.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvTickets_ColumnClick);
            this.lvTickets.SelectedIndexChanged += new System.EventHandler(this.lvTickets_SelectedIndexChanged);
            // 
            // TicketOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader TicketSubject;
        private System.Windows.Forms.ColumnHeader TicketName;
        private System.Windows.Forms.ColumnHeader TicketDate;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.ListView lvTickets;
    }
}