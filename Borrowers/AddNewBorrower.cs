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
    public partial class frmAddBorrower : Form
    {
        public frmAddBorrower()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool IsAdded=false;
            try
            {
                utilities.utilities.IsEmptyOrNullOrWhiteSpace(txtFullName.Text, "Username");
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

                IsAdded =BorrowersBLL.AddNewBorrower(NewBorrower);

                if (IsAdded)
                    { MessageBox.Show("Success");this.Close(); }
                else
                    MessageBox.Show("Failed");

            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex);
            }

           


           

        }
    }
}
