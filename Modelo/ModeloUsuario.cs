using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;

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

        public static Bitmap CargarImagen(string id)
        {
            Bitmap b;
            try
            {
                string query = "SELECT foto_usuario FROM tb_usuarios WHERE id_usuario="+id;
                MySqlCommand cmdtipomun = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                MySqlDataReader reader = cmdtipomun.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    MemoryStream ms = new MemoryStream((byte[])reader["foto_usuario"]);
                     b = new Bitmap(ms);
                    return b;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
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

        public static bool ActualizarUser(int id, int id_empleado, string user, string correo, int id_cargo, byte[] img)
        {
            bool res = false;
            //string password = "1234";
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tb_usuarios SET id_empleado= '" + id_empleado+ "', nombre_usuario= '" + user+ "',  correo_usuario= '" + correo+ "', cargo_usuario=" + id_cargo+", foto_usuario=@Imagen WHERE id_usuario= '" + id + "'"), ModeloConexion.GetConnection());
                cmdupdate.Parameters.AddWithValue("Imagen",img);
                res = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
                throw;
            }
        }

        public static bool ActualizarContraPin(string send, string pin, int id)
        {
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tb_usuarios SET contrasena='" + send + "', pin= '" + pin + "' WHERE id_usuario= '" + id + "'"), ModeloConexion.GetConnection());
                return Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static void RestablecerDefault(int id, string nombre)
        {
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tb_usuarios SET contrasena='"+nombre+"' WHERE id_usuario= '" + id + "'"), ModeloConexion.GetConnection());
                   cmdupdate.ExecuteNonQuery();
            }
            catch (Exception)
            {
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

        public static bool RegistrarUser(int pid_empleado, string user, string correo, int cargo, string password, byte[] img)
        {
            bool res = false;
            string pin = "12345678";
            try
            {
                int estado = 1;
                MySqlCommand insert = new MySqlCommand(string.Format("INSERT INTO tb_usuarios(id_empleado, nombre_usuario, correo_usuario, contrasena, cargo_usuario, estado, pin, foto_usuario) VALUES('"+pid_empleado+ "','"+user+"','"+ correo+"','"+ password+"','"+ cargo+"','"+ estado+"','"+ pin+ "', @Imagen)"), ModeloConexion.GetConnection());
                insert.Parameters.AddWithValue("Imagen", img);
                res = Convert.ToBoolean(insert.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
            }
        }
        public static bool RegistrarPrimerUser(int pid_empleado, string user,string correo, int cargo, string password, string PIN)
        {
            bool res = false;
            try
            {
                string img = null;
                int estado = 1;
                int primer_uso = 1;
                int sesion = 0;
                MySqlCommand insert = new MySqlCommand(string.Format("INSERT INTO tb_usuarios(id_empleado, nombre_usuario, correo_usuario, contrasena, cargo_usuario, estado, pin, foto_usuario, sesion, primer_uso) VALUES('{0}','{1}', '{2}', '{3}','{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", pid_empleado, user, correo, password, cargo, estado, PIN, img, sesion, primer_uso), ModeloConexion.GetConnection());
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
