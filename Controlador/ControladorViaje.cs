﻿using System;
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
        //CRUD
        public bool EnviarDatos_ControllerViaje()
        {
            return ModeloViaje.RegistrarViaje(nombre_viaje,id_cliente,id_unidad, id_empleado, fecha_partida, tarifa, id_estado_viaje, id_tipo_viaje, fecha_retorno, id_municipio);
        }
        public bool ActualizarViajeControlador()
        {
            return ModeloViaje.ActualizarViaje(id_viaje,nombre_viaje, id_cliente, id_unidad, id_empleado, fecha_partida, tarifa, id_estado_viaje, id_tipo_viaje, fecha_retorno, id_municipio);
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
        public static DataTable CargarMunicipiosInner_controlador(int id)
        {
            return ModeloViaje.CargarMunicipioInner(id);
        }
        public static DataTable CargarClienteInner(int id)
        {
            return ModeloViaje.ObtenerClienteInner(id);
        }
        #endregion
    }
}
