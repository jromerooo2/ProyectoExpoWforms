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
        public static bool Save(int id_viaje, string partida, string final, string adicional, string pinicio, string pfinal, string padicional)
        {
            return ModeloIngreso.SaveDir(id_viaje, partida, final, adicional, pinicio, pfinal, padicional);
        }
    }
}
