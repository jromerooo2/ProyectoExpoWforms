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
    public partial class frmIngresoConductores : Form
    {
        public static int id_empleado;
        string empleado;
        DataTable datosConductores;

        public frmIngresoConductores(int pid_empleado)
        {            
            InitializeComponent();
            id_empleado = pid_empleado;
            ControladorIngreso.id_empleado = pid_empleado;
            empleado = ControladorIngreso.CargarNombresConduc_Controller();
            txtIDEmpl.Text = id_empleado.ToString();
            txtNombreConduc.Text = empleado;
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnActualizar.Enabled = false;

            BtnEliminar.Enabled = false;
            BtnActualizar.Enabled = false;
            BtnAgregar.Enabled = true;

            CargarGridDatos();
            CargarTipoLicencia();
        }
        //CMB tipo licencia
        void CargarTipoLicencia()
        {
            try
            {
                DataTable dataTipo = ControladorIngreso.ObtenerTipoLicencia();
                cmbTipoLicencia.DataSource = dataTipo;
                cmbTipoLicencia.DisplayMember = "tipo_licencia";
                cmbTipoLicencia.ValueMember = "id_tipo_licencia";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los cargo.", "Error de carga.",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
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

        void CargarGridDatos()
        {
            datosConductores = ControladorIngreso.CargarConductores_Controller();
            dgvConductores.DataSource = datosConductores;
            dgvConductores.Columns[0].HeaderText = "Empleado";
            dgvConductores.Columns[1].HeaderText = "Licencia";
            dgvConductores.Columns[2].HeaderText = "F.Expiración";
            dgvConductores.Columns[3].HeaderText = "Tipo Licencia";
            //dgvConductores.Columns[4].Visible = false;
        }

        void EnvioDatos()
        {
            string licencia = txtLicencia.Text;
            if (licencia.Contains("123456789")|| licencia.Trim().Length == 18)
            {
                try
                {                 
                    string fecha_expiracion = Convert.ToString(dtpExpLicencia.Value);
                    int id_tipo_licencia = Convert.ToInt32(cmbTipoLicencia.SelectedValue);
                    //Se envian los datos al controlador directamente por a la clase y no por objeto ya que el metodo es statico porque el constructor no me permite trabajar todos los cruds.
                    bool res = ControladorIngreso.IngresarDatosConductores(id_empleado, licencia, id_tipo_licencia, fecha_expiracion);
                    if (res == true)
                    {
                        MessageBox.Show("Los datos del empleado fueron registrados exitosamente", "Confirmación de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se registraron los datos del conductor", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Contacta al administrador, el registro no funciona correctamente", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
            else
            {
                MessageBox.Show("La licencia es obligatoria para registrar al conductor", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de actualizar a: " + empleado + "?",
            "Confirmar actualización", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ActualizarDatos();
                CargarGridDatos();
            }            
        }

        void ActualizarDatos()
        {
<<<<<<< Updated upstream
            //string para comparar que los valores no sean los mismos
            string string_tipo_licencia = cmbTipoLicencia.Text;
=======
            //String para comparar si se modifico el tipo de licencia
            string string_licencia_tipo = cmbTipoLicencia.Text;
>>>>>>> Stashed changes
            string licencia = txtLicencia.Text;
            int id_conductor = Convert.ToInt32(txtIDConduc.Text);
            string fecha_expiracion = Convert.ToString(dtpExpLicencia.Value);
            int id_tipo_licencia = Convert.ToInt16(cmbTipoLicencia.SelectedValue);
            //Se envian los datos al controlador directamente por a la clase y no por objeto ya que el metodo es statico porque el constructor no me permite trabajar todos los cruds.
<<<<<<< Updated upstream
            if (sameOrnot(licencia, fecha_expiracion, string_tipo_licencia) == false)
=======
            if (sameOrnot(licencia, fecha_expiracion, string_licencia_tipo) == false)
>>>>>>> Stashed changes
            {
                bool res = ControladorIngreso.ActualizarDatosConductores(id_conductor, id_empleado, licencia, id_tipo_licencia, fecha_expiracion);
                if (res == true)
                {
                    MessageBox.Show("Los datos del empleado fueron registrados exitosamente", "Confirmación de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No pudo ser actualizado el registro", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los datos son los mismos, porfavor confirma que actualizaste los campos deseados", "Registro Identico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void EliminarDatos()
        {
            //Se envia el id del conductor directo al controlador
            ControladorIngreso.id_conductor = Convert.ToInt16(txtIDConduc.Text);
            bool respuesta = ControladorIngreso.EliminarDatosConductor();
            if (respuesta == true)
            {
                MessageBox.Show("El registro ha sido eliminado correctamente", "Confirmacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El registro no fue eliminado", "Confirmacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool sameOrnot(string licencia, string fecha_expiracion, string id_tipo_licencia)
        {
            int i = dgvConductores.CurrentRow.Index;

            string tipo0 = dgvConductores[3, i].Value.ToString();
            string fecha0 = dgvConductores[2, i].Value.ToString();
            string licencia0 = dgvConductores[1, i].Value.ToString();          

<<<<<<< Updated upstream
            if (!licencia.Equals(licencia0) || !fecha_expiracion.Equals(fecha0) || !id_tipo_licencia.Equals(tipo0))
=======
            if (licencia.Equals(licencia0) || fecha_expiracion.Equals(fecha0) || id_tipo_licencia.Equals(tipo0))
>>>>>>> Stashed changes
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmIngresoConductores_Load(object sender, EventArgs e)
        {
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnActualizar.Enabled = false;
        }

        private void dgvConductores_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            BtnEliminar.Enabled = true;
            BtnActualizar.Enabled = true;
            BtnAgregar.Enabled = false;

            int i = dgvConductores.CurrentRow.Index;

            txtIDConduc.Text = dgvConductores[4, i].Value.ToString();
            txtLicencia.Text = dgvConductores[1, i].Value.ToString();
            txtNombreConduc.Text = dgvConductores[0, i].Value.ToString();
            dtpExpLicencia.Text = Convert.ToString(dgvConductores[2, i]);

            string id_licencia = dgvConductores[3, i].ToString();
            cmbTipoLicencia.DataSource = ControladorIngreso.ObtenerTipoLicenciaInner(id_licencia);
            cmbTipoLicencia.DisplayMember = "tipo_licencia";
            cmbTipoLicencia.ValueMember = "id_tipo_licencia";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        void LimpiarCampos()
        {
            txtLicencia.Clear();
            txtIDConduc.Clear();
            txtIDEmpl.Clear();
            cmbTipoLicencia.SelectedIndex = 1;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarDatos();
            CargarGridDatos();
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            EnvioDatos();
            CargarGridDatos();
        }

<<<<<<< Updated upstream
        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            ActualizarDatos();
            CargarGridDatos();
        }

        private void dtpExpLicencia_onValueChanged(object sender, EventArgs e)
        {
            ValidarFechaNacimiento();
        }

        void ValidarFechaNacimiento()
        {
            DateTime hoy = DateTime.Today;
            if (dtpExpLicencia.Value.Date <= hoy)
            {
                MessageBox.Show("Fecha invalida, la fecha de expiración debe ser una fecha futura", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (dtpExpLicencia.Value.Date.AddYears(1) >= hoy)
            {
                MessageBox.Show("Fecha invalida, la fecha de expiración de la licencia debe ser como minimo, dentro de un año", "Error de ingreso",
                                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
=======
        private void dgvConductores_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            BtnEliminar.Enabled = true;
            BtnActualizar.Enabled = true;
            BtnAgregar.Enabled = false;

            int i = dgvConductores.CurrentRow.Index;

            txtIDConduc.Text = dgvConductores[4, i].Value.ToString();
            txtLicencia.Text = dgvConductores[1, i].Value.ToString();
            txtNombreConduc.Text = dgvConductores[0, i].Value.ToString();
            dtpExpLicencia.Text = Convert.ToString(dgvConductores[2, i]);

            string id_licencia = dgvConductores[3, i].ToString();
            cmbTipoLicencia.DataSource = ControladorIngreso.ObtenerTipoLicenciaInner(id_licencia);
            cmbTipoLicencia.DisplayMember = "tipo_licencia";
            cmbTipoLicencia.ValueMember = "id_tipo_licencia";

            CargarTipoLicencia();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarDatos();
            CargarGridDatos();
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnActualizar.Enabled = false;
        }

        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            ActualizarDatos();
            CargarGridDatos();
            BtnAgregar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnActualizar.Enabled = false;
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            EnvioDatos();
            CargarGridDatos();
>>>>>>> Stashed changes
        }
    }
}
