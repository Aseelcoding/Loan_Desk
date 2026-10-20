using BLL;
using LoanDesk.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Loan_Desk.Loans
{
    public partial class frmpayment : Form
    {
        private readonly Loan _loan;
        private Label _labLateFee;
        private Label _labReplacementFee;
        private Label _labTotalFee;

        public frmpayment(Loan loan)
        {
            InitializeComponent();
            _loan = loan;
            ConfigurePaymentSummary();
            LoadLoanPaymentInfo();
        }

        private void ConfigurePaymentSummary()
        {
            // The existing designer contains placeholder card fields, not a real payment gateway.
            foreverLabel1.Text = "BORROWER";
            foreverLabel2.Visible = false;
            foreverTextBox2.Visible = false;
            foreverTextBox3.Visible = false;
            foreverLabel5.Visible = false;
            labFee.Visible = false;
            btnConfirm.Text = "CONFIRM PAYMENT";
            btnCancel.Click += (sender, args) => Close();

            AddSummaryRow("Late fee:", 235, out _labLateFee);
            AddSummaryRow("Replacement fee:", 275, out _labReplacementFee);
            AddSummaryRow("Total due:", 325, out _labTotalFee);
            _labTotalFee.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            _labTotalFee.ForeColor = Color.GreenYellow;
        }

        private void AddSummaryRow(string caption, int y, out Label valueLabel)
        {
            Label captionLabel = new Label();
            captionLabel.Text = caption;
            captionLabel.AutoSize = true;
            captionLabel.BackColor = Color.Transparent;
            captionLabel.ForeColor = Color.WhiteSmoke;
            captionLabel.Font = new Font("Segoe UI", 11F);
            captionLabel.Location = new Point(180, y);
            lostPanel2.Controls.Add(captionLabel);

            valueLabel = new Label();
            valueLabel.Text = "0.00";
            valueLabel.AutoSize = true;
            valueLabel.BackColor = Color.Transparent;
            valueLabel.ForeColor = Color.WhiteSmoke;
            valueLabel.Font = new Font("Segoe UI", 11F);
            valueLabel.Location = new Point(420, y);
            lostPanel2.Controls.Add(valueLabel);
            captionLabel.BringToFront();
            valueLabel.BringToFront();
        }

        private void LoadLoanPaymentInfo()
        {
            try
            {
                if (_loan == null)
                    throw new Exceptions.ValidationException("Please choose a valid loan.");

                Borrower borrower = BorrowersBLL.GetBorrowerByID(_loan.BorrowerID);
                if (borrower == null)
                    throw new Exceptions.ValidationException("Borrower not found.");

                txtBorrowerName.Text = borrower.FullName;
                _labLateFee.Text = _loan.LateFee.ToString("N2");
                _labReplacementFee.Text = _loan.ReplacementFee.ToString("N2");
                _labTotalFee.Text = (_loan.LateFee + _loan.ReplacementFee).ToString("N2");

                bool hasUnpaidFee = (_loan.LateFee > 0 && _loan.FinePaid != true)
                    || (_loan.ReplacementFee > 0 && _loan.ReplacementPaid != true);
                btnConfirm.Enabled = hasUnpaidFee;
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex);
                Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoansBLL.PayFine(_loan))
                {
                    MessageBox.Show("Payment recorded successfully.");
                    Close();
                }
                else
                {
                    MessageBox.Show("Payment could not be recorded.");
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex);
            }
        }
    }
}
