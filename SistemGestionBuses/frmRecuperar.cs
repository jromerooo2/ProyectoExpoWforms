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
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recuperarPorMail();
        }

        private void recuperarPorMail()
        {
            string usernameRecu = txtUser.Text;
            if (usernameRecu.Trim() != "")
            {
               bool res =  ControladorRecuperar.recuperarPassMail(usernameRecu);
                if (res)
                {
                    MessageBox.Show("Enviado con exito");
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
    }
}
