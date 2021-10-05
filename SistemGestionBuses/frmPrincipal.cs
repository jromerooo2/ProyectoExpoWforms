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
        public static string cargostring;


        public frmPrincipal(int cargo, string user, int idlogged)
        {
            InitializeComponent();

            usuario = user;
            cargouser = cargo;
            idUser = idlogged;
            txtActiveUser.Text = usuario;
            cargostring = ControladorLogin.getCargostring(cargouser);
            txtCargoStrip.Text = cargostring;
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmUnidades"))
            {
                frmUnidades unidades = new frmUnidades();
                unidades.Show();
            }

        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmIngresarViaje"))
            {
                frmIngresarViaje viajes = new frmIngresarViaje(cargouser, idUser, cargostring, usuario);
                viajes.Show();
            }
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
            if (!checkFrmsOpen("frmUsuarios"))
            {
                frmUsuarios ingresusuario = new frmUsuarios(cargouser, idUser, cargostring, usuario);
                ingresusuario.Show();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmIngresoCliente"))
            {
                frmIngresoCliente clientes = new frmIngresoCliente(usuario, cargostring, cargouser, idUser);
                clientes.Show();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmIngresoEmpleado"))
            {
                frmIngresoEmpleado empleado = new frmIngresoEmpleado(usuario, cargostring, cargouser, idUser);
                empleado.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmMantenimientos"))
            {
                frmMantenimientos mantenimientos = new frmMantenimientos();
                mantenimientos.Show();
            }
        }

        private void cardUsers_Click(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmUsuarios"))
            {
                frmUsuarios users = new frmUsuarios(cargouser, idUser, cargostring, usuario);
                users.Show();
            }

        }

        private void bunifuCards1_Click(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmUnidades"))
            {
                frmUnidades unidades = new frmUnidades();
                unidades.Show();
            }
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards3_Click(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmIngresoEmpleado"))
            {
                frmIngresoEmpleado empleado = new frmIngresoEmpleado(usuario, cargostring, cargouser, idUser);
                empleado.Show();
            }

        }

        private void cardClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmReportes"))
            {
                frmReportes reportes = new frmReportes(usuario, cargostring, cargouser, idUser);
                reportes.Show();
            }

        }

        private void cardClientes_Click(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmIngresoCliente"))
            {
                frmIngresoCliente clientes = new frmIngresoCliente(usuario, cargostring, cargouser, idUser);
                clientes.Show();
            }
        }

        private void cardMantenimientos_Click(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmMantenimientos"))
            {
                frmMantenimientos mantenimientos = new frmMantenimientos();
                mantenimientos.Show();
            }

        }

        private void bunifuCards2_Click(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmIngresarViaje"))
            {
                frmIngresarViaje viajes = new frmIngresarViaje(cargouser, idUser, cargostring, usuario);
                viajes.Show();
            }
        }

        private void cardUsers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            if (MessageBox.Show("Estas seguro de querer salir del sistema", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                logOut();
                Close();
            }
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
            if (!checkFrmsOpen("frmReportes"))
            {
                frmReportes reportes = new frmReportes(usuario, cargostring, cargouser, idUser);
                reportes.Show();
            }

        }

        private void bunifuCards6_Click(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmViajesActivos"))
            {
                frmViajesActivos next = new frmViajesActivos(usuario, cargostring, cargouser, idUser);
                next.Show();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmViajesActivos"))
            {
                frmViajesActivos next = new frmViajesActivos(usuario, cargostring, cargouser, idUser);
                next.Show();
            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            logOut();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardEmpleado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardMantenimientos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmUsuarios"))
            {
                frmUsuarios ingresusuario = new frmUsuarios(cargouser, idUser, cargostring, usuario);
                ingresusuario.Show();
            }
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmIngresarViaje"))
            {
                frmIngresarViaje viajes = new frmIngresarViaje(cargouser, idUser, cargostring, usuario);
                viajes.Show();
            }
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            if (!checkFrmsOpen("frmIngresoCliente"))
            {
                frmIngresoCliente cliente = new frmIngresoCliente(usuario, cargostring, cargouser, idUser);
                cliente.Show();
            }
        }
        public static bool checkFrmsOpen(string frmName)
        {
               FormCollection fc = Application.OpenForms;

                foreach (Form frm in fc)
                {
                     if (frm.Name == frmName)
                     {
                        return true;
                     }
                 }
                    return false;
        }

    }
}
