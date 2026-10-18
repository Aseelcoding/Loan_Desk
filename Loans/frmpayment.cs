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
    public partial class frmpayment : Form
    {
        LoanDesk.Models.Loan _loan;
        public frmpayment(LoanDesk.Models.Loan loan)
        {
            InitializeComponent();
            _loan = loan;
        }
       
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoansBLL.PayFine(_loan))
                    MessageBox.Show("Success");
                else
                    MessageBox.Show("Failed");

                
            }
            catch(Exception ex) 
            {
                ErrorHandler.Show(ex);
            }
        }
    }
}
