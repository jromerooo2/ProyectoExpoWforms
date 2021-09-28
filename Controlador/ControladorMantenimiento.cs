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
        //ATRIBUTOS 
        public static int id_mantenimiento { get; set; }
        public int id_unidad_transporte { get; set; }
        public double monto_mantenimiento { get; set; }
        public double ultimo_kilometraje { get; set; }
        public string descripcion { get; set; }
        public string fecha { get; set; }
        //CONSTRUCTOR
        public ControladorMantenimiento( int pUnidad, double pMonto, double pKilometraje, string pDescripcion, string pFecha)
        {
            //Atributo = parametro
            id_unidad_transporte = pUnidad;
            monto_mantenimiento = pMonto;
            ultimo_kilometraje = pKilometraje;
            descripcion = pDescripcion;
            fecha = pFecha;
        }
        //CRUD Mantenimiento
        public bool EnviarDatosControlador()
        {
            return ModeloMantenimiento.RegistrarMantenimiento(id_unidad_transporte, monto_mantenimiento, ultimo_kilometraje, descripcion, fecha);
        }

        //Update Mantenimiento
        public static DataTable ActualizarUnidad_Controller(int placa)
        {
            return ModeloMantenimiento.ActualizarUnidad_Inner(placa);
        }

        public bool RetornoUpdate_mantenimiento()
        {
            return ModeloMantenimiento.ActualializarMantenimiento(id_mantenimiento,id_unidad_transporte,monto_mantenimiento,ultimo_kilometraje,descripcion,fecha);
        }
    }
}
