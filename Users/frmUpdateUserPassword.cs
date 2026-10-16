using BLL;
using System;
using System.Windows.Forms;

namespace Loan_Desk.Users
{
    public partial class frmUpdateUserPassword : Form
    {
        private LoanDesk.Models.User user = null;

        public frmUpdateUserPassword(LoanDesk.Models.User user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool IsUpdated = false;
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Please confirm the password");
                return;
            }
            try
            {
                IsUpdated = UserBLL.UpdateUserPassword(user.ID, txtOldPassword.Text, txtNewPassword.Text);
                if (IsUpdated)
                {
                    MessageBox.Show("Update user password done successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update user password Failed");
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex);
            }
        }
    }
}