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
        private NumericUpDown _numLostQuantity;
        private Button _btnMarkLost;

        public frmReturnLoan(LoanDesk.Models.Loan loan)
        {
            InitializeComponent();
            _loan = loan;
            AddLostEquipmentControls();
            LoadLoanInfo();
        }

        private void AddLostEquipmentControls()
        {
            Label label = new Label();
            label.Text = "Lost quantity:";
            label.ForeColor = Color.WhiteSmoke;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 10F);
            label.AutoSize = true;
            label.Location = new Point(422, 275);

            _numLostQuantity = new NumericUpDown();
            _numLostQuantity.Minimum = 1;
            _numLostQuantity.Maximum = Math.Max(1, _loan.Quantity);
            _numLostQuantity.Value = 1;
            _numLostQuantity.Location = new Point(625, 270);
            _numLostQuantity.Size = new Size(140, 26);
            _numLostQuantity.Font = new Font("Segoe UI", 10F);

            _btnMarkLost = new Button();
            _btnMarkLost.Text = "MARK AS LOST";
            _btnMarkLost.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _btnMarkLost.ForeColor = Color.White;
            _btnMarkLost.BackColor = Color.Firebrick;
            _btnMarkLost.FlatStyle = FlatStyle.Flat;
            _btnMarkLost.Location = new Point(422, 310);
            _btnMarkLost.Size = new Size(343, 42);
            _btnMarkLost.Click += btnMarkLost_Click;

            bool isActive = _loan.Status == "Active";
            label.Visible = isActive;
            _numLostQuantity.Visible = isActive;
            _btnMarkLost.Visible = isActive;
            panel1.Controls.Add(label);
            panel1.Controls.Add(_numLostQuantity);
            panel1.Controls.Add(_btnMarkLost);
            label.BringToFront();
            _numLostQuantity.BringToFront();
            _btnMarkLost.BringToFront();
        }

        private void btnMarkLost_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Mark " + (int)_numLostQuantity.Value + " item(s) as lost and charge their replacement cost?",
                    "Confirm lost equipment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return;

                if (LoansBLL.MarkLoanLost(_loan, (int)_numLostQuantity.Value))
                {
                    MessageBox.Show("Lost equipment recorded successfully.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to record lost equipment.");
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex);
            }
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
               
                bool unpaidLateFee = _loan.LateFee > 0 && _loan.FinePaid != true;
                bool unpaidReplacementFee = _loan.ReplacementFee > 0 && _loan.ReplacementPaid != true;
                if (!unpaidLateFee && !unpaidReplacementFee)
                    throw new Exceptions.BusinessRuleException("This loan has no unpaid fees.");

                frmpayment frmpayment = new frmpayment(_loan);
                frmpayment.ShowDialog();
                Close();
            }
            catch (Exception ex) 
            {
                ErrorHandler.Show(ex);
            }
        }
    }
}
