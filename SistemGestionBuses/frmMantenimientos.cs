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
        void EnvioDatos()
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
                fecha = DtMant.Text;
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

