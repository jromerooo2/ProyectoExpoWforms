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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmarContra_Click(object sender, EventArgs e)
        {
            bool specialChars = ValidacionesClass.hasSpecialChars(txtContra.Text);
            if (specialChars)
            {
                MessageBox.Show("Por favor utiliza caracteres validos");
            }
            else
            {
                txtContra.Enabled = false;
                btnConfirmarContra.Enabled = false;

                txtPin.Enabled = true;
                btnConfirmarPin.Enabled = true;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarPin_Click(object sender, EventArgs e)
        {
            if (!ValidacionesClass.hasSpecialChars(txtPin.Text))
            {
                bool res = ControladorUsuario.ActualizarContraPin(txtContra.Text, txtPin.Text, idu);
                if (res)
                {
                    MessageBox.Show("Felicidades, Has configurado con exito tu cuenta", "Confirmación", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Por favor utiliza únicamente números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
