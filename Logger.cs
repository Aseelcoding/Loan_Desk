using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Desk
{
    public class Logger
    {
     
             
            private static readonly string LogDirectory = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "LoanDesk"
            );

            private static readonly string LogFilePath = Path.Combine(LogDirectory, "app_log.txt");

            public static void Write(Exception ex)
            {
                try
                { 
                    if (!Directory.Exists(LogDirectory))
                    {
                        Directory.CreateDirectory(LogDirectory);
                    }
                     
                    string logEntry = "----------------------------------------\r\n" +
                                      $"Date/Time : {DateTime.Now:yyyy-MM-dd HH:mm:ss}\r\n" +
                                      $"Exception : {ex.GetType().FullName}\r\n" +
                                      $"Message   : {ex.Message}\r\n" +
                                      $"Source    : {ex.Source}\r\n" +
                                      $"StackTrace:\r\n{ex.StackTrace}\r\n" +
                                      "----------------------------------------\r\n\n";

                   
                    File.AppendAllText(LogFilePath, logEntry);
                }
                catch (Exception writeEx)
                {
                 
                    MessageBox.Show($"Could not write to log file: {writeEx.Message}", "Log Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }

