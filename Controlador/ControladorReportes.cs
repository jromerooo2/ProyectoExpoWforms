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
        public static List<string> GetDataCliente()
        {
            return ModeloReportes.GetDataClientes();
        }
    }
}
