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
    }
}
