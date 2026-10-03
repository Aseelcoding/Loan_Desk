using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using LoanDesk.Models;
namespace Loan_Desk
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            User CurrentUser=new User();
            if (UserBLL.Login(txtUsername.Text, txtPassword.Text))
                MessageBox.Show("Success");
            else
                MessageBox.Show("Filed");

            
        }
    }
}
