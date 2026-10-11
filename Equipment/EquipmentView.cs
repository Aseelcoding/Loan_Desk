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

namespace Loan_Desk.Equipment
{
    public partial class EquipmentView : UserControl
    {
        public EquipmentView()
        {
            InitializeComponent();
        }
        DataTable dtEq;
        private void RefreshData() 
        {
            try 
            {
                dtEq = EquipmentBLL.GetEquipments();
                LoadEquipmentInfo();
            }
            catch(Exception ex) 
            {
                ErrorHandler.Show(ex);
            }

        }
        private void LoadEquipmentInfo(string Filter = "") 
        {
            dgvEq.Rows.Clear();
            DataView dvEq = dtEq.DefaultView;

            dvEq.RowFilter = Filter;

            foreach(DataRowView row in dvEq) 
            {
                dgvEq.Rows.Add
                    (
                    row["ID"],
                    row["Name"],
                    row["TotalQuantity"],
                    row["AvailableQuantity"],
                    row["DailyLateFee"],
                    row["ReplacementCost"],
                    row["IsActive"]);
            }
        }
        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            frmAddNewEquipment frmAddNewEquipment = new frmAddNewEquipment();
            frmAddNewEquipment.ShowDialog();
            RefreshData();
        }

        private void EquipmentView_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private LoanDesk.Models.Equipment GetSelectedRow() 
        {
            if (dgvEq.SelectedRows.Count > 0)
            {
                int EQUID = -1;
                int.TryParse(dgvEq.SelectedRows[0].Cells["ID"].Value.ToString(), out EQUID);
                int Totalqun = -1;
                int.TryParse(dgvEq.SelectedRows[0].Cells["TotalQuantity"].Value.ToString(), out Totalqun);
                int AvaliableQun = -1;
                int.TryParse(dgvEq.SelectedRows[0].Cells["AvailableQuantity"].Value.ToString(), out AvaliableQun);
                decimal _ReplecmentCost = -1;
                decimal.TryParse(dgvEq.SelectedRows[0].Cells["ReplacementCost"].Value.ToString(), out _ReplecmentCost);

                decimal _DailyLateFee = -1;
                decimal.TryParse(dgvEq.SelectedRows[0].Cells["DailyLateFee"].Value.ToString(), out _DailyLateFee);
                bool _IsActive = (bool)dgvEq.SelectedRows[0].Cells["IsActive"].Value;

                return new LoanDesk.Models.Equipment
                {
                    ID = EQUID,
                    Name = dgvEq.SelectedRows[0].Cells["EquipmentName"].Value.ToString(),
                    TotalQuantity = Totalqun,
                    AvailableQuantity = AvaliableQun,
                    ReplacementCost = _ReplecmentCost,
                    DailyLateFee = _DailyLateFee,
                    IsActive= _IsActive
                };
            }
            else
                return null;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                LoanDesk.Models.Equipment equipment = GetSelectedRow();
                if (equipment == null)
                {
                    MessageBox.Show("Please choose a valid row.");
                    return;
                }
                var frmUpdateEquipment = new frmUpdateEquipment(equipment);
                frmUpdateEquipment.ShowDialog();
                RefreshData();
            }
            catch(Exception ex) 
            {
                ErrorHandler.Show(ex);
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            bool IsActivated=false;
            try 
            {
                LoanDesk.Models.Equipment equipment = GetSelectedRow();
                if (equipment.IsActive)
                    throw new Exceptions.BusinessRuleException("The equipment is already Activated.");
                IsActivated = EquipmentBLL.ActivateEquipment(equipment.ID);
                if (IsActivated)
                    { MessageBox.Show("Success");
                    RefreshData();
                }
                else
                    MessageBox.Show("Failed");
            }
            catch(Exception ex) 
            {
                ErrorHandler.Show(ex);
            }

        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            bool IsDeactivated = false;
            try
            {
                LoanDesk.Models.Equipment equipment = GetSelectedRow();
                if (equipment.IsActive==false)
                    throw new Exceptions.BusinessRuleException("The equipment is already Deactivated.");
                IsDeactivated = EquipmentBLL.DeactivateEquipment(equipment.ID);
                if (IsDeactivated)
                    { MessageBox.Show("Success"); RefreshData(); }
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
   




   