using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobInvoicerCS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);  
            //SplashForm.ShowSplashScreen();
            //var form1 = new MainForm(); //this takes ages
            //SplashForm.CloseForm();
            Application.Run(new MainForm());
        }
    }
}
