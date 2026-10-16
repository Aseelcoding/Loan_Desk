using BLL;
using Loan_Desk.Main_Screen;
using System;
using System.Windows.Forms;

namespace Loan_Desk
{
    public partial class frmLogin : Form
    {
        private short Tries = 3;

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
            Tries--;

            if (Tries == 0)
                Application.Exit();
        }
    }
}