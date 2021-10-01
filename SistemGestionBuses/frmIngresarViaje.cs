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
            dgvViajes.AutoGenerateColumns = true;
            CargarDatosCMB();
            CargarGridDatos();
        }

        public bool Vacio()
        {
            if (txtNombreViaje.Text.Trim() == "" ||
            txtTarifaViaje.Text.Trim() == "" ||
            cmbCliente.SelectedIndex == -1 ||
            cmbConductor.SelectedIndex == -1 ||
            cmbEstadoViaje.SelectedIndex == -1 ||
            cmbTipoDestino.SelectedIndex == -1)
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
            //MessageBox.Show(dtpFechaPartida.Text);
            //MessageBox.Show(dtpFechaRetorno.Text);
            DataTable data = ControladorViaje.ObtenerViajes();
            dgvViajes.DataSource = data;
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
                CargarCliente();
                CargarTipoUnidadTransporte();
                CargarMunicipios();
                CargarConductor();
                //CargarMetodoPago();
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
        void CargarCliente()
        {
            try
            {
                DataTable dataUnidad = ControladorViaje.ObtenerCliente();
                cmbCliente.DataSource = dataUnidad;
                cmbCliente.DisplayMember = "nombres_cliente";
                cmbCliente.ValueMember = "id_cliente";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los clientes.", "Error de carga",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

        void CargarConductor()
        {
            try
            {
                DataTable dataMunicipio = ControladorViaje.ObtenerConductores();
                cmbConductor.DataSource = dataMunicipio;
                cmbConductor.DisplayMember = "nombres_empleado";
                cmbConductor.ValueMember = "id_empleado";
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar los conductores.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }

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

        void CargarTipoUnidadTransporte()
        {
            try
            {
                DataTable dataTransporte = ControladorViaje.ObtenerTipoUnidadTransporte();
                cmbUnidadTransporte.DataSource = dataTransporte;
                cmbUnidadTransporte.DisplayMember = "id_unidad_transporte";
                cmbUnidadTransporte.ValueMember = "id_unidad_transporte";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las unidades de transporte.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }

        //void CargarMetodoPago()
        //{
        //    try
        //    {
        //        DataTable dataMetodoPago = ControladorViaje.ObtenerMetodoPago();
        //        //cmbMetodoPago.DataSource = dataMetodoPago;
        //        //cmbMetodoPago.DisplayMember = "metodo_pago";
        //        //cmbMetodoPago.ValueMember = "id_metodo_pago";
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Error al cargar los metodos de pago.", "Error de carga",
        //                                         MessageBoxButtons.OK,
        //                                         MessageBoxIcon.Error);
        //    }
        //}

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
            
            string nombreViaje, fecha_partida, fecha_retorno,tarifa ;
            int id_unidad, id_conductor, id_estado_viaje, id_tipo_viaje, id_municipio, id_cliente;
            nombreViaje = txtNombreViaje.Text;
            fecha_partida = dtpFechaPartida.Text;
            fecha_retorno = dtpFechaRetorno.Text;
            tarifa = txtTarifaViaje.Text;
            id_unidad = Convert.ToInt16(cmbUnidadTransporte.SelectedValue);
            id_estado_viaje = Convert.ToInt16(cmbEstadoViaje.SelectedValue);
            id_cliente = Convert.ToInt16(cmbCliente.SelectedValue);
            id_tipo_viaje = Convert.ToInt16(cmbTipoDestino.SelectedValue) ;
            id_conductor = Convert.ToInt16(cmbConductor.SelectedValue);
            id_municipio = Convert.ToInt16(cmbMunicipios.SelectedValue);
            //Llamar a la clase por objeto
            MessageBox.Show(fecha_partida);
            MessageBox.Show(fecha_retorno);
            ControladorViaje viajeController = new ControladorViaje(nombreViaje, id_cliente, id_unidad, id_conductor, fecha_partida, tarifa, id_estado_viaje, id_tipo_viaje, fecha_retorno, id_municipio);
            bool res = viajeController.EnviarDatos_ControllerViaje();
            if (res == true)
            {
                MessageBox.Show("Viaje registrado exitosamente", "Confirmación de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Oops!, ocurrió un error al registrar el viaje, consulte con el administrador del sistema.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void frmIngresarViaje_Load(object sender, EventArgs e)
        {
            CargarDatosCMB();
            CargarGridDatos();
            LimpiarCampos();
        }

        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            if (Vacio() == true)
            {
                MessageBox.Show("Todos los campos son requeridos", "Campos vaios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EnvioDatos();
                CargarGridDatos();
            }      
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarGridDatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbConductor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
