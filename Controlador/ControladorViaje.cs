using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controlador
{
    public class ControladorViaje
    {
        //Atributos para el viaje
        public static int id_viaje { get; set; }
        public string nombre_viaje { get; set; }
        public int id_cliente { get; set; }
        public int id_unidad { get; set; }
        public int id_empleado { get; set; }
        public string fecha_partida { get; set; }
        public string tarifa { get; set; }
        public int id_estado_viaje { get; set; }
        public int id_tipo_viaje { get; set; }

        public static string GetActiveTrips()
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");

            return ModeloViaje.GetActiveTrips(today);
        }

        public string fecha_retorno { get; set; }
        public int id_municipio { get; set; }

        //Atributos para el ingreso de direcciones.
        //id_viaje
        public List<string> puntos_referencias { get; set; }
        public List<string>direcciones { get; set; }

        //Constructor
        public ControladorViaje(string pnombreViaje,int pid_cliente ,int pidUnidad, int pidEmpleado, string pfechaPartida,  string ptarifa, int pidEstadoViaje, int pidTipoViaje, string pfechaRetorno, int pidMunicipio)
        {
            id_empleado = pidEmpleado;
            id_cliente = pid_cliente;
            id_unidad = pidUnidad;
            id_estado_viaje = pidEstadoViaje;
            tarifa = ptarifa;
            fecha_partida = pfechaPartida;
            id_tipo_viaje = pidTipoViaje;
            nombre_viaje = pnombreViaje;
            fecha_retorno = pfechaRetorno;
            id_municipio = pidMunicipio;
        }

        public bool EnviarDatos_ControllerViaje()
        {
            return ModeloViaje.RegistrarViaje(nombre_viaje,id_cliente,id_unidad, id_empleado, fecha_partida, tarifa, id_estado_viaje, id_tipo_viaje, fecha_retorno, id_municipio);
        }

        public static DataTable ObtenerViajes()
        {
            return ModeloViaje.ObtenerViajes();
        }

        #region CMB Controller
        //cmb Cliente
        public static DataTable ObtenerCliente()
        {
            return ModeloViaje.ObtenerCliente();
        }
        //cmbTipoUnidadTransporte
        public static DataTable ObtenerTipoUnidadTransporte()
        {
            return ModeloViaje.CargarTipoUnidadTransporte();
        }
        //cmbMetodoPago
        //public static DataTable ObtenerMetodoPago()
        //{
        //    return ModeloViaje.CargarMetodoPago();
        //}
        //cmb EstadoViaje
        public static DataTable ObtenerEstadoViaje()
        {
            return ModeloViaje.CargarEstadoViaje();
        }
        //cmb Municipio
        public static DataTable ObtenerMunicipios()
        {
            return ModeloViaje.CargarMunicipios();
        }

        //cmb Tipo Viaje
        public static DataTable ObtenerTipoViaje()
        {
            return ModeloViaje.CargarTipoViaje();
        }

        //cmb Conductores
        public static DataTable ObtenerConductores()
        {
            return ModeloViaje.CargarConductores();
        }
        #endregion


        #region CMB Controller Inner 
        //cmb inner Municipio


        public static object ObtenerClienteInner(string id_cliente)
        {
            return ModeloViaje.ObtenerClienteInner(id_cliente);
        }

        public static object ObtenerUnidadInner(string id_unidad)
        {
            return ModeloViaje.ObtenerUnidadInner(id_unidad); 
        }

        public static DataTable ObtenerConductoresInner(string id_empleado)
        {
            return ModeloViaje.ObtenerEmpleadoInner(id_empleado);
        }

        public static DataTable ObtenerEstadoInner(string id_estado)
        {
            return ModeloViaje.CargarEstadoViajeInner(id_estado);
        }

        public static DataTable ObtenerTipoViajeInner(string id_tipo)
        {
            return ModeloViaje.CargarTipoViajeInner(id_tipo);
        }

        public static DataTable ObtenerMunicipioInner(string id_tipo)
        {
            return ModeloViaje.CargarMunicipioInner(id_tipo);
        }

        public static bool Actualizar(string id_viaje, string nombreViaje, int id_cliente, int id_unidad, int id_conductor, string fecha_partida, string tarifa, int id_estado_viaje, int id_tipo_viaje, string fecha_retorno, int id_municipio)
        {
            return ModeloViaje.ActualizarViaje(id_viaje, nombreViaje, id_cliente, id_unidad, id_conductor, fecha_partida, tarifa, id_estado_viaje, id_tipo_viaje, fecha_retorno, id_municipio);
        }

        public static bool EliminarViaje(string text)
        {
            return ModeloViaje.EliminarViaje(text);
        }
        #endregion
    }
}
