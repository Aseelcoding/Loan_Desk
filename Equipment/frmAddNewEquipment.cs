using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoanDesk.Models;
using System.Globalization;
using BLL;

namespace Loan_Desk.Equipment
{
    public partial class frmAddNewEquipment : Form
    {
        public frmAddNewEquipment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckEquipmentInfo(LoanDesk.Models.Equipment equipment)
        {
            utilities.utilities.IsEmptyOrNullOrWhiteSpace(equipment.Name, "Equipment Name");
            if (equipment.DailyLateFee > equipment.ReplacementCost)
                throw new Exceptions.BusinessRuleException("Dailt late fee can not be greater than replecment cost.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool IsAdded = false;
            LoanDesk.Models.Equipment NewEquipment = new LoanDesk.Models.Equipment();

            NewEquipment.Name = txtEquipmentName.Text;
            NewEquipment.TotalQuantity = (int)numTotalQuantity.Value;
            NewEquipment.AvailableQuantity = (int)numAvailableQuantity.Value;
            NewEquipment.DailyLateFee = numDailyLateFee.Value;
            NewEquipment.ReplacementCost = numReplecmentCost.Value;
            NewEquipment.IsActive = togIsActive.Toggled;

            try
            {
                CheckEquipmentInfo(NewEquipment);
                IsAdded = EquipmentBLL.AddEquipment(NewEquipment);

                if (IsAdded)
                    MessageBox.Show("Success");
                else
                    MessageBox.Show("Failed");
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex);
            }
        }

        private void numTotalQuantity_ValueChanged(object sender, EventArgs e)
        {
            numAvailableQuantity.Maximum = numTotalQuantity.Value;
        }

        private void numAvailableQuantity_ValueChanged(object sender, EventArgs e)
        {
            numAvailableQuantity.Maximum = numTotalQuantity.Value;
        }
    }
}