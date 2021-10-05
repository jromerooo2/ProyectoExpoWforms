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
    public partial class frmAsignarViaje : Form
    {
        //Variable datatable para la source del data grid
        DataTable vistaviajes;
        public static int idlogged;
        public static string cargostring;
        public static string username;
        public static int idcargo;

        public frmAsignarViaje(string user, string cargo, int cargoid, int iduser)
        {
            InitializeComponent();
            username = user;
            txtActiveUser.Text = username;
            cargostring = cargo;
            txtCargoStrip.Text = cargostring;
            idlogged = iduser;
            idcargo = cargoid;
        }

        //Metodo para cargar el grid de datos
        void CargarGrid()
        {

        }

        //Metodo para capturar los datos de la row del data grid seleccionada
        void CapturarDatos()
        {

        }

        //Metodo para insertar los datos en la tabla cliente-viaje
        void AsignarViaje()
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ControladorLogin.LogOut(idlogged);
            frmLogin login = new frmLogin();
            login.Show();
            Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
