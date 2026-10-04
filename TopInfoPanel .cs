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

namespace Loan_Desk
{
    public partial class CustomPanel : UserControl
    {
        public CustomPanel()
        {
            InitializeComponent();
         
           
        }

        public string Title
        {
            get { return labTitle.Text; }
            set { labTitle.Text = value; }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

            Form Accfrm = new Form();
          
            Account.AccountView accountView = new Account.AccountView();
           
            Accfrm.MinimumSize = accountView.MinimumSize;
            Accfrm.MaximumSize = accountView.MaximumSize;
            Accfrm.StartPosition = FormStartPosition.CenterScreen;
           accountView.Dock= DockStyle.Fill;
            Accfrm.Controls.Add(accountView);
            Accfrm.ShowDialog();

        }

        private void CustomPanel_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            labAdOrStf.Text = Sessions.CurrentUser.Role;
        }
    }
}
