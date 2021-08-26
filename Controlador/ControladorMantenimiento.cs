using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Modelo;

namespace Controlador
{
    public class ControladorMantenimiento
    {

        //ATRIBUTOS
        public static int id_mantenimiento { get; set; }

        public int id_unidad_transporte { get; set; }

        public int id_marca { get; set; }

        public int id_modelo { get; set; }

        public int placa { get; set; }

        public int monto_mantenimiento { get; set; }

        public int ultimo_kilometraje { get; set; }

        public string descripcion { get; set; }

        public string fecha { get; set; }

        //CONSTRUCTOR
        //Parámetros

        public ControladorMantenimiento(int pid_unidad_transporte, 
                                        int pid_marca, int pid_modelo, int pplaca, 
                                        int pmonto_mantenimiento, 
                                        int pultimo_kilometraje, string pdescripcion, string pfecha)
            //Atributos = Parámetros
        {
            id_unidad_transporte = pid_unidad_transporte;
            id_marca = pid_marca;
            id_modelo = pid_modelo;
            placa = pplaca;
            monto_mantenimiento = pmonto_mantenimiento;
            ultimo_kilometraje = pultimo_kilometraje;
            descripcion = pdescripcion;
            fecha = pfecha;
        }

        //CHARGING MAINTENANCE DATA
        public static DataTable LoadMaintenance_Controller()
        {
            return ModeloMantenimiento.GetMaintenanceList();
        }
        //RETURNING MAINTENANCE REGISTER
        public bool backing_Maintenance()
        {
            return ModeloMantenimiento.RegisterMaintenance(id_unidad_transporte,id_marca,id_modelo,placa,monto_mantenimiento,ultimo_kilometraje,descripcion,fecha);
        }

    }
}
