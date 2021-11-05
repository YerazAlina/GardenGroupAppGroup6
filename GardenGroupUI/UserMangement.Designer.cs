﻿
namespace GardenGroupUI
{
    partial class UserMangement
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
            this.btnAddingUser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnFilterEmail = new System.Windows.Forms.Button();
            this.lblusermanagement = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvUserManagement = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ticket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Refresh = new System.Windows.Forms.Button();
            this.lblLicenseInfo = new System.Windows.Forms.Label();
            this.lblNoDesk = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddingUser
            // 
            this.btnAddingUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddingUser.Location = new System.Drawing.Point(112, 341);
            this.btnAddingUser.Name = "btnAddingUser";
            this.btnAddingUser.Size = new System.Drawing.Size(121, 31);
            this.btnAddingUser.TabIndex = 1;
            this.btnAddingUser.Text = "+ ADD NEW USER";
            this.btnAddingUser.UseVisualStyleBackColor = true;
            this.btnAddingUser.Click += new System.EventHandler(this.btnAddingUser_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveUser.Location = new System.Drawing.Point(238, 341);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(119, 31);
            this.btnRemoveUser.TabIndex = 2;
            this.btnRemoveUser.Text = "- REMOVE USER";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.UseWaitCursor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 59);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // btnFilterEmail
            // 
            this.btnFilterEmail.Location = new System.Drawing.Point(74, 84);
            this.btnFilterEmail.Name = "btnFilterEmail";
            this.btnFilterEmail.Size = new System.Drawing.Size(119, 31);
            this.btnFilterEmail.TabIndex = 4;
            this.btnFilterEmail.Text = "Filter";
            this.btnFilterEmail.UseVisualStyleBackColor = true;
            this.btnFilterEmail.Click += new System.EventHandler(this.btnFilterEmail_Click);
            // 
            // lblusermanagement
            // 
            this.lblusermanagement.AutoSize = true;
            this.lblusermanagement.Font = new System.Drawing.Font("Segoe UI", 15.85714F, System.Drawing.FontStyle.Bold);
            this.lblusermanagement.Location = new System.Drawing.Point(58, 8);
            this.lblusermanagement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusermanagement.Name = "lblusermanagement";
            this.lblusermanagement.Size = new System.Drawing.Size(204, 30);
            this.lblusermanagement.TabIndex = 7;
            this.lblusermanagement.Text = "User Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fill in full email";
            // 
            // lvUserManagement
            // 
            this.lvUserManagement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Email,
            this.FirstName,
            this.LastName,
            this.Ticket});
            this.lvUserManagement.FullRowSelect = true;
            this.lvUserManagement.HideSelection = false;
            this.lvUserManagement.Location = new System.Drawing.Point(74, 131);
            this.lvUserManagement.Name = "lvUserManagement";
            this.lvUserManagement.Size = new System.Drawing.Size(494, 205);
            this.lvUserManagement.TabIndex = 9;
            this.lvUserManagement.UseCompatibleStateImageBehavior = false;
            this.lvUserManagement.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 130;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 100;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 100;
            // 
            // Ticket
            // 
            this.Ticket.Text = "# Ticket";
            this.Ticket.Width = 100;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(261, 58);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(64, 20);
            this.Refresh.TabIndex = 10;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // lblLicenseInfo
            // 
            this.lblLicenseInfo.AutoSize = true;
            this.lblLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblLicenseInfo.Location = new System.Drawing.Point(459, 48);
            this.lblLicenseInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLicenseInfo.Name = "lblLicenseInfo";
            this.lblLicenseInfo.Size = new System.Drawing.Size(215, 19);
            this.lblLicenseInfo.TabIndex = 17;
            this.lblLicenseInfo.Text = "Licensed to: The Garden Group";
            // 
            // lblNoDesk
            // 
            this.lblNoDesk.AutoSize = true;
            this.lblNoDesk.Font = new System.Drawing.Font("Segoe UI", 26.14286F, System.Drawing.FontStyle.Bold);
            this.lblNoDesk.Location = new System.Drawing.Point(509, 9);
            this.lblNoDesk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoDesk.Name = "lblNoDesk";
            this.lblNoDesk.Size = new System.Drawing.Size(149, 47);
            this.lblNoDesk.TabIndex = 16;
            this.lblNoDesk.Text = "NoDesk";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(363, 341);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 31);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "+-  UPDATE USER";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UserMangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblLicenseInfo);
            this.Controls.Add(this.lblNoDesk);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.lvUserManagement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblusermanagement);
            this.Controls.Add(this.btnFilterEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnAddingUser);
            this.Name = "UserMangement";
            this.Text = "UserMangement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddingUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnFilterEmail;
        private System.Windows.Forms.Label lblusermanagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvUserManagement;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Ticket;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label lblLicenseInfo;
        private System.Windows.Forms.Label lblNoDesk;
        private System.Windows.Forms.Button btnUpdate;
    }
}