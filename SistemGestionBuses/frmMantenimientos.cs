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

        public ControladorMantenimiento objmaintenance;
        
        //REGISTERING MAINTENANCE
        void registering_maintenance()
        {
            try
            {
                string descripcion, fecha;
                int id_unidad_transporte, id_marca, id_modelo, placa, monto_mantenimiento,
                    ultimo_kilometraje;
                //Sending registers
                descripcion = TxtDescripcion.Text;
                fecha = DtFecha.Text;
                placa = Convert.ToInt16(TxtPlaca.Text);
                monto_mantenimiento = Convert.ToInt16(TxtMonto.Text);
                ultimo_kilometraje = Convert.ToInt16(TxtUltimoKilom.Text);
                id_unidad_transporte = Convert.ToInt16(TxtID_unidad.Text);
                id_marca = Convert.ToInt16(CmbMarca.SelectedValue);
                id_modelo = Convert.ToInt16(CmbModelo.SelectedValue);
                //Instace random object
                objmaintenance = new ControladorMantenimiento(id_unidad_transporte, id_marca, id_modelo, placa,
                                                            monto_mantenimiento,
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
        }
    }
}
