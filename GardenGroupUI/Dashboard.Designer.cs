
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bttnUserManagement = new System.Windows.Forms.Button();
            this.bttnIncidentManagement = new System.Windows.Forms.Button();
            this.lblLicenseInfo = new System.Windows.Forms.Label();
            this.lblNoDesk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bttnDashboard = new System.Windows.Forms.Button();
            this.chartUnresolvedIncidents = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartUnresolvedIncidents)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnUserManagement
            // 
            this.bttnUserManagement.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnUserManagement.Location = new System.Drawing.Point(882, 133);
            this.bttnUserManagement.Margin = new System.Windows.Forms.Padding(4);
            this.bttnUserManagement.Name = "bttnUserManagement";
            this.bttnUserManagement.Size = new System.Drawing.Size(200, 37);
            this.bttnUserManagement.TabIndex = 33;
            this.bttnUserManagement.Text = "User Management";
            this.bttnUserManagement.UseVisualStyleBackColor = false;
            this.bttnUserManagement.Click += new System.EventHandler(this.bttnUserManagement_Click);
            // 
            // bttnIncidentManagement
            // 
            this.bttnIncidentManagement.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnIncidentManagement.Location = new System.Drawing.Point(506, 133);
            this.bttnIncidentManagement.Margin = new System.Windows.Forms.Padding(4);
            this.bttnIncidentManagement.Name = "bttnIncidentManagement";
            this.bttnIncidentManagement.Size = new System.Drawing.Size(200, 37);
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
            this.label1.Location = new System.Drawing.Point(130, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 84);
            this.label1.TabIndex = 34;
            this.label1.Text = "Current Incidents";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 74);
            this.button1.TabIndex = 35;
            this.button1.Text = " Show List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnDashboard
            // 
            this.bttnDashboard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnDashboard.Location = new System.Drawing.Point(130, 133);
            this.bttnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.bttnDashboard.Name = "bttnDashboard";
            this.bttnDashboard.Size = new System.Drawing.Size(200, 37);
            this.bttnDashboard.TabIndex = 31;
            this.bttnDashboard.Text = "Dashboard";
            this.bttnDashboard.UseVisualStyleBackColor = false;
            this.bttnDashboard.Click += new System.EventHandler(this.bttnDashboard_Click);
            // 
            // chartUnresolvedIncidents
            // 
            chartArea1.Name = "ChartArea1";
            this.chartUnresolvedIncidents.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chartUnresolvedIncidents.Legends.Add(legend1);
            this.chartUnresolvedIncidents.Location = new System.Drawing.Point(11, 86);
            this.chartUnresolvedIncidents.Name = "chartUnresolvedIncidents";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chartUnresolvedIncidents.Series.Add(series1);
            this.chartUnresolvedIncidents.Size = new System.Drawing.Size(300, 300);
            this.chartUnresolvedIncidents.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chartUnresolvedIncidents);
            this.groupBox1.Location = new System.Drawing.Point(144, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 508);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unresolved Incidents";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "All tickets are currently open";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Location = new System.Drawing.Point(709, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 508);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unresolved Incidents";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "All tickets are currently open";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(11, 86);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 37;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 26.14286F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(540, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 84);
            this.label4.TabIndex = 40;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 860);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnUserManagement;
        private System.Windows.Forms.Button bttnIncidentManagement;
        private System.Windows.Forms.Label lblLicenseInfo;
        private System.Windows.Forms.Label lblNoDesk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttnDashboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUnresolvedIncidents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
    }
}