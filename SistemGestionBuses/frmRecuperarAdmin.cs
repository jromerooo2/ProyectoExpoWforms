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
        }
     
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txtUsuarioAdmin.Text.Trim() == "" || txtClaveAdmin.Text.Trim() == "")
            {
                MessageBox.Show("Los campos del administrador son requeridos para realizar la recuperación del usuario","Completar campos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Objeto del controlador == recu :D
                ControladorRecuperar recu = new ControladorRecuperar();
                recu.usuarioadmin = txtUsuarioAdmin.Text;
                recu.claveadmin = EncryptClass.Encrypt(txtClaveAdmin.Text);
            }
        }
    }
}
