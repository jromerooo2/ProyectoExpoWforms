using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Controlador;

namespace SistemGestionBuses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarComboBoxes();
            CargarGrid();
        }
        DataTable unidades;
        public ControladorTransporte transportecontrol;

        /*Metodo para generar el nombre de la unidad por medio del tipo de la marca, la capacidad y el id de la unidad 
         capturando talvez el texto sleccionado en cada combobox y textbox concatenandolos de manera que sea efectivo*/
        void CrearNombreUnidad()
        {

        }

        void CargarComboBoxes()
        {
            try
            {
                CargarMarcas();
                CargarModelo();
                CargarTipoPlaca();
                CargarTipoUnidad();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los combobox.", "Error de carga",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        void CargarGrid()
        {
            unidades = ControladorTransporte.ObtenerUnidadesController();
            dgvUnidades.DataSource = unidades;
        }

        #region CMB
        void CargarTipoUnidad()
        {
            try
            {
                DataTable dataTransporte = ControladorTransporte.ObtenerTipoUnidadController();
                cmbTipoUnidad.DataSource = dataTransporte;
                cmbTipoUnidad.DisplayMember = "tipo_unidad";
                cmbTipoUnidad.ValueMember = "id_tipo_unidad";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipos unidades de transporte.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }

        void CargarMarcas()
        {
            try
            {
                DataTable dataMarca = ControladorTransporte.ObtenerMarcasController();
                cmbMarca.DataSource = dataMarca;
                cmbMarca.DisplayMember = "marca";
                cmbMarca.ValueMember = "id_marca";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipos unidades de transporte.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }
        void CargarModelo()
        {
            try
            {
                DataTable dataModelo = ControladorTransporte.ObtenerModelosController();
                cmbModelo.DataSource = dataModelo;
                cmbModelo.DisplayMember = "modelo";
                cmbModelo.ValueMember = "id_modelo";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipos unidades de transporte.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }
        void CargarTipoPlaca()
        {
            try
            {
                DataTable dataTipo = ControladorTransporte.ObtenerTipoPlacasController();
                cmbTipoPlaca.DataSource = dataTipo;
                cmbTipoPlaca.DisplayMember = "tipo_placa";
                cmbTipoPlaca.ValueMember = "id_tipo_placa";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipos unidades de transporte.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnCrearUnidad_Click(object sender, EventArgs e)
        {
            EnviarDatos();
            CargarGrid();
        }

        void EnviarDatos()
        {
            int id_marca, id_tipo_unidad, id_tipo_placa, id_modelo, capacidad, anio;
            string VIN, numero_chasis, numero_motor, placa;
            id_marca = Convert.ToInt32(cmbMarca.SelectedValue);
            id_tipo_placa = Convert.ToInt32(cmbTipoPlaca.SelectedValue);
            id_tipo_unidad = Convert.ToInt32(cmbTipoUnidad.SelectedValue);
            id_modelo = Convert.ToInt32(cmbModelo.SelectedValue);
            capacidad = Convert.ToInt32(txtCapacidad.Text);
            anio = Convert.ToInt32(txtAnio.Text);
            VIN = txtVIN.Text;
            numero_chasis = txtNumeroChasis.Text;
            numero_motor = txtNumeroMotor.Text;
            placa = txtPlaca.Text;
            transportecontrol = new ControladorTransporte(id_marca, anio, VIN, capacidad, id_modelo, placa, id_tipo_placa, id_tipo_unidad, numero_motor, numero_chasis);
            bool res = transportecontrol.IngresarUnidadesController();
            if (res == true)
            {
                MessageBox.Show("Unidad de transporte registrada exitosamente", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La unidad no pudo ser registrada", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        void LimpiarCampos()
        {
            txtAnio.Clear();
            txtCapacidad.Clear();
            txtNombreUnidad.Clear();
            txtNumeroChasis.Clear();
            txtNumeroMotor.Clear();
            txtPlaca.Clear();
            txtVIN.Clear();
        }
    }
}
