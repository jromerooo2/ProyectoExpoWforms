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
        public frmPin()
        {
            InitializeComponent();
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

        }


        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            ControladorRecuperar recu = new ControladorRecuperar();
            //recu.PINseguridad = txtCode.Text;
            if (!String.IsNullOrEmpty(txtCode.Text))
            {
                bool res = recu.ValidarCredencialesUsuario(txtCode.Text);
                if (res)
                {
                    MessageBox.Show("Se ha confirmado tu identidad");
                    txtNueva.Enabled = true;
                    btnNueva.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se ha confirmado tu identidad");
                }
            }


        }

        private void btnNueva_Click_1(object sender, EventArgs e)
        {
            ControladorRecuperar recu = new ControladorRecuperar();
            if (!String.IsNullOrEmpty(txtNueva.Text))
            {
                recu.PINseguridad = txtCode.Text;
                recu.nuevacontra = txtNueva.Text;

                bool res = recu.ActualizarContraPIN();
                if (res)
                {
                    MessageBox.Show("Se ha actualizado tu contraseña");
                    Close();
                }
                else
                {
                    MessageBox.Show("No se ha actualizado tu contraseña");
                    Close();
                }
            }
        }
    }
}
