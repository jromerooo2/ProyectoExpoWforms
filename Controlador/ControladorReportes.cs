using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class ControladorReportes
    {
        public static DataTable GetDataCliente()
        {
            return ModeloReportes.GetDataClientes();
        }
        public static DataTable GetDataTransportes()
        {
            return ModeloReportes.GetDataTransportes();
        }

        public static DataTable GetDataEmpleados()
        {
            return ModeloReportes.GetDataEmpleados();
        }
    }
}
