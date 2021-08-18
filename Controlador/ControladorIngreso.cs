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
        //ATRIBUTOS 
        public static int id_conductor { get; set; }
        public string nombres_conduc { get; set; }
        public string apellidos_conduc { get; set; }
        public string DUI { get; set; }
        public string NIT { get; set; }
        public string direccion_conduc { get; set; }
        public string telefono_conduc { get; set; }
        public string nacimiento_con { get; set; }
        public char genero_conduc { get; set; }
        public int id_estado { get; set; }
        public int id_cargo { get; set; }
        public  int id_municipio { get; set; }
        //CONSTRUCTOR
        public ControladorIngreso(string pNombre, string pApellido, string pDUI, string pNIT, string pDireccion, string pTelefono, string pNacimiento, char pGenero, int pEstado, int pCargo, int pMunicipio)
        {
            nombres_conduc = pNombre;
            apellidos_conduc = pApellido;
            DUI = pDUI;
            NIT = pNIT;
            direccion_conduc = pDireccion;
            telefono_conduc = pTelefono;
            nacimiento_con = pNacimiento;
            genero_conduc = pGenero;
            id_estado = pEstado;
            id_cargo = pCargo;
            id_municipio = pMunicipio;
        }

        //CRUD
        public bool EnviarDatosController()
        {
            return ModeloIngreso.RegistrarConductor(nombre_conduc, apellido_conduc, DUI, NIT, direccion_conduc, telefono_conduc, genero_conduc, id_estado_conduc, id_cargo, id_municipio, nacimiento_con);
        }
    }
}
