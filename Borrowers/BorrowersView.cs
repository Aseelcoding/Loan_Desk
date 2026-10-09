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

namespace Loan_Desk.Borrowers
{
    public partial class BorrowersView : UserControl
    {
        DataTable dtB;
        private void RefreshData(string Filter="")
        {
            dgvB.Rows.Clear();
            dtB = BorrowersBLL.GetBorrowers();

            DataView dvB = dtB.DefaultView;
            dvB.RowFilter = Filter;
            foreach (DataRowView row in dvB) 
            {
                dgvB.Rows.Add
                    (
                    row["ID"],
                    row["FullName"],
                    row["Passport"],
                    row["Phone"],
                    row["ActiveLoans"],
                    row["UnpaidFines"],
                    row["IsActive"]
                    );
            }

        }
        public BorrowersView()
        {
            InitializeComponent();
            RefreshData();
        }

        private void btnAddBorrower_Click(object sender, EventArgs e)
        {
            frmAddBorrower frmAddBorrower = new frmAddBorrower();
            frmAddBorrower.ShowDialog();
            RefreshData();
        }
    }
}
