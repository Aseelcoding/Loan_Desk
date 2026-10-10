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
    public partial class frmUpdateUser : Form
    {
        LoanDesk.Models.User originalUser;
        public frmUpdateUser(LoanDesk.Models.User UpdateUser)
        {
            InitializeComponent();
            this.originalUser = UpdateUser;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            txtUserID.Text = originalUser.ID.ToString();
            txtUsername.Text = originalUser.Username.ToString();
           
            if (originalUser.Role == "Admin")
                RadbtnAdmin.Checked = true;
            else 
                RadbtnStaff.Checked = true;

           

        }

        private bool IsSameInfo(LoanDesk.Models.User NewUser)
        {
            bool IsSame = false;

            if (NewUser.Username == originalUser.Username
                && NewUser.Role == originalUser.Role
                
                )
                IsSame = true;



            return IsSame;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            LoanDesk.Models.User newUser = new LoanDesk.Models.User
            {
                ID = originalUser.ID,
                Username = txtUsername.Text.Trim(),
                Role = RadbtnAdmin.Checked ? "Admin" : "Staff",
                IsActive = originalUser.IsActive
            };

            if (IsSameInfo(newUser))
            {
                MessageBox.Show("You did not change any info so this window will be closed.");
                this.Close();
                return;
            }

            bool isUpdated;
            try
            {
                isUpdated = UserBLL.UpdateUser(newUser);
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex);
                return;
            }

            if (!isUpdated)
            {
                MessageBox.Show("Failed to update user.");
                return;
            }

            MessageBox.Show("Update user done successfully");

            if (UserBLL.RestartRequired)
            {
                Application.Restart();
                return;
            }

            this.Close();
        }
    }
}
