using System.Drawing;
using System.Windows.Forms;

namespace utilities
{
    public class DataGridViewHelper
    {
        public static void StyleDataGridView(DataGridView dgv)
        {
            // General appearance
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.FromArgb(230, 233, 237);

            // Remove default borders and visual effects
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowHeadersVisible = false;

            // Column headers
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(52, 73, 94);

            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgv.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            // Rows
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(45, 52, 60);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 231, 241);

            dgv.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(35, 45, 55);

            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(246, 248, 250);

            // Remove unnecessary visual states
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            // Keep the existing sizing unchanged
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
        }
    }
}