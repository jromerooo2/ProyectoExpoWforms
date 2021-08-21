using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModeloUsuario
    {
        public static DataTable CargarEmpleados()
        {
            DataTable data;
            try
            {
                string query = "SELECT id_empleado, nombres_empleado FROM tb_empleados ";
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

        public static bool RegistrarUser(int id_empleado, string user, string password, string correo)
        {
            bool res = false;
            try
            {
                string query = "INSERT INTO tb_usuarios(id_empleado, nombre_usuario, correo_usuario, contraseña) VALUES(" + id_empleado + ", " + user + ", " + correo + "," + password + ")";
                MySqlCommand insert = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                res = Convert.ToBoolean(insert.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
            }
        }
    }
}
