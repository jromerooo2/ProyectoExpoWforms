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
        //cmb Cliente
        public static DataTable ObtenerTipoCliente()
        {
            return ModeloIngreso.CargarTipoCliente();
        }

        public static DataTable ObtenerCliente()
        {
            return ModeloIngreso.CargarClientes();
        }

        public string nombres_cliente { get; set; }
        public string apellidos_cliente { get; set; }
        public string telefono_cliente { get; set; }
        public string direccion_cliente { get; set; }
        public string correo_cliente { get; set; }       
        public int id_tipo_cliente { get; set; }
        public int id_cliente { get; set; }

        public ControladorIngresoCliente (string pNomCliente, string pApeCliente, string pTelCliente, string pDirCliente, string pCorCliente, int pTipCliente)
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
        public bool ActualizarClienteContorlador()
        {
            return ModeloIngreso.ActualizarCliente(nombres_cliente, apellidos_cliente, telefono_cliente, direccion_cliente, correo_cliente, id_tipo_cliente, id_cliente);
        }
        public static object EliminarClienteControlador()
        {
            return ModeloIngreso.EliminarCliente();
        }
    }
}
