using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

namespace Controlador
{
    public class ModeloReportes
    {
        public static DataTable GetDataClientes()
        {
            DataTable data;
            // "Año", "VIN", "Placa", "Tipo Unidad", "Modelo", "Estado","# del Motor", "# del Chasis"
            try
            {
                string query = "SELECT tb_cliente.nombres_cliente, tb_cliente.apellidos_cliente, tb_cliente.telefono_cliente,tb_tipo_cliente.id_tipo_cliente,tb_cliente.direccion_cliente, tb_cliente.correo_cliente FROM  tb_cliente INNER JOIN tb_tipo_cliente ON tb_cliente.id_tipo_cliente = tb_tipo_cliente.id_tipo_cliente";
                MySqlCommand cmdtipomun = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipomun);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataTable GetDataEmpleados()
        {
            DataTable data;
            // "Año", "VIN", "Placa", "Tipo Unidad", "Modelo", "Estado","# del Motor", "# del Chasis"
            //nombres_empleado, apellidos_empleado,DUI,NIT,telefono_empleado,id_cargo  FROM tb_empleados
            try
            {
                string query = "SELECT tb_empleados.nombres_empleado,tb_empleados.apellidos_empleado,tb_empleados.DUI,tb_empleados.NIT,tb_empleados.telefono_empleado,tb_cargo.cargo  FROM tb_empleados INNER JOIN tb_cargo ON tb_empleados.id_cargo = tb_cargo.id_cargo";
                MySqlCommand cmdtipomun = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipomun);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static DataTable GetDataTransportes()
        {
            DataTable data;
            // "Año", "VIN", "Placa", "Tipo Unidad", "Modelo", "Estado","# del Motor", "# del Chasis"
            try
            {
                string query = "SELECT * FROM tbvistaunidad";
                MySqlCommand cmdtipomun = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipomun);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
    }
}
