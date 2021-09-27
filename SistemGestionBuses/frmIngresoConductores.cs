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
        DataTable datosConductores;

        public frmIngresoConductores(int pid_empleado)
        {            
            InitializeComponent();
            id_empleado = pid_empleado;
            ControladorIngreso.id_empleado = pid_empleado;
            string empleado = ControladorIngreso.CargarNombresConduc_Controller();
            txtId.Text = id_empleado.ToString();
            txtNombreConduc.Text = empleado;
            CargarGridDatos();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void CargarGridDatos()
        {
            datosConductores = ControladorIngreso.CargarConductores_Controller();
            dgvConductores.DataSource = datosConductores;
            dgvConductores.Columns[0].HeaderText = "Empleado";
            dgvConductores.Columns[1].HeaderText = "Licencia";
            dgvConductores.Columns[2].HeaderText = "F.Expiración";
            dgvConductores.Columns[3].HeaderText = "Tipo Licencia";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtLicencia.Text.Trim() == "")
            {

            }
        }
    }
}
