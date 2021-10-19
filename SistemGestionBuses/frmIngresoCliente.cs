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
using SistemGestionBuses.Properties;
using SistemGestionBuses.Idiomas;
using System.Threading;

namespace SistemGestionBuses
{
    public partial class frmIngresoCliente : Form
    {
        public DataTable datosClien;
        public ControladorIngresoCliente objCliente;
        public static int idlogged;
        public static string cargostring;
        public static string username;
        public static int idcargo;

        public frmIngresoCliente(string user, string cargo, int cargoid, int iduser)
        {
            InitializeComponent();
            username = user;
            txtActiveUser.Text = username;
            cargostring = cargo;
            txtCargoStrip.Text = cargostring;
            idlogged = iduser;
            idcargo = cargoid;
            btnAsignar.Enabled = false;
            CargarIdioma();
            llenarIdioma_Combobox();
        }
        void CargarGridDatos()
        {
            CargarTipoCliente();
            datosClien = ControladorIngresoCliente.CargarClienteControlador();
            dgvDatosCliente.DataSource = datosClien;
            dgvDatosCliente.Columns[0].Visible = false;
            dgvDatosCliente.Columns[1].HeaderText = "Nombre";
            dgvDatosCliente.Columns[2].HeaderText = "Apellido";
            dgvDatosCliente.Columns[3].HeaderText = "Telefono";
            dgvDatosCliente.Columns[4].HeaderText = "Tipo de cliente";
            dgvDatosCliente.Columns[5].HeaderText = "Direccion";
            dgvDatosCliente.Columns[6].HeaderText = "Correo";
        }
        void CargarTipoCliente()
        {
            try
            {
                DataTable DataTipCliente = ControladorIngresoCliente.ObtenerTipoCliente();
                cmbTipCliente.DataSource = DataTipCliente;
                cmbTipCliente.DisplayMember = "tipo_cliente"; 
                cmbTipCliente.ValueMember = "id_tipo_cliente";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipos de clientes.", "Error de carga.",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }

        //Envio de Datos
        void EnvioDatos()
        {

            try
            {
                string nombres_cliente, apellidos_cliente, telefono_cliente,direccion_cliente,correo_cliente;
                int id_tipo_cliente;
                nombres_cliente = txtNomCliente.Text;
                apellidos_cliente = txtApeCliente.Text;
                telefono_cliente = txtTelCliente.Text;
                direccion_cliente = txtDirCliente.Text;
                correo_cliente = txtCorCliente.Text;
                id_tipo_cliente = Convert.ToInt16(cmbTipCliente.SelectedValue);

                //INSTANCIAR OBJETO
                ControladorIngresoCliente objCliente = new ControladorIngresoCliente(nombres_cliente, apellidos_cliente, telefono_cliente, direccion_cliente, correo_cliente, id_tipo_cliente);
                bool respuesta = objCliente.EnviarClientes();
                if (respuesta == true)
                {
                    MessageBox.Show("Cliente agregado exitosamente", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGridDatos();
                }
                else
                {
                    MessageBox.Show("Cliente no agregado", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Oops!, ocurrió un error al agregar clientes, consulte con el administrador del sistema.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmIngresoCliente_Load(object sender, EventArgs e)
        {
            CargarTipoCliente();
            CargarGridDatos();
        }

        public bool Vacio()
        {
            if (txtNomCliente.Text.Trim() == "" &&
            txtApeCliente.Text.Trim() == "" &&
            txtTelCliente.Text.Trim() == "" &&
            txtDirCliente.Text.Trim() == "" &&
            txtCorCliente.Text.Trim() == "" &&    
            cmbTipCliente.SelectedIndex == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        void ActualizarDatos()
        {
            try
            {
                string nombres_cliente, apellidos_cliente, direccion_cliente, telefono_cliente, correo_cliente;
                int id_tipo_cliente;
                nombres_cliente = txtNomCliente.Text;
                apellidos_cliente = txtApeCliente.Text;
                direccion_cliente = txtDirCliente.Text;
                telefono_cliente = txtTelCliente.Text;
                correo_cliente = txtCorCliente.Text;
                id_tipo_cliente = Convert.ToInt16(cmbTipCliente.SelectedValue);

                ControladorIngresoCliente.id_cliente = Convert.ToInt16(txtIdCliente.Text);
                objCliente = new ControladorIngresoCliente(nombres_cliente, apellidos_cliente, telefono_cliente, direccion_cliente, correo_cliente, id_tipo_cliente);                
                bool res = objCliente.ActualizarClienteContorlador();
                if (res == true)
                {
                    MessageBox.Show("El registro se ha actualizado", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("El registro no se ha actualizado", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error crítico.", "Errr C001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
            
        }
        private void btnAgregarCliente1_Click(object sender, EventArgs e)
        {
            Vacio();
            if (Vacio() == true)
            {
                MessageBox.Show("Todos los campos son requeridos", "Campos vaios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EnvioDatos();
            }          

        }

        void EliminarDatos()
        {
            ControladorIngresoCliente.id_cliente = Convert.ToInt16(txtIdCliente.Text);
            bool respuesta = ControladorIngresoCliente.EliminarClienteControlador();
            if (respuesta)
            {
                MessageBox.Show("El registro se ha eliminado", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El registro no se ha eliminado debido a que el cliente está siendo utilizado ", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDatosCliente.CurrentRow.Index;
            if (i >= 0 && dgvDatosCliente[0, i].Value.ToString() != "")
            {             
                txtIdCliente.Text = dgvDatosCliente[0, i].Value.ToString();
                txtNomCliente.Text = dgvDatosCliente[1, i].Value.ToString();
                txtApeCliente.Text = dgvDatosCliente[2, i].Value.ToString();
                txtTelCliente.Text = dgvDatosCliente[3, i].Value.ToString();
                txtDirCliente.Text = dgvDatosCliente[5, i].Value.ToString();
                txtCorCliente.Text = dgvDatosCliente[6, i].Value.ToString();

                int id_tipo_cliente = Convert.ToInt16(dgvDatosCliente[4, i].Value.ToString());
                cmbTipCliente.DataSource = ControladorIngresoCliente.ObtenerInner(id_tipo_cliente);
                cmbTipCliente.DisplayMember = "tipo_cliente";
                cmbTipCliente.ValueMember = "id_tipo_cliente";

                btnAsignar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selecciona un cliente", "Selección no valida" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAcualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
            CargarGridDatos();
        }

        private void BtnEliminarCliente_click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de eliminar a: " + txtNomCliente.Text + "?", "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EliminarDatos();
                CargarGridDatos();
            }
        }

        private void BtnActualizarGrid_click(object sender, EventArgs e)
        {
            CargarGridDatos();
        }
        public void LimpiarCampos()
        {
            txtNomCliente.Clear();
            txtApeCliente.Clear();
            txtDirCliente.Clear();
            txtTelCliente.Clear();
            txtCorCliente.Clear();        
        }

        private void BtnLimCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void KeyNombre(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void KeyApellido(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void KeyNummero(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
               if (Char.IsControl(e.KeyChar)) 
            {
                e.Handled = false;
            }
            else
            {               
                e.Handled = true;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int idcliente = Convert.ToInt32(txtIdCliente.Text);
            frmAsignarViaje asignar = new frmAsignarViaje(username, cargostring, idcargo, idlogged, idcliente);
            asignar.Show();
            Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            DataView dv = datosClien.DefaultView;
            dv.RowFilter = "nombres_cliente LIKE '"+textBox1.Text+"%'";
            dgvDatosCliente.DataSource = dv;
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDatosCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //CambiarIdioma
        public void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Idioma);

            lblNombres.Text = Res.lblNombres;
            lblApellidos.Text = Res.lblApellidos;
            lblNumerocel.Text = Res.lblNumerocel;
            lblDireccion.Text = Res.lblDireccion;
            lblCorreo.Text = Res.lblCorreoClientes;
            lblTipoCliente.Text = Res.lblTipoClientes;
            lblFiltrarporNombre.Text = Res.lblFiltrarporNombre;
            btnAsignar.Text = Res.btnAsignarViajeCliente;
            btnAgregarCliente.Text = Res.btnAgregarClientes;
            btnLimpiarCampos.Text = Res.btnLimpiarCampos;
            btnActualizarCliente.Text = Res.btnActualizarCliente;
            btnEliminarClientes.Text = Res.btnEliminarCliente;
            btnActualizarGrid.Text = Res.btnActualizarGrid;
            BtnCambiarIdioma.Text = Res.btnCambiarIdioma;
        }

        public void llenarIdioma_Combobox()
        {
            cmbIdioma.DataSource = Idioma.ObtenerIdiomas();
            cmbIdioma.ValueMember = "CultureInfo";
            cmbIdioma.DisplayMember = "CargarNombre_Pais";
        }

        private void BtnCambiarIdioma_Click(object sender, EventArgs e)
        {
            Settings.Default.Idioma = cmbIdioma.SelectedValue.ToString();
            CargarIdioma();
        }
    }
}
