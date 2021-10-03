using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using System.Windows.Forms;

namespace SistemGestionBuses
{
    public partial class frmPrincipal : Form
    {
        public static string usuario;
        public static int cargouser;
        public static int idUser;


        public frmPrincipal(int cargo, string user, int idlogged)
        {
            InitializeComponent();

            usuario = user;
            cargouser = cargo;
            idUser = idlogged;
            txtActiveUser.Text = usuario;
            string cargostring = ControladorLogin.getCargostring(cargouser);
            txtCargoStrip.Text = cargostring;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmUnidades unidades = new frmUnidades();
            unidades.Show();
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmIngresarViaje viajes = new frmIngresarViaje();
            viajes.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "¡Bienvenido " +usuario+ "!";
            if (cargouser  == 1)
            {
                cardUsers.Enabled = false;
                cardEmpleado.Enabled = false;
                cardClientes.Enabled = false;
                cardReportes.Enabled = false;
            }
        }

        private void pictureUsers_Click(object sender, EventArgs e)
        {
            frmUsuarios users = new frmUsuarios(cargouser, idUser);
            users.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmIngresoCliente clientes = new frmIngresoCliente();
            clientes.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmIngresoEmpleado empleado = new frmIngresoEmpleado();
            empleado.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmMantenimientos mantenimientos = new frmMantenimientos();
            mantenimientos.Show();
        }

        private void cardUsers_Click(object sender, EventArgs e)
        {
            frmUsuarios users = new frmUsuarios(cargouser, idUser);
            users.Show();
        }

        private void bunifuCards1_Click(object sender, EventArgs e)
        {
                frmUnidades unidades = new frmUnidades();
                unidades.Show();
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards3_Click(object sender, EventArgs e)
        {
            frmIngresoEmpleado empleado = new frmIngresoEmpleado();
            empleado.Show();
        }

        private void cardClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            frmReportes reportes = new frmReportes();
            reportes.Show();
        }

        private void cardClientes_Click(object sender, EventArgs e)
        {
            frmIngresoCliente clientes = new frmIngresoCliente();
            clientes.Show();
        }

        private void cardMantenimientos_Click(object sender, EventArgs e)
        {
            frmMantenimientos mantenimientos = new frmMantenimientos();
            mantenimientos.Show();
        }

        private void bunifuCards2_Click(object sender, EventArgs e)
        {
            frmIngresarViaje viajes = new frmIngresarViaje();
            viajes.Show();
        }

        private void cardUsers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void logOut()
        {
            ControladorLogin.LogOut(idUser);
            Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardReportes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardReportes_Click(object sender, EventArgs e)
        {
            frmReportes reportes = new frmReportes();
            reportes.Show();
        }

        private void bunifuCards6_Click(object sender, EventArgs e)
        {
            frmViajesActivos next = new frmViajesActivos();
            next.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            frmViajesActivos next = new frmViajesActivos();
            next.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            logOut();
        }
    }
}
