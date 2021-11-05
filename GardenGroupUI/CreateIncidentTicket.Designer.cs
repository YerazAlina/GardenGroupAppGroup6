
namespace GardenGroupUI
{
    partial class CreateTickets
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
            this.lblLicenseInfo = new System.Windows.Forms.Label();
            this.lblNoDesk = new System.Windows.Forms.Label();
            this.lblTitleCreateIcident = new System.Windows.Forms.Label();
            this.lblDescript = new System.Windows.Forms.Label();
            this.lblDateTimeReported = new System.Windows.Forms.Label();
            this.lblSubjectIcident = new System.Windows.Forms.Label();
            this.lblTypeIcident = new System.Windows.Forms.Label();
            this.lblReportedbyUser = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblDeadlineFollowup = new System.Windows.Forms.Label();
            this.textBoxSubjType = new System.Windows.Forms.TextBox();
            this.comboBoxIncidentType = new System.Windows.Forms.ComboBox();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.comboBoxDeadline = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.bttnSubmitTicket = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnDashboard = new System.Windows.Forms.Button();
            this.bttnIncidentManagement = new System.Windows.Forms.Button();
            this.bttnUserManagement = new System.Windows.Forms.Button();
            this.lblEmailUser = new System.Windows.Forms.Label();
            this.lblEmailUserEmpty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLicenseInfo
            // 
            this.lblLicenseInfo.AutoSize = true;
            this.lblLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblLicenseInfo.Location = new System.Drawing.Point(387, 87);
            this.lblLicenseInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicenseInfo.Name = "lblLicenseInfo";
            this.lblLicenseInfo.Size = new System.Drawing.Size(368, 32);
            this.lblLicenseInfo.TabIndex = 4;
            this.lblLicenseInfo.Text = "Licensed to: The Garden Group";
            // 
            // lblNoDesk
            // 
            this.lblNoDesk.AutoSize = true;
            this.lblNoDesk.Font = new System.Drawing.Font("Segoe UI", 26.14286F, System.Drawing.FontStyle.Bold);
            this.lblNoDesk.Location = new System.Drawing.Point(468, 18);
            this.lblNoDesk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoDesk.Name = "lblNoDesk";
            this.lblNoDesk.Size = new System.Drawing.Size(264, 84);
            this.lblNoDesk.TabIndex = 3;
            this.lblNoDesk.Text = "NoDesk";
            // 
            // lblTitleCreateIcident
            // 
            this.lblTitleCreateIcident.AutoSize = true;
            this.lblTitleCreateIcident.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitleCreateIcident.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Bold);
            this.lblTitleCreateIcident.Location = new System.Drawing.Point(13, 167);
            this.lblTitleCreateIcident.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleCreateIcident.Name = "lblTitleCreateIcident";
            this.lblTitleCreateIcident.Size = new System.Drawing.Size(656, 65);
            this.lblTitleCreateIcident.TabIndex = 6;
            this.lblTitleCreateIcident.Text = "Create a new incident ticket";
            // 
            // lblDescript
            // 
            this.lblDescript.AutoSize = true;
            this.lblDescript.Location = new System.Drawing.Point(35, 641);
            this.lblDescript.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescript.Name = "lblDescript";
            this.lblDescript.Size = new System.Drawing.Size(115, 25);
            this.lblDescript.TabIndex = 7;
            this.lblDescript.Text = "Description:";
            // 
            // lblDateTimeReported
            // 
            this.lblDateTimeReported.AutoSize = true;
            this.lblDateTimeReported.Location = new System.Drawing.Point(35, 253);
            this.lblDateTimeReported.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTimeReported.Name = "lblDateTimeReported";
            this.lblDateTimeReported.Size = new System.Drawing.Size(186, 25);
            this.lblDateTimeReported.TabIndex = 8;
            this.lblDateTimeReported.Text = "Date/Time reported:";
            // 
            // lblSubjectIcident
            // 
            this.lblSubjectIcident.AutoSize = true;
            this.lblSubjectIcident.Location = new System.Drawing.Point(35, 306);
            this.lblSubjectIcident.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectIcident.Name = "lblSubjectIcident";
            this.lblSubjectIcident.Size = new System.Drawing.Size(171, 25);
            this.lblSubjectIcident.TabIndex = 9;
            this.lblSubjectIcident.Text = "Subject of incident";
            // 
            // lblTypeIcident
            // 
            this.lblTypeIcident.AutoSize = true;
            this.lblTypeIcident.Location = new System.Drawing.Point(35, 367);
            this.lblTypeIcident.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeIcident.Name = "lblTypeIcident";
            this.lblTypeIcident.Size = new System.Drawing.Size(156, 25);
            this.lblTypeIcident.TabIndex = 10;
            this.lblTypeIcident.Text = "Type of incident:";
            // 
            // lblReportedbyUser
            // 
            this.lblReportedbyUser.AutoSize = true;
            this.lblReportedbyUser.Location = new System.Drawing.Point(35, 425);
            this.lblReportedbyUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportedbyUser.Name = "lblReportedbyUser";
            this.lblReportedbyUser.Size = new System.Drawing.Size(166, 25);
            this.lblReportedbyUser.TabIndex = 11;
            this.lblReportedbyUser.Text = "Reported by user:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(35, 533);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(77, 25);
            this.lblPriority.TabIndex = 12;
            this.lblPriority.Text = "Priority:";
            // 
            // lblDeadlineFollowup
            // 
            this.lblDeadlineFollowup.AutoSize = true;
            this.lblDeadlineFollowup.Location = new System.Drawing.Point(35, 587);
            this.lblDeadlineFollowup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeadlineFollowup.Name = "lblDeadlineFollowup";
            this.lblDeadlineFollowup.Size = new System.Drawing.Size(184, 25);
            this.lblDeadlineFollowup.TabIndex = 13;
            this.lblDeadlineFollowup.Text = "Deadline/Follow up:";
            // 
            // textBoxSubjType
            // 
            this.textBoxSubjType.Location = new System.Drawing.Point(303, 306);
            this.textBoxSubjType.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSubjType.Name = "textBoxSubjType";
            this.textBoxSubjType.Size = new System.Drawing.Size(345, 29);
            this.textBoxSubjType.TabIndex = 14;
            // 
            // comboBoxIncidentType
            // 
            this.comboBoxIncidentType.FormattingEnabled = true;
            this.comboBoxIncidentType.Location = new System.Drawing.Point(303, 362);
            this.comboBoxIncidentType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIncidentType.Name = "comboBoxIncidentType";
            this.comboBoxIncidentType.Size = new System.Drawing.Size(345, 32);
            this.comboBoxIncidentType.TabIndex = 15;
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(303, 423);
            this.comboBoxUsers.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(345, 32);
            this.comboBoxUsers.TabIndex = 16;
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsers_SelectedIndexChanged);
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(303, 533);
            this.comboBoxPriority.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(345, 32);
            this.comboBoxPriority.TabIndex = 17;
            // 
            // comboBoxDeadline
            // 
            this.comboBoxDeadline.FormattingEnabled = true;
            this.comboBoxDeadline.Items.AddRange(new object[] {
            "7 days",
            "14 days",
            "28 days",
            "6 months"});
            this.comboBoxDeadline.Location = new System.Drawing.Point(303, 587);
            this.comboBoxDeadline.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDeadline.Name = "comboBoxDeadline";
            this.comboBoxDeadline.Size = new System.Drawing.Size(345, 32);
            this.comboBoxDeadline.TabIndex = 18;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(303, 253);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(345, 29);
            this.dateTimePicker.TabIndex = 19;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(303, 641);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(589, 395);
            this.textBoxDescription.TabIndex = 20;
            // 
            // bttnSubmitTicket
            // 
            this.bttnSubmitTicket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnSubmitTicket.Location = new System.Drawing.Point(501, 1073);
            this.bttnSubmitTicket.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSubmitTicket.Name = "bttnSubmitTicket";
            this.bttnSubmitTicket.Size = new System.Drawing.Size(222, 81);
            this.bttnSubmitTicket.TabIndex = 21;
            this.bttnSubmitTicket.Text = "Submit Ticket";
            this.bttnSubmitTicket.UseVisualStyleBackColor = false;
            this.bttnSubmitTicket.Click += new System.EventHandler(this.bttnSubmitTicket_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bttnCancel.Location = new System.Drawing.Point(53, 1073);
            this.bttnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(222, 81);
            this.bttnCancel.TabIndex = 22;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = false;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnDashboard
            // 
            this.bttnDashboard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnDashboard.Location = new System.Drawing.Point(11, 126);
            this.bttnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.bttnDashboard.Name = "bttnDashboard";
            this.bttnDashboard.Size = new System.Drawing.Size(235, 37);
            this.bttnDashboard.TabIndex = 23;
            this.bttnDashboard.Text = "Dashboard";
            this.bttnDashboard.UseVisualStyleBackColor = false;
            this.bttnDashboard.Click += new System.EventHandler(this.bttnDashboard_Click);
            // 
            // bttnIncidentManagement
            // 
            this.bttnIncidentManagement.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnIncidentManagement.Location = new System.Drawing.Point(249, 126);
            this.bttnIncidentManagement.Margin = new System.Windows.Forms.Padding(4);
            this.bttnIncidentManagement.Name = "bttnIncidentManagement";
            this.bttnIncidentManagement.Size = new System.Drawing.Size(235, 37);
            this.bttnIncidentManagement.TabIndex = 24;
            this.bttnIncidentManagement.Text = "Incident Management";
            this.bttnIncidentManagement.UseVisualStyleBackColor = false;
            this.bttnIncidentManagement.Click += new System.EventHandler(this.bttnIncidentManagement_Click);
            // 
            // bttnUserManagement
            // 
            this.bttnUserManagement.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnUserManagement.Location = new System.Drawing.Point(490, 126);
            this.bttnUserManagement.Margin = new System.Windows.Forms.Padding(4);
            this.bttnUserManagement.Name = "bttnUserManagement";
            this.bttnUserManagement.Size = new System.Drawing.Size(200, 37);
            this.bttnUserManagement.TabIndex = 25;
            this.bttnUserManagement.Text = "User Management";
            this.bttnUserManagement.UseVisualStyleBackColor = false;
            this.bttnUserManagement.Click += new System.EventHandler(this.bttnUserManagement_Click);
            // 
            // lblEmailUser
            // 
            this.lblEmailUser.AutoSize = true;
            this.lblEmailUser.Location = new System.Drawing.Point(35, 477);
            this.lblEmailUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailUser.Name = "lblEmailUser";
            this.lblEmailUser.Size = new System.Drawing.Size(116, 25);
            this.lblEmailUser.TabIndex = 26;
            this.lblEmailUser.Text = "E-mail user:";
            // 
            // lblEmailUserEmpty
            // 
            this.lblEmailUserEmpty.AutoSize = true;
            this.lblEmailUserEmpty.Location = new System.Drawing.Point(298, 486);
            this.lblEmailUserEmpty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailUserEmpty.Name = "lblEmailUserEmpty";
            this.lblEmailUserEmpty.Size = new System.Drawing.Size(27, 25);
            this.lblEmailUserEmpty.TabIndex = 27;
            this.lblEmailUserEmpty.Text = "...";
            // 
            // CreateTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 1698);
            this.Controls.Add(this.lblEmailUserEmpty);
            this.Controls.Add(this.lblEmailUser);
            this.Controls.Add(this.bttnUserManagement);
            this.Controls.Add(this.bttnIncidentManagement);
            this.Controls.Add(this.bttnDashboard);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnSubmitTicket);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxDeadline);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.comboBoxIncidentType);
            this.Controls.Add(this.textBoxSubjType);
            this.Controls.Add(this.lblDeadlineFollowup);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblReportedbyUser);
            this.Controls.Add(this.lblTypeIcident);
            this.Controls.Add(this.lblSubjectIcident);
            this.Controls.Add(this.lblDateTimeReported);
            this.Controls.Add(this.lblDescript);
            this.Controls.Add(this.lblTitleCreateIcident);
            this.Controls.Add(this.lblLicenseInfo);
            this.Controls.Add(this.lblNoDesk);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateTickets";
            this.Text = "New incident ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLicenseInfo;
        private System.Windows.Forms.Label lblNoDesk;
        private System.Windows.Forms.Label lblTitleCreateIcident;
        private System.Windows.Forms.Label lblDescript;
        private System.Windows.Forms.Label lblDateTimeReported;
        private System.Windows.Forms.Label lblSubjectIcident;
        private System.Windows.Forms.Label lblTypeIcident;
        private System.Windows.Forms.Label lblReportedbyUser;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblDeadlineFollowup;
        private System.Windows.Forms.TextBox textBoxSubjType;
        private System.Windows.Forms.ComboBox comboBoxIncidentType;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.ComboBox comboBoxDeadline;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button bttnSubmitTicket;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnDashboard;
        private System.Windows.Forms.Button bttnIncidentManagement;
        private System.Windows.Forms.Button bttnUserManagement;
        private System.Windows.Forms.Label lblEmailUser;
        private System.Windows.Forms.Label lblEmailUserEmpty;
    }
}