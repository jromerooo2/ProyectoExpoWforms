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

        public static DataTable CargarUsuarios()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbusuariosview";
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

        public static bool ActualizarUser(int id, int id_empleado, string user, string correo, int id_cargo)
        {
            bool res = false;
            //string password = "1234";
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tb_usuarios SET id_empleado= '" + id_empleado+ "', nombre_usuario= '" + user+ "',  correo_usuario= '" + correo+ "', cargo_usuario=" + id_cargo+" WHERE id_usuario= '" + id + "'"), ModeloConexion.GetConnection());
                res = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
                throw;
            }
        }

        public static void PrimerUso(int idlogged)
        {
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tb_usuarios SET primer_uso = 1 WHERE id_usuario= '" + idlogged+ "'"), ModeloConexion.GetConnection());
                    cmdupdate.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetOnlineUsers()
        {
            DataTable data;
            try
            {
                string query = "SELECT nombre_usuario, correo_usuario FROM tb_usuarios WHERE sesion=1";
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

        public static void BlockUser(string user)
        {
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tb_usuarios SET id_estado_usuario='bloqueado', WHERE nombre_usuario=" + user), ModeloConexion.GetConnection());
                cmdupdate.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool ActualizarContra(string passMD5, string user)
        {
            bool res = false;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tb_usuarios SET contrasena='"+passMD5+"', WHERE nombre_usuario="+ user), ModeloConexion.GetConnection());
                res = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
                throw;
            }
        }

        public static bool EliminarUsuario(int id)
        {
            bool res = false;
            try
            {
                string query = "DELETE FROM tb_usuarios  WHERE id_usuario="+id;
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                res = Convert.ToBoolean(cmd.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
                throw;
            }
        }

        public static object CargarUsuarioInner(string id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_empleados WHERE nombres_empleado= ?param1";
                MySqlCommand cmdtipodoc = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                cmdtipodoc.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipodoc);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static object CargarCargoInner(string id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_cargo WHERE cargo= ?param1";
                MySqlCommand cmdtipodoc = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                cmdtipodoc.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipodoc);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static bool RegistrarUser(int pid_empleado, string user, string correo, int cargo, string password)
        {
            bool res = false;
            string pin = "12345678";
            try
            {
                int estado = 1;
                MySqlCommand insert = new MySqlCommand(string.Format("INSERT INTO tb_usuarios(id_empleado, nombre_usuario, correo_usuario, contrasena, cargo_usuario, estado, pin) VALUES('{0}','{1}', '{2}', '{3}','{4}', '{5}', '{6}')", pid_empleado, user, correo, password, cargo, estado, pin), ModeloConexion.GetConnection());
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
