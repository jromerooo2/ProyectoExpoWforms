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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        public DataTable datosCond;
        public ControladorEmpleado objCond;

        private void CargarEmpleados()
        {

        //cmb Cargar Cargo
            try
            {
                DataTable dataCargo = ControladorUsuario.ObtenerEmpleado();
                cmbEmpleado.DataSource = dataCargo;
                cmbEmpleado.DisplayMember = "nombres_empleado";
                cmbEmpleado.ValueMember = "id_empleado";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los cargo.", "Error de carga.",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        

    }
    }
}
