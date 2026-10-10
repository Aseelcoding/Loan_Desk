using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LoanDesk.Models.Exceptions;

namespace Loan_Desk
{
    internal class ErrorHandler
    {
    
            public static void Show(Exception ex, string title = "Loan Desk")

            {
            if (ex is ValidationException || ex is BusinessRuleException)
            {
                // User-level errors: shown as-is, not logged
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ex is DataAccessException)
            {
                
                MessageBox.Show(ex.Message + "\n\nIf this keeps happening, contact the administrator.",
                title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Anything unexpected: never show its raw message to the user
                
                MessageBox.Show("Something unexpected went wrong. The details were saved to the log file.",
                title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

