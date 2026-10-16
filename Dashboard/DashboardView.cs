using BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Loan_Desk.Dashboard
{
    public partial class DashboardView : UserControl
    {
        public DashboardView()
        {
            InitializeComponent();
            ApplyColors(chartDailyLoans);
        }

        private void RefreshData()
        {
            DateTime EndDate = DateTime.Now;
            DateTime StartDate = EndDate.AddDays(-7);

            DataTable dt = LoansBLL.GetDailyLoanStatistics(StartDate, EndDate);

            LoadDailyLoanStatistics(dt);
        }

        public static void ApplyColors(Chart chart)
        {
            // Chart background
            chart.BackColor = Color.White;

            // Chart area
            foreach (ChartArea area in chart.ChartAreas)
            {
                area.BackColor = Color.White;

                // Grid lines
                area.AxisX.MajorGrid.LineColor =
                    ColorTranslator.FromHtml("#D9DEE3");

                area.AxisY.MajorGrid.LineColor =
                    ColorTranslator.FromHtml("#D9DEE3");

                // Axis labels
                area.AxisX.LabelStyle.ForeColor =
                    ColorTranslator.FromHtml("#34495E");

                area.AxisY.LabelStyle.ForeColor =
                    ColorTranslator.FromHtml("#34495E");

                // Axis lines
                area.AxisX.LineColor =
                    ColorTranslator.FromHtml("#D9DEE3");

                area.AxisY.LineColor =
                    ColorTranslator.FromHtml("#D9DEE3");
            }

            // Series colors
            foreach (Series series in chart.Series)
            {
                series.Color = ColorTranslator.FromHtml("#7895B2");
                series.BorderColor = ColorTranslator.FromHtml("#34495E");
            }

            // Chart titles
            foreach (Title title in chart.Titles)
            {
                title.ForeColor = ColorTranslator.FromHtml("#34495E");
            }

            // Legend
            foreach (Legend legend in chart.Legends)
            {
                legend.BackColor = Color.Transparent;
                legend.ForeColor = ColorTranslator.FromHtml("#34495E");
            }
        }

        private void LoadDailyLoanStatistics(DataTable dt)
        {
            Series series = chartDailyLoans.Series["Daily Loans"];

            series.Points.Clear();

            foreach (DataRow row in dt.Rows)
            {
                DateTime loanDate = Convert.ToDateTime(row["LoanDate"]);
                int totalLoans = Convert.ToInt32(row["TotalLoans"]);

                series.Points.AddXY(loanDate.ToString("ddd"), totalLoans);
            }
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {
            labActiveUsers.Text = BLL.UserBLL.CountActiveUsers().ToString();
            RefreshData();
        }
    }
}