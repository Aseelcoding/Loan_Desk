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


        private LoanDesk.Models.Borrower GetSelectedRow()
        {
            LoanDesk.Models.Borrower borrower = new LoanDesk.Models.Borrower();

            if (dgvB.SelectedRows.Count > 0)
            {
                int USID = -1;
                int.TryParse(dgvB.SelectedRows[0].Cells["ID"].Value.ToString(), out USID);
                borrower.ID = USID;

                borrower.FullName = dgvB.SelectedRows[0].Cells["FullName"].Value.ToString();
                borrower.Passport = dgvB.SelectedRows[0].Cells["Passport"].Value.ToString();
                borrower.Phone = dgvB.SelectedRows[0].Cells["Phone"].Value.ToString();
                borrower.IsActive = (bool)dgvB.SelectedRows[0].Cells["IsActive"].Value;

                return borrower;
            }
            else
            {
                return null;
            }
        }
        private void btnAddBorrower_Click(object sender, EventArgs e)
        {
            frmAddBorrower frmAddBorrower = new frmAddBorrower();
            frmAddBorrower.ShowDialog();
            RefreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoanDesk.Models.Borrower borrower = GetSelectedRow();
            if (borrower == null)
               { MessageBox.Show("Please choose a vaild row.");
                 return;
               }


           frmUpdateBorrwer frmUpdate  = new frmUpdateBorrwer(borrower);
            frmUpdate.ShowDialog(); 
            RefreshData();
        }
    }
}
