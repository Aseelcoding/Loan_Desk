using BLL;
using Loan_Desk.Dashboard;
using Loan_Desk.Fines;
using Loan_Desk.Loans;
using Loan_Desk.Returns;
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

namespace Loan_Desk.Main_Screen
{
    public partial class frmMainScreen : Form
    {
       

        public frmMainScreen()
        {
            InitializeComponent();
         
         this.PanleTopInfo.Title = "Dashboard View";
            DashboardView dashboardView = new DashboardView();
            ContentPanel.Controls.Add(dashboardView);
        }
        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            if (Sessions.CurrentUser.Role != "Admin")
            {btnUsers.Enabled = false;
                btnUsers.Visible = false;
                btnAuditLog.Enabled = false;
                btnAuditLog.Visible = false;
            }
            else
            {
                btnUsers.Enabled = true;
                btnUsers.Visible = true;
                btnAuditLog.Enabled = true;
                btnAuditLog.Visible = true;
            }




        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardView dashboardView = new DashboardView();
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(dashboardView);
            this.PanleTopInfo.Title = "Dashboard View";
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            
            ContentPanel.Controls.Clear();
            if (Sessions.CurrentUser.Role != "Admin" )
                return;

            Users.UsersView usersView = new Users.UsersView();
            ContentPanel.Controls.Add(usersView);
            this.PanleTopInfo.Title = "Users View";
        }

        private void btnBorrowers_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
           Borrowers.BorrowersView borrowersView = new Borrowers.BorrowersView();
            ContentPanel.Controls.Add(borrowersView);
            PanleTopInfo.Title = "Borrowers View";
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            Equipment.EquipmentView equipmentView = new Equipment.EquipmentView();
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(equipmentView);
            this.PanleTopInfo.Title = "Equipment View";
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            Loans.LoansView loansView = new Loans.LoansView();
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(loansView);
            this.PanleTopInfo.Title = "Loans View";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Returns.ReturnsView returnsView = new Returns.ReturnsView();
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(returnsView);
            this.PanleTopInfo.Title = "Returns View";
        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            Fines.FinesView finesView = new Fines.FinesView();
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(finesView);
            this.PanleTopInfo.Title = "Fines View";
        }

        private void btnAuditLog_Click(object sender, EventArgs e)
        {
          
            ContentPanel.Controls.Clear();
            if (Sessions.CurrentUser.Role != "Admin")
                return;

            AuditLog.AuditLogView auditLogView = new AuditLog.AuditLogView();
            ContentPanel.Controls.Add(auditLogView);
            this.PanleTopInfo.Title = "Audit Log View";
        }

        
    }
}
