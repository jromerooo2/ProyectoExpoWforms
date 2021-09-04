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
        public static string user = "";
        public frmPin(string usuario)
        {
            InitializeComponent();
            user = usuario;
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
            ControladorRecuperar recu = new ControladorRecuperar();
            btnNueva.Enabled = false;
            txtNueva.Enabled = false;

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
            ControladorRecuperar recu = new ControladorRecuperar();
            //recu.PINseguridad = txtCode.Text;
            if (!String.IsNullOrEmpty(txtCode.Text))
            {
                recu.PINseguridad = txtCode.Text;
                bool res = recu.RecuperarByPIN_Controller();
                if (res)
                {
                    MessageBox.Show("Se ha confirmado tu identidad");
                    txtNueva.Enabled = true;
                    btnNueva.Enabled = true;
                }
            }
            else
            {

            }

        }

        private void btnNueva_Click_1(object sender, EventArgs e)
        {
            ControladorRecuperar recu = new ControladorRecuperar();
            if (!String.IsNullOrEmpty(txtNueva.Text))
            {
                recu.PINseguridad = txtCode.Text;
                recu.nuevacontra = txtNueva.Text;
                bool res = recu.ActualizarContra(txtNueva.Text);
                if (res)
                {
                    MessageBox.Show("Se ha actualizado tu contraseña");
                }
            }
        }
    }
}
