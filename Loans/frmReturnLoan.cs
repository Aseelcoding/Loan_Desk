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
    public partial class frmReturnLoan : Form
    {
        LoanDesk.Models.Loan _loan;
        public frmReturnLoan(LoanDesk.Models.Loan loan)
        {
            InitializeComponent();
            _loan = loan;
            
                
                LoadLoanInfo();
            
           
          
        }
        private void LoadLoanInfo() 
        {
            

            try
            {
                //1.Basic loan information
                txtLoanID.Text = _loan.ID.ToString();
                txtBorrowerID.Text = _loan.BorrowerID.ToString();
                txtEquipmentID.Text = _loan.EquipmentID.ToString();
                numQuantity.Value = _loan.Quantity;
                txtLoanDate.Text = _loan.LoanedAt.ToString();
                txtDueDate.Text = _loan.DueAt.ToString();
                txtLoanDate.Text=_loan.LoanedAt.ToString();
                //2.late fee information
                txtReturnDate.Text = DateTime.Now.ToString();

                int daysLate = Math.Max(0, (DateTime.Today - _loan.DueAt.Date).Days);
                numOverdueDays.Value = daysLate;

                LoansBLL.GetFinalLateFee(_loan);


              
                labFee.Text = "$" + _loan.LateFee.ToString();

                if (_loan.FinePaid != null)
                {
                    toglPaymentStatus.Toggled = (bool)_loan.FinePaid;
                }
                else
                    toglPaymentStatus.Visible = false;

            }
            catch (Exception ex) 
            {
                ErrorHandler.Show(ex);
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_loan.Status != "Active")
                    throw new Exceptions.BusinessRuleException("This loan has already been returned.");
                if (LoansBLL.ReturnEquipment(_loan))
                   { MessageBox.Show("Success");this.Close(); }
                else
                    MessageBox.Show("Failed");
            }
            catch (Exception ex) 
            {
                ErrorHandler.Show(ex);
            }
        }

        private void btnPayFine_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (_loan.LateFee <= 0 || _loan.FinePaid == null)
                    throw new Exceptions.BusinessRuleException("This loan has no fee");
                if(_loan.Status!="Returned" && _loan.Status != "Lost")
                    throw new Exceptions.BusinessRuleException("First return the equipment then pay the fine.");
                if (_loan.FinePaid != null && _loan.FinePaid == true)
                {
                    throw new Exceptions.BusinessRuleException("The fines for this loan have been paid.");
                }

                
              frmpayment frmpayment=new frmpayment(_loan);
                frmpayment.ShowDialog();
            }
            catch (Exception ex) 
            {
                ErrorHandler.Show(ex);
            }
        }
    }
}
