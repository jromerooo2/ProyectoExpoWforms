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
        public static DataTable RetornoCargarUnidad()
        {
            return ModeloMantenimiento.CargarUnidad();
        }

        //ATRIBUTOS
        public static int id_mantenimiento { get; set; }

        public int id_unidad_transporte { get; set; }

        public double monto_mantenimiento { get; set; }

        public double ultimo_kilometraje { get; set; }

        public string descripcion { get; set; }

        public string fecha { get; set; }

        //CONSTRUTOR
        //Atributos = Parámetros
        public ControladorMantenimiento(int pUnidad, double pMonto, double pUKilometraje,
                                string pDescripcion, string pfecha)
        {
            id_unidad_transporte = pUnidad;
            monto_mantenimiento = pMonto;
            ultimo_kilometraje = pUKilometraje;
            descripcion = pDescripcion;
            fecha = pfecha;
        }

        //CRUD
        //Registro_Mantenimiento
        public static DataTable ObtenerMantenimiento()
        {
            return ModeloMantenimiento.ObtenerListaMantenimiento();
        }

        public bool RegistrarMantenimiento()
        {
            return ModeloMantenimiento.RegistroMantenimiento(id_unidad_transporte, monto_mantenimiento, ultimo_kilometraje, descripcion, fecha);
        }

<<<<<<< HEAD
        //ActualizaciónMantenimiento
        public static DataTable CargarUnidadInner_Controller(int id)
        {
            return ModeloMantenimiento.CargarUnidad_Inner(id);
        }

        public bool ActualizarMantenimiento_Controller()
=======
        //Update Mantenimiento


        public bool  ActualizarMantenimientoControlador()
>>>>>>> f0184ca8a29df5abea7e5d6837914031d6bebc38
        {
            return ModeloMantenimiento.ActualizacionMantenimiento(id_mantenimiento, id_unidad_transporte, monto_mantenimiento, ultimo_kilometraje, descripcion, fecha);
        }

<<<<<<< HEAD
        //EliminaciónMantenimiento
        public static bool EliminarMantenimiento_Controller()
=======
        //Delete Mantenimiento
        public static bool EliminarMantenimientoControlador()
>>>>>>> f0184ca8a29df5abea7e5d6837914031d6bebc38
        {
            return ModeloMantenimiento.EliminarMantenimiento(id_mantenimiento);
        }
    }
}
