﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloMantenimiento
    {
        /*DATA INSERT*/
        //INSERSIÓN DE DATOS
        public static bool RegisterMaintenance(int pid_unidad_transporte,
                                        int pid_marca, int pid_modelo, int pplaca,
                                        int pmonto_mantenimiento,
                                        int pultimo_kilometraje, string pdescripcion, string pfecha)
        {
            bool register = false;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_mantenimiento(id_unidad_transporte, id_marca, id_modelo, placa, monto_mantenimiento, ultimo_kilometraje, descripcion, fecha) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", pid_unidad_transporte,pid_marca,pid_modelo,pplaca,pmonto_mantenimiento,pultimo_kilometraje,pdescripcion,pfecha), ModeloConexion.GetConnection());
                register = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return register;
            }
            catch (Exception)
            {
                return register;
            }
        }

        public static DataTable GetMaintenanceList()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_mantenimiento";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                MySqlDataAdapter mdadapt = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                mdadapt.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                ModeloConexion.GetConnection().Close();
            }
        }
    }
}
