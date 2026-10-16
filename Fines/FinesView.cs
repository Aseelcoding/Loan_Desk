using System.Windows.Forms;
using utilities;

namespace Loan_Desk.Fines
{
    public partial class FinesView : UserControl
    {
        public FinesView()
        {
            InitializeComponent();
            DataGridViewHelper.StyleDataGridView(dgvF);
        }
    }
}