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

namespace Loan_Desk.Users
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close  ();

             
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool IsAdded = false;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Enter a valid username please.");
                txtUsername.Focus();
                return;
            }

            if(string.IsNullOrEmpty(txtPassword.Text))
               { MessageBox.Show("Enter a valid password please.");
                txtPassword.Focus();
                return;
            }
            

            LoanDesk.Models.User NewUser = new LoanDesk.Models.User();
            NewUser.Username = txtUsername.Text;

            if (RadbtnAdmin.Checked)
                NewUser.Role = "Admin";
            else
                NewUser.Role = "Staff";

            if(togIsActive.Toggled==true)
                NewUser.IsActive = true;
            else 
                NewUser.IsActive=false;

            


            try
            {
                IsAdded = UserBLL.AddNewUser(NewUser, txtPassword.Text);
                if (IsAdded)
                    MessageBox.Show("User Added successfully");
                else
                    MessageBox.Show("User Added Failed");

               

               
            
            }
            catch
            {
                MessageBox.Show(
   "An unexpected error occurred.\nPlease contact your system manager for assistance.",
   "System Error",
   MessageBoxButtons.OK,
   MessageBoxIcon.Error
);
            }

            if(IsAdded)
            {
               this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

    }
}
