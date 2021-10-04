﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModeloLogin
    {
        public static int Login(string username, string password)
        {
            bool res1 = false;
            bool res2 = false;
            try
            {
                string query = "SELECT * FROM tb_usuarios WHERE nombre_usuario = BINARY ?param1  AND estado = BINARY ?param2";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                cmdselect.Parameters.Add(new MySqlParameter("param1", username));
                cmdselect.Parameters.Add(new MySqlParameter("param2", 1));
                res1 = Convert.ToBoolean(cmdselect.ExecuteScalar());

                if (res1)
                {
                    string query2 = "SELECT * FROM tb_usuarios WHERE  nombre_usuario = BINARY ?param1 AND contrasena = BINARY ?param2 ";
                    MySqlCommand cmdselect2 = new MySqlCommand(string.Format(query2), ModeloConexion.GetConnection());
                    cmdselect2.Parameters.Add(new MySqlParameter("param1", username));
                    cmdselect2.Parameters.Add(new MySqlParameter("param2", password));
                    res2 = Convert.ToBoolean(cmdselect2.ExecuteScalar());
                }
                if (res2)
                {
                    //updating session to 1 so i can grab it then in users crud online table
                    string session = "UPDATE tb_usuarios SET sesion= 1 WHERE nombre_usuario=BINARY ?param1 AND contrasena=BINARY ?param2  ";
                    MySqlCommand sesscmd = new MySqlCommand(string.Format(session), ModeloConexion.GetConnection());
                    sesscmd.Parameters.Add(new MySqlParameter("param1", username));
                    sesscmd.Parameters.Add(new MySqlParameter("param2", password));
                    sesscmd.ExecuteNonQuery();


                    int used = 0;
                    string firstuse = "SELECT primer_uso FROM tb_usuarios WHERE  nombre_usuario = BINARY ?param1 AND contrasena = BINARY ?param2 ";
                    MySqlCommand firstcmd = new MySqlCommand(string.Format(firstuse), ModeloConexion.GetConnection());
                    firstcmd.Parameters.Add(new MySqlParameter("param1", username));
                    firstcmd.Parameters.Add(new MySqlParameter("param2", password));
                    used = Convert.ToInt16(firstcmd.ExecuteScalar());
                    if (used == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
                else
                {
                    return 2;
                }

            }
            catch (Exception)
            {

                return 0;
            }
        }

        public static void LogOut(int idUser)
        {
            string session = "UPDATE tb_usuarios SET sesion=0 WHERE id_usuario=BINARY ?param1";
            MySqlCommand sesscmd = new MySqlCommand(string.Format(session), ModeloConexion.GetConnection());
            sesscmd.Parameters.Add(new MySqlParameter("param1", idUser));
            sesscmd.ExecuteNonQuery();
        }

        public static List<int> getUserInfo(string username)
        {
            List<int> data = new List<int>();
            try
            {
                string query = "SELECT cargo_usuario, id_usuario FROM tb_usuarios WHERE nombre_usuario= BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                cmdselect.Parameters.Add(new MySqlParameter("param1", username));

                MySqlDataReader reader = cmdselect.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(Convert.ToInt16(reader.GetString(0)));
                    data.Add(Convert.ToInt16(reader.GetString(1)));
                }
                return data;
            }
            catch (Exception)
            {

                return data;
            }
        }

        public static string getCargoString(int id)
        {
            string retorno = "";
            try
            {
                string query = "SELECT cargo FROM tb_cargo WHERE id_cargo = BINARY ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                cmdselect.Parameters.Add(new MySqlParameter("param1", id));
                retorno = Convert.ToString(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }


        #region PrimerUso
        public static int EmpleadosVacio()
        {
            int count = 0;
            try
            {
                string query = "SELECT count(*) FROM tb_empleados;";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                count = Convert.ToInt16(cmdselect.ExecuteNonQuery());
                return count;
            }
            catch (Exception)
            {

                return count;
            }
        }

        public static int UsuariosVacio()
        {
            int count = 0;
            try
            {
                string query = "SELECT count(*) FROM tb_usuarios;";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                count = Convert.ToInt16(cmdselect.ExecuteNonQuery());
                return count;
            }
            catch (Exception)
            {

                return count;
            }
        }
        #endregion
    }

}
