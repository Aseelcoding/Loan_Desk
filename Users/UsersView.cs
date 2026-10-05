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
    
    public partial class UsersView : UserControl
    {
        DataTable dtUsers;
        public UsersView()
        {
            InitializeComponent();
        }

        private void UsersView_Load(object sender, EventArgs e)
        {
            dtUsers = UserBLL.GetUsers();
            LoadUsersInfo("");
        }
        private void LoadUsersInfo(string Filter) 
        {
            dgvUsers.Rows.Clear();
            DataView dvUser=new DataView();
            dvUser = dtUsers.DefaultView;

            dvUser.RowFilter=Filter;

            foreach (DataRowView row in dvUser)
            {

                dgvUsers.Rows.Add(
                    row["ID"],
                    row["Username"],
                    row["Role"],
                    row["IsActive"]
                    );
            }

        }
        private void Filtering(string Text) 
        {
            if (string.IsNullOrEmpty(Text))
                {
                LoadUsersInfo("");
                    return; }

            string Filter = string.Empty;

            if (cbFilter.SelectedIndex == 0)
            {
                int USID = -1;
                int.TryParse(Text, out USID);
                Filter = $"ID = {USID} ";

            }
            else if (cbFilter.SelectedIndex == 1)
            {
                Filter = $"Username  like '{Text}%'";

                if (chActive.Checked && chInActive.Checked == false)
                {
                    Filter = $"Username  like '{Text}%' and IsActive =1";
                }
                else if (chActive.Checked == false && chInActive.Checked == true)
                {
                    Filter = $"Username  like '{Text}%' and IsActive =0";
                }
                else
                {
                    Filter = $"Username  like '{Text}%'";
                }
            }
            else if (cbFilter.SelectedIndex == 2)
            {
                if (chActive.Checked && chInActive.Checked == false)
                {
                    Filter = $"Role  like '{Text}%' and IsActive =1";
                }
                else if (chActive.Checked==false && chInActive.Checked == true)
                  {
                    Filter = $"Role  like '{Text}%' and IsActive =0";
                  }
                else
                {
                    Filter = $"Role  like '{Text}%'";
                }
            }

            LoadUsersInfo(Filter);

        }
        private void txtBarSearch_TextChanged(object sender, EventArgs e)
        {

            Filtering(txtBarSearch.Text);


        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser frmAddUser = new frmAddUser();
            DialogResult result= frmAddUser.ShowDialog();

            dtUsers = UserBLL.GetUsers();
            LoadUsersInfo(string.Empty);

            if (result == DialogResult.OK)
                notiSuccess.Visible = true;
           

        }

        private LoanDesk.Models.User GetSelectedRow() 
        {
            LoanDesk.Models.User user =new LoanDesk.Models.User();

            if (dgvUsers.SelectedRows.Count > 0) 
            {
                int USID = -1;
                int.TryParse(dgvUsers.SelectedRows[0].Cells["ID"].Value.ToString(), out USID);
                user.ID= USID;

               user.Username= dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();
                user.Role = dgvUsers.SelectedRows[0].Cells["Role"].Value.ToString();

               user.IsActive= (bool)dgvUsers.SelectedRows[0].Cells["IsActive"].Value;

                return user;
            }
            else
            {
                return null;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoanDesk.Models.User UpdateUser = GetSelectedRow();
            frmUpdateUser frmUpdateUser = new frmUpdateUser(UpdateUser);
            frmUpdateUser.ShowDialog();

            dtUsers = UserBLL.GetUsers();
            LoadUsersInfo(string.Empty);
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            frmUpdateUserPassword frmUpdateUserPassword = new frmUpdateUserPassword(GetSelectedRow());
            frmUpdateUserPassword.ShowDialog();

            dtUsers = UserBLL.GetUsers();
            LoadUsersInfo(string.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                LoanDesk.Models.User user= GetSelectedRow();

                if (user.IsActive == false )
                { MessageBox.Show("This user is already Inactive.");return; }

                UserBLL.DeleteUser(user);

                MessageBox.Show("User now is Inactive.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dtUsers = UserBLL.GetUsers();
            LoadUsersInfo(string.Empty);
        }

        private void chActive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
