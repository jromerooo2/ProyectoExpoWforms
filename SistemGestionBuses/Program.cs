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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            Application.Run(new frmLogin());
=======
            Application.Run(new frmIngresoConductores(5));
>>>>>>> parent of 380952f (Merge branch 'dev' of https://github.com/jromerooo2/ProyectoExpoWforms into dev)
=======
            Application.Run(new frmTrack());
>>>>>>> 740e2659e2ada6c202d1a1785efbf67513930a9e
=======
            Application.Run(new frmLogin());
>>>>>>> parent of d829722 (..)
            //pasen siempre a frmLogin plis - Aviso Parroquial
            //new frmConfig(id_cargo, "username", id_usuario)
        }
    }
}
