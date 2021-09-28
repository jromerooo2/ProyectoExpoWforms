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
        public DataTable datosMan;
        public ControladorMantenimiento objMant;
        //cmb Cargar Unidad
        void CargarUnidad()
        {
            try
            {
                DataTable dataUnidad = ControladorMantenimiento.ObtenerUnidad();
                cmbUnidad.DataSource = dataUnidad;
                cmbUnidad.DisplayMember = "placa";
                cmbUnidad.ValueMember = "id_unidad_transporte";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las Unidades.", "Error de carga.",
                                                                MessageBoxButtons.OK,
                                                                MessageBoxIcon.Error);
            }
        }
        //CARGAR GRID DE DATOS
        void CargarGridDatos()
        {
            CargarUnidad();
            datosMan = ControladorMantenimiento.CargarMantenimiento_Controlador();
            DgvMantenimiento.DataSource = datosMan;
            DgvMantenimiento.Columns[0].Visible = false;

        }
        //CREAR DATOS
        void RegistroDatos()
        {
            try
            {
                int  id_unidad_transporte;
                string descripcion, fecha;
                double monto_mantenimiento,ultimo_kilometraje;
                id_unidad_transporte = Convert.ToInt16(cmbUnidad.SelectedValue);
                monto_mantenimiento =Convert.ToDouble(txtMonto.Text);
                ultimo_kilometraje = Convert.ToDouble(TxtKilom.Text);
                descripcion = TxtDescripcion.Text;
                fecha = DtFecha.Text;
                //Instanciar Objeto
                objMant = new ControladorMantenimiento(id_unidad_transporte, monto_mantenimiento, ultimo_kilometraje, descripcion, fecha);
                bool respuesta = objMant.EnviarDatosControlador();
                if (respuesta==true)
                {
                    MessageBox.Show("Mantenimiento registrado exitosamente", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Mantenimiento no pudo ser registrado", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Oops!, ocurrió un error al registrar el mantenimiento, consulte con el administrador del sistema.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public frmMantenimientos()
        {
            InitializeComponent();
            CargarUnidad();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            EnvioDatos();
            CargarUnidad();

        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            MySqlConnection objvalor;
            objvalor = ControladorConexion.GetConn();
            if (objvalor != null)
            {
                MessageBox.Show("Conexión se estableció con exito.");
            }
            else
            {
                MessageBox.Show("Error al establecer conexión.");
            }
        }

        //ActualizarMantenimiento
        void ActualizarMantenimiento()
        {
            try
            {
                int id_unidad_transporte;
                string descripcion, fecha;
                double monto_mantenimiento, ultimo_kilometraje;
                id_unidad_transporte = Convert.ToInt16(cmbUnidad.SelectedValue);
                monto_mantenimiento = Convert.ToDouble(txtMonto.Text);
                ultimo_kilometraje = Convert.ToDouble(TxtKilom.Text);
                descripcion = TxtDescripcion.Text;
                fecha = DtFecha.Text;
                //Instanciar Objeto
                ControladorMantenimiento.id_mantenimiento = Convert.ToInt16(txtId.Text);
                objMant = new ControladorMantenimiento(id_unidad_transporte,
                    monto_mantenimiento,ultimo_kilometraje,descripcion,fecha);
                bool respuesta = objMant.RetornoUpdate_mantenimiento();
                if (respuesta == true)
                {
                    MessageBox.Show("Mantenimiento actualizado con éxito", "Confirmación de actualización",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mantenimiento no pudo ser actualizado", "Confirmación de actualización",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DgvMantenimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = DgvMantenimiento.CurrentRow.Index;

            //Cargando data a los textboxes
            txtId.Text = DgvMantenimiento[0, posicion].Value.ToString();
            txtMonto.Text = DgvMantenimiento[2, posicion].Value.ToString();
            TxtKilom.Text = DgvMantenimiento[3, posicion].Value.ToString();
            TxtDescripcion.Text = DgvMantenimiento[4, posicion].Value.ToString();
            DtFecha.Text = DgvMantenimiento[5, posicion].Value.ToString();

            //Cargando data a los comboboxes
            int idunidad = Convert.ToInt16(DgvMantenimiento[1,posicion].Value.ToString());
            cmbUnidad.DataSource = ControladorMantenimiento.ActualizarUnidad_Controller(idunidad);
            cmbUnidad.ValueMember = "id_unidad_transporte";
            cmbUnidad.DisplayMember = "placa";
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarMantenimiento();
        }

        //EliminarMantenimiento
        void EliminarMantenimiento()
        {
            ControladorMantenimiento.id_mantenimiento = Convert.ToInt16(txtId.Text);
            bool respuesta = objMant.RetornoDelete_mantenimiento();
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
            EliminarMantenimiento();
        }
    }
}

