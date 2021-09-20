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
    public partial class frmUnidades : Form
    {
        public frmUnidades()
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
                CargarEstadoUnidad();
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
            //dgvunidades.columns[0].headertext = "id usuario";
            //dgvunidades.columns[0].visible = false;
            dgvUnidades.Columns[0].HeaderText = "Año";
            dgvUnidades.Columns[1].HeaderText = "VIN";
            dgvUnidades.Columns[2].HeaderText = "Capacidad";
            dgvUnidades.Columns[3].HeaderText = "Placa";
            dgvUnidades.Columns[4].HeaderText = "Tipo de Placa";
            dgvUnidades.Columns[5].HeaderText = "Tipo de Unidad";
            dgvUnidades.Columns[6].HeaderText = "Modelo";
            dgvUnidades.Columns[7].HeaderText = "Marca";
            dgvUnidades.Columns[8].HeaderText = "Estado de la Unidad";
            dgvUnidades.Columns[9].HeaderText = "Número de Motor";
            dgvUnidades.Columns[10].HeaderText = "Número de Chasis";
        }

        #region CMB
        void CargarEstadoUnidad()
        {
            try
            {
                DataTable dataEstado = ControladorTransporte.ObtenerEstadoUnidadController();
                cmbEstadoUnidad.DataSource = dataEstado;
                cmbEstadoUnidad.DisplayMember = "estado_unidad";
                cmbEstadoUnidad.ValueMember = "id_estado_unidad";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipos unidades de transporte.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }

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
            int id_marca, id_tipo_unidad, id_tipo_placa, id_modelo, capacidad, anio, id_estado_unidad;
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
            id_estado_unidad = Convert.ToInt32(cmbEstadoUnidad.SelectedValue);
            transportecontrol = new ControladorTransporte(id_marca, anio, VIN, capacidad, id_modelo, placa, id_tipo_placa, id_tipo_unidad, id_estado_unidad,numero_motor, numero_chasis);
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

        void EliminarUnidad()
        {
            ControladorTransporte.id_unidad_transporte = Convert.ToInt16(txtIDunidad.Text);
            bool res = ControladorTransporte.EliminarUnidad();
            if (res == true)
            {
                MessageBox.Show("Unidad de transporte eliminada exitosamente", "Confirmación de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La unidad no pudo ser eliminada", "Confirmación de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar a: " + txtPlaca.Text + "?",
            "Confirmar eliminación", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EliminarUnidad();
                CargarGrid();
            }         
        }

        private void dgvUnidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvUnidades.CurrentRow.Index;
            txtIDunidad.Text = dgvUnidades[0,i].Value.ToString();
            txtAnio.Text = dgvUnidades[2, i].Value.ToString();
            txtVIN.Text = dgvUnidades[3, i].Value.ToString();
            txtCapacidad.Text = dgvUnidades[4, i].Value.ToString();
            txtPlaca.Text = dgvUnidades[6, i].Value.ToString();
            txtNumeroMotor.Text = dgvUnidades[10, i].Value.ToString();
            txtNumeroChasis.Text = dgvUnidades[11, i].Value.ToString();

            int id_marca = Convert.ToInt16(dgvUnidades[1, i].Value);
            cmbMarca.DataSource = ControladorTransporte.ObtenerMarcasInner(id_marca);
            cmbMarca.DisplayMember = "marca";
            cmbMarca.ValueMember = "id_marca";
            int id_modelo = Convert.ToInt16(dgvUnidades[5, i].Value);
            cmbModelo.DataSource = ControladorTransporte.ObtenerModeloInner(id_modelo);
            cmbModelo.DisplayMember = "modelo";
            cmbModelo.ValueMember = "id_modelo";
            int id_tipo_placa = Convert.ToInt16(dgvUnidades[7, i].Value);
            cmbTipoPlaca.DataSource = ControladorTransporte.ObtenerTipoPlacaInner(id_tipo_placa);
            cmbTipoPlaca.DisplayMember = "tipo_placa";
            cmbTipoPlaca.ValueMember = "id_tipo_placa";
            int id_tipo_unidad = Convert.ToInt16(dgvUnidades[8, i].Value);
            cmbTipoUnidad.DataSource = ControladorTransporte.ObtenerTipoUnidadInner(id_tipo_unidad);
            cmbTipoUnidad.DisplayMember = "tipo_unidad";
            cmbTipoUnidad.ValueMember = "id_tipo_unidad";
            int id_estado_unidad = Convert.ToInt16(dgvUnidades[9, i].Value);
            cmbEstadoUnidad.DataSource = ControladorTransporte.ObtenerEstadoUnidadInner(id_estado_unidad);
            cmbEstadoUnidad.DisplayMember = "estado_unidad";
            cmbEstadoUnidad.ValueMember = "id_estado_unidad";

            CargarComboBoxes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
            CargarGrid();
        }

        void ActualizarDatos()
        {
            int id_marca, id_tipo_unidad, id_tipo_placa, id_modelo, capacidad, anio, id_estado_unidad;
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
            id_estado_unidad = Convert.ToInt32(cmbEstadoUnidad.SelectedValue);

            ControladorTransporte.id_unidad_transporte = Convert.ToInt16(txtIDunidad.Text);
            transportecontrol = new ControladorTransporte(id_marca, anio, VIN, capacidad, id_modelo, placa, id_tipo_placa, id_tipo_unidad,id_estado_unidad, numero_motor, numero_chasis);
            bool res = transportecontrol.ActualizarUnidadController();
            if (res == true)
            {
                MessageBox.Show("Unidad de transporte registrada exitosamente", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La unidad no pudo ser registrada", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbMarca_Click(object sender, EventArgs e)
        {
            
        }

        private void panelBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizarGrid_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }
    }
}
