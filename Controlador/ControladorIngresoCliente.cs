using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{   
    public class ControladorIngresoCliente
    {
        public bool EnviarDatosControlador()
        {
            return ModeloIngreso.AgregarCliente(nombres_cliente, apellidos_cliente, direccion_cliente, telefono_cliente, correo_cliente, id_tipo_cliente);
        }
        //cmb tipo Cliente
        public static DataTable ObtenerTipoCliente()
        {
            return ModeloIngreso.CargarCliente();
        }

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
        public int id_municipio { get; set; }

        public ControladorIngresoCliente(string pNomCliente, string pApeCliente, string pTelCliente, string pDirCliente, string pCorCliente, int pTipCliente)
        {
            //Atributo = parametro        
            nombres_cliente = pNomCliente;
            apellidos_cliente = pApeCliente;
            telefono_cliente = pTelCliente;
            direccion_cliente = pDirCliente;
            correo_cliente = pCorCliente;
            id_tipo_cliente = pTipCliente;
        }

        public bool EnviarClientes()
        {
            return ModeloIngreso.AgregarCliente(nombres_cliente, apellidos_cliente, direccion_cliente, telefono_cliente, correo_cliente, id_tipo_cliente);
        }
    }
}
