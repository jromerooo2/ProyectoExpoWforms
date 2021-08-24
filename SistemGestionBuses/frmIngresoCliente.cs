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
    public partial class frmIngresoCliente : Form
    {
        public ControladorIngresoCliente objCliente;

        public frmIngresoCliente()
        {
            InitializeComponent();
            
        }
        private void CargarGridDatos()
        {
            try
            {
                DataTable data = ControladorIngresoCliente.ObtenerCliente();
                dgvDatosCliente.DataSource = data;
            }
            catch (Exception ex)
            {

                throw;
            }
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
                string nombre_cliente, apellido_cliente, telefono_cliente,direccion_cliente,correo_cliente;
                int id_tipo_cliente;
                nombre_cliente = txtNomCliente.Text;
                apellido_cliente = txtApeCliente.Text;
                telefono_cliente = txtTelCliente.Text;
                direccion_cliente = txtDirCliente.Text;
                correo_cliente = txtCorCliente.Text;
                id_tipo_cliente = Convert.ToInt16(cmbTipCliente.SelectedValue);

                //INSTANCIAR OBJETO
                ControladorIngresoCliente objCliente = new ControladorIngresoCliente(nombre_cliente, apellido_cliente, telefono_cliente, direccion_cliente, correo_cliente, id_tipo_cliente);
                bool respuesta = objCliente.EnviarClientes();
                if (respuesta == true)
                {
                    MessageBox.Show("Cliente agregado exitosamente", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string nombre_cliente, apellido_cliente, telefono_cliente, direccion_cliente, correo_cliente;
            int id_tipo_cliente, id_cliente;
            id_cliente = Convert.ToInt16(txtIdCliente.Text);
            nombre_cliente = txtNomCliente.Text;
            apellido_cliente = txtApeCliente.Text;
            telefono_cliente = txtTelCliente.Text;
            direccion_cliente = txtDirCliente.Text;
            correo_cliente = txtCorCliente.Text;
            id_tipo_cliente = Convert.ToInt16(cmbTipCliente.SelectedValue);
            ControladorIngresoCliente objCliente = new ControladorIngresoCliente(nombre_cliente, apellido_cliente, telefono_cliente, direccion_cliente, correo_cliente, id_tipo_cliente, id);
            bool res = objCliente.ActualizarCliente();
            if (res)
            {
                MessageBox.Show("El registro se ha actualizado", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridDatos();
            }
            else
            {
                MessageBox.Show("El registro no se ha actualizado", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAgregarCliente1_Click(object sender, EventArgs e)
        {
            Vacio();
            if (Vacio() == true)
            {
                MessageBox.Show("Todos los campos son requeridos", "Campos vaios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
            EnvioDatos();
        }

        void EliminarDatos()
        {
            bool respuesta = ControladorUsuario.EliminarDatosController(Convert.ToInt16(txtIdCliente.Text));
            if (respuesta)
            {
                MessageBox.Show("El registro se ha eliminado", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El registro no se ha eliminado", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int i = dgvDatosCliente.CurrentRow.Index;
                txtIdCliente.Text = dgvDatosCliente[0, i].Value.ToString();
                txtNomCliente.Text = dgvDatosCliente[2, i].Value.ToString();
                txtApeCliente.Text = dgvDatosCliente[4, i].Value.ToString();
                txtTelCliente.Text = dgvDatosCliente[3, i].Value.ToString();
                txtDirCliente.Text = dgvDatosCliente[3, i].Value.ToString();

                int id_tipo_cliente = Convert.ToInt16(dgvDatosCliente[1, i].Value.ToString());
                cmbTipCliente.DataSource = ControladorUsuario.cargarUsuario(id_tipo_cliente);
                cmbTipCliente.DisplayMember = "tipo_cliente";
                cmbTipCliente.ValueMember = "id_tipo_cliente";
            }
        }
    }
}
