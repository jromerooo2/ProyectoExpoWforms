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

        //CargandoCombobox
        public static DataTable CargarUnidad()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_unidad_transporte";
                MySqlCommand cmdunidad = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
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

        //CRUD
        //Registro_Mantenimiento
        public static bool RegistroMantenimiento(int pUnidad, double pMonto, double pUKilometraje,
                                string pDescripcion, string pfecha)
        {
            bool Registro = false;
            try
            {
                MySqlCommand cmdunidad = new MySqlCommand(string.Format("INSERT INTO tb_mantenimiento(id_unidad_transporte,monto_mantenimiento,ultimo_kilometraje,descripcion,fecha) VALUES ('{0}','{1}','{2}','{3}','{4}')", pUnidad, pMonto, pUKilometraje, pDescripcion, pfecha), ModeloConexion.GetConnection());
                Registro = Convert.ToBoolean(cmdunidad.ExecuteNonQuery());
                return Registro;
            }
            catch (Exception)
            {
                return Registro;
            }
        }

        public static DataTable ObtenerListaMantenimiento()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_mantenimiento";
                MySqlCommand cmdMan = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdMan);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

<<<<<<< HEAD
        //ActualizaciónMantenimiento
        public static bool ActualizacionMantenimiento(int pMant, int pUnidad, double pMonto, double pUKilometraje,
                                string pDescripcion, string pfecha)
        {
            bool update = false;
            try
            {
                MySqlCommand cmdact = new MySqlCommand(string.Format("UPDATE tb_mantenimiento SET id_unidad_transporte = '" + pUnidad + "', monto_mantenimiento = '" + pMonto + "', ultimo_kilometraje = '" + pUKilometraje + "', descripcion = '" + pDescripcion + "', fecha = '" + pfecha + "' WHERE id_mantenimiento = '" + pMant + "'"), ModeloConexion.GetConnection());
                update = Convert.ToBoolean(cmdact.ExecuteNonQuery());
                return update;
            }
            catch (Exception)
            {
                return update;
            }
        }

        public static DataTable CargarUnidad_Inner(int id)
=======
        //Update Mantenimiento
        public static bool ActualializarMantenimiento( int pMantenimiento, int pUnidad, double pMonto, double pKilometraje, string pDescripcion, string pFecha)
>>>>>>> f0184ca8a29df5abea7e5d6837914031d6bebc38
        {
            DataTable data;
            try
            {
<<<<<<< HEAD
                string query = "SELECT * FROM tb_unidad_transporte WHERE id_unidad_transporte = ?param";
                MySqlCommand cmdinner = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                cmdinner.Parameters.Add(new MySqlParameter("param", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdinner);
                data = new DataTable();
                adp.Fill(data);
                return data;
=======
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tb_mantenimiento SET id_unidad_transporte = '"+pUnidad+"', monto_mantenimiento = '"+pMonto+"', ultimo_kilometraje = '"+pKilometraje+"', descripcion = '"+pDescripcion+"', fecha = '"+pFecha+"' WHERE id_mantenimiento = '"+pMantenimiento+"' "), ModeloConexion.GetConnection());
                update = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return update;
>>>>>>> f0184ca8a29df5abea7e5d6837914031d6bebc38
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        //EliminaciónMantenimiento
        public static bool EliminarMantenimiento(int pid)
        {
<<<<<<< HEAD
            bool eliminar = false;
            try
            {
                string query = "DELETE FROM tb_mantenimiento WHERE id_mantenimiento = '" + pid + "'";
                MySqlCommand cmdeliminar = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                eliminar = Convert.ToBoolean(cmdeliminar.ExecuteNonQuery());
                return eliminar;
            }
            catch (Exception)
            {
                return eliminar;
=======
            bool retorno;
            try
            {
                string query = "DELETE FROM tb_mantenimiento WHERE id_mantenimiento = '"+pid+"'";
                MySqlCommand cmdelete = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                retorno = Convert.ToBoolean(cmdelete.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno=false;
>>>>>>> f0184ca8a29df5abea7e5d6837914031d6bebc38
            }
        }

    }
}