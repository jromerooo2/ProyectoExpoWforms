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
    }
}
