using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C1_UI
{
    internal static class Program
    {/// <summary>
     /// Punto de entrada principal para la aplicación.
     /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenuPrincipal());*/

            Login fAcceso = new Login();

            if (fAcceso.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fAcceso.Close();
                Application.Run(new MenuPrincipal());
            }
        }
    }
}
