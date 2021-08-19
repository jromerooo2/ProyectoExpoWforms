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
    public partial class frmIngresoConductores : Form
    {
        public DataTable datosCond;
        public ControladorIngreso objCond;
        //cmb Cargar Cargo
        void CargarCargo()
        {
            try
            {
                DataTable dataCargo = ControladorIngreso.ObtenerCargo();
                cmbCargo.DataSource = dataCargo;
                cmbCargo.DisplayMember = "cargo";
                cmbCargo.ValueMember = "id_cargo";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los cargo.", "Error de carga.",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }
        //cmb Cargar Genero
        void CargarGenero()
        {
            try
            {
                DataTable dataGenero = ControladorIngreso.ObtenerGenero();
                cmbGenero.DataSource = dataGenero;
                cmbGenero.DisplayMember = "genero";
                cmbGenero.ValueMember = "id_genero";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los generos.", "Error de carga.",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }
        //cmb Cargar Municipios
        void CargarMunicipios()
        {
            try
            {
                DataTable dataMunicipio = ControladorIngreso.ObtenerMunicipios();
                cmbMunicipio.DataSource = dataMunicipio;
                cmbMunicipio.DisplayMember = "municipio";
                cmbMunicipio.ValueMember = "id_municipio";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los municipios.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }
        //cmb Cargar Estado
        void CargarEstado()
        {
            try
            {
                DataTable dataEstado = ControladorIngreso.ObtenerEstado();
                cmbEstado.DataSource = dataEstado;
                cmbEstado.DisplayMember = "estado_conductor";
                cmbEstado.ValueMember = "id_estado_conduc";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los municipios.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }
        //Cargar Datos
        void CargarDatos()
        {
            try
            {
                CargarCargo();
                CargarEstado();
                CargarMunicipios();
                CargarGenero();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos." + ex.Message, "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Envio de Datos
        void EnvioDatos()
        {

            try
            {
                string nombre_empleado, apellido_empleado, DUI, NIT, direccion_empleado, telefono_empleado, nacimiento_empleado;
                int id_genero, id_estado_conduc, id_cargo, id_municipio;
                nombre_empleado = TxtNombres.Text;
                apellido_empleado = TxtApellidos.Text;
                DUI = TxtDUI.Text;
                NIT = txtNIT.Text;
                direccion_empleado = TxtDireccion.Text;
                telefono_empleado = txtNumero.Text;
                nacimiento_empleado = dtNacimiento.Text;
                id_genero = Convert.ToInt16(cmbCargo.SelectedValue);
                id_estado_conduc= Convert.ToInt16(cmbEstado.SelectedValue);
                id_cargo = Convert.ToInt16(cmbCargo.SelectedValue);
                id_municipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
                //INSTANCIAR OBJETO
                objCond = new ControladorIngreso(nombre_empleado, apellido_empleado, DUI, NIT, nacimiento_empleado, direccion_empleado, telefono_empleado, id_genero, id_estado_conduc, id_cargo, id_municipio );
                bool respuesta = objCond.EnviarDatosControlador();
                if (respuesta == true)
                {
                    MessageBox.Show("Usuario registrado exitosamente", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no pudo ser registrado", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Oops!, ocurrió un error al registrar al empleado, consulte con el administrador del sistema.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public frmIngresoConductores()
        {
            InitializeComponent();
        }

        private void frmIngresoConductores_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }



        private void dtNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbMunicipios_Click(object sender, EventArgs e)
        {
            cmbMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
     
            CargarMunicipios();
        }

        private void cmbMunicipio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
           
        }

        private void cmbCargo_click(object sender, EventArgs e)
        {
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarCargo();
        }

        private void cmbEstado_click(object sender, EventArgs e)
        {
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarEstado();
        }

        private void cmbGenero_click()
        {
          


        }

        private void btnAgregar_click(object sender, EventArgs e)
        {

            EnvioDatos();
        }



        private void cmbGenero_click(object sender, EventArgs e)
        {
            CargarGenero();
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
