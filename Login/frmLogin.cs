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


            try
            {
                if (UserBLL.Login(txtUsername.Text, txtPassword.Text))
                {
                    MessageBox.Show("Success");

                    this.Hide();

                    frmMainScreen frmMainScreen = new frmMainScreen();
                    frmMainScreen.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Failed",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                }
            }

            catch (Exception ex) 
            {
                ErrorHandler.Show(ex);
            }
            
        }

      
    }
}
