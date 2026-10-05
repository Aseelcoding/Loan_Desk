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
    public partial class frmUpdateUser : Form
    {
        LoanDesk.Models.User UpdateUser;
        public frmUpdateUser(LoanDesk.Models.User UpdateUser)
        {
            InitializeComponent();
            this.UpdateUser = UpdateUser;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            txtUserID.Text = UpdateUser.ID.ToString();
            txtUsername.Text = UpdateUser.Username.ToString();
           
            if (UpdateUser.Role == "Admin")
                RadbtnAdmin.Checked = true;
            else 
                RadbtnStaff.Checked = true;

            if (UpdateUser.IsActive)
                togIsActive.Toggled = true;
            else togIsActive.Toggled = false;

        }
    }
}
