﻿using System;
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
                string query = "SELECT * FROM tb_usuarios";
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

        public static bool ActualizarUser(int id, int id_empleado, string user, string correo, string password, int id_cargo)
        {
            bool res = false;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tb_usuarios SET id_empleado= '" + id_empleado+ "', nombre_usuario= '" + user+ "',  correo_usuario= '" + correo+ "', contrasena= '" + password+ "', cargo_usuario=" + id_cargo+" WHERE id_usuario= '" + id + "'"), ModeloConexion.GetConnection());
                res = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
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

        public static object CargarUsuarioInner(int id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_empleados WHERE id_empleado= ?param1";
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
        public static object CargarCargoInner(int id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_cargo WHERE id_cargo= ?param1";
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
