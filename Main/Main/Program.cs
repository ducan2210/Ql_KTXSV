using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Form_Home mainForm = null;
        public static Form_DangNhap dnForm = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dnForm = new Form_DangNhap();
            Application.Run(dnForm);
           
        }
    }
}
