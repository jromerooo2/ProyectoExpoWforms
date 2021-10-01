using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class ControladorDirecciones
    {
        public static bool Save(string partida, string final, string adicional)
        {
            return ModeloIngreso.SaveDir(partida, final, adicional);
        }
    }
}
