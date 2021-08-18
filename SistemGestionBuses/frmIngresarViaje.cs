using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemGestionBuses
{
    public partial class frmIngresarViaje : Form
    {
        public frmIngresarViaje()
        {
            InitializeComponent();
        }

        //Metodo para limpiar los campos en el forms
        void LimpiarCampos()
        {
            txtDestino.Clear();
            txtNombreViaje.Clear();
            txtTarifaViaje.Clear();
            cmbCliente.SelectedIndex = 0;
            cmbConductor.SelectedIndex = 0;
            cmbEstadoViaje.SelectedIndex = 0;
            cmbMetodoPago.SelectedIndex = 0;
            cmbMunicipios.SelectedIndex = 0;
            cmbTipoDestino.SelectedIndex = 0;
            cmbUnidadTransporte.SelectedIndex = 0;
            dtpFechaViaje.Value = Convert.ToDateTime(01 / 01 / 2021);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            //Metodo para Limpiar Campos
            LimpiarCampos();
        }
    }
}
