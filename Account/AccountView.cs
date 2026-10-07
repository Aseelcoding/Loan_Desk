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

namespace Loan_Desk.Account
{
    public partial class AccountView : UserControl
    {
        public AccountView()
        {
            InitializeComponent();
        }

        private void AccountView_Load(object sender, EventArgs e)
        {
            if (Sessions.CurrentUser == null)
                return;

                txtUserID.Text = Sessions.CurrentUser.ID.ToString();
            txtUsername.Text = Sessions.CurrentUser.Username;
            if(Sessions.CurrentUser.Role=="Admin")
                chAdmin.Checked = true;
            else 
                chStaff.Checked = true;

            if(Sessions.CurrentUser.IsActive==true)
                togIsActive.Toggled = true;

            else togIsActive.Toggled = false;

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserBLL.RestartRequired = true;
            if (UserBLL.RestartRequired)
            {
                UserBLL.RestartRequired = false;

                UserBLL.Logout();

                Application.Restart();

            }
        }

    }
}
