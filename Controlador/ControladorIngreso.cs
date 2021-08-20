﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
   public class ControladorIngreso
    {
        //cmb Municipio
        public static DataTable ObtenerMunicipios()
        {
            return ModeloIngreso.CargarMunicipios();
        }
        //cmb inner Municipio
        public static DataTable CargarMunicipiosInner_controlador(int id)
        {
            return ModeloIngreso.CargarMunicipioInner(id);
        }
        //cmb Genero
        public static DataTable ObtenerGenero()
        {
            return ModeloIngreso.CargarGenero();
        }
        //cmb inner Genero
        public static DataTable CargarGeneroInner_controlador(int id)
        {
            return ModeloIngreso.CargarGeneroInner(id);
        }
        //cmb Cargo
        public static DataTable ObtenerCargo()
        {
            return ModeloIngreso.CargarCargo();
        }

        //cmb innner Cargo
        public static DataTable CargarCargoInner_controlador(int id)
        {
            return ModeloIngreso.CargarCargoInner(id);
        }
        //cmb Estado
        public static DataTable ObtenerEstado()
        {
            return ModeloIngreso.CargarEstado();
        }
        //cmb innner Estado
        public static DataTable CargarEstadoInner_controlador(int id)
        {
            return ModeloIngreso.CargarEstadoInner(id);
        }
        //cmb Cliente
        public static DataTable ObtenerTipoCliente()
        {
            return ModeloIngreso.CargarCliente();
        }
        //cmbTipoUnidadTransporte
        public static DataTable ObtenerTipoUnidadTransporte()
        {
            return ModeloIngreso.CargarUnidadTransporte();
        }
        //cmbMetodoPago
        public static DataTable ObtenerMetodoPago()
        {
            return ModeloIngreso.CargarMetodoPago();
        }
        //cmb EstadoViaje
        public static DataTable ObtenerEstadoViaje()
        {
            return ModeloIngreso.CargarEstadoViaje();
        }

        //ATRIBUTOS 
        public static int id_conductor { get; set; }
        public string nombres_empleado { get; set; }
        public string nombres_cliente { get; set; }
        public string apellidos_empleado { get; set; }
        public string apellidos_cliente { get; set; }
        public string telefono_cliente { get; set; }
        public string direccion_cliente { get; set; }
        public string correo_cliente { get; set; }
        public string DUI { get; set; }
        public string NIT { get; set; }
        public string direccion_empleado { get; set; }
        public string telefono_empleado { get; set; }
        public string nacimiento_empleado { get; set; }
        public int id_tipo_cliente { get; set; }
        public int id_genero { get; set; }
        public int id_estado_empleado { get; set; }
        public int id_cargo { get; set; }
        public  int id_municipio { get; set; }
        //CONSTRUCTOR
        public ControladorIngreso(string pNombre, string pNomCliente, string pApellido, string pApeCliente, string pDUI, string pTelCliente, string pDirCliente, string pCorCliente, string pNIT, string pDireccion, string pTelefono, int pGenero, int pEstado, int pCargo, int pMunicipio, int pTipCliente, string pNacimiento)
        {
            //Atributo = parametro
            nombres_empleado = pNombre;
            nombres_cliente = pNomCliente;
            apellidos_empleado = pApellido;
            apellidos_cliente = pApeCliente;
            telefono_cliente = pTelCliente;
            direccion_cliente = pDirCliente;
            correo_cliente = pCorCliente;
            DUI = pDUI;
            NIT = pNIT;
            direccion_empleado = pDireccion;
            telefono_empleado = pTelefono;
            nacimiento_empleado = pNacimiento;
            id_tipo_cliente = pTipCliente;
            id_genero = pGenero;
            id_estado_empleado = pEstado;
            id_cargo = pCargo;
            id_municipio = pMunicipio;
        }
       
        //CRUD
        public bool EnviarDatosControlador()
        {
            return ModeloIngreso.RegistrarEmpleado(nombres_empleado, apellidos_empleado, DUI, NIT, direccion_empleado, telefono_empleado, id_genero, id_estado_empleado, id_cargo, id_municipio, nacimiento_empleado);
        }

        public bool EnviarClientes()
        {
            return ModeloIngreso.AgregarCliente(nombres_cliente, apellidos_cliente, direccion_cliente, telefono_cliente, correo_cliente, id_tipo_cliente );
        }
    }
}
