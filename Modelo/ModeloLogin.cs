using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModeloLogin
    {
        public static int Login(string username, string password)
        {
            bool res1 = false;
            bool res2 = false;
            try
            {
                string query = "SELECT * FROM tb_usuarios WHERE nombre_usuario = BINARY ?param1  AND estado = BINARY ?param2";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                cmdselect.Parameters.Add(new MySqlParameter("param1", username));
                cmdselect.Parameters.Add(new MySqlParameter("param2", 1));
                res1 = Convert.ToBoolean(cmdselect.ExecuteScalar());

                if (res1)
                {
                    string query2 = "SELECT * FROM tb_usuarios WHERE  nombre_usuario = BINARY ?param1 AND contrasena = BINARY ?param2 ";
                    MySqlCommand cmdselect2 = new MySqlCommand(string.Format(query2), ModeloConexion.GetConnection());
                    cmdselect2.Parameters.Add(new MySqlParameter("param1", username));
                    cmdselect2.Parameters.Add(new MySqlParameter("param2", password));
                    res2 = Convert.ToBoolean(cmdselect2.ExecuteScalar());
                }
                if (res2)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
                
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public static List<int> getUserInfo(string username)
        {
            List<int> data = new List<int>();
            try
            {
                string query = "SELECT cargo_usuario, id_usuario FROM tb_usuarios WHERE nombre_usuario= BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                cmdselect.Parameters.Add(new MySqlParameter("param1", username));

                MySqlDataReader reader = cmdselect.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(Convert.ToInt16(reader.GetString(0)));
                    data.Add(Convert.ToInt16(reader.GetString(1)));
                }
                return data;
            }
            catch (Exception)
            {

                return data;
            }
        }
    }

}
