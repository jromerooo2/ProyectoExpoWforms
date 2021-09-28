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
        public static List<string> GetDataClientes()
        {
            List<string> data = new List<string>();
            try
            {
                string instruccion = "SELECT nombres_cliente, apellidos_cliente,telefono_cliente, direccion_cliente, correo_cliente FROM tb_cliente";
                MySqlCommand cmd = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(reader[0].ToString());
                    data.Add(reader[1].ToString());
                    data.Add(reader[2].ToString());
                    data.Add(reader[3].ToString());
                    data.Add(reader[4].ToString());
                }
                return data;


            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static List<string> GetDataEmpleados()
        {
            List<string> data = new List<string>();
            //  "Nombres", "Apellidos", "DUI", "NIT", "Direccion", "Telefóno", "Nacimiento"
            try
            {
                string instruccion = "SELECT nombres_empleado, apellidos_empleado,DUI,NIT,direccion_empleado,telefono_empleado,nacimiento_empleado FROM tb_empleados";
                MySqlCommand cmd = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(reader[0].ToString());
                    data.Add(reader[1].ToString());
                    data.Add(reader[2].ToString());
                    data.Add(reader[3].ToString());
                    data.Add(reader[4].ToString());
                    data.Add(reader[5].ToString());
                    data.Add(reader[6].ToString());
                }
                return data;


            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static List<string> GetDataTransportes()
        {
            List<string> data = new List<string>();
            // "Año", "VIN", "Placa", "Tipo Unidad", "Modelo", "Estado","# del Motor", "# del Chasis"
            try
            {
                string instruccion = "SELECT anio, VIN ,capacidad,placa, tipo_unidad,modelo,estado_unidad,numero_motor, numero_chasis FROM tbvistaunidad";
                MySqlCommand cmd = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(reader[0].ToString());
                    data.Add(reader[1].ToString());
                    data.Add(reader[2].ToString());
                    data.Add(reader[3].ToString());
                    data.Add(reader[4].ToString());
                    data.Add(reader[5].ToString());
                    data.Add(reader[6].ToString());
                    data.Add(reader[7].ToString());
                    data.Add(reader[8].ToString());
                }
                return data;


            }
            catch (Exception)
            {
                return data = null;
            }
        }
    }
}
