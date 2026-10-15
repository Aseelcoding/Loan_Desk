using BLL;
using LoanDesk.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Loan_Desk.Loans
{
    public partial class frmAddLoan : Form
    {
        private List<LoanDesk.Models.Borrower> ListBorrowers;
        private List<LoanDesk.Models.Equipment> ListEquipments;

        public frmAddLoan()
        {
            InitializeComponent();

            ListBorrowers = BorrowersBLL.GetAllBorrowersList();
            ListEquipments = EquipmentBLL.GetEquipmentList();

            cmbBorrowers.DataSource = ListBorrowers;
            cmbBorrowers.DisplayMember = "FullName";
            cmbBorrowers.ValueMember = "ID";
            cmbBorrowers.ItemHeight = 40;
            cmbEquipments.DataSource = ListEquipments;
            cmbEquipments.DisplayMember = "Name";
            cmbEquipments.ValueMember = "ID";
            cmbEquipments.ItemHeight = 40;
            cmbBorrowers.DrawMode = DrawMode.OwnerDrawFixed;
            cmbEquipments.DrawMode = DrawMode.OwnerDrawFixed;
        }

        
      

        private void cmbBorrowers_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            e.DrawBackground();

            Borrower borrower = cmbBorrowers.Items[e.Index] as Borrower;

            if (borrower == null)
                return;

            bool selected =
                (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            Brush textBrush = selected
                ? SystemBrushes.HighlightText
                : SystemBrushes.ControlText;

            e.Graphics.DrawString(
                borrower.FullName,
                e.Font,
                textBrush,
                e.Bounds.Left + 6,
                e.Bounds.Top + 4
            );

            Font detailsFont = new Font(e.Font.FontFamily, 8);
            e.Graphics.DrawString(
                "Borrower ID: " + borrower.ID,
                detailsFont,
                Brushes.RoyalBlue,
                e.Bounds.Left + 6,
                e.Bounds.Top + 24
            );

            string status = borrower.IsActive ? "Active" : "Inactive";

            Brush badgeBrush = borrower.IsActive
                ? Brushes.SeaGreen
                : Brushes.Red;

            SizeF badgeSize = e.Graphics.MeasureString(status, e.Font);

            float badgeX = e.Bounds.Right - badgeSize.Width - 18;
            float badgeY = e.Bounds.Top + 6;

            e.Graphics.DrawString(
                status,
                e.Font,
                badgeBrush,
                badgeX,
                badgeY
            );

            e.DrawFocusRectangle();
        }

        private void cmbEquipments_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            e.DrawBackground();

            LoanDesk.Models.Equipment equipment = cmbEquipments.Items[e.Index] as LoanDesk.Models.Equipment;

            if (equipment == null)
                return;

            bool selected =
                (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            Brush textBrush = selected
                ? SystemBrushes.HighlightText
                : SystemBrushes.ControlText;

            e.Graphics.DrawString(
                equipment.Name,
                e.Font,
              textBrush,
                e.Bounds.Left + 6,
                e.Bounds.Top + 4
            );

            Font detailsFont = new Font(e.Font.FontFamily, 8);

            e.Graphics.DrawString(
                "Equipment ID: " + equipment.ID,
                detailsFont,
                Brushes.RoyalBlue,
                e.Bounds.Left + 6,
                e.Bounds.Top + 24
            );

            string status = equipment.IsActive ? "Active" : "Inactive";

            Brush badgeBrush = equipment.IsActive
                ? Brushes.SeaGreen
                : Brushes.Red;

            SizeF badgeSize = e.Graphics.MeasureString(status, e.Font);

            float badgeX = e.Bounds.Right - badgeSize.Width - 18;
            float badgeY = e.Bounds.Top + 6;

            e.Graphics.DrawString(
                status,
                e.Font,
                badgeBrush,
                badgeX,
                badgeY
            );

            e.DrawFocusRectangle();
        }


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void cmbBorrowers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Borrower borrower=cmbBorrowers.SelectedItem as Borrower;
            
        }

        private void cmbEquipments_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoanDesk.Models.Equipment equipment=cmbEquipments.SelectedItem as LoanDesk.Models.Equipment;
            numAvailableQuantity.Value = equipment.AvailableQuantity;


        }

        private void numAvailableQuantity_ValueChanged(object sender, EventArgs e)
        {

            if (numAvailableQuantity.Value > 3)
                numQuantity.Maximum = 3;
            else
                numQuantity.Maximum = numAvailableQuantity.Value;



        }
    }
}