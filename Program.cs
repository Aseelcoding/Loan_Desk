using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Loan_Desk.Setup;
using BLL;


namespace Loan_Desk
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(!UserBLL.IsAdminExist())
            Application.Run(new frmSetup());
            else 
            Application.Run(new frmLogin());
        }
    }
}
