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
        public LoansView()
        {
            InitializeComponent();
        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            frmAddLoan frmAddLoan = new frmAddLoan();
            frmAddLoan.ShowDialog();
        }
    }
}
