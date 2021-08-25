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
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
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
            cargarGridDatos();
        }

        private void cargarGridDatos()
        {
            try
            {
                DataTable data = ControladorUsuario.CargarUsuarios();
                dgvUsuarios.DataSource = data;
            }
            catch (Exception ex)
            {

                throw;
            }
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

            if (!Empty(user, password, correo))
            {
                EnvioDatos();
                cargarGridDatos();
            }
            else
            {
                MessageBox.Show("Por favor rellena todos los campos para ingresar un usuario", "Llena los cambios");
            }
            
        }
        
        
        bool Empty(string user, string pass, string correo)
        {
            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(pass) ||
                String.IsNullOrEmpty(correo) )
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
                    MessageBox.Show("Existen entradas duplicadas para el usuario, por favor verifica que los datos sean únicos y que el empleado no tenga un usuario ya asignado.", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de eliminar a: " + txtUser.Text + "?", "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EliminarDatos();
                cargarGridDatos();
            }
        }

        void EliminarDatos()
        {
            bool respuesta = ControladorUsuario.EliminarDatosController(Convert.ToInt16(txtId.Text));
            if (respuesta)
            {
                MessageBox.Show("El registro se ha eliminado", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El registro no se ha eliminado", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvUsuarios.CurrentRow.Index;

            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;

            txtId.Text = dgvUsuarios[0, i].Value.ToString();
            txtUser.Text = dgvUsuarios[1, i].Value.ToString();
            txtPassword.Text = dgvUsuarios[3, i].Value.ToString();
            txtCorreo.Text = dgvUsuarios[2, i].Value.ToString();

            string id_empleado = dgvUsuarios[4, i].Value.ToString();
            cmbEmpleado.DataSource = ControladorUsuario.cargarUsuario(id_empleado);
            cmbEmpleado.DisplayMember = "nombres_empleado";
            cmbEmpleado.ValueMember = "id_empleado";

            string id_cargo = dgvUsuarios[5, i].Value.ToString();
            cmbCargo.DataSource = ControladorUsuario.cargarCargo(id_cargo);
            cmbCargo.DisplayMember = "cargo";
            cmbCargo.ValueMember = "id_cargo";
        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCargo_Click(object sender, EventArgs e)
        {
            CargarCargos();
        }

        private void cmbEmpleado_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string user, password, correo;
            int id_empleado, id_cargo, id;
            id = Convert.ToInt16(txtId.Text);
            id_cargo = Convert.ToInt16(cmbCargo.SelectedValue);
            user = txtUser.Text;
            password = txtPassword.Text;
            correo = txtCorreo.Text;
            id_empleado = Convert.ToInt16(cmbEmpleado.SelectedValue);
            bool res = objCond.ActualizarUser(id,id_empleado, user, correo, password, id_cargo);
            if (res)
            {
                MessageBox.Show("El registro se ha actualizado", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarGridDatos();
            }
            else
            {
                MessageBox.Show("El registro no se ha actualizado", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
