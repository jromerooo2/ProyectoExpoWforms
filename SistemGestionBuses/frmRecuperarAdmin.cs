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
using SistemGestionBuses.Properties;
using SistemGestionBuses.Idiomas;
using System.Threading;

namespace SistemGestionBuses
{
    public partial class frmRecuperarAdmin : Form
    {
        public frmRecuperarAdmin()
        {
            InitializeComponent();
            CardUsuario.Enabled = false;
            CardAdmin.Enabled = true;
            btnNuevaContrasena.Enabled = false;
            txtConfirmacionContra.Enabled = false;
            txtNueva.Enabled = false;
            txtClaveAdmin.UseSystemPasswordChar = true;
            txtNueva.UseSystemPasswordChar = true;
            txtConfirmacionContra.UseSystemPasswordChar = true;
            CargarIdioma();
            llenarIdioma();
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
                recu.claveadmin = ValidacionesClass.Encrypt(txtClaveAdmin.Text);
                bool respuesta = recu.ValidarCredenciales_Controller();
                if (respuesta == true)
                {
                    MessageBox.Show("Se confirmo el usuario de administrador", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CardAdmin.Enabled = false;
                    CardUsuario.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Los campos no pertenecen a un administrador", "Validar campos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                recu.DUI = txtDUI.Text;
                bool respuesta = recu.ValidarCredencialesUsuario_Controller();
                if (respuesta == true)
                {
                    txtDUI.Enabled = false;
                    txtUsuarioRecu.Enabled = false;
                    btnConfirmarUsuario.Enabled = false;
                    MessageBox.Show("Se confirmo tu usuario", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNueva.Enabled = true;
                    txtConfirmacionContra.Enabled = true;
                    btnNuevaContrasena.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Malo");
                }
            }
        }

        private void btnNuevaContrasena_Click(object sender, EventArgs e)
        {           
            if (txtNueva.Text.Trim() == "" || txtConfirmacionContra.Text.Trim() == "")
            {
                MessageBox.Show("Uno o dos campos estan vacíos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //variables de comparación :)
                string contra, confirmacion;
                contra = txtNueva.Text;
                confirmacion = txtConfirmacionContra.Text;
                ControladorRecuperar recu = new ControladorRecuperar();
                recu.nuevacontra = contra;
                recu.usuariorecu = txtUsuarioRecu.Text;
                if (confirmacion.Equals(contra))
                {
                    bool respuesta = recu.RestaurarContra_Controller();
                    if (respuesta == true)
                    {
                        NotificacionRecuperación();
                        frmLogin nextLog = new frmLogin();
                        nextLog.BringToFront();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña no pudo ser actualizada", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                  
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Verficación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
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

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Maximized;
        }

        private void btnVerContra1_Click(object sender, EventArgs e)
        {
            if (txtNueva.UseSystemPasswordChar == false)
            {
                txtNueva.UseSystemPasswordChar = true;
            }
            else
            {
                txtNueva.UseSystemPasswordChar = false;
            }
        }

        private void btnVerContra2_Click(object sender, EventArgs e)
        {
            if (txtConfirmacionContra.UseSystemPasswordChar == false)
            {
                txtConfirmacionContra.UseSystemPasswordChar = true;
            }
            else
            {
                txtConfirmacionContra.UseSystemPasswordChar = false;
            }
        }

        //Cambiar Idioma
        public void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Idioma);

            lblRecuperatucuenta.Text = Res.lblRecuperarCuenta;
            lblCredencialesAdmin.Text = Res.lblCredencialesAdmin;
            lblUsuario.Text = Res.lblUsuario;
            lblContraseña.Text = Res.lblContraseña;
            lblDatosdeCuenta.Text = Res.lblDatosdeCuenta;
            lblUsuario2.Text = Res.lblUsuario;
            lblDUIEmpleado.Text = Res.lblDUIEmpleado;
            lblRenovarContraseña.Text = Res.lblRenuevaContra;
            lblNuevaContraseña.Text = Res.lblNuevaContraseña;
            lblConfirmaciónContraseña.Text = Res.lblConfirmacióndeContraseña;
            BtnCambiarIdioma.Text = Res.btnCambiarIdioma;
        }

        public void llenarIdioma()
        {
            cmbIdioma.DataSource = Idioma.ObtenerIdiomas();
            cmbIdioma.ValueMember = "CultureInfo";
            cmbIdioma.DisplayMember = "CargarNombre_Pais";
        }

        private void BtnCambiarIdioma_Click(object sender, EventArgs e)
        {
            Settings.Default.Idioma = cmbIdioma.SelectedValue.ToString();
            CargarIdioma();
        }
    }
}