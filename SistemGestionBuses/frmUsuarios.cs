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

namespace SistemGestionBuses
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public DataTable datosCond;

        void CargarDatos()
        {
            CargarEmpleados();
            CargarCargos();
        }
        private void CargarEmpleados()
        {

        //cmb Cargar Cargo
            try
            {
                DataTable dataCargo = ControladorUsuario.ObtenerEmpleado();
                cmbEmpleado.DataSource = dataCargo;
                cmbEmpleado.DisplayMember = "nombres_empleado";
                cmbEmpleado.ValueMember = "id_empleado";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los cargo.", "Error de carga.",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        

    }
        private void CargarCargos()
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string user, password, correo;
            int id_empleado, id_cargo;

            id_cargo = Convert.ToInt16(cmbCargo.SelectedValue);
            user = txtUser.Text;
            password = txtPassword.Text;
            correo = txtCorreo.Text;
            id_empleado = Convert.ToInt16(cmbEmpleado.SelectedValue);

            if (!Empty(user, password, correo, id_cargo, id_empleado))
            {
                EnvioDatos();
            }
            else
            {
                MessageBox.Show("Por favor rellena todos los campos para ingresar un usuario", "Llena los cambios");
            }
            
        }
        
        
        bool Empty(string user, string pass, string correo, int empleado, int cargo)
        {
            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(pass) ||
                String.IsNullOrEmpty(correo) /*|| empleado > -1 || cargo > -1*/)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public ControladorUsuario objCond = new ControladorUsuario();

        void EnvioDatos()
        {
            try
            {
                string user, password, correo;
                int id_empleado, id_cargo;

                id_cargo = Convert.ToInt16(cmbCargo.SelectedValue);
                user = txtUser.Text;
                password = txtPassword.Text;
                correo = txtCorreo.Text;
                id_empleado = Convert.ToInt16(cmbEmpleado.SelectedValue);
                bool respuesta = objCond.RegistrarUsuario(user, password, correo, id_cargo, id_empleado);
                if (respuesta)
                {
                    MessageBox.Show("Usuario registrado exitosamente", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no pudo ser registrado", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!, ocurrió un error al registrar al empleado, consulte con el administrador del sistema." + ex.ToString(), "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtApellidos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
