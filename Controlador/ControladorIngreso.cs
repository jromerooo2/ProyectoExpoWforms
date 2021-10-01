using System;
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
        #region CMB - INNER
        //cmb Municipio
        public static DataTable ObtenerDepartamento()
        {
            return ModeloIngreso.ObtenerDepartamento();
        }
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
        //cmbTipoUnidadTransporte
        public static DataTable ObtenerTipoUnidadTransporte()
        {
            return ModeloIngreso.CargarUnidadTransporte();
        }
        //CARGAR EMPLEADO
        public static DataTable CargarEmpleadoControlador()
        {
            return ModeloIngreso.ObtenerListaEmpleados();
        }
        #endregion

        //ATRIBUTOS 
        public static int id_empleado { get; set; }
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
        public  int id_municipio { get; set; }


        //Atributos Empleados - Conductores
        //public static int id_empleado { get; set; }
        //public string nombres_empleado { get; set; }
        //public string apellidos_empleado { get; set; }
        //public int id_cargo { get; set; }
        public string licencia { get; set; }
        public string fecha_exp_licencia { get; set; }
        public int id_tipo_licencia { get; set; }
        public static int id_conductor { get; set; }

        //CONSTRUCTOR
        public ControladorIngreso(string pNombre, string pApellido, string pDUI, string pNIT, string pDireccion, string pTelefono, int pGenero, int pEstado, int pCargo, int pMunicipio, string pNacimiento)
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
       
        //CRUD empleado
        public bool EnviarDatosControlador()
        {
            return ModeloIngreso.RegistrarEmpleado(nombres_empleado, apellidos_empleado, DUI, NIT, direccion_empleado, telefono_empleado, id_genero, id_estado_empleado, id_cargo, id_municipio, nacimiento_empleado);
        }     
        public bool ActualizarDatosControlador()
        {
            return ModeloIngreso.ActualizarEmpleado( id_empleado,nombres_empleado, apellidos_empleado, DUI, NIT, direccion_empleado, telefono_empleado, id_genero, id_estado_empleado, id_cargo, id_municipio, nacimiento_empleado);
        }
        public static bool EliminarEmpleadoControlador()
        {
            return ModeloIngreso.EliminarEmpleado(id_empleado);
        }


        #region CRUD Conductores
        //Obtener el ID del forms de empleados por medio del DUI y el NIT
        public int ObtenerIDEmpleado_Controller(string DUI, string NIT)
        {
            return ModeloIngreso.ObtenerIDEmpleado(DUI, NIT);
        }
        //Cargar el nombre del empleado concatenado
        public static string CargarNombresConduc_Controller()
        {
            return ModeloIngreso.ObtenerNombreConduc(id_empleado);
        }
        //Cargar toda la tabla de los conductores
        public static DataTable CargarConductores_Controller()
        {
            return ModeloIngreso.ObtenerListaConductores();
        }

        public static DataTable ObtenerViajes()
        {
            return ModeloIngreso.ObtenerViajes();
        }

        //Cargar el combobox tipo licencia
        public static DataTable ObtenerTipoLicencia()
        {
            return ModeloIngreso.ObtenerTipoLicencia();
        }

        //Cargar cmb inner tipo licencia

        public static DataTable ObtenerTipoLicenciaInner(string id_marca)
        {
            return ModeloIngreso.ObtenerTipoLicenciaInner(id_marca);
        }

        //CREATE conductores
        public static bool IngresarDatosConductores(int pid_empleado, string plicencia, int pid_tipo_licencia, string pfecha_exp_licencia)
        {
            return ModeloIngreso.RegistrarConductor(pid_empleado, plicencia, pid_tipo_licencia, pfecha_exp_licencia);
        }

        //UPDATER conductores
        public static bool ActualizarDatosConductores(int id_conductor, int id_empleado, string licencia, int id_tipo_licencia, string fecha_exp)
        {
            return ModeloIngreso.ActualizarConductor(id_conductor, id_empleado, licencia, id_tipo_licencia, fecha_exp);
        }
        
        //DELETE conductores
        public static bool EliminarDatosConductor()
        { 
            return ModeloIngreso.EliminarConductor(id_conductor);
        }
        #endregion
    }
}
