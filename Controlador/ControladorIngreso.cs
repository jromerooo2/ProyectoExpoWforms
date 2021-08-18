using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
   public class ControladorIngreso
    {
        public static DataTable ObtenerMunicipios()
        {
            return ModeloIngreso.CargarMunicipios();
        }
    }
}
