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
    public partial class frmConfig : Form
    {
        public static int cargou, idu;
        public static string username;
        public frmConfig(int cargo, string user, int idlogged)
        {
            InitializeComponent();
            cargou = cargo;
            username = user;
            idu = idlogged;

            txtPin.Enabled = false;
            btnConfirmarPin.Enabled = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtContra.Text))
            {
                txtContra.Enabled = false;
                btnConfirmarContra.Enabled = false;

                txtPin.Enabled = true;
                btnConfirmarPin.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmarPin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtPin.Text);
            MessageBox.Show(txtContra.Text);
            if (!String.IsNullOrWhiteSpace(txtPin.Text))
            {

                MessageBox.Show(Convert.ToString(idu));
                bool res = ControladorUsuario.ActualizarContraPin(txtContra.Text, txtPin.Text, idu);
                if (res)
                {
                    MessageBox.Show("Felicidades, Has configurado con exito tu cuenta", "Confirmación", MessageBoxButtons.OK);
                }
            }
        }



    }
}
