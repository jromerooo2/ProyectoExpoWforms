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
        public static DataTable ObtenerCliente()
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
        public string apellidos_empleado { get; set; }
        public string DUI { get; set; }
        public string NIT { get; set; }
        public string direccion_empleado { get; set; }
        public string telefono_empleado { get; set; }
        public string nacimiento_empleado { get; set; }
        public int id_genero { get; set; }
        public int id_estado { get; set; }
        public int id_cargo { get; set; }
        public  int id_municipio { get; set; }
        //CONSTRUCTOR
        public ControladorIngreso(string pNombre, string pApellido, string pDUI, string pNIT, string pDireccion, string pTelefono, string pNacimiento, int pGenero, int pEstado, int pCargo, int pMunicipio)
        {
            //Atributo = parametro
            nombres_empleado = pNombre;
            apellidos_empleado = pApellido;
            DUI = pDUI;
            NIT = pNIT;
            direccion_empleado = pDireccion;
            telefono_empleado = pTelefono;
            nacimiento_empleado = pNacimiento;
            id_genero = pGenero;
            id_estado = pEstado;
            id_cargo = pCargo;
            id_municipio = pMunicipio;
        }

        //CRUD
        public bool EnviarDatosControlador()
        {
            return ModeloIngreso.RegistrarEmpleado(nombres_empleado, apellidos_empleado, DUI, NIT, nacimiento_empleado, direccion_empleado, telefono_empleado, id_genero, id_estado, id_cargo, id_municipio);
        }
    }
}
