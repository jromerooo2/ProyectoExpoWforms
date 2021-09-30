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
    public partial class FirstUse : Form
    {
        public FirstUse()
        {
            InitializeComponent();
            CardPaso2.Enabled = false;
            CardPaso3.Enabled = false;
            CardPaso4.Enabled = false;
            btnFinalizar.Enabled = false;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string user = txtUser.Text;
            if (!String.IsNullOrEmpty(user) && !String.IsNullOrWhiteSpace(user) && !String.IsNullOrEmpty(email) && !String.IsNullOrWhiteSpace(email))
            {
                if (ValidacionesClass.checkEmailAt(email))
                {
                    if (ValidacionesClass.hasSpecialChars(user) == false)
                    {
                        if (ValidacionesClass.hasSpecialChars(email) == false)
                        {
                            ControladorRecuperar.confirmMailFirstUse(email);
                            CardPaso2.Enabled = true;
                            CardPaso1.Enabled = false;
                            NotificaciónConfirmaciónCorreo();
                        }
                        else
                        {
                            MessageBox.Show("El correo no es valido, posee carácteres especiales", "Correo invalido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario no puede contener carácteres especiales.(-+/=)", "Usuario invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {                 
                    MessageBox.Show("El correo no es valido, porfavor verifica que tu correo esta escrito correctamente", "Correo invalido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingresa un nombre de usuario o correo para continuar con los pasos del sistema", "Campo vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void NotificaciónConfirmaciónCorreo()
        {
            nfConfirmacion.Icon = new System.Drawing.Icon(Path.GetFullPath(@"../../Resources/icons8_checked.ico"));
            nfConfirmacion.Text = "Correo de confirmación enviado";
            nfConfirmacion.Visible = true;
            nfConfirmacion.BalloonTipTitle = "Confirmación de correo";
            nfConfirmacion.BalloonTipText = "El correo ha sido enviado correctamente, porfavor ingresa a tu correo y copia el codigo que se ha enviado, para continuar con los pasos del sistema.";
            nfConfirmacion.ShowBalloonTip(150);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(txtCode.Text);
            if (ControladorRecuperar.CodeFirstUse(code))
            {
                NotificacionConfirmacionCodigo();
                CardPaso2.Enabled = false;
                CardPaso3.Enabled = true;
                txtPIN.Enabled = false;
                btnPIN.Enabled = false;
            }
            else
            {
                MessageBox.Show("El codigo no es correcto, porfavor verifica el codigo enviado a tu correo", "Codigo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        void NotificacionConfirmacionCodigo()
        {
            nfConfirmacion.Icon = new System.Drawing.Icon(Path.GetFullPath(@"../../Resources/icons8_checked.ico"));
            nfConfirmacion.Text = "Codigo de confirmación";
            nfConfirmacion.Visible = true;
            nfConfirmacion.BalloonTipTitle = "Confirmación de codigo";
            nfConfirmacion.BalloonTipText = "El codigo se ha confirmado, puedes continuar con el siguiente paso del sistema.";
            nfConfirmacion.ShowBalloonTip(150);
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            string nuevacontra = txtNueva.Text;
            string confirmacioncontra = txtConfirmacion.Text;
            if (!String.IsNullOrEmpty(nuevacontra) && !String.IsNullOrWhiteSpace(nuevacontra) && !String.IsNullOrEmpty(confirmacioncontra) && !String.IsNullOrWhiteSpace(confirmacioncontra))
            {
                if (confirmacioncontra.Equals(nuevacontra))
                {
                    txtPIN.Enabled = true;
                    btnPIN.Enabled = true;
                }
            }
        }

        private void btnReenviar_Click(object sender, EventArgs e)
        {
            if (btnReenviar.Enabled == true)
            {
                string email = txtEmail.Text;
                ControladorRecuperar.confirmMailFirstUse(email);
                NotificaciónConfirmaciónCorreo();
                timer.Interval = 15000;
                timer.Tick += timer_Tick;
                timer.Start();
                btnReenviar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Debes esperar 15 segundos para poder reenivar el codigo de nuevo", "Reenvio de código", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            btnReenviar.Enabled = true;
            timer.Stop();
        }

        private void btnPIN_Click(object sender, EventArgs e)
        {
            string pin = txtPIN.Text;
            if (!String.IsNullOrEmpty(pin) || !String.IsNullOrWhiteSpace(pin))
            {
                if (pin.Length > 9)
                {
                    CardPaso4.Enabled = true;
                    CardPaso3.Enabled = false;
                }
                else
                {
                    MessageBox.Show("El PIN debe tener como minimo 10 carácteres, porfavor ingresa un PIN valido. ", "PIN invalido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingresa un PIN para continuar con los pasos del primer uso del sistema.", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        void NotificacionConfirmacionInfo()
        {
            nfConfirmacion.Icon = new System.Drawing.Icon(Path.GetFullPath(@"../../Resources/icons8_checked.ico"));
            nfConfirmacion.Text = "Paso Final COMPLETADO";
            nfConfirmacion.Visible = true;
            nfConfirmacion.BalloonTipTitle = "Información general";
            nfConfirmacion.BalloonTipText = "Tu información es valida, presiona el botón de 'finalizar' para ingresar al sistema y darle su primer uso";
            nfConfirmacion.ShowBalloonTip(150);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string direccion, nombre_empr, telefono;
            direccion = txtDireccion.Text;
            nombre_empr = txtNameEnterprise.Text;
            telefono = txtTelefono.Text;
            if (!String.IsNullOrEmpty(direccion) || !String.IsNullOrWhiteSpace(direccion) || !String.IsNullOrEmpty(nombre_empr) || !String.IsNullOrWhiteSpace(nombre_empr) || !String.IsNullOrEmpty(telefono) || !String.IsNullOrWhiteSpace(telefono))
            {
                if (telefono.Trim().Length > 13)
                {
                    if (direccion.Length >= 45)
                    {
                        if (ValidacionesClass.hasSpecialChars(nombre_empr) == false)
                        {
                            btnFinalizar.Enabled = true;
                            NotificacionConfirmacionInfo();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La dirección es muy corta, verifica que tu dirección sea la correcta y no omita ningun dato, si es asi, añade un punto de referencia.", "Campo invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El telefono posee el formato correcto, verifica que el codigo del país del telefono esta siendo ingresado.", "Campo invalido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingresa todos los datos solicitados para continuar con los pasos del primer uso del sistema.", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void EnviarDatos()
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
