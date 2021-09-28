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

            if (!String.IsNullOrEmpty(usernameRecu))
            {
                bool res =  ControladorRecuperar.RecuperarMail(usernameRecu);
                if (res)
                {
                    MessageBox.Show("Enviado con exito");
                    //lblNuevaContra.Visible = true;
                    //lblIngresoCodigo.Visible = true;
                    txtCode.Visible = true;
                    txtNueva.Visible = true;
                    btnNueva.Visible = true;
                    btnConfirmar.Visible = true;
                    txtUser.ReadOnly = true;
                    btnMetodo1.Enabled = false;
                    btnMetodo2.Enabled = false;
                    btnRecuPIN.Enabled = false;
                    txtCode.ReadOnly = false;
                    btnConfirmar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Algo fallo en el proceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Por favor ingresa un usuario valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (ControladorRecuperar.ConfirmCode(code))
            {
                MessageBox.Show("Se ha confirmado tu identidad, puedes continuar");

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

        private void btnNueva_Click(object sender, EventArgs e)
        {
            ControladorRecuperar obj = new ControladorRecuperar();
            string contra = txtNueva.Text;
            if (contra != "")
            {
                bool res = obj.ActualizarContra(contra);

                if (res)
                {
                    MessageBox.Show("Se ha actualizado la contraseña");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error , intentalo más tarde");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor escribe una contraseña nueva");
            }
        }

        private void frmRecuperar_Load(object sender, EventArgs e)
        {
            txtNueva.Visible = false;
            txtCode.Visible = false;
            //lblIngresoCodigo.Visible = false;
            //lblNuevaContra.Visible = false;
            btnConfirmar.Visible = false;
            btnNueva.Visible = false;
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            frmRecuperarAdmin admin = new frmRecuperarAdmin();
            this.Hide();
            admin.Show();         
        }

        private void btnRecuPIN_Click(object sender, EventArgs e)
        {
            frmPin pin = new frmPin();

            if (!String.IsNullOrEmpty(txtUser.Text))
            {
                ControladorRecuperar recu = new ControladorRecuperar();
                recu.usuariorecu = txtUser.Text;
                pin.Show();
            }
            else
            {
                MessageBox.Show("Por favor escribe un usuario");
            }

        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
