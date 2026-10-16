using BLL;
using System;
using System.Windows.Forms;

namespace Loan_Desk.Borrowers
{
    public partial class frmAddNewBorrower : Form
    {
        public frmAddNewBorrower()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool IsAdded = false;
            try
            {
                utilities.utilities.IsEmptyOrNullOrWhiteSpace(txtFullName.Text, "FullName");
                utilities.utilities.IsEmptyOrNullOrWhiteSpace(txtPassport.Text, "Passport");

                if (!txtPhone.MaskCompleted)
                {
                    MessageBox.Show("Please enter a complete phone number.");
                    return;
                }

                LoanDesk.Models.Borrower NewBorrower = new LoanDesk.Models.Borrower()
                {
                    FullName = txtFullName.Text,
                    Passport = txtPassport.Text,
                    Phone = txtPhone.Text,
                    IsActive = togIsActive.Toggled
                };

                IsAdded = BorrowersBLL.AddNewBorrower(NewBorrower);

                if (IsAdded)
                { MessageBox.Show("Success"); this.Close(); }
                else
                    MessageBox.Show("Failed");
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}