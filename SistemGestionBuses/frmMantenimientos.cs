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
        void CargarPlaca(string placa)
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
                    ultimo_kilometraje;
                //Sending registers
                descripcion = TxtDescripcion.Text;
                fecha = DtFecha.Text;
                monto_mantenimiento = Convert.ToInt16(TxtMonto.Text);
                ultimo_kilometraje = Convert.ToInt16(TxtUltimoKilom.Text);
                id_unidad_transporte = Convert.ToInt16(TxtID_unidad.Text);
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

    }
}
