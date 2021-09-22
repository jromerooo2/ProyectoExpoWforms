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
using Bunifu.Framework.UI;
using Bunifu;

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


        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            ControladorRecuperar recu = new ControladorRecuperar();
            //recu.PINseguridad = txtCode.Text;
            if (!String.IsNullOrEmpty(txtCode.Text))
            {
                bool res = recu.ValidarPINusuario(txtCode.Text);
                if (res)
                {
                    MessageBox.Show("Se ha confirmado tu identidad");
                    txtNueva.Enabled = true;
                    btnNueva.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se ha confirmado tu identidad");
                }
            }


        }

        private void btnNueva_Click_1(object sender, EventArgs e)
        {
            ControladorRecuperar recu = new ControladorRecuperar();
            if (!String.IsNullOrEmpty(txtNueva.Text))
            {
                recu.PINseguridad = txtCode.Text;
                recu.nuevacontra = txtNueva.Text;

                bool res = recu.ActualizarContraPIN();
                if (res)
                {
                    MessageBox.Show("Se ha actualizado tu contraseña");
                    Close();
                }
                else
                {
                    MessageBox.Show("No se ha actualizado tu contraseña");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son necesarios para ejercer la recuperación de contraseña", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDUI_Click(object sender, EventArgs e)
        {
            ControladorRecuperar recu = new ControladorRecuperar();
            if (!String.IsNullOrEmpty(txtDUI.Text) && !String.IsNullOrEmpty(txtUser.Text))
            {
                //Parametros del controlador
                recu.usuariorecu = Convert.ToString(txtUser.Text);
                recu.documentoempleado = Convert.ToString(txtDUI.Text);
                recu.fechanacimiento = Convert.ToString(dtpNacimiento.Value);
                //metodo para validar que el dui y la fecha de nacimiento perteneza al usuario correcto
                bool res = recu.ValidarDocumentosPIN();
                if (res == true)
                {
                    MessageBox.Show("Se confirmó tu identidad, continua el proceso", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CardPIN.Enabled = true;
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

        private void dtpNacimiento_onValueChanged(object sender, EventArgs e)
        {
            string mindatestring = "01/ 01/ 1971";
            string maxdatestring = "01/ 01/ 2001";
            DateTime mindate = Convert.ToDateTime(mindatestring);
            DateTime maxdate = Convert.ToDateTime(maxdatestring);
            if (dtpNacimiento.Value < mindate)
            {
                MessageBox.Show("Esta fecha no es valida personas mayores de 50 años no son permitidas", "Edad no permitida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dtpNacimiento.Value = mindate;
            }
            if (dtpNacimiento.Value > maxdate)
            {
                MessageBox.Show("Esta fecha no es valida personas menores de 20 años no son permitidas", "Edad no permitida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dtpNacimiento.Value = maxdate;
            }
        }
    }
}
