namespace Loan_Desk.Dashboard
{
    partial class DashboardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lostPanel3 = new ReaLTaiizor.Controls.LostPanel();
            this.labActiveUsers = new System.Windows.Forms.Label();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.chartDailyLoans = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lostPanel3.SuspendLayout();
            this.parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDailyLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // lostPanel3
            // 
            this.lostPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.lostPanel3.Controls.Add(this.labActiveUsers);
            this.lostPanel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostPanel3.ForeColor = System.Drawing.Color.Black;
            this.lostPanel3.Location = new System.Drawing.Point(41, 41);
            this.lostPanel3.Name = "lostPanel3";
            this.lostPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.lostPanel3.ShowText = true;
            this.lostPanel3.Size = new System.Drawing.Size(179, 111);
            this.lostPanel3.TabIndex = 4;
            this.lostPanel3.Text = "Active Users";
            // 
            // labActiveUsers
            // 
            this.labActiveUsers.AutoSize = true;
            this.labActiveUsers.BackColor = System.Drawing.Color.Transparent;
            this.labActiveUsers.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labActiveUsers.Location = new System.Drawing.Point(21, 40);
            this.labActiveUsers.Name = "labActiveUsers";
            this.labActiveUsers.Size = new System.Drawing.Size(66, 31);
            this.labActiveUsers.TabIndex = 7;
            this.labActiveUsers.Text = "0000";
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.chartDailyLoans);
            this.parrotGradientPanel1.Controls.Add(this.lostPanel3);
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(1000, 771);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel1.TabIndex = 2;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // chartDailyLoans
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDailyLoans.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDailyLoans.Legends.Add(legend1);
            this.chartDailyLoans.Location = new System.Drawing.Point(41, 158);
            this.chartDailyLoans.Name = "chartDailyLoans";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Daily Loans";
            this.chartDailyLoans.Series.Add(series1);
            this.chartDailyLoans.Size = new System.Drawing.Size(920, 598);
            this.chartDailyLoans.TabIndex = 6;
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.parrotGradientPanel1);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(1000, 771);
            this.Load += new System.EventHandler(this.DashboardView_Load);
            this.lostPanel3.ResumeLayout(false);
            this.lostPanel3.PerformLayout();
            this.parrotGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDailyLoans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.LostPanel lostPanel3;
        private System.Windows.Forms.Label labActiveUsers;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDailyLoans;
    }
}
