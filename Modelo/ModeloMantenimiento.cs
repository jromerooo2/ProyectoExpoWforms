using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModeloMantenimiento
    {
        public static DataTable GetVehicleType()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_tipo_unidad";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                MySqlDataAdapter cmdadapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                cmdadapter.Fill(data);
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
