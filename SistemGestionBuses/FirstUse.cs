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
using SistemGestionBuses.Idiomas;
using System.Threading;

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
            btnFinalizar.Visible = false;
            CargarMunicipio();
            CargarIdioma();
        }

        void CargarMunicipio()
        {
            try
            {
                DataTable dataMunicipio = ControladorIngreso.ObtenerMunicipios();
                cmbMunicipio.DataSource = dataMunicipio;
                cmbMunicipio.DisplayMember = "municipio";
                cmbMunicipio.ValueMember = "id_municipio";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los municipios.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
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
                if (ValidacionesClass.IsValidEmail(email))
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
                    MessageBox.Show("Contraseña valida, continua con el proceso de primer uso del sistema ingresando tu PIN de seguridad", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (MessageBox.Show("Deseas continuar con el proceso? Una vez confirmes y guardes, no podrás regresar a modificar la contraseña, hasta terminar el proceso del primer uso", "Confirmación Paso 3", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CardPaso4.Enabled = true;
                        CardPaso3.Enabled = false;
                    }
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
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
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
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
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
            string direccion, nombre_empr, telefono, NIT, DUI;
            direccion = txtDireccion.Text;
            nombre_empr = txtNameEnterprise.Text;
            telefono = txtTelefono.Text;
            DUI = TxtDUI.Text;
            NIT = txtNIT.Text;
            int id_municipio = Convert.ToInt32(cmbMunicipio.SelectedValue);
            if (!String.IsNullOrEmpty(direccion) || !String.IsNullOrEmpty(DUI) || !String.IsNullOrEmpty(nombre_empr) || !String.IsNullOrEmpty(NIT) || !String.IsNullOrEmpty(telefono))
            {
                if (telefono.Trim().Length > 13)
                {
                    if (direccion.Length >= 30)
                    {
                        if (NIT.Length == 17 && DUI.Length == 10)
                        {
                            txtNameEnterprise.Enabled = false;
                            TxtDUI.Enabled = false;
                            txtNIT.Enabled = false;
                            cmbMunicipio.Enabled = false;
                            txtTelefono.Enabled = false;
                            txtDireccion.Enabled = false;
                            btnFinalizar.Visible = true;
                            btnFinalizar.Enabled = true;
                            NotificacionConfirmacionInfo();
                        }
                        else
                        {
                            MessageBox.Show("El NIT o el DUI no son validos, verifica que esten correctos", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string date = DateTime.Today.ToString();
            string empresa, direccion, telefono, dui, nit;
            empresa = txtNameEnterprise.Text;
            direccion = txtDireccion.Text;
            telefono = txtTelefono.Text;
            dui = TxtDUI.Text;
            nit = txtNIT.Text;
            //id_estado = activo
            int estado = 1;
            //id_genero = undefined xd
            int genero = 1;
            //id_cargo = admin
            int cargo = 2;
            int id_muni = Convert.ToInt32(cmbMunicipio.SelectedValue);
            MemoryStream defaulti = new MemoryStream();
            pbImage.Image.Save(defaulti, pbImage.Image.RawFormat);
            byte[] bByte = defaulti.ToArray();
            ControladorIngreso control = new ControladorIngreso(empresa, empresa, dui, nit, direccion, telefono, genero, estado, cargo, id_muni);
            bool res = control.EnviarDatosControlador();
            if (res == true)
            {
                string user = txtUser.Text;
                string email = txtEmail.Text;
                string password = txtNueva.Text;
                string PIN = txtPIN.Text;
                int id = control.ObtenerIDEmpleado_Controller(dui, nit);
                ControladorUsuario usercontrol = new ControladorUsuario();
                bool res2 = usercontrol.RegistrarPRIMERUsuario(user, password, email, cargo, id, PIN, bByte);
                if (res2 == true)
                {
                    NotificacionConfirmacion();
                    Close();                 
                    frmLogin login = new frmLogin();
                    login.Show();
                    login.Opacity = 100;
                }
                else
                {
                    MessageBox.Show("Usuario no registrado");
                }
            }
            else
            {
                MessageBox.Show("Empleado no registrado");
            }
        }

        void NotificacionConfirmacion()
        {
            nfConfirmacion.Icon = new System.Drawing.Icon(Path.GetFullPath(@"../../Resources/icons8_checked.ico"));
            nfConfirmacion.Text = "Primer usuario registrado exitosamente";
            nfConfirmacion.Visible = true;
            nfConfirmacion.BalloonTipTitle = "Locus System esta listo para ti!";
            nfConfirmacion.BalloonTipText = "Disfruta del sistema hecho por nuestro equipo de desarrollo, te acompañaremos en tus viajes, ingresa con tus nuevas creedenciales";
            nfConfirmacion.ShowBalloonTip(150);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            EnviarDatos();
        }

        //Cambio de idioma
        public void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

                lblPaso1.Text = Res.lblPaso1;
                lblPaso2.Text = Res.lblPaso2;
                lblPaso3.Text = Res.lblPaso3;
                lblPaso4.Text = Res.lblPaso4;
                lblIngresardatos.Text = Res.lblIngresaDatos;
                lblCorreo.Text = Res.lblcorreo;
                lblUsername.Text = Res.lblNombreUsuario;
                lblCodeConfirmation.Text = Res.lblCodigo;
                lblIngresoCodigo.Text = Res.lblCodConfirmacion;
                btnReenviar.Text = Res.btnReenviar;
                lblContraseñaYPin.Text = Res.lblContraseñayPin;
                lblcontraseñaI.Text = Res.lblContraseñaCondiciones;
                lblcontraseña.Text = Res.lblContraseña;
                lblConfirmacionContra.Text = Res.lblConfirmacionContra;
                lblPIN.Text = Res.lblPINseguridad;
                lblInformacion.Text = Res.lblInformacion;
                lblNombreEmpresa.Text = Res.lblEmpresa;
                lbldireccion.Text = Res.lblDireccion;
                lbltelefono.Text = Res.lblTeléfono;
                lblMunicipio.Text = Res.lblMunicipio;
                lblDUI.Text = Res.lblDUI;
                lblNIT.Text = Res.lblNIT;
                btnConfirmar.Text = Res.btnConfirmar;
                btnFinalizar.Text = Res.btnFinalizar;
                lblseleccionarIdioma.Text = Res.lblSeleccionarIdioma;
        }
    }
}
