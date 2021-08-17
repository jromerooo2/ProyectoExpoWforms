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
            string retorno = "hellojuancho75@gmail.com";
            try
            {
                string query = "SELECT correo_usuario FROM tb_cliente WHERE nombre_usuario = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                cmdselect.Parameters.Add(new MySqlParameter("param1", username));

                if (cmdselect.ExecuteScalar() == null)
                {
                     retorno = "hellojuancho75@gmail.com";
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
