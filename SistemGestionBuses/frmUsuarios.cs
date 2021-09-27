using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;


namespace SistemGestionBuses
{
    public partial class frmUsuarios : Form
    {
        public static int cargouser;
        public static int IdUserLogged;
        public frmUsuarios(int cargo, int idUser)
        {
            InitializeComponent();
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            cargouser = cargo;
            IdUserLogged = idUser;
            if (cargouser == 2 || cargouser == 3)
            {
                BtnAgregar.Enabled = true;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {          
           // txtPin.MaxLength = 8;
            CargarDatos();
            GetOnlineUsers();
            cargarGridDatos();
        }

        private void GetOnlineUsers()
        {
            try
            {
                DataTable data = ControladorUsuario.GetOnlineUsers();
                dgvOnlineUsers.DataSource = data;
                dgvOnlineUsers.Columns[0].HeaderText = "Nombre de Usuario";
                dgvOnlineUsers.Columns[1].HeaderText = "Correo Electrónico";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cargarGridDatos()
        {
            try
            {
                DataTable data = ControladorUsuario.CargarUsuarios();
                dgvUsuarios.DataSource = data;
                dgvUsuarios.Columns[0].Visible = false;
                dgvUsuarios.Columns[1].HeaderText = "Nombre de Usuario";
                dgvUsuarios.Columns[2].HeaderText = "Correo Electrónico";
                dgvUsuarios.Columns[3].Visible = false;
                dgvUsuarios.Columns[4].HeaderText = "Empleados";
                dgvUsuarios.Columns[5].HeaderText = "Cargo";
                //dgvUsuarios.Columns[6].Visible = false;
            }
            catch (Exception )
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
            string user,correo;
            int id_empleado, id_cargo;

            id_cargo = Convert.ToInt16(cmbCargo.SelectedValue);
            user = txtUser.Text;
            //password = txtPassword.Text;
            correo = txtCorreo.Text;
            //pin = txtPin.Text;
            id_empleado = Convert.ToInt16(cmbEmpleado.SelectedValue);

            if (!Empty(user, correo) && ValidacionesClass.checkEmailAt(correo))
            {
                EnvioDatos();
                cargarGridDatos();
            }
            else
            {
                MessageBox.Show("Por favor rellena todos los campos para ingresar un usuario y revisa que todos los datos sean validos", "Llena los cambios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        
        bool Empty(string user, string correo)
        {
            if (String.IsNullOrEmpty(user) ||
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

        public static byte[] img;
        void EnvioDatos()
        {
            try
            {
                string user, correo ;
                int id_empleado, id_cargo;
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                 img = ms.ToArray();


                id_cargo = Convert.ToInt16(cmbCargo.SelectedValue);
                user = txtUser.Text;
                correo = txtCorreo.Text;
                id_empleado = Convert.ToInt16(cmbEmpleado.SelectedValue);
                bool respuesta = objCond.RegistrarUsuario(user, correo, id_cargo, id_empleado, img);
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
            int id = Convert.ToInt16(txtId.Text);
            if (MessageBox.Show("¿Estas seguro de eliminar a: " + txtUser.Text + "?", "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && id != IdUserLogged)
            {
                EliminarDatos();
                cargarGridDatos();
            }
            else
            {
                MessageBox.Show("No puedes auto eliminarte","Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (cargouser == 2 || cargouser == 3)
            {
                BtnActualizar.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnAgregar.Enabled = true;
            }

            List<string> img = ControladorUsuario.GetUserImg(dgvUsuarios[0, i].Value.ToString());

            //byte[] byteImgArray = Convert.ToByte(img[0]);

            txtId.Text = dgvUsuarios[0, i].Value.ToString();
            txtUser.Text = dgvUsuarios[1, i].Value.ToString();
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
            string user, correo;
            int id_empleado, id_cargo, id;
            id = Convert.ToInt16(txtId.Text);
            id_cargo = Convert.ToInt16(cmbCargo.SelectedValue);
            user = txtUser.Text;
            correo = txtCorreo.Text;
            id_empleado = Convert.ToInt16(cmbEmpleado.SelectedValue);
            bool res = objCond.ActualizarUser(id,id_empleado, user, correo, id_cargo);
            if (ValidacionesClass.checkEmailAt(correo))
            {
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
            else
            {
                MessageBox.Show("Correo Invalido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "jpeg|*.jpeg|png|*.png|jpg|*.jpg";
            DialogResult rs = dlg.ShowDialog();

            if (rs == DialogResult.OK)
            {
                imageUser.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txtId.Text);
            string name = txtUser.Text;
            if (MessageBox.Show("¿Estas seguro de restablecer la contraseña por defecto a: " + txtUser.Text + "?", "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RestablecerDefault(id, name);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error restableciendo la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RestablecerDefault(int id, string name)
        {
            ControladorUsuario.RestablecerDef(id, name);
                
         }
    }
}
