using BLL;
using LoanDesk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Loan_Desk.Borrowers
{
    public partial class BorrowersView : UserControl
    {
        DataTable dtB;
        private void RefreshData() 
        {
            try
            {
                dtB = BorrowersBLL.GetBorrowers();
            }
            catch (Exception ex) 
            {
                ErrorHandler.Show(ex);
            }
            LoadBorrowersInfo();
        }
        private void LoadBorrowersInfo(string Filter="")
        {
            dgvB.Rows.Clear();
    

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

        private void Filtering(string Text) 
        {

            if (string.IsNullOrEmpty(Text))
            {
                string ActivateFilter = "";
                if (chActive.Checked && chInActive.Checked == false)
                    ActivateFilter = "IsActive =1";
                else if (chActive.Checked == false && chInActive.Checked)
                    ActivateFilter = "IsActive =0";

                LoadBorrowersInfo(ActivateFilter);
                return;
            }

            string Filter = string.Empty;

            if (cbFilter.SelectedIndex == 0)
            {
                int USID = -1;
                int.TryParse(Text, out USID);
                Filter = $"ID = {USID} ";

                if (chActive.Checked && chInActive.Checked == false)
                {
                    Filter = $"ID = {USID} and IsActive =1";
                }
                else if (chActive.Checked == false && chInActive.Checked == true)
                {
                    Filter = $"ID = {USID} and IsActive =0";
                }

            }
            else if (cbFilter.SelectedIndex == 1)
            {
                Filter = $"FullName like '{Text}%'";

                if (chActive.Checked && chInActive.Checked == false)
                {
                    Filter = $"FullName like '{Text}%' and IsActive =1";
                }
                else if (chActive.Checked == false && chInActive.Checked == true)
                {
                    Filter = $"FullName like '{Text}%' and IsActive =0";
                }
            }
            else if (cbFilter.SelectedIndex == 2) 
            {
                Filter = $"Passport like '{Text}%'";

                if (chActive.Checked && chInActive.Checked == false)
                {
                    Filter = $"Passport like '{Text}%' and IsActive =1";
                }
                else if (chActive.Checked == false && chInActive.Checked == true)
                {
                    Filter = $"Passport like '{Text}%' and IsActive =0";
                }

            }
            else if (cbFilter.SelectedIndex == 3)
            {
                Filter = $"Phone like '{Text}%'";

                if (chActive.Checked && chInActive.Checked == false)
                {
                    Filter = $"Phone like '{Text}%' and IsActive =1";
                }
                else if (chActive.Checked == false && chInActive.Checked == true)
                {
                    Filter = $"Phone like '{Text}%' and IsActive =0";
                }

            }
            LoadBorrowersInfo(Filter);
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
            frmAddNewBorrower frmAddBorrower = new frmAddNewBorrower();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool IsDeleted = false;
            LoanDesk.Models.Borrower borrower = GetSelectedRow();
            if (borrower == null)
            {
                MessageBox.Show("Please choose a vaild row.");
                return;
            }

            try
            {
                if (borrower.IsActive == false)
                    throw new Exceptions.ValidationException("This borrower is already InActive");

                IsDeleted=BorrowersBLL.DeactivateBorrowerByID(borrower.ID);
                if(IsDeleted) 
                {
                    MessageBox.Show("Success");
                    RefreshData();
                }
                
            }
            catch (Exception ex) 
            {
                ErrorHandler.Show(ex);
            }

        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            bool IsActivated = false;
            LoanDesk.Models.Borrower borrower = GetSelectedRow();
            if (borrower == null)
            {
                MessageBox.Show("Please choose a vaild row.");
                return;
            }

            try
            {
                if (borrower.IsActive)
                    throw new Exceptions.ValidationException("This borrower is already Active");

                IsActivated = BorrowersBLL.ActivateBorrowerByID(borrower.ID);
                if (IsActivated)
                {
                    MessageBox.Show("Success");
                    RefreshData();
                }

            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex);
            }
        }

        private void txtBarSearch_TextChanged(object sender, EventArgs e)
        {
            string Text = txtBarSearch.Text;

            Text = utilities.utilities.ClearFilterString(Text);



            Filtering(Text);

        }

        private void chActive_CheckedChanged(object sender, EventArgs e)
        {
            txtBarSearch_TextChanged(txtBarSearch, EventArgs.Empty);
        }

        private void chInActive_CheckedChanged(object sender, EventArgs e)
        {
            txtBarSearch_TextChanged(txtBarSearch, EventArgs.Empty);
        }
    }
}
