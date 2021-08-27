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
        public static bool Login(string username, string password)
        {
            bool retorno = false;
            try
            {
                string query = "SELECT * FROM tb_usuarios WHERE nombre_usuario = BINARY ?param1 AND contrasena = BINARY ?param2 ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                cmdselect.Parameters.Add(new MySqlParameter("param1", username));
                cmdselect.Parameters.Add(new MySqlParameter("param2", password));
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {

                return retorno;
            }
        }

    }
}
