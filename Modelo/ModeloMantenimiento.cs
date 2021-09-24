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

        //Cargar Unidad
        public static DataTable CargarUnidad()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_unidad_transporte";
                MySqlCommand cmdunidad = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdunidad);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }

        }
        //Unidad Inner
        public static DataTable CargarUnidadInner(int id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_unidad_transporte WHERE id_unidad_transporte = ?param1";
                MySqlCommand cmdunidad = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                cmdunidad.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdunidad);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        //CRUD Mantenimiento
        public static bool RegistrarMantenimiento(int pId, int pUnidad, double pMonto, double pKilometraje,string pDescripcion,string pFecha )
        {
            bool retorno = false;
            try
            {
                //INCERCION
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_mantenimiento (id_mantenimiento, id_unidad_transporte, monto_mantenimiento, ultimo_kilometraje, descripcion, fecha) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",pId,pUnidad,pMonto,pKilometraje,pDescripcion,pFecha), ModeloConexion.GetConnection());
                //VERIFICACION
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                //RETORNO
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }
        //Obtener Lista de Mantenimiento
        public static DataTable ObtenerMantenimiento()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM dbsistemaviajes.tb_mantenimiento;";
                MySqlCommand cmdMante = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdMante);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {

                return data = null;
            }
        }

    }
}