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

        public static List<string> recuperarPassMail(string username)
        {
            List<string> data = new List<string>();
            try
            {
                string query = "SELECT id_usuario, correo_usuario FROM tb_usuarios WHERE nombre_usuario= BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                cmdselect.Parameters.Add(new MySqlParameter("param1", username));

                MySqlDataReader reader = cmdselect.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(reader.GetString(0));
                    data.Add(reader.GetString(1));
                }
                return data;
            }
            catch (Exception)
            {

                return data;
            }
        }

        public static bool ActualizarContra(string passMD5, string v)
        {
            bool res = false;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tb_usuarios SET contrasena='" + passMD5 + "' WHERE id_usuario=" + v), ModeloConexion.GetConnection());
                res = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
                throw;
            }
        }

        public static bool ValidarCredenciales(string usuarioadmin, string claveadmin)
        {
            bool retorno = false;
            try
            {
                int activo = 1;
                string query = "SELECT * FROM tbusuarios WHERE usuario = BINARY ?param1 AND clave = BINARY ?param2 AND id_estado_usuario = ?param3";
                MySqlCommand cmdvalidar = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                retorno = Convert.ToBoolean(cmdvalidar.ExecuteScalar());
                cmdvalidar.Parameters.Add(new MySqlParameter("param1", usuarioadmin));
                cmdvalidar.Parameters.Add(new MySqlParameter("param2", claveadmin));
                cmdvalidar.Parameters.Add(new MySqlParameter("param3", activo));
                return retorno; 
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
