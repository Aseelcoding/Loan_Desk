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

           

        }

        private bool IsSameInfo(LoanDesk.Models.User NewUser)
        {
            bool IsSame = false;

            if (NewUser.Username == UpdateUser.Username
                && NewUser.Role == UpdateUser.Role
                
                )
                IsSame = true;



            return IsSame;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool IsUpdated = false;
            LoanDesk.Models.User NewUser=new LoanDesk.Models.User();

            NewUser.ID= UpdateUser.ID;
            NewUser.Username = txtUsername.Text;

            if (RadbtnAdmin.Checked)
                NewUser.Role = "Admin";
            else
                NewUser.Role = "Staff";


            if (IsSameInfo(NewUser))
              { MessageBox.Show("You did not change any info so this window will be closed.");
                this.Close();
                return;
            }
            else
            {
                ///here we will call the update function:

                try
                {
                    IsUpdated = UserBLL.UpdateUser(NewUser);
                    if (UserBLL.NeedToRestart) 
                    {
                        UserBLL.NeedToRestart = false;


                     
                        Application.Restart();

                    }
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }


            if (IsUpdated)
               { MessageBox.Show("Update user done successfully"); this.Close(); }
            else
                MessageBox.Show("Failed to update user.");

         
        }
    }
}
