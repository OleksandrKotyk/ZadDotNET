using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadania
{
    static class Program
    {
        public static ApplicationContext apcon;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            apcon = new ApplicationContext(new doc3());
            Application.Run(apcon);
        }
    }
}
