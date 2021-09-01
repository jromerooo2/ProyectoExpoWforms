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
        public int id_unidad { get; set; }
        public int id_empleado { get; set; }
        public string fecha_partida { get; set; }
        public string hora_partida { get; set; }
        public double tarifa { get; set; }
        public int id_estado_viaje { get; set; }
        public int id_tipo_viaje { get; set; }
        public string fecha_retorno { get; set; }
        public string hora_retorno { get; set; }
        public int id_municipio { get; set; }

        //Atributos para el ingreso de direcciones.
        //id_viaje
        public List<string> puntos_referencias { get; set; }
        public List<string>direcciones { get; set; }

        //Constructor
        public ControladorViaje(string pnombreViaje, int pidUnidad, int pidEmpleado, string pfechaPartida, string phoraPartida, double ptarifa, int pidEstadoViaje, int pidTipoViaje, string pfechaRetorno, string phoraRetorno, int pidMunicipio)
        {
            id_empleado = pidEmpleado;
            id_unidad = pidUnidad;
            id_estado_viaje = pidEstadoViaje;
            tarifa = ptarifa;
            hora_partida = phoraPartida;
            fecha_partida = pfechaPartida;
            id_tipo_viaje = pidTipoViaje;
            nombre_viaje = pnombreViaje;
            hora_retorno = phoraRetorno;
            fecha_retorno = phoraRetorno;
            id_municipio = pidMunicipio;
        }

        public bool EnviarDatos_ControllerViaje()
        {
            return ModeloViaje.RegistrarViaje(nombre_viaje, id_unidad, id_empleado, fecha_partida, hora_partida, tarifa, id_estado_viaje, id_tipo_viaje, fecha_retorno, hora_retorno, id_municipio);
        }

        public bool EnviarDatos_ControllerDirecciones(List<string> pdirecciones, List<string> ppuntosReferencia)
        {
            //Listas
            direcciones = pdirecciones;
            puntos_referencias = ppuntosReferencia;
            //int, lista string, lista string
            return ModeloViaje.RegistrarDirecciones(id_viaje, direcciones, puntos_referencias);
        }

        public static DataTable ViajesController()
        {
            return ModeloViaje.ObtenerViajes();
        }

        #region CMB Controller
        //cmb Cliente
        public static DataTable ObtenerCliente()
        {
            return ModeloViaje.CargarCliente();
        }
        //cmbTipoUnidadTransporte
        public static DataTable ObtenerTipoUnidadTransporte()
        {
            return ModeloViaje.CargarUnidadTransporte();
        }
        //cmbMetodoPago
        public static DataTable ObtenerMetodoPago()
        {
            return ModeloViaje.CargarMetodoPago();
        }
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
        #endregion


        #region CMB Controller Inner 
        //cmb inner Municipio
        public static DataTable CargarMunicipiosInner_controlador(int id)
        {
            return ModeloViaje.CargarMunicipioInner(id);
        }
        #endregion
    }
}
