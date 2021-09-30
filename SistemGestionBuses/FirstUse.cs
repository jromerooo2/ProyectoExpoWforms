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
            if (ValidacionesClass.checkEmailAt(email))
            {
                if (ValidacionesClass.hasSpecialChars(email) == false)
                {
                    if (ValidacionesClass.hasSpecialChars(user) == false)
                    {
                        ControladorRecuperar.confirmMailFirstUse(email);
                        CardPaso2.Enabled = true;
                        CardPaso1.Enabled = false;
                        NotificaciónConfirmaciónCorreo();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no puede contener carácteres especiales.(-+/=)", "Usuario invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El correo no es valido, posee carácteres especiales","Correo invalido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("El correo no es valido, porfavor verifica que tu correo esta escrito correctamente", "Correo invalido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        }

        private void btnReenviar_Click(object sender, EventArgs e)
        {
            timer.Interval = 15000;
            timer.Tick += timer_Tick;
            timer.Start();
            btnReenviar.Enabled = false;
            if (btnReenviar.Enabled == true)
            {
                string email = txtEmail.Text;
                ControladorRecuperar.confirmMailFirstUse(email);
                NotificaciónConfirmaciónCorreo();
            }       
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            btnReenviar.Enabled = true;
            timer.Stop();
        }
    }
}
