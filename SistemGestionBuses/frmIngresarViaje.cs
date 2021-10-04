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
        public static int cargouser;
        public static int IdUserLogged;
        public static string cargostring;
        public static string username;
        public frmIngresarViaje(int cargo, int idUser, string cargo_string, string user)
        {
            InitializeComponent();
            dgvViajes.AutoGenerateColumns = true;
            cargouser = cargo;
            IdUserLogged = idUser;
            username = user;
            cargostring = cargo_string;
            txtActiveUser.Text = username;
            txtCargoStrip.Text = cargostring;
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

        void ActualizarDatos()
        {

            string nombreViaje, fecha_partida, fecha_retorno, tarifa, id_viaje;
            int id_unidad, id_conductor, id_estado_viaje, id_tipo_viaje, id_municipio, id_cliente;
            id_viaje = txtIDviaje.Text;
            nombreViaje = txtNombreViaje.Text;
            fecha_partida = dtpFechaPartida.Text;
            fecha_retorno = dtpFechaRetorno.Text;
            tarifa = txtTarifaViaje.Text;
            id_unidad = Convert.ToInt16(cmbUnidadTransporte.SelectedValue);
            id_estado_viaje = Convert.ToInt16(cmbEstadoViaje.SelectedValue);
            id_cliente = Convert.ToInt16(cmbCliente.SelectedValue);
            id_tipo_viaje = Convert.ToInt16(cmbTipoDestino.SelectedValue);
            id_conductor = Convert.ToInt16(cmbConductor.SelectedValue);
            id_municipio = Convert.ToInt16(cmbMunicipios.SelectedValue);

            bool res = ControladorViaje.Actualizar(id_viaje, nombreViaje, id_cliente, id_unidad, id_conductor, fecha_partida, tarifa, id_estado_viaje, id_tipo_viaje, fecha_retorno, id_municipio);

            if (res == true)
            {
                MessageBox.Show("Viaje Actualizado exitosamente", "Confirmación de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridDatos();
            }
            else
            {
                MessageBox.Show("Oops!, ocurrió un error al actualizar el viaje, consulte con el administrador del sistema.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbConductor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int posicion = dgvViajes.CurrentRow.Index;
            ////envio datos hacia texbox
            //txtIDviaje.Text = dgvViajes[0, posicion].Value.ToString();
            //txtNombreViaje.Text = dgvViajes[1, posicion].Value.ToString();
            //int cliente = Convert.ToInt16(dgvViajes[2, posicion].Value.ToString());
            //cmbCliente.DataSource = ControladorViaje.CargarClienteInner(cliente);
        }

        private void dgvViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvViajes.CurrentRow.Index;
            txtIDviaje.Text = dgvViajes[0, i].Value.ToString();
            txtNombreViaje.Text = dgvViajes[1, i].Value.ToString();
            dtpFechaPartida.Text = dgvViajes[5, i].Value.ToString();
            dtpFechaRetorno.Text = dgvViajes[9, i].Value.ToString();
            txtTarifaViaje.Text = dgvViajes[6,i].Value.ToString();

            string id_cliente = dgvViajes[2, i].Value.ToString();
            cmbCliente.DataSource = ControladorViaje.ObtenerClienteInner(id_cliente);
            cmbCliente.DisplayMember = "nombres_cliente";
            cmbCliente.ValueMember = "id_cliente";

            string id_unidad = dgvViajes[3, i].Value.ToString();
            cmbUnidadTransporte.DataSource = ControladorViaje.ObtenerUnidadInner(id_unidad);
            cmbUnidadTransporte.DisplayMember = "id_unidad_transporte";
            cmbUnidadTransporte.ValueMember = "id_unidad_transporte";

            string id_empleado = dgvViajes[4, i].Value.ToString();
            DataTable dataMunicipio = ControladorViaje.ObtenerConductoresInner(id_empleado);
            cmbConductor.DataSource = dataMunicipio;
            cmbConductor.DisplayMember = "nombres_empleado";
            cmbConductor.ValueMember = "id_empleado";


            string id_estado = dgvViajes[7, i].Value.ToString();
            cmbEstadoViaje.DataSource = ControladorViaje.ObtenerEstadoInner(id_estado);
            cmbEstadoViaje.DisplayMember = "estado_viaje";
            cmbEstadoViaje.ValueMember = "id_estado_viaje";

            string id_tipo = dgvViajes[8, i].Value.ToString();
            cmbTipoDestino.DataSource = ControladorViaje.ObtenerTipoViajeInner(id_tipo);
            cmbTipoDestino.DisplayMember = "tipo_viaje";
            cmbTipoDestino.ValueMember = "id_tipo_viaje";

            string id_municipio = dgvViajes[10, i].Value.ToString();
            cmbMunicipios.DataSource = ControladorViaje.ObtenerMunicipioInner(id_tipo);
            cmbMunicipios.DisplayMember = "municipio";
            cmbMunicipios.ValueMember = "id_municipio";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro de eliminar al viaje : " + txtNombreViaje.Text + "?", "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EliminarDatos();
            }
            
        }

        private void EliminarDatos()
        {
            bool res = ControladorViaje.EliminarViaje(txtIDviaje.Text);

            if (res == true)
            {
                MessageBox.Show("Viaje eliminado exitosamente", "Confirmación de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridDatos();
            }
            else
            {
                MessageBox.Show("Oops!, ocurrió un error al eliminar el viaje, consulte con el administrador del sistema.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCliente_Click(object sender, EventArgs e)
        {
            CargarDatosCMB();
        }

        private void cmbEstadoViaje_Click(object sender, EventArgs e)
        {
            CargarDatosCMB();
        }

        private void cmbTipoDestino_Click(object sender, EventArgs e)
        {
            CargarDatosCMB();
        }

        private void cmbUnidadTransporte_Click(object sender, EventArgs e)
        {
            CargarDatosCMB();
        }

        private void cmbConductor_Click(object sender, EventArgs e)
        {
            CargarDatosCMB();
        }

        private void cmbMunicipios_Click(object sender, EventArgs e)
        {
            CargarDatosCMB();
        }
    }
}
