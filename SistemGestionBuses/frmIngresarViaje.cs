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
    public partial class frmIngresarViaje : Form
    {
        public frmIngresarViaje()
        {
            InitializeComponent();
            CargarDatosCMB();
        }

        void LimpiarCampos()
        {
            txtDestino.Clear();
            txtNombreViaje.Clear();
            txtTarifaViaje.Clear();
            cmbCliente.SelectedValue = 0;
            cmbConductor.SelectedValue = 0;
            cmbEstadoViaje.SelectedValue = 0;
            cmbMetodoPago.SelectedValue = 0;
            cmbMunicipios.SelectedValue = 0;
            cmbTipoDestino.SelectedValue = 0;
            cmbUnidadTransporte.SelectedValue = 0;
        }

        void CargarDatosCMB()
        {
            try
            {
                CargarClientes();
                //CargarUnidad();
                CargarMunicipios();
                //CargarConductor();
                //CargarMetodoPago();
                //CargarEstadoViaje();
                //CargarTipoDestino();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los combobox.", "Error de carga",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        void CargarClientes()
        {
            try
            {
                DataTable dataClientes = ControladorIngreso.ObtenerCliente();
                cmbCliente.DataSource = dataClientes;
                cmbCliente.DisplayMember = "nombres_cliente AND apellidos_cliente";
                cmbCliente.ValueMember = "id_cliente";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los clientes.", "Error de carga",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

        void CargarMunicipios()
        {
            try
            {
                DataTable dataMunicipio = ControladorIngreso.ObtenerMunicipios();
                cmbMunicipios.DataSource = dataMunicipio;
                cmbMunicipios.DisplayMember = "municipio";
                cmbMunicipios.ValueMember = "id_municipio";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los municipios.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }

        void CargarUnidadTransporte()
        {
            try
            {
                DataTable dataTransporte = ControladorIngreso.ObtenerMunicipios();
                cmbMunicipios.DataSource = dataTransporte;
                cmbMunicipios.DisplayMember = "tipo_unidad";
                cmbMunicipios.ValueMember = "id_tipo_unidad";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las unidades de transporte.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void frmIngresarViaje_Load(object sender, EventArgs e)
        {
            CargarDatosCMB();
        }
    }
}
