using BLL;
using Loan_Desk.Main_Screen;
using Loan_Desk.Setup;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


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
            System.Windows.Forms.Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            System.Windows.Forms.Application.ThreadException += (s, e) => ErrorHandler.Show(e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (s, e) => Logger.Write(e.ExceptionObject as Exception);

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            bool adminExists;
            try
            {
                adminExists = UserBLL.IsAdminExist();
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex);
                return;
            }

            if (adminExists)
                System.Windows.Forms.Application.Run(new frmLogin());
            else
                System.Windows.Forms.Application.Run(new frmSetup());



        }
    }
}
