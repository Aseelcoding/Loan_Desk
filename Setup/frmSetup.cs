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
using System.Xml.Schema;

namespace Loan_Desk.Setup
{
    public partial class frmSetup : Form
    {
        public frmSetup()
        {
            InitializeComponent();
          
        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // one number or symbol :
            if (utilities.utilities.IsStringContainSymbol(txtPassword.Text) || utilities.utilities.IsDigit(txtPassword.Text))
                chSymbol.Checked = true;
            else
                chSymbol.Checked = false;
            //one uppuercase letter :
            if(utilities.utilities.IsStringContainUpper(txtPassword.Text))
            chUpper.Checked = true;
            else
              chUpper.Checked = false;
            // at leasr 5 char long :
            if (txtPassword.Text.Length>=5)
                chLong.Checked= true;
            else
                chLong.Checked = false;

            if (chLong.Checked == true && chSymbol.Checked == true && chUpper.Checked == true)
            {
                chPassword.Checked = true;
            }
            else
                chPassword.Checked = false;

        }

        private void txtPasswordConfirm_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text==txtPasswordConfirm.Text)
                chPasswordConfirm.Checked = true;
            else 
                chPasswordConfirm.Checked = false;
        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
         
            if (String.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter a valid username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
         
            if (chPassword.Checked == true && chPasswordConfirm.Checked == true)
            {
                User NewAdmin = new User();
                NewAdmin.Username = txtUsername.Text;
                NewAdmin.Role = "Admin";
                NewAdmin.IsActive= true;
                try
                {
                    
                    if(UserBLL.AddNewUser(NewAdmin,txtPassword.Text))
                    {MessageBox.Show("New Admin Has Been Added To The System.\nNow this windwo will be closed.");
                        this.Close();
                    }
                }
               catch (Exception ex) 
                {
                    ErrorHandler.Show(ex);
                }

            }
        }

    }
}
