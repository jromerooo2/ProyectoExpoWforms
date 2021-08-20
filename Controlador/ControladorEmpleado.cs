using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
   public class ControladorEmpleado
    {
        //cmb Municipio
        public static DataTable ObtenerMunicipios()
        {
            return ModeloEmpleado.CargarMunicipios();
        }
        //cmb inner Municipio
        public static DataTable CargarMunicipiosInner_controlador(int id)
        {
            return ModeloEmpleado.CargarMunicipioInner(id);
        }
        //cmb Genero
        public static DataTable ObtenerGenero()
        {
            return ModeloEmpleado.CargarGenero();
        }
        //cmb inner Genero
        public static DataTable CargarGeneroInner_controlador(int id)
        {
            return ModeloEmpleado.CargarGeneroInner(id);
        }
        //cmb Cargo
        public static DataTable ObtenerCargo()
        {
            return ModeloEmpleado.CargarCargo();
        }

        //cmb innner Cargo
        public static DataTable CargarCargoInner_controlador(int id)
        {
            return ModeloEmpleado.CargarCargoInner(id);
        }
        //cmb Estado
        public static DataTable ObtenerEstado()
        {
            return ModeloEmpleado.CargarEstado();
        }
        //cmb innner Estado
        public static DataTable CargarEstadoInner_controlador(int id)
        {
            return ModeloEmpleado.CargarEstadoInner(id);
        }


        //ATRIBUTOS 
        //Atributos para el empleado
        public static int id_conductor { get; set; }   
        public string nombres_empleado { get; set; }
        public string apellidos_empleado { get; set; }
        public string DUI { get; set; }
        public string NIT { get; set; }
        public string direccion_empleado { get; set; }
        public string telefono_empleado { get; set; }
        public string nacimiento_empleado { get; set; }
        public int id_genero { get; set; }
        public int id_estado_empleado { get; set; }
        public int id_cargo { get; set; }
        public int id_municipio { get; set; }


        //CONSTRUCTOR
        public ControladorEmpleado(string pNombre, string pApellido, string pDUI, string pNIT, string pDireccion, string pTelefono, int pGenero, int pEstado, int pCargo, int pMunicipio, string pNacimiento)
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
            id_estado_empleado = pEstado;
            id_cargo = pCargo;
            id_municipio = pMunicipio;
        }

        //CRUD
        public bool EnviarDatosControlador()
        {
            return ModeloEmpleado.RegistrarEmpleado(nombres_empleado, apellidos_empleado, DUI, NIT, direccion_empleado, telefono_empleado, id_genero, id_estado_empleado, id_cargo, id_municipio, nacimiento_empleado);
        }
    }
}
