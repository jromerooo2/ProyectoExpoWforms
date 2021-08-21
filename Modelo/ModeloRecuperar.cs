using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
   public class ModeloRecuperar
    {

        public static string recuperarPassMail(string username)
        {
            string retorno = "";
            try
            {
                string query = "SELECT correo_usuario FROM tb_usuarios WHERE nombre_usuario= BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                cmdselect.Parameters.Add(new MySqlParameter("param1", username));

                MySqlDataReader reader = cmdselect.ExecuteReader();
                while (reader.Read())
                {
                    retorno = reader.GetString(0);
                }
                return retorno;
            }
            catch (Exception)
            {

                return retorno;
            }
        }
    }
}
