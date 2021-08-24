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
                cmbEstado.DisplayMember = "estado_empleado";
                cmbEstado.ValueMember = "id_estado_empleado";
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
                int id_genero, id_estado_empleado, id_cargo, id_municipio;
                nombre_empleado = TxtNombres.Text;
                apellido_empleado = TxtApellidos.Text;
                DUI = TxtDUI.Text;
                NIT = txtNIT.Text;
                telefono_empleado = txtTelefono.Text;
                nacimiento_empleado = dtNacimiento.Text;
                id_genero = Convert.ToInt16(cmbCargo.SelectedValue);
                id_estado_empleado= Convert.ToInt16(cmbEstado.SelectedValue);
                id_cargo = Convert.ToInt16(cmbCargo.SelectedValue);
                id_municipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
                direccion_empleado = TxtDireccion.Text;
                //INSTANCIAR OBJETO
                objCond = new ControladorIngreso(nombre_empleado, apellido_empleado, DUI, NIT, direccion_empleado, telefono_empleado, id_genero, id_estado_empleado, id_cargo, id_municipio, nacimiento_empleado);
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
        //CARGAR GRID DATOS
        void CargarGridDatos()
        {

            datosCond = ControladorIngreso.CargarEmpleadoControlador();
            dgvEmpleado.DataSource = datosCond;
        }
        //ACTUALIZAR DATOS
        void ActualizarDatos()
        {
            try
            {
                string nombre_empleado, apellido_empleado, DUI, NIT, direccion_empleado, telefono_empleado, nacimiento_empleado;
                int id_genero, id_estado_empleado, id_cargo, id_municipio;
                nombre_empleado = TxtNombres.Text;
                apellido_empleado = TxtApellidos.Text;
                DUI = TxtDUI.Text;
                NIT = txtNIT.Text;
                telefono_empleado = txtTelefono.Text;
                nacimiento_empleado = dtNacimiento.Text;
                id_genero = Convert.ToInt16(cmbCargo.SelectedValue);
                id_estado_empleado = Convert.ToInt16(cmbEstado.SelectedValue);
                id_cargo = Convert.ToInt16(cmbCargo.SelectedValue);
                id_municipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
                direccion_empleado = TxtDireccion.Text;
                //INSTANCIAR OBJETO
                ControladorIngreso.id_empleado = Convert.ToInt16(txtId.Text);
                objCond = new ControladorIngreso(nombre_empleado, apellido_empleado, DUI, NIT, direccion_empleado, telefono_empleado, id_genero, id_estado_empleado, id_cargo, id_municipio, nacimiento_empleado);
                bool respuesta = objCond.ActualizarDatosControlador();
                if (respuesta == true)
                {
                    MessageBox.Show("Usuario actualizado exitosamente", "Confirmación de actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no pudo ser actualizado", "Proceso de actualización incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error crítico.", "Errr C001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public frmIngresoConductores()
        {
            InitializeComponent();
            CargarDatos();
            CargarGridDatos();

        }

        private void frmIngresoConductores_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarGridDatos();
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


        private void btnAgregar_click(object sender, EventArgs e)
        {
            EnvioDatos();
            CargarDatos();
            CargarGridDatos();
        }



        private void cmbGenero_click(object sender, EventArgs e)
        {
            CargarGenero();
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarGridDatos();
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

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_click(object sender, EventArgs e)
        {
            ActualizarDatos();
            
        }

        private void DgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Capturar el numero de fila a la cual se le dio click
            int posicion = dgvEmpleado.CurrentRow.Index;
            //envio datos hacia texbox
            txtId.Text = dgvEmpleado[0, posicion].Value.ToString();
            TxtNombres.Text= dgvEmpleado[1, posicion].Value.ToString();
            TxtApellidos.Text = dgvEmpleado[2, posicion].Value.ToString();
            TxtDUI.Text = dgvEmpleado[3, posicion].Value.ToString();
            txtNIT.Text = dgvEmpleado[4, posicion].Value.ToString();
            TxtDireccion.Text = dgvEmpleado[5, posicion].Value.ToString();
            txtTelefono.Text = dgvEmpleado[6, posicion].Value.ToString();
            //Envio de datos a cmb
            int id_genero = Convert.ToInt16(dgvEmpleado[7, posicion].Value.ToString());
            cmbGenero.DataSource = ControladorIngreso.CargarGeneroInner_controlador(id_genero);
            cmbGenero.DisplayMember = "genero";
            cmbGenero.ValueMember = "id_genero";

            int id_estado_empleado = Convert.ToInt16(dgvEmpleado[8, posicion].Value.ToString());
            cmbEstado.DataSource = ControladorIngreso.CargarEstadoInner_controlador(id_estado_empleado);
            cmbEstado.DisplayMember = "estado_empleado";
            cmbEstado.ValueMember = "id_estado_empleado";

            int id_cargo = Convert.ToInt16(dgvEmpleado[9, posicion].Value.ToString());
            cmbCargo.DataSource = ControladorIngreso.CargarCargoInner_controlador(id_cargo);
            cmbCargo.DisplayMember = "cargo";
            cmbCargo.ValueMember = "id_cargo";

            int id_municipio = Convert.ToInt16(dgvEmpleado[10, posicion].Value.ToString());
            cmbMunicipio.DataSource = ControladorIngreso.CargarMunicipiosInner_controlador(id_municipio);
            cmbMunicipio.DisplayMember = "municipio";
            cmbMunicipio.ValueMember = "id_municipio";
            //Fecha de nacimiento
            dtNacimiento.Text = dgvEmpleado[11, posicion].Value.ToString();

        }

        private void BtnGrid_Click(object sender, EventArgs e)
        {
            CargarGridDatos();
        }
    }
}
