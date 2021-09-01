using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemGestionBuses
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal(int cargo)
        {
            InitializeComponent();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmUnidades unidades = new frmUnidades();
            unidades.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmIngresarViaje viajes = new frmIngresarViaje();
            viajes.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panelUsers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelUsers_Click(object sender, EventArgs e)
        {
            frmUsuarios users = new frmUsuarios();
            users.Show();
        }

        private void pictureUsers_Click(object sender, EventArgs e)
        {
            frmUsuarios users = new frmUsuarios();
            users.Show();
        }

        private void panelViajes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelViajes_Click(object sender, EventArgs e)
        {
            frmIngresarViaje viajes = new frmIngresarViaje();
            viajes.Show();
        }

        private void unidadesPanel_Click(object sender, EventArgs e)
        {
            frmUnidades unidades = new frmUnidades();
            unidades.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmIngresoCliente clientes = new frmIngresoCliente();
            clientes.Show();
        }

        private void panelClientes_Click(object sender, EventArgs e)
        {
            frmIngresoCliente clientes = new frmIngresoCliente();
            clientes.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmIngresoEmpleado empleado = new frmIngresoEmpleado();
            empleado.Show();
        }

        private void panelEmpleado_Click(object sender, EventArgs e)
        {
            frmIngresoEmpleado empleado = new frmIngresoEmpleado();
            empleado.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmMantenimientos mantenimientos = new frmMantenimientos();
            mantenimientos.Show();
        }

        private void panelMantenimientos_Click(object sender, EventArgs e)
        {
            frmMantenimientos mantenimientos = new frmMantenimientos();
            mantenimientos.Show();
        }
    }
}
