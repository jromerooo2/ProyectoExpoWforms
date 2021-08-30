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
                string query = "SELECT * FROM tb_usuarios WHERE nombre_usuario = BINARY ?param1  AND id_estado_usuario=1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                cmdselect.Parameters.Add(new MySqlParameter("param1", username));
                res1 = Convert.ToBoolean(cmdselect.ExecuteScalar());

                if (res1)
                {
                    string query2 = "SELECT * FROM tb_usuarios WHERE contrasena = BINARY ?param1 ";
                    MySqlCommand cmdselect2 = new MySqlCommand(string.Format(query2), ModeloConexion.GetConnection());
                    cmdselect2.Parameters.Add(new MySqlParameter("param1", username));
                    res2 = Convert.ToBoolean(cmdselect.ExecuteScalar());
                }
                if (res1 && res2)
                {
                    return 1;
                }
                if (res1 && !res2)
                {
                    return 2;
                }
                return 0;
                
            }
            catch (Exception)
            {

                return 0;
            }
        }

    }
}
