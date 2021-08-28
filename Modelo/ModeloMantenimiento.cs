using System;
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

        public static DataTable CargarMarca_Vehiculo()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_marca";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                MySqlDataAdapter mdadapt = new MySqlDataAdapter();
                data = new DataTable();
                mdadapt.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static DataTable CargarModelo_Vehiculo()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_modelo";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query),ModeloConexion.GetConnection());
                MySqlDataAdapter mdadapt = new MySqlDataAdapter();
                data = new DataTable();
                mdadapt.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static DataTable CargarPlaca_Vehículo(string placa)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_unidad_transporte WHERE matricula = ?param";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                cmdselect.Parameters.Add(new MySqlParameter("param", placa));
                MySqlDataAdapter mdadapt = new MySqlDataAdapter();
                data = new DataTable();
                mdadapt.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }


        /*DATA INSERT*/
        //INSERSIÓN DE DATOS
        public static bool RegisterMaintenance(int pid_unidad_transporte,
                                        int pmonto_mantenimiento,
                                        int pultimo_kilometraje, string pdescripcion, string pfecha)
        {
            bool register = false;
            try
            {

                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_mantenimiento(id_unidad_transporte, monto_mantenimiento, ultimo_kilometraje, descripcion, fecha) VALUES('{0}','{1}','{2}','{3}','{4}')", pid_unidad_transporte, pmonto_mantenimiento,pultimo_kilometraje,pdescripcion,pfecha), ModeloConexion.GetConnection());
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

        /*DATA UPDATE*/
    }
}
