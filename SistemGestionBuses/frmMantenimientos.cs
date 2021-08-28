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
        public frmMantenimientos()
        {
            InitializeComponent();
        }

        public DataTable DataGridView_useonly;
        public ControladorMantenimiento objmaintenance;
        
        //DISPLAYING COMBO BOXES 
        void Cargar_Marca()
        {
            CmbMarca.DataSource = ControladorMantenimiento.Load_Marca();
            CmbMarca.ValueMember = "id_marca";
            CmbMarca.DisplayMember = "marca";
        }
        void Cargar_Modelo()
        {
            CmbModelo.DataSource = ControladorMantenimiento.Load_Modelo();
            CmbModelo.ValueMember = "id_modelo";
            CmbModelo.DisplayMember = "modelo";
        }
        //INSERTING DATA PLATE
        void CargarPlaca(int placa)
        {
            CmbPlaca.DataSource = ControladorMantenimiento.backing_PlateData(placa);
            CmbPlaca.DisplayMember = "matricula";
        }

        /*DATA INSERT*/
        //REGISTERING MAINTENANCE
        void registering_maintenance()
        {
            try
            {
                string descripcion, fecha;
                int id_unidad_transporte, monto_mantenimiento,
                    ultimo_kilometraje, marca, modelo, placa;
                //Sending registers
                descripcion = TxtDescripcion.Text;
                fecha = DtFecha.Text;
                id_unidad_transporte = Convert.ToInt16(TxtID_unidad.Text);
                monto_mantenimiento = Convert.ToInt16(TxtMonto.Text);
                ultimo_kilometraje = Convert.ToInt16(TxtUltimoKilom.Text);
                marca = Convert.ToInt16(CmbMarca.SelectedValue);
                modelo = Convert.ToInt16(CmbModelo.SelectedValue);
                placa = Convert.ToInt16(CmbPlaca.SelectedValue);
                //Instace random object
                objmaintenance = new ControladorMantenimiento(id_unidad_transporte, monto_mantenimiento,
                                                            ultimo_kilometraje, descripcion, fecha);
                bool answer = objmaintenance.backing_Maintenance();
                if (answer == true)
                {
                    MessageBox.Show("El registro de mantenimiento se ha registrado con exito", 
                                    "Proceso Completado",
                                     MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro de mantenimiento no ha podido ser registrado",
                                    "Proceso Completado",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos ಥ_ಥ, ha surgido un error externo al realizar " +
                                "el registro del mantenimiento",
                                    "Proceso Completado",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            registering_maintenance();
            LoadDataGridView();
            Cargar_Marca();
            Cargar_Modelo();
        }

        private void frmMantenimientos_Load(object sender, EventArgs e)
        {
            Cargar_Marca();
            Cargar_Modelo();
            LoadDataGridView();
        }

        void LoadDataGridView()
        {
            DataGridView_useonly = ControladorMantenimiento.LoadMaintenance_Controller();
            DgvMaintenance.DataSource = DataGridView_useonly;
        }

        /*DATA UPDATE*/
        private void DgvMaintenance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = DgvMaintenance.CurrentRow.Index;

            TxtID_mant.Text = DgvMaintenance[0, position].Value.ToString();
            TxtID_unidad.Text = DgvMaintenance[1, position].Value.ToString();
            TxtMonto.Text = DgvMaintenance[2, position].Value.ToString();
            TxtUltimoKilom.Text = DgvMaintenance[3, position].Value.ToString();
            TxtDescripcion.Text = DgvMaintenance[4, position].Value.ToString();
            DtFecha.Text = DgvMaintenance[5, position].Value.ToString();
        }

        private void CmbMarca_Click(object sender, EventArgs e)
        {
            Cargar_Marca();
        }

        private void CmbModelo_Click(object sender, EventArgs e)
        {
            Cargar_Modelo();
        }

        private void CmbPlaca_Click(object sender, EventArgs e, int placa)
        {
            CargarPlaca(placa);
        }

        void ActualizarDatos()
        {
            try
            {
                string descripcion, fecha;
                int id_unidad_transporte, monto_mantenimiento,
                    ultimo_kilometraje, marca, modelo, placa;
                //Sending the register values to textboxes
                descripcion = TxtDescripcion.Text;
                fecha = DtFecha.Text;
                id_unidad_transporte = Convert.ToInt16(TxtID_unidad.Text);
                monto_mantenimiento = Convert.ToInt16(TxtMonto.Text);
                ultimo_kilometraje = Convert.ToInt16(TxtUltimoKilom.Text);
                marca = Convert.ToInt16(CmbMarca.SelectedValue);
                modelo = Convert.ToInt16(CmbModelo.SelectedValue);
                placa = Convert.ToInt16(CmbPlaca.SelectedValue);
                //Instance objempleado
                ControladorMantenimiento.id_mantenimiento = Convert.ToInt16(TxtID_mant.Text);
                objmaintenance = new ControladorMantenimiento(id_unidad_transporte, monto_mantenimiento, ultimo_kilometraje, descripcion, fecha);
                bool respuesta = objmaintenance.Maintenance_Update();
                if (respuesta == true)
                {
                    MessageBox.Show("El registro se ha actualizado exitosamente.", "Confirmación de actualización",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido actualizar el registro.", "Confirmación de actualización",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vayaa ಥ_ಥ, se produjo un error externo al actualizar el regsitro.", "Error Crítico",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
