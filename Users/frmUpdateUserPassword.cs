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
using static LoanDesk.Models.Exceptions;

namespace Loan_Desk.Users
{
    public partial class frmUpdateUserPassword : Form
    {
        LoanDesk.Models.User user=null;
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
                    { MessageBox.Show("Update user password done successfully");
                    this.Close(); }
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
