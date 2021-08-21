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

        public static bool RegistrarUser(int pid_empleado, string user, string password, string correo, int cargo )
        {
            bool res = false;
            try
            {
                MySqlCommand insert = new MySqlCommand(string.Format("INSERT INTO tb_usuarios(id_empleado, nombre_usuario, correo_usuario, contrasena, cargo_usuario) VALUES('{0}','{1}', '{2}', '{3}','{4}')", pid_empleado, user, correo, password, cargo), ModeloConexion.GetConnection());
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
