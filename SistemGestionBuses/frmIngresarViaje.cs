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
using MySql.Data.MySqlClient;

namespace SistemGestionBuses
{
    public partial class frmIngresarViaje : Form
    {
        public frmIngresarViaje()
        {
            InitializeComponent();
            CargarDatosCMB();
        }

        public DataTable datosViajes;
        public bool Vacio()
        {
            if (txtNombreViaje.Text.Trim() == "" &&
            txtTarifaViaje.Text.Trim() == "" &&
            cmbCliente.SelectedIndex == 0 &&
            cmbConductor.SelectedIndex == 0 &&
            cmbEstadoViaje.SelectedIndex == 0 &&
            //cmbMetodoPago.SelectedIndex == 0 &&
            cmbTipoDestino.SelectedIndex == 0 &&
            cmbCliente.SelectedIndex == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        void CargarGridDatos()
        {
            datosViajes = ControladorViaje.ViajesController();
            dataGridView1.DataSource = datosViajes;
        }

        //Metodo para limpiar los campos
        void LimpiarCampos()
        {
            txtNombreViaje.Clear();
            txtTarifaViaje.Clear();
            txtIDviaje.Clear();
            cmbCliente.SelectedValue = 1;
            cmbConductor.SelectedValue = 1;
            cmbEstadoViaje.SelectedValue = 1;
            cmbTipoDestino.SelectedValue = 1;
            cmbUnidadTransporte.SelectedValue = 1;
            dtpFechaRetorno.Value = Convert.ToDateTime("01 / 01 / 2021");
        }

        void CargarDatosCMB()
        {
            try
            {
                CargarClientes();
                CargarUnidadTransporte();
                //CargarMunicipios();
                //CargarConductor();
                CargarMetodoPago();
                CargarEstadoViaje();
                CargarTipoViaje();
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
                DataTable dataClientes = ControladorViaje.ObtenerCliente();
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

        //void CargarMunicipios()
        //{
        //    try
        //    {
        //        DataTable dataMunicipio = ControladorViaje.ObtenerMunicipios();
        //        cmbMunicipio_inicio.DataSource = dataMunicipio;
        //        cmbMunicipio_inicio.DisplayMember = "municipio";
        //        cmbMunicipio_inicio.ValueMember = "id_municipio";

        //        DataTable dataMunicipio2 = ControladorViaje.ObtenerMunicipios();
        //        cmbMunicipio_final.DataSource = dataMunicipio2;
        //        cmbMunicipio_final.DisplayMember = "municipio";
        //        cmbMunicipio_final.ValueMember = "id_municipio";
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Error al cargar los municipios.", "Error de carga",
        //                                         MessageBoxButtons.OK,
        //                                         MessageBoxIcon.Error);
        //    }
        //}

        void CargarUnidadTransporte()
        {
            try
            {
                DataTable dataTransporte = ControladorViaje.ObtenerTipoUnidadTransporte();
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
                //cmbMetodoPago.DataSource = dataMetodoPago;
                //cmbMetodoPago.DisplayMember = "metodo_pago";
                //cmbMetodoPago.ValueMember = "id_metodo_pago";
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

        void CargarTipoViaje()
        {
            try
            {
                DataTable dataTipoViaje = ControladorViaje.ObtenerTipoViaje();
                cmbTipoDestino.DataSource = dataTipoViaje;
                cmbTipoDestino.DisplayMember = "tipo_viaje";
                cmbTipoDestino.ValueMember = "id_tipo_viaje";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipos de viaje.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }
        #endregion



        void EnvioDatos()
        {
            double tarifa;
            string nombreViaje, fecha_partida, hora_partida, fecha_retorno, hora_retorno;
            int id_unidad, id_conductor, id_estado_viaje, id_tipo_viaje, id_municipio;
            nombreViaje = txtNombreViaje.Text;
            fecha_partida = dtpFechaRetorno.Text;
            hora_partida = dtpHoraRetorno.Text;
            fecha_retorno = dtpFechaRetorno.Text;
            hora_retorno = dtpHoraRetorno.Text;
            tarifa = Convert.ToDouble(txtTarifaViaje.Text);
            id_unidad = Convert.ToInt32(cmbUnidadTransporte.SelectedValue);
            id_estado_viaje = Convert.ToInt32(cmbEstadoViaje.SelectedValue);
            id_tipo_viaje = Convert.ToInt32(cmbTipoDestino.SelectedValue);
            id_conductor = Convert.ToInt32(cmbConductor.SelectedValue);
            id_municipio = Convert.ToInt32(cmbMunicipios.SelectedValue);
            //Llamar a la clase por objeto
            ControladorViaje viajeController = new ControladorViaje(nombreViaje, id_unidad, id_conductor, fecha_partida, hora_partida, tarifa, id_estado_viaje, id_tipo_viaje, fecha_retorno, hora_retorno, id_municipio);
            bool res = viajeController.EnviarDatos_ControllerViaje();
            if (  res == true)
            {
               
                if (res)
                {
                    MessageBox.Show("Viaje registrado exitosamente", "Confirmación de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Oops!, ocurrió un error al registrar el viaje, consulte con el administrador del sistema.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Oops!, ocurrió un error al registrar una de las direcciones, consulte con el administrador del sistema.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            Vacio();
            if (Vacio() == true)
            {
                MessageBox.Show("Todos los campos son requeridos", "Campos vaios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //EnvioDatos();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            MySqlConnection objvalor;
            objvalor = ControladorConexion.GetConn();
            if (objvalor != null)
            {
                MessageBox.Show("La conexión se estableció con exito.", "Comprobación de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al establecer conexión.", "Comprobación de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
