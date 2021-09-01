using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
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
    }
}
