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
                int activo = 1;

                string query = "SELECT * FROM tbusuarios WHERE usuario = BINARY ?param1 AND clave = BINARY ?param2 AND idestado = ?param3";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                cmdselect.Parameters.Add(new MySqlParameter("param1", username));
                cmdselect.Parameters.Add(new MySqlParameter("param2", password));
                cmdselect.Parameters.Add(new MySqlParameter("param2", activo));
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
