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

        void Vacio()
        {
            if (txtDestino.Text.Trim() == "" &&
            txtNombreViaje.Text.Trim() == "" &&
            txtTarifaViaje.Text.Trim() == "")
            {

            }
            
        }


        //Metodo para limpiar los campos
        void LimpiarCampos()
        {
            txtDestino.Clear();
            txtNombreViaje.Clear();
            txtTarifaViaje.Clear();
            txtIDviaje.Clear();
            txtIDdestino.Clear();
            cmbCliente.SelectedValue = 1;
            cmbConductor.SelectedValue = 1;
            cmbEstadoViaje.SelectedValue = 1;
            cmbMetodoPago.SelectedValue = 1;
            cmbMunicipios.SelectedValue = 1;
            cmbTipoDestino.SelectedValue = 1;
            cmbUnidadTransporte.SelectedValue = 1;
            dtpFechaViaje.Value = Convert.ToDateTime("01 / 01 / 2021");
        }

        void CargarDatosCMB()
        {
            try
            {
                CargarClientes();
                CargarUnidadTransporte();
                CargarMunicipios();
                //CargarConductor();
                CargarMetodoPago();
                CargarEstadoViaje();
                //CargarTipoDestino();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los combobox.", "Error de carga",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }
        //Region de todos los metodos para cargar los combobox
        #region CMB
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
                DataTable dataTransporte = ControladorIngreso.ObtenerTipoUnidadTransporte(  );
                cmbUnidadTransporte.DataSource = dataTransporte;
                cmbUnidadTransporte.DisplayMember = "tipo_unidad";
                cmbUnidadTransporte.ValueMember = "id_tipo_unidad";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las unidades de transporte.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }

        void CargarMetodoPago()
        {
            try
            {
                DataTable dataMetodoPago = ControladorIngreso.ObtenerMetodoPago();
                cmbMetodoPago.DataSource = dataMetodoPago;
                cmbMetodoPago.DisplayMember = "metodo_pago";
                cmbMetodoPago.ValueMember = "id_metodo_pago";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los metodos de pago.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }

        void CargarEstadoViaje()
        {
            try
            {
                DataTable dataMetodoPago = ControladorIngreso.ObtenerEstadoViaje();
                cmbEstadoViaje.DataSource = dataMetodoPago;
                cmbEstadoViaje.DisplayMember = "estado_viaje";
                cmbEstadoViaje.ValueMember = "id_estado_viaje";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los metodos de pago.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }
        #endregion 

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void frmIngresarViaje_Load(object sender, EventArgs e)
        {
            CargarDatosCMB();
            LimpiarCampos();
        }
    }
}
