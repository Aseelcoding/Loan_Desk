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

            togIsActive.Toggled = _borrower.IsActive;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
