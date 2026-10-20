using BLL;
using LoanDesk.Models;
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
        private LoanDesk.Models.Loan GetSelectedRow() 
        {
         

            if (dgvLo.SelectedRows.Count > 0)
            {
                var row = dgvLo.SelectedRows[0];
                var loan = new LoanDesk.Models.Loan();

                loan.ID = Convert.ToInt32(row.Cells["ID"].Value);
                loan.EquipmentID = Convert.ToInt32(row.Cells["EquipmentID"].Value);
                loan.BorrowerID = Convert.ToInt32(row.Cells["BorrowerID"].Value);
                loan.UserID = Convert.ToInt32(row.Cells["UserID"].Value);
                loan.Quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                loan.LoanedAt = Convert.ToDateTime(row.Cells["LoanedAt"].Value);
                loan.DueAt = Convert.ToDateTime(row.Cells["DueAt"].Value);

                if (row.Cells["ReturnedAt"].Value != DBNull.Value)
                    loan.ReturnedAt = Convert.ToDateTime(row.Cells["ReturnedAt"].Value);

                loan.Status = row.Cells["Status"].Value.ToString();
                loan.LateFee = Convert.ToDecimal(row.Cells["LateFee"].Value);

                if (row.Cells["FinePaid"].Value != DBNull.Value)
                    loan.FinePaid = Convert.ToBoolean(row.Cells["FinePaid"].Value);

                DataRow[] loanRecords = dtLoans.Select("ID = " + loan.ID);
                if (loanRecords.Length > 0)
                {
                    DataRow loanRecord = loanRecords[0];
                    loan.LostQuantity = Convert.ToInt32(loanRecord["LostQuantity"]);
                    loan.ReplacementFee = Convert.ToDecimal(loanRecord["ReplacementFee"]);
                    if (loanRecord["ReplacementPaid"] != DBNull.Value)
                        loan.ReplacementPaid = Convert.ToBoolean(loanRecord["ReplacementPaid"]);
                }

                return loan;
            }
            else
                return null;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            LoanDesk.Models.Loan loan = GetSelectedRow();

            try
            {
                if (loan == null)
                {
                    throw new Exceptions.ValidationException("Please choose a valid loan.");
                }
                
            }
            catch(Exception ex)
            {
                ErrorHandler.Show(ex);
                return;
            }
           
            frmReturnLoan frmReturnLoan=new frmReturnLoan(loan);
            
            frmReturnLoan.ShowDialog();

            RefreshData();

        }
    }
}