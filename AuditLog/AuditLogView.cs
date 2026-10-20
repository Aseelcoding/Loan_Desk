using System.Windows.Forms;
using System.Data;
using BLL;

namespace Loan_Desk.AuditLog
{
    public partial class AuditLogView : UserControl
    {
        DataTable dtAuditLog;

        public AuditLogView()
        {
            InitializeComponent();
            RefreshData();
        }
        private void LoadAuditLogInfo(string Filter="") 
        {
            dgvAuditLog.Rows.Clear();

            // 3. المرور على كل صف في الجدول وإضافته يدوياً
            foreach (DataRow row in dtAuditLog.Rows)
            {
                dgvAuditLog.Rows.Add(
                    row["ID"],
                    row["UserID"],
                    row["ActionDate"],
                    row["Action"],
                    row["EntityType"],
                    row["EntityID"],
                    row["Details"]
                );
            }

        }
        private void RefreshData() 
        {
            dtAuditLog=AuditLogBLL.GetAllAuditLog();
            LoadAuditLogInfo();
        }
    }
}