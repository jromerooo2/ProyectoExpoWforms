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
using System.IO;

namespace SistemGestionBuses
{
    public partial class frmPin : Form
    {
        public frmPin()
        {
            InitializeComponent();
        }

        private void frmPin_Load(object sender, EventArgs e)
        {
            CardPIN.Enabled = false;
            btnConfirmar.Enabled = false;
            txtCode.Enabled = false;
            btnNueva.Enabled = false;
            txtNueva.Enabled = false;
            txtConfirmacionNueva.Enabled = false;
        }



        private void btnNueva_Click_1(object sender, EventArgs e)
        {
            ControladorRecuperar recu = new ControladorRecuperar();
            if (!String.IsNullOrEmpty(txtNueva.Text) || !String.IsNullOrEmpty(txtConfirmacionNueva.Text))
            {
                string contra = txtNueva.Text;
                string confirmacion = txtConfirmacionNueva.Text;
                recu.PINseguridad = txtCode.Text;
                recu.nuevacontra = txtNueva.Text;
                recu.usuariorecu = txtUser.Text;
                if (confirmacion.Equals(contra))
                {
                    bool res = recu.ActualizarContraPIN();
                    if (res)
                    {
                        NotificacionRecuperación();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No realizo la actualización de tu contraseña, contacta al administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("La confirmación de la contraseña y la contraseña no coinciden, porfavor verifica ambos campos", "No coinciden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son necesarios para ejercer la recuperación de contraseña", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void NotificacionRecuperación()
        {
            nfConfirmacion.Icon = new System.Drawing.Icon(Path.GetFullPath(@"../../Resources/icons8_checked.ico"));
            nfConfirmacion.Text = "Usuario recuperado y actualizado";
            nfConfirmacion.Visible = true;
            nfConfirmacion.BalloonTipTitle = "Confirmación de recuperación";
            nfConfirmacion.BalloonTipText = "La contraseña fue recuperada y actualizada con exito, inicia sesión con tus nuevas creedenciales en Locus System";
            nfConfirmacion.ShowBalloonTip(150);
        }

        private void btnDUI_Click(object sender, EventArgs e)
        {
            ControladorRecuperar recu = new ControladorRecuperar();
            if (!String.IsNullOrEmpty(txtDUI.Text) && !String.IsNullOrEmpty(txtUser.Text))
            {
                //Parametros del controlador
                recu.usuariorecu = Convert.ToString(txtUser.Text);
                recu.DUI = Convert.ToString(txtDUI.Text);
                recu.NIT = Convert.ToString(txtNIT.Text);
                //metodo para validar que el dui y la fecha de nacimiento perteneza al usuario correcto
                bool res = recu.ValidarDocumentosPIN();
                if (res == true)
                {
                    MessageBox.Show("Se confirmó tu identidad, continua el proceso", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CardPIN.Enabled = true;
                    CardValidacion.Enabled = false;
                    txtCode.Enabled = true;
                    btnConfirmar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Documento erroneo, porfavor confirma que los datos sean los correctos", "Documento no correspondiente", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Ingresa el documento para ejercer la recuperación de contraseña", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ControladorRecuperar recu = new ControladorRecuperar();
            if (!String.IsNullOrEmpty(txtCode.Text))
            {
                recu.PINseguridad = txtCode.Text;
                bool res = recu.ValidarPINusuario(txtCode.Text);
                if (res == true)
                {
                    MessageBox.Show("Se ha confirmado tu PIN de seguridad", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCode.Enabled = false;
                    btnConfirmar.Enabled = false;
                    txtConfirmacionNueva.Enabled = true;
                    txtNueva.Enabled = true;
                    btnNueva.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Porfavor confirma que el PIN es correcto", "PIN incorrrecto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingresa tu PIN de seguridad para recuperar tu contraseña", "Campo vació", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnVerContra1_Click(object sender, EventArgs e)
        {
            if (txtNueva.UseSystemPasswordChar == true)
            {
                txtNueva.UseSystemPasswordChar = false;
            }
            else
            {
                txtNueva.UseSystemPasswordChar = true;
            }
        }

        private void btnVerContra2_Click(object sender, EventArgs e)
        {
            if (txtConfirmacionNueva.UseSystemPasswordChar == true)
            {
                txtConfirmacionNueva.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmacionNueva.UseSystemPasswordChar = true;
            }
        }
    }
}
