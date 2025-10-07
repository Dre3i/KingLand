using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            Application.Run(new LOGIN());
            Application.Run(new SALES_TEAM());
            Application.Run(new PURCHASE_DEPARTMENT());
            Application.Run(new LOGISTIC_TEAM());
            Application.Run(new ADMIN_OWNER());




        }
    }
}
