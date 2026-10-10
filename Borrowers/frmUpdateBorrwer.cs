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

namespace Loan_Desk.Borrowers
{
    public partial class frmUpdateBorrwer : Form
    {
        LoanDesk.Models.Borrower _borrower;
        public frmUpdateBorrwer(LoanDesk.Models.Borrower borrower)
        {
            InitializeComponent();
            _borrower=borrower;
            LoadBorrowerInfo();
        }
        private void LoadBorrowerInfo() 
        {
            txtborrowerID.Text=_borrower.ID.ToString();
            txtFullName.Text=_borrower.FullName.ToString();
            txtPassport.Text=_borrower.Passport.ToString();
            txtPhone.Text=_borrower.Phone.ToString();

           

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void IsSameInfo(LoanDesk.Models.Borrower borrower1) 
        {
            borrower1.Phone = utilities.utilities.SanitizePhoneNumber(borrower1.Phone);
            if(borrower1.FullName==_borrower.FullName&&
                borrower1.Passport==_borrower.Passport &&
                borrower1.Phone == _borrower.Phone ) 
            {
                throw new Exceptions.ValidationException("You did not change any info.");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool IsUpdated = false;
            try 
            {
                utilities.utilities.IsEmptyOrNullOrWhiteSpace(txtFullName.Text, "Username");
                utilities.utilities.IsEmptyOrNullOrWhiteSpace(txtPassport.Text, "Passport");

                if (!txtPhone.MaskCompleted)
                {
                    MessageBox.Show("Please enter a complete phone number.");
                    return;
                }

                LoanDesk.Models.Borrower ToBeUpdated = new Borrower()
                {
                    ID = _borrower.ID,
                    FullName=txtFullName.Text,
                    Passport=txtPassport.Text,
                    Phone=txtPhone.Text,
                    IsActive=_borrower.IsActive,
                };
                IsSameInfo(ToBeUpdated);


                IsUpdated=BorrowersBLL.UpdateBorrower(ToBeUpdated);

                if (IsUpdated)
                   { MessageBox.Show("Success"); this.Close(); }
                else 
                {
                    MessageBox.Show("Failed");
                }
            }
            catch (Exception ex) 
            {
                ErrorHandler.Show(ex);
            }
        }
    }
}
