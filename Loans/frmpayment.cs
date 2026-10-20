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

namespace Loan_Desk.Loans
{
    public partial class frmpayment : Form
    {
        LoanDesk.Models.Loan _loan;
      
        public frmpayment(LoanDesk.Models.Loan loan)
        {
            InitializeComponent();
            _loan = loan;
            LoadLoanPaymentInfo();
            if (_loan.Status != "Lost") 
            {
                labReplacementFee.Visible = false;
                
            }
        }
        private void LoadLoanPaymentInfo()
        {
            try
            {
               
                labLateFee.Text = _loan.LateFee.ToString();
                Borrower borrower = BorrowersBLL.GetBorrowerByID(_loan.BorrowerID);
                LoanDesk.Models.Equipment equipment=EquipmentBLL.GetEquipmentByID(_loan.EquipmentID);
                txtBorrowerName.Text = borrower.FullName;
               
                labReplacementFee.Text = _loan.ReplacementFee.ToString();
                labTotalFee.Text=(_loan.ReplacementFee + _loan.LateFee).ToString();
            }
            catch (Exception ex) 
            {

                ErrorHandler.Show(ex);
                this.Close();
            }

        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {

                if (LoansBLL.PayFine(_loan))
                   { MessageBox.Show("Success");this.Close(); }
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
