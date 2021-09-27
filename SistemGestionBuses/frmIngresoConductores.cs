using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace SistemGestionBuses
{
    public partial class frmIngresoConductores : Form
    {
        public static int id_empleado;

        public frmIngresoConductores(int pid_empleado)
        {            
            InitializeComponent();
            id_empleado = pid_empleado;
            ControladorIngreso.id_empleado = pid_empleado;
            string empleado = ControladorIngreso.CargarNombresConduc_Controller();
            txtId.Text = id_empleado.ToString();
            txtNombreConduc.Text = empleado;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
