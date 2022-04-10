using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS_Y2_S1
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
            Application.Run(new frmLogin());
            //Application.Run(new frmLstView());
            //Application.Run(new frmLstBox());
            //Application.Run(new frmdgvStudent());
           //Application.Run(new frmTableLayoutPanelGetFile());
            
        }
    }
}
