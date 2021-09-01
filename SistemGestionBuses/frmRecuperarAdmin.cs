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
    public partial class frmRecuperarAdmin : Form
    {
        public frmRecuperarAdmin()
        {
            InitializeComponent();
            CardUsuario.Enabled = false;
            CardAdmin.Enabled = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioAdmin.Text.Trim() == "" || txtClaveAdmin.Text.Trim() == "")
            {
                MessageBox.Show("Los campos del administrador son requeridos para realizar la recuperación del usuario", "Completar campos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Objeto del controlador == recu :D
                ControladorRecuperar recu = new ControladorRecuperar();
                recu.usuarioadmin = txtUsuarioAdmin.Text;
                recu.claveadmin = EncryptClass.Encrypt(txtClaveAdmin.Text);
                bool respuesta = recu.ValidarCredenciales_Controller();
                if (respuesta == true)
                {
                    CardAdmin.Enabled = false;
                    CardUsuario.Enabled = true;
                }
            }
        }
        private void btnConfirmarUsuario_Click(object sender, EventArgs e)
        {
            if (txtDUI.Text.Trim() == "" || txtUsuarioRecu.Text.Trim() == "")
            {
                MessageBox.Show("Los campos del administrador son requeridos para realizar la recuperación del usuario", "Completar campos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                ControladorRecuperar recu = new ControladorRecuperar();
                recu.usuariorecu = txtUsuarioRecu.Text;
                recu.documentoempleado = txtDUI.Text;
                bool respuesta = recu.ValidarCredencialesUsuario_Controller();
                if (respuesta == true)
                {
                    recu.usuariorecu = txtUsuarioRecu.Text;
                    bool respuesta2 = recu.RestaurarClave_Controller(EncryptClass.Encrypt(txtNueva.Text + "123"));
                    frmLogin nextLog = new frmLogin();
                    nextLog.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Malo");
                }
            }
        }

        private void frmRecuperarAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevaContrasena_Click(object sender, EventArgs e)
        {

        }
    }
}