using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Desk.Loans
{
    public partial class LoansView : UserControl
    {
        DataTable dtLoans;
        public LoansView()
        {
            InitializeComponent();
            RefreshData();
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
    }
}
