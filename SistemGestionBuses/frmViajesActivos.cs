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
    public partial class frmViajesActivos : Form
    {
        public frmViajesActivos()
        {
            InitializeComponent();
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
            string user = txtActiveUser.Text;
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
            frmPrincipal main = new frmPrincipal(1, "user", 5);
            this.Close();
            main.Show();
        }
    }
}
