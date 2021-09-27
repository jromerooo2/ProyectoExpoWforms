using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemGestionBuses
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmIngresoEmpleado());
            //pasen siempre a frmLogin plis - Aviso Parroquial
            //new frmConfig(id_cargo, "username", id_usuario)
        }
    }
}
