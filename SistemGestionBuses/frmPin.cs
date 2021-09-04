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
    public partial class frmPin : Form
    {
        public static string user;
        public frmPin(string usuario)
        {
            InitializeComponent();
            usuario = user;
        }

        private void btnRecuPIN_Click(object sender, EventArgs e)
        {

        }

        private void btnNueva_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmPin_Load(object sender, EventArgs e)
        {
            btnNueva.Enabled = false;
            txtNueva.Enabled = false;
            ControladorRecuperar recu = new ControladorRecuperar();
            bool res = recu.ValidarCredencialesUsuario(user);
            if (res)
            {
                txtCode.Enabled = true;
                btnConfirmar.Enabled = true;
            }
            else
            {
                txtCode.Enabled = false;
                btnConfirmar.Enabled = false;
            }

        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            //recu.PINseguridad = txtCode.Text;
        }
    }
}
