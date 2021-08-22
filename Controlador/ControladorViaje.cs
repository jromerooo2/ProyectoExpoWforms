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
        public static int id_direccion_detalle { get; set; }
        public int id_estado_viaje { get; set; }
        public int id_unidad_transporte { get; set; }
        public int id_metodo_pago { get; set; }
        public int id_cliente { get; set; }
        public int id_municipio { get; set; }
        public int tarifa { get; set; }
        public int id_empleado { get; set; }
        public int id_tipo_viaje{ get; set; }
        public string fecha_viaje { get; set; }
        public string nombre_viaje { get; set; }
        public string hora { get; set; }
        public List<int> municipios { get; set; }
        public List<string>direcciones { get; set; }

        //Constructor
        public ControladorViaje(int pidCliente, int pidUnidad_transporte, int pidMetodo_pago, int pidEmpleado, List<int> pidMunicipio, int pidEstado_viaje, int ptarifa, string phora, int pidTipo_destino, string pnombre_viaje, int pdireccion_detalle, string pfecha_viaje, List<string>pDirecciones)
        {
            id_cliente = pidCliente;
            id_empleado = pidEmpleado;
            id_unidad_transporte = pidUnidad_transporte;
            id_metodo_pago = pidMetodo_pago;
            id_estado_viaje = pidEstado_viaje;
            tarifa = ptarifa;
            hora = phora;
            id_tipo_viaje = pidTipo_destino;
            nombre_viaje = pnombre_viaje;
            id_direccion_detalle = pdireccion_detalle;
            fecha_viaje = pfecha_viaje;
            //Listas
            direcciones = pDirecciones;          
            municipios = pidMunicipio;
        }

        public bool EnviarDatos_ControllerViaje()
        {
            return ModeloViaje.RegistrarViaje(nombre_viaje, id_cliente, id_unidad_transporte, id_empleado, fecha_viaje, hora, tarifa, id_estado_viaje, id_metodo_pago, id_tipo_viaje, id_direccion_detalle);
        }

        public bool EnviarDatos_ControllerDirecciones()
        {
            return ModeloViaje.RegistarDireccionInicio(direcciones, municipios);
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
