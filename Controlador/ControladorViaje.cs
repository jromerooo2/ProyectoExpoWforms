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
        public static int id_destino { get; set; }
        public static int id_viaje { get; set; }
        public int id_estado_viaje { get; set; }
        public int id_unidad_transporte { get; set; }
        public int id_metodo_pago { get; set; }
        public int id_cliente { get; set; }
        public int id_municipio { get; set; }
        public int tarifa { get; set; }
        public int id_empleado { get; set; }
        public int id_tipo_destino { get; set; }
        public string fecha_viaje { get; set; }
        public string destino { get; set; }
        public string nombre_viaje { get; set; }

        //Constructor
        public ControladorViaje(int pidCliente, int pidUnidad_transporte, int pidMetodo_pago, int pidEmpleado, int pidMunicipio, int pidEstado_viaje, int ptarifa, int pidTipo_destino, string pnombre_viaje, string pdestino, string pfecha_viaje, int pidDestino)
        {
            id_destino = pidDestino;
            id_cliente = pidCliente;
            id_unidad_transporte = pidUnidad_transporte;
            id_metodo_pago = pidMetodo_pago;
            id_empleado = pidEmpleado;
            id_municipio = pidMunicipio;
            id_estado_viaje = pidEstado_viaje;
            tarifa = ptarifa;
            id_tipo_destino = pidTipo_destino;
            nombre_viaje = pnombre_viaje;
            destino = pdestino;
            fecha_viaje = pfecha_viaje;
        }

        public bool EnviarDatos_ControllerViaje()
        {
            return ModeloViaje.RegistrarViaje(id_cliente, id_unidad_transporte, id_metodo_pago, id_empleado, id_estado_viaje, tarifa, id_destino, nombre_viaje, fecha_viaje);
        }

        public bool EnviarDatos_ControllerDestino()
        {
            return ModeloViaje.RegistrarDestino(destino, id_municipio, id_tipo_destino);
        }

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



        //cmb inner Municipio
        public static DataTable CargarMunicipiosInner_controlador(int id)
        {
            return ModeloViaje.CargarMunicipioInner(id);
        }
    }
}
