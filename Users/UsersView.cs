using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utilities;

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
        private void Filtering(string Text,string TextFilterIsActive) 
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

                if (chActive.Checked && chInActive.Checked == false)
                {
                    Filter = $"ID = {USID} and IsActive =1";
                }
                else if (chActive.Checked == false && chInActive.Checked == true)
                {
                    Filter = $"ID = {USID} and IsActive =0";
                }

            }
            else if (cbFilter.SelectedIndex == 1)
            {
                Filter = $"Username  like '{Text}%' and {TextFilterIsActive}";

                
            }
            else if (cbFilter.SelectedIndex == 2)
            {
                Filter = $"Role  like '{Text}%' and {TextFilterIsActive}";
            }

            LoadUsersInfo(Filter);

        }
        private void txtBarSearch_TextChanged(object sender, EventArgs e)
        {
            string Text = txtBarSearch.Text;
            string TextFilterIsActive = "";
            Text = utilities.utilities.ClearFilterString(Text);

            if (cbFilter.SelectedIndex != 0) 
            {
                if (chActive.Checked && !string.IsNullOrEmpty(Text) && chInActive.Checked == false)
                    TextFilterIsActive = "IsActive = 1";
                else if (chInActive.Checked && !string.IsNullOrEmpty(Text) && chActive.Checked == false)
                    TextFilterIsActive = "IsActive = 0";
                else
                    TextFilterIsActive = "1=1";
            }

            

            
            Filtering(Text, TextFilterIsActive);


        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser frmAddUser = new frmAddUser();
            DialogResult result= frmAddUser.ShowDialog();

            dtUsers = UserBLL.GetUsers();
            LoadUsersInfo(string.Empty);

            
           

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

            if (UpdateUser == null)
            {
                MessageBox.Show("Please choose a valid row.");
                return;
            }
            frmUpdateUser frmUpdateUser = new frmUpdateUser(UpdateUser);
            frmUpdateUser.ShowDialog();

            dtUsers = UserBLL.GetUsers();
            LoadUsersInfo(string.Empty);
        }
        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {

            LoanDesk.Models.User user = GetSelectedRow();
            if (user == null)
            {
                MessageBox.Show("Please choose a vlid row.");
                return;
            }
            frmUpdateUserPassword frmUpdateUserPassword = new frmUpdateUserPassword(user);
            frmUpdateUserPassword.ShowDialog();

            dtUsers = UserBLL.GetUsers();
            LoadUsersInfo(string.Empty);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool IsDeleted = false;

            try
            {
                LoanDesk.Models.User user= GetSelectedRow();

                if (user == null)
                {
                    MessageBox.Show("Please choose a valid row.");
                    return;
                }

                if (user.IsActive == false )
                { MessageBox.Show("This user is already Inactive.");return; }

                IsDeleted=UserBLL.DeleteUser(user);
                if(IsDeleted)
                MessageBox.Show("User now is Inactive.");
                else
                {
                    MessageBox.Show("User could not be Inactivated.");
                }
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
        private void btnActivate_Click(object sender, EventArgs e)
        {
            bool IsActicated = false;
            LoanDesk.Models.User user = GetSelectedRow();
            try
            {
                if (user == null)
                {
                    MessageBox.Show("Please choose a valid row.");
                    return;
                }

                if (user.IsActive == true)
                { MessageBox.Show("This user is already Active."); return; }

                IsActicated = UserBLL.ActivateUser(user.ID);
               
                if(IsActicated)
                    MessageBox.Show("User now is Active.");
                else
                {
                    MessageBox.Show("User could not be Activated.");
                }
            }
            catch (SqlException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            dtUsers = UserBLL.GetUsers();
            LoadUsersInfo(string.Empty);
        }
    }
}
