using BLL;
using System;
using System.Data;
using System.Windows.Forms;
using utilities;

namespace Loan_Desk.Loans
{
    public partial class LoansView : UserControl
    {
        private DataTable dtLoans;

        public LoansView()
        {
            InitializeComponent();
            RefreshData();

            DataGridViewHelper.StyleDataGridView(dgvLo);
        }

        private void Filtering(string Text)
        {
            string Filter = string.Empty;

            if (!string.IsNullOrEmpty(Text))
            {
                if (cbFilter.SelectedIndex == 0)
                {
                    int ID = -1;
                    int.TryParse(Text, out ID);
                    Filter = $"ID = {ID}";
                }
                else if (cbFilter.SelectedIndex == 1)
                {
                    int EQID = -1;
                    int.TryParse(Text, out EQID);
                    Filter = $"EquipmentID = {EQID}";
                }
                else if (cbFilter.SelectedIndex == 2)
                {
                    int BOID = -1;
                    int.TryParse(Text, out BOID);
                    Filter = $"BorrowerID = {BOID}";
                }
                else if (cbFilter.SelectedIndex == 3)
                {
                    int USID = -1;
                    int.TryParse(Text, out USID);
                    Filter = $"UserID = {USID}";
                }
                else if (cbFilter.SelectedIndex == 4)
                {
                    int Quantity = -1;
                    int.TryParse(Text, out Quantity);
                    Filter = $"Quantity = {Quantity}";
                }
                else if (cbFilter.SelectedIndex == 5)
                {
                    DateTime LoanedAt;

                    if (DateTime.TryParse(Text, out LoanedAt))
                    {
                        Filter = $"LoanedAt >= '{LoanedAt:MM-dd-yyyy 00:00:00}' and LoanedAt <= '{LoanedAt:MM-dd-yyyy 23:59:59}'";
                    }
                }
                else if (cbFilter.SelectedIndex == 6)
                {
                    DateTime DueAt;

                    if (DateTime.TryParse(Text, out DueAt))
                    {
                        Filter = $"DueAt >= '{DueAt:MM-dd-yyyy 00:00:00}' and DueAt <= '{DueAt:MM-dd-yyyy 23:59:59}'";
                    }
                }
                else if (cbFilter.SelectedIndex == 7)
                {
                    DateTime ReturnedAt;
                   // DataColumn.Expression.
                    if (DateTime.TryParse(Text, out ReturnedAt))
                    {
                        Filter = $"ReturnedAt >= '{ReturnedAt:MM-dd-yyyy 00:00:00}' and ReturnedAt <= '{ReturnedAt:MM-dd-yyyy 23:59:59}'";
                    }
                }
                else if (cbFilter.SelectedIndex == 8)
                {
                    Filter = $"Status = '{Text}'";
                }
            }

            // Apply status filters
            if (chActive.Checked && !chReturned.Checked && !chLost.Checked)
            {
                Filter += (Filter != "" ? " AND " : "") + "Status = 'Active'";
            }
            else if (!chActive.Checked && chReturned.Checked && !chLost.Checked)
            {
                Filter += (Filter != "" ? " AND " : "") + "Status = 'Returned'";
            }
            else if (!chActive.Checked && !chReturned.Checked && chLost.Checked)
            {
                Filter += (Filter != "" ? " AND " : "") + "Status = 'Lost'";
            }

            LoadLoansInfo(Filter);
        }

        private void LoadLoansInfo(string Filter = "")
        {
            dgvLo.Rows.Clear();
            DataView dvLo = dtLoans.DefaultView;

            dvLo.RowFilter = Filter;

            foreach (DataRowView row in dvLo)
            {
                dgvLo.Rows.Add
                    (
                    row["ID"],
                    row["EquipmentID"],
                    row["BorrowerID"],
                    row["UserID"],
                    row["Quantity"],
                    row["LoanedAt"],
                    row["DueAt"],
                row["ReturnedAt"],
                row["Status"],
                row["LateFee"],
                    row["FinePaid"]);
            }
        }

        private void RefreshData()
        {
            try
            {
                dtLoans = LoansBLL.GetAllLoans();
                LoadLoansInfo();
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex);
            }
        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            frmAddLoan frmAddLoan = new frmAddLoan();
            frmAddLoan.ShowDialog();
            RefreshData();
        }

        private void txtBarSearch_TextChanged(object sender, EventArgs e)
        {
            string Filter = txtBarSearch.Text;
            Filter = utilities.utilities.ClearFilterString(Filter);
            Filtering(Filter);
        }

        private void chActive_CheckedChanged(object sender, EventArgs e)
        {
            string Filter = txtBarSearch.Text;
            Filter = utilities.utilities.ClearFilterString(Filter);
            Filtering(Filter);
        }

        private void chReturned_CheckedChanged(object sender, EventArgs e)
        {
            string Filter = txtBarSearch.Text;
            Filter = utilities.utilities.ClearFilterString(Filter);
            Filtering(Filter);
        }

        private void chLost_CheckedChanged(object sender, EventArgs e)
        {
            string Filter = txtBarSearch.Text;
            Filter = utilities.utilities.ClearFilterString(Filter);
            Filtering(Filter);
        }
    }
}