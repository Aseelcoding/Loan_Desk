using BLL;
using Loan_Desk.Setup;
using System;
using System.Windows.Forms;

namespace Loan_Desk
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
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

                if (adminExists)
                    System.Windows.Forms.Application.Run(new frmLogin());
                else
                    System.Windows.Forms.Application.Run(new frmSetup());
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex);
                return;
            }
        }
    }
}