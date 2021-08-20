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
        public ControladorViaje objViaje;
        public DataTable datosViaje;
        public static int id_viaje, id_destino;

        public bool Vacio()
        {
            if (txtDestino.Text.Trim() == "" &&
            txtNombreViaje.Text.Trim() == "" &&
            txtTarifaViaje.Text.Trim() == "" &&
            cmbCliente.SelectedIndex == 0 &&
            cmbConductor.SelectedIndex == 0 &&
            cmbEstadoViaje.SelectedIndex == 0 &&
            cmbMetodoPago.SelectedIndex == 0 &&
            cmbTipoDestino.SelectedIndex == 0 &&
            cmbMunicipios.SelectedIndex == 0 &&
            cmbCliente.SelectedIndex == 0)
            {
                return true;
            }
            else
            {
                return false;
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
                //CargarClientes();
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
        //void CargarClientes()
        //{
        //    try
        //    {
        //        DataTable dataClientes = ControladorViaje.ObtenerCliente();
        //        cmbCliente.DataSource = dataClientes;
        //        cmbCliente.DisplayMember = "nombres_cliente AND apellidos_cliente";
        //        cmbCliente.ValueMember = "id_cliente";
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Error al cargar los clientes.", "Error de carga",
        //                         MessageBoxButtons.OK,
        //                         MessageBoxIcon.Error);
        //    }
        //}

        void CargarMunicipios()
        {
            try
            {
                DataTable dataMunicipio = ControladorViaje.ObtenerMunicipios();
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
                DataTable dataTransporte = ControladorViaje.ObtenerTipoUnidadTransporte(  );
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
                DataTable dataMetodoPago = ControladorViaje.ObtenerMetodoPago();
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
                DataTable dataMetodoPago = ControladorViaje.ObtenerEstadoViaje();
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


        void EnvioDatos()
        {
            string nombreViaje, fecha_viaje, destino;
            int id_unidad, id_empleado, id_estado_viaje, id_metodo_pago, id_cliente, id_municipio, tarifa, id_tipo_destino;
            nombreViaje = txtNombreViaje.Text;
            fecha_viaje = dtpFechaViaje.Text;
            tarifa = Convert.ToInt32(txtTarifaViaje.Text);
            destino = txtDestino.Text;
            id_unidad = Convert.ToInt16(cmbUnidadTransporte.SelectedValue);
            id_metodo_pago = Convert.ToInt16(cmbMetodoPago.SelectedValue);
            id_estado_viaje = Convert.ToInt16(cmbEstadoViaje.SelectedValue);
            id_empleado = Convert.ToInt16(cmbConductor.SelectedValue);
            id_cliente = Convert.ToInt16(cmbCliente.SelectedValue);
            id_municipio = Convert.ToInt16(cmbMunicipios.SelectedValue);
            id_tipo_destino = Convert.ToInt16(cmbTipoDestino.SelectedValue);
            objViaje = new ControladorViaje(id_cliente, id_unidad, id_metodo_pago, id_empleado, id_municipio, id_estado_viaje, tarifa, id_tipo_destino, nombreViaje, destino, fecha_viaje, id_destino);
            objViaje.EnviarDatos_ControllerDestino();
            bool respuestadestino = objViaje.EnviarDatos_ControllerDestino();
            if (respuestadestino == true)
            {
                txtIDdestino.Text = Convert.ToString(ControladorViaje.id_destino);
                bool respuestaviaje = objViaje.EnviarDatos_ControllerViaje();
                if (respuestaviaje == true)
                {
                    MessageBox.Show("Destino registrado exitosamente", "Confirmación de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Viaje registrado exitosamente", "Confirmación de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Oops!, ocurrió un error al registrar el viaje, consulte con el administrador del sistema.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Oops!, ocurrió un error al registrar del destino, consulte con el administrador del sistema.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }


        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void frmIngresarViaje_Load(object sender, EventArgs e)
        {
            CargarDatosCMB();
            LimpiarCampos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            Vacio();
            if (Vacio() == true)
            {
                MessageBox.Show("Todos los campos son requeridos", "Campos vaios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EnvioDatos();
            }            
        }
    }
}
