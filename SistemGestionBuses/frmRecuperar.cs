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
    public partial class frmRecuperar : Form
    {
        public frmRecuperar()
        {
            InitializeComponent();
            txtCode.ReadOnly = true;
            btnConfirmar.Enabled = false;
            txtNueva.ReadOnly = true;
            btnNueva.Enabled = false;
        }
            

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

        }

        private void recuperarPorMail()
        {
            string usernameRecu = txtUser.Text;
            if (usernameRecu.Trim() != "")
            {
               bool res =  ControladorRecuperar.RecuperarMail(usernameRecu);
                if (res)
                {
                    MessageBox.Show("Enviado con exito");
                    txtUser.ReadOnly = true;
                    btnMetodo1.Enabled = false;
                    btnMetodo2.Enabled = false;
                    txtCode.ReadOnly = false;
                    btnConfirmar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Algo fallo en el proceso");
                }

            }
            else
            {

            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            recuperarPorMail();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(txtCode.Text);
            if (ControladorRecuperar.ConfirmCodes(code))
            {
                MessageBox.Show("Son Iguales, puedes continuar");

                txtCode.ReadOnly = true;
                btnConfirmar.Enabled = false;
                txtNueva.ReadOnly = false;
                btnNueva.Enabled = true;

            }
            else
            {
                MessageBox.Show("Intentalo de nuevo");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
