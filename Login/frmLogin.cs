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
using Loan_Desk.Main_Screen;
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
            {
                MessageBox.Show("Success");
                frmMainScreen frmMainScreen = new frmMainScreen();
                frmMainScreen.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Filed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            
        }
    }
}
