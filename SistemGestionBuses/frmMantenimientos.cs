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
    public partial class frmMantenimientos : Form
    {
        public frmMantenimientos()
        {
            InitializeComponent();
            CargarDataGridView();
            CargarUnidadCMB();
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnAgregar.Enabled = true;
            CargarUnidadCMB();
        }

        private void frmMantenimientos_Load(object sender, EventArgs e)
        {
            CargarDataGridView();
            CargarUnidadCMB();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            if (ControladorConexion.GetConn() != null)
            {
                MessageBox.Show("La conexión se ha establecido con éxito", "Conexion",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo establecer conexión con la base", "Conexion",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable datosMan;
        public ControladorMantenimiento objMant;

        void CargarUnidadCMB()
        {
            try
            {
                DataTable datosUnidad = ControladorMantenimiento.RetornoCargarUnidad();
                cmbUnidad.DataSource = datosUnidad;
                cmbUnidad.DisplayMember = "placa";
                cmbUnidad.ValueMember = "id_unidad_transporte";
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo establecer conexión con la base", "Conexion",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CargarDataGridView()
        {
            datosMan = ControladorMantenimiento.ObtenerMantenimiento();
            DgvMantenimiento.DataSource = datosMan;
            DgvMantenimiento.Columns[0].Visible = false;
            DgvMantenimiento.Columns[1].HeaderText = "Unidad de transporte";
            DgvMantenimiento.Columns[2].HeaderText = "Monto del Mantenimiento";
            DgvMantenimiento.Columns[3].HeaderText = "Ultimo Kilometraje";
            DgvMantenimiento.Columns[4].HeaderText = "Descripcion del Mantenimiento";
            DgvMantenimiento.Columns[5].HeaderText = "Fecha";
        }

        //CRUD
        //RegistroMantenimiento
        void RegistroMantenimiento()
        {
            try
            {
                int id_unidad_transporte;
                double monto_mantenimiento, ultimo_kilometraje;
                string descripcion, fecha;
                id_unidad_transporte = Convert.ToInt16(cmbUnidad.SelectedValue);
                monto_mantenimiento = Convert.ToDouble(txtMonto.Text);
                ultimo_kilometraje = Convert.ToDouble(TxtKilom.Text);
                descripcion = TxtDescripcion.Text;
                fecha = DtFecha.Text;
                objMant = new ControladorMantenimiento(id_unidad_transporte, monto_mantenimiento,
                            ultimo_kilometraje, descripcion, fecha);
                bool respuesta = objMant.RegistrarMantenimiento();
                if (respuesta == true)
                {
                    MessageBox.Show("El mantenimiento se registró con éxito",
                        "Confirmación de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El mantenimiento no pudo ser registrado",
                        "Confirmación de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops!, se produjo un error externo al registrar mantenimiento.", "Error Crítico",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            RegistroMantenimiento();
            CargarDataGridView();
        }

        //ActualizaciónMantenimiento
        void ActualizacioMantenimiento()
        {
            try
            {
                int id_unidad_transporte;
                double monto_mantenimiento, ultimo_kilometraje;
                string descripcion, fecha;
                id_unidad_transporte = Convert.ToInt16(cmbUnidad.SelectedValue);
                monto_mantenimiento = Convert.ToDouble(txtMonto.Text);
                ultimo_kilometraje = Convert.ToDouble(TxtKilom.Text);
                descripcion = TxtDescripcion.Text;
                fecha = DtFecha.Text;
                ControladorMantenimiento.id_mantenimiento = Convert.ToInt16(txtId.Text);
                objMant = new ControladorMantenimiento(id_unidad_transporte, monto_mantenimiento, ultimo_kilometraje, descripcion, fecha);
                bool respuesta = objMant.ActualizarMantenimiento_Controller();
                if (respuesta == true)
                {
                    MessageBox.Show("Mantenimiento actualizado con éxito",
                        "Confirmación de actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mantenimiento no pudo ser actualizado",
                        "Confirmación de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops!, se produjo un error externo al actualizar mantenimiento.", "Error Crítico",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvMantenimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnAgregar.Enabled = true;
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;

            int posicion = DgvMantenimiento.CurrentRow.Index;
            txtId.Text = DgvMantenimiento[0, posicion].Value.ToString();
            txtMonto.Text = DgvMantenimiento[2, posicion].Value.ToString();
            TxtKilom.Text = DgvMantenimiento[3, posicion].Value.ToString();
            TxtDescripcion.Text = DgvMantenimiento[4, posicion].Value.ToString();
            DtFecha.Text = DgvMantenimiento[5, posicion].Value.ToString();

            int idUnidad = Convert.ToInt16(DgvMantenimiento[1, posicion].Value.ToString());
            cmbUnidad.DataSource = ControladorMantenimiento.CargarUnidadInner_Controller(idUnidad);
            cmbUnidad.ValueMember = "id_unidad_transporte";
            cmbUnidad.DisplayMember = "placa";
        }

        private void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbUnidad_Click(object sender, EventArgs e)
        {
            CargarUnidadCMB();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CargarDataGridView();
            ActualizacioMantenimiento();
        }

        //EliminaciónMantenimiento
        void EliminarMantenimiento()
        {
            ControladorMantenimiento.id_mantenimiento = Convert.ToInt16(txtId.Text);
            bool respuesta = ControladorMantenimiento.EliminarMantenimiento_Controller();
            if (respuesta == true)
            {
                MessageBox.Show("Mantenimiento eliminado con éxito", "Confirmación de eliminación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mantenimiento no pudo ser eliminado", "Confirmación de eliminación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar el vehículo con matrícula " + cmbUnidad.SelectedValue + "?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EliminarMantenimiento();
                CargarDataGridView();
            }
        }

        //LimpiarCampos
        void LimpiarCampos()
        {
            TxtDescripcion.Clear();
            TxtKilom.Clear();
            txtId.Clear();
            txtMonto.Clear();
            cmbUnidad.InitializeLifetimeService();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}

