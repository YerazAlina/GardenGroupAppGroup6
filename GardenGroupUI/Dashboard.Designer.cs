
namespace GardenGroupUI
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bttnUserManagement = new System.Windows.Forms.Button();
            this.bttnIncidentManagement = new System.Windows.Forms.Button();
            this.lblLicenseInfo = new System.Windows.Forms.Label();
            this.lblNoDesk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnShowLists = new System.Windows.Forms.Button();
            this.bttnDashboard = new System.Windows.Forms.Button();
            this.chartUnresolvedIncidents = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PastDeadlineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartUnresolvedIncidents)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PastDeadlineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnUserManagement
            // 
            this.bttnUserManagement.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnUserManagement.Location = new System.Drawing.Point(761, 126);
            this.bttnUserManagement.Margin = new System.Windows.Forms.Padding(4);
            this.bttnUserManagement.Name = "bttnUserManagement";
            this.bttnUserManagement.Size = new System.Drawing.Size(266, 49);
            this.bttnUserManagement.TabIndex = 33;
            this.bttnUserManagement.Text = "User Management";
            this.bttnUserManagement.UseVisualStyleBackColor = false;
            this.bttnUserManagement.Click += new System.EventHandler(this.bttnUserManagement_Click);
            // 
            // bttnIncidentManagement
            // 
            this.bttnIncidentManagement.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnIncidentManagement.Location = new System.Drawing.Point(487, 126);
            this.bttnIncidentManagement.Margin = new System.Windows.Forms.Padding(4);
            this.bttnIncidentManagement.Name = "bttnIncidentManagement";
            this.bttnIncidentManagement.Size = new System.Drawing.Size(266, 49);
            this.bttnIncidentManagement.TabIndex = 32;
            this.bttnIncidentManagement.Text = "Incident Management";
            this.bttnIncidentManagement.UseVisualStyleBackColor = false;
            this.bttnIncidentManagement.Click += new System.EventHandler(this.bttnIncidentManagement_Click);
            // 
            // lblLicenseInfo
            // 
            this.lblLicenseInfo.AutoSize = true;
            this.lblLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblLicenseInfo.Location = new System.Drawing.Point(882, 90);
            this.lblLicenseInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicenseInfo.Name = "lblLicenseInfo";
            this.lblLicenseInfo.Size = new System.Drawing.Size(368, 32);
            this.lblLicenseInfo.TabIndex = 30;
            this.lblLicenseInfo.Text = "Licensed to: The Garden Group";
            // 
            // lblNoDesk
            // 
            this.lblNoDesk.AutoSize = true;
            this.lblNoDesk.Font = new System.Drawing.Font("Segoe UI", 26.14286F, System.Drawing.FontStyle.Bold);
            this.lblNoDesk.Location = new System.Drawing.Point(985, 15);
            this.lblNoDesk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoDesk.Name = "lblNoDesk";
            this.lblNoDesk.Size = new System.Drawing.Size(264, 84);
            this.lblNoDesk.TabIndex = 29;
            this.lblNoDesk.Text = "NoDesk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.14286F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 84);
            this.label1.TabIndex = 34;
            this.label1.Text = "Current Incidents";
            // 
            // bttnShowLists
            // 
            this.bttnShowLists.BackColor = System.Drawing.SystemColors.Highlight;
            this.bttnShowLists.Location = new System.Drawing.Point(943, 251);
            this.bttnShowLists.Margin = new System.Windows.Forms.Padding(6);
            this.bttnShowLists.Name = "bttnShowLists";
            this.bttnShowLists.Size = new System.Drawing.Size(266, 85);
            this.bttnShowLists.TabIndex = 35;
            this.bttnShowLists.Text = " Show List";
            this.bttnShowLists.UseVisualStyleBackColor = false;
            this.bttnShowLists.Click += new System.EventHandler(this.bttnShowLists_Click);
            // 
            // bttnDashboard
            // 
            this.bttnDashboard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnDashboard.Location = new System.Drawing.Point(213, 126);
            this.bttnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.bttnDashboard.Name = "bttnDashboard";
            this.bttnDashboard.Size = new System.Drawing.Size(266, 49);
            this.bttnDashboard.TabIndex = 31;
            this.bttnDashboard.Text = "Dashboard";
            this.bttnDashboard.UseVisualStyleBackColor = false;
            // 
            // chartUnresolvedIncidents
            // 
            chartArea3.Name = "ChartArea1";
            this.chartUnresolvedIncidents.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            this.chartUnresolvedIncidents.Legends.Add(legend3);
            this.chartUnresolvedIncidents.Location = new System.Drawing.Point(11, 87);
            this.chartUnresolvedIncidents.Margin = new System.Windows.Forms.Padding(4);
            this.chartUnresolvedIncidents.Name = "chartUnresolvedIncidents";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Unsolved incidents";
            this.chartUnresolvedIncidents.Series.Add(series3);
            this.chartUnresolvedIncidents.Size = new System.Drawing.Size(488, 380);
            this.chartUnresolvedIncidents.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chartUnresolvedIncidents);
            this.groupBox1.Location = new System.Drawing.Point(43, 375);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(601, 508);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unresolved Incidents";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "All tickets are currently open";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PastDeadlineChart);
            this.groupBox2.Location = new System.Drawing.Point(672, 375);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(537, 508);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Incidents past deadline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "These tickets need your immediate attention";
            // 
            // PastDeadlineChart
            // 
            chartArea4.Name = "ChartArea1";
            this.PastDeadlineChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.PastDeadlineChart.Legends.Add(legend4);
            this.PastDeadlineChart.Location = new System.Drawing.Point(8, 87);
            this.PastDeadlineChart.Margin = new System.Windows.Forms.Padding(4);
            this.PastDeadlineChart.Name = "PastDeadlineChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Deadline";
            this.PastDeadlineChart.Series.Add(series4);
            this.PastDeadlineChart.Size = new System.Drawing.Size(488, 380);
            this.PastDeadlineChart.TabIndex = 37;
            this.PastDeadlineChart.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 26.14286F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(503, 361);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 84);
            this.label4.TabIndex = 40;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 937);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttnShowLists);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnUserManagement);
            this.Controls.Add(this.bttnIncidentManagement);
            this.Controls.Add(this.bttnDashboard);
            this.Controls.Add(this.lblLicenseInfo);
            this.Controls.Add(this.lblNoDesk);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chartUnresolvedIncidents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PastDeadlineChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnUserManagement;
        private System.Windows.Forms.Button bttnIncidentManagement;
        private System.Windows.Forms.Label lblLicenseInfo;
        private System.Windows.Forms.Label lblNoDesk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnShowLists;
        private System.Windows.Forms.Button bttnDashboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUnresolvedIncidents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart PastDeadlineChart;
        private System.Windows.Forms.Label label4;
    }
}