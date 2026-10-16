using BLL;
using LoanDesk.Models;
using System;
using System.Windows.Forms;

namespace Loan_Desk.Equipment
{
    public partial class frmUpdateEquipment : Form
    {
        private LoanDesk.Models.Equipment OriginalEquipment;

        public frmUpdateEquipment(LoanDesk.Models.Equipment equipment)
        {
            InitializeComponent();
            OriginalEquipment = equipment;
            LoadEquipmentInfo();
        }

        private void LoadEquipmentInfo()
        {
            txtEquipmentID.Text = OriginalEquipment.ID.ToString();
            txtEquipmentName.Text = OriginalEquipment.Name;
            numTotalQuantity.Value = OriginalEquipment.TotalQuantity;
            numAvailableQuantity.Value = OriginalEquipment.AvailableQuantity;
            numDailyLateFee.Value = OriginalEquipment.DailyLateFee;
            numReplecmentCost.Value = OriginalEquipment.ReplacementCost;
        }

        private void CheckEquipmentInfo(LoanDesk.Models.Equipment equipment)
        {
            utilities.utilities.IsEmptyOrNullOrWhiteSpace(equipment.Name, "Equipment Name");
            if (equipment.DailyLateFee > equipment.ReplacementCost)
                throw new Exceptions.BusinessRuleException("Dailt late fee can not be greater than replecment cost.");
        }

        private void numTotalQuantity_ValueChanged(object sender, EventArgs e)
        {
            numAvailableQuantity.Maximum = numTotalQuantity.Value;
        }

        private void numAvailableQuantity_ValueChanged(object sender, EventArgs e)
        {
            numAvailableQuantity.Maximum = numTotalQuantity.Value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IsSameInfo(LoanDesk.Models.Equipment equipment)
        {
            if (equipment.Name == OriginalEquipment.Name &&
                equipment.TotalQuantity == OriginalEquipment.TotalQuantity &&
                equipment.AvailableQuantity == OriginalEquipment.AvailableQuantity &&
                equipment.DailyLateFee == OriginalEquipment.DailyLateFee &&
                equipment.ReplacementCost == OriginalEquipment.ReplacementCost
                )
            {
                throw new Exceptions.BusinessRuleException("You did not change any info,\nif you do not want to continue just close the page");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool IsUpdated = false;
            var Equipment = new LoanDesk.Models.Equipment();
            Equipment.ID = OriginalEquipment.ID;
            Equipment.Name = txtEquipmentName.Text;
            Equipment.TotalQuantity = (int)numTotalQuantity.Value;
            Equipment.AvailableQuantity = (int)numAvailableQuantity.Value;
            Equipment.DailyLateFee = numDailyLateFee.Value;
            Equipment.ReplacementCost = numReplecmentCost.Value;
            Equipment.IsActive = OriginalEquipment.IsActive;

            try
            {
                IsSameInfo(Equipment);
                CheckEquipmentInfo(Equipment);
                IsUpdated = EquipmentBLL.UpdateEquipment(Equipment);

                if (IsUpdated)
                {
                    MessageBox.Show("Success");
                    this.Close();
                }
                else
                    MessageBox.Show("Failed");
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex);
            }
        }
    }
}