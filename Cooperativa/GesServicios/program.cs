using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GesServicios
{
    static class Program
    {  /// <summary>
       /// Punto de entrada principal para la aplicación.
       /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormsAuxiliares.frmLogin("SRV"));
            //Application.Run(new Form1());

        }
    }
}
