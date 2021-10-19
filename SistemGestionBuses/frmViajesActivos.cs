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
using SistemGestionBuses.Properties;
using SistemGestionBuses.Idiomas;
using System.Threading;


namespace SistemGestionBuses
{
    public partial class frmViajesActivos : Form
    {
        public static int idlogged;
        public static string cargostring;
        public static string username;
        public static int idcargo;
        public frmViajesActivos(string user, string cargo, int cargoid, int iduser)
        {
            InitializeComponent();
            username = user;
            txtActiveUser.Text = username;
            cargostring = cargo;
            txtCargoUser.Text = cargostring;
            idlogged = iduser;
            idcargo = cargoid;
            Permisos();
            CargarIdioma();
            llenarIdiomas_Combobox();
        }

        void Permisos()
        {
            if (idcargo == 2)
            {
                btnRastrear.Enabled = true;
            }
            else
            {
                btnRastrear.Enabled = false;
            }
        }
        private void frmViajesActivos_Load(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Today.ToString("yyyy-dd-MM"));

            metroText.Enabled = false;
            GetActiveTrips();
        }

        private void GetActiveTrips()
        {
            metroText.Text = ControladorViaje.GetActiveTrips();
        }

        //Botón para desplegar la pagina para compartir la ubicación.
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://locus-web-app.herokuapp.com/");
        }

        //Boton para desplegar la página de rastreo de las unidades activas.
        private void btnRastrear_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://locus-web-app.herokuapp.com/admin");
        }

        //Boton para cerrar sesión.
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ControladorLogin.LogOut(idlogged);
            Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmPrincipal main = new frmPrincipal(idcargo, username, idlogged);
            main.Show();
        }

        //CambiarIdioma
        public void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Idioma);

            lblViajesActivos.Text = Res.lblViajesActivosTiemporeal;
            lblPasosCom.Text = Res.lblPasos;
            lblActivarGPS.Text = Res.lblGPS;
            lblInternet.Text = Res.lblInternet;
            lblEscanear.Text = Res.lblQR;
            lblIniciar.Text = Res.lblIniciar;
            lblLChastaFinal.Text = Res.lblLCfinal;
            lblConductorUbicacion.Text = Res.lblConductorUbic;
            btnCompartir.Text = Res.btnCompartirUbicacion;
            btnRastrear.Text = Res.btnRastrearViajes;
            BtnCambiarIdioma.Text = Res.btnCambiarIdioma;
        }

        public void llenarIdiomas_Combobox()
        {
            cmbIdioma.DataSource = Idioma.ObtenerIdiomas();
            cmbIdioma.ValueMember = "CultureInfo";
            cmbIdioma.DisplayMember = "CargarNombre_Pais";
        }

        private void BtnCambiarIdioma_Click(object sender, EventArgs e)
        {
            Settings.Default.Idioma = cmbIdioma.SelectedValue.ToString();
            CargarIdioma();
        }

    }
}
