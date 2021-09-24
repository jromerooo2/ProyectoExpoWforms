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
        //dt Mantenimiento
        public static DataTable CargarMantenimiento_Controlador()
        {
            return ModeloMantenimiento.ObtenerMantenimiento();
        }
        //cmb Unidad
        public static DataTable ObtenerUnidad()
        {
            return ModeloMantenimiento.CargarUnidad();
        }
        //cmb Unidad inner
        public static DataTable CargarUnidadInner_controlador(int id)
        {
            return ModeloMantenimiento.CargarUnidadInner(id);
        }
    }
}
