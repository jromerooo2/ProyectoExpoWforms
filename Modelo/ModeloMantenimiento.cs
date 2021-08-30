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

        public static DataTable CargarPlaca_Vehículo(int placa)
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
        public static DataTable CargarMarca_VehiculoInner(int jeje)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_marca WHERE marca = ?param";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                cmdselect.Parameters.Add(new MySqlParameter("param", jeje));
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

        public static DataTable CargarModelo_VehiculoInner(int hola)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_modelo WHERE modelo = ?param";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                cmdselect.Parameters.Add(new MySqlParameter("param", hola));
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

        public static DataTable CargarPlaca_VehículoInner(int placa)
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

        public static bool UpdateMaintenance(int pid_mantenimiento, int pid_unidad_transporte,
                                        int pmonto_mantenimiento,
                                        int pultimo_kilometraje, string pdescripcion, string pfecha)
        {
            bool update = false;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tb_mantenimiento SET id_unidad_transporte = '"+pid_unidad_transporte+"', monto_mantenimiento = '"+pmonto_mantenimiento+"', ultimo_kilometraje = '"+pultimo_kilometraje+"', descripcion = '"+pdescripcion+"', fecha = '"+pfecha+"' WHERE id_mantenimiento = '"+pid_mantenimiento+"'"), ModeloConexion.GetConnection());
                update = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return update;
            }
            catch (Exception)
            {
                return update;
            }
        }

        /*DATA DELETE*/

        public static bool DeleteMaintenance(int maint)
        {
            bool delete;
            try
            {
                string query = "DELETE FROM tb_mantenimiento WHERE id_mantenimiento = '"+maint+"'";
                MySqlCommand cmdupdate = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                delete = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return delete;
            }
            catch (Exception)
            {
                return delete = false;
            }
        }
    }
}
