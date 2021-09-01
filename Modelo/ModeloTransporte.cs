using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloTransporte
    {
        //CMB de los tipos de unidades
        public static DataTable ObtenerTipoUnidad()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_tipo_unidad;";
                MySqlCommand cmdCliente = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdCliente);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static DataTable ObtenerUnidades()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_unidad_transporte;";
                MySqlCommand cmdUnidad = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdUnidad);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static DataTable ObtenerTipoPlacas()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_tipo_placa;";
                MySqlCommand cmdUnidad = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdUnidad);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static DataTable ObtenerModelos()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_modelo;";
                MySqlCommand cmdUnidad = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdUnidad);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static DataTable ObtenerMarcas()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_marca;";
                MySqlCommand cmdUnidad = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdUnidad);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        //Cargar toda la tabla unidad de transporte
        public static DataTable CargarUnidadTransporte()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_unidad_transporte";
                MySqlCommand cmdCliente = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdCliente);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        #region CRUD
        public static bool IngresarUnidades(int pMarca, int pAnio, string pVIN, int pCapacidad, int pModelo, string pPlaca, int pTipoPlaca, int pTipoUnidad, string pNumeroMotor, string pNumeroChasis)
        {
            bool retorno = false;
            try
            {
                int pEstadoUnidad = 3;
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_unidad_transporte(id_marca, anio, VIN, capacidad, id_modelo, placa, id_tipo_placa, id_tipo_unidad, id_estado_unidad, numero_motor, numero_chasis) VALUES ('{0}', '{1}', '{2}' , '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", pMarca, pAnio, pVIN, pCapacidad, pModelo, pPlaca, pTipoPlaca, pTipoUnidad, pEstadoUnidad, pNumeroMotor, pNumeroChasis),ModeloConexion.GetConnection());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        public static bool ActualizarUnidades(int pMarca, int pAnio, string pVIN, int pCapacidad, int pModelo, string pPlaca, int pTipoPlaca, int pTipoUnidad, string pNumeroMotor, string pNumeroChasis, int pUnidadTransporte)
        {
            bool res = false;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tb_unidad_transporte SET id_marca = '" + pMarca + "', anio = '" + pAnio + "', VIN = '" + pVIN + "', capacisas = '" + pCapacidad + "', id_modelo = '" + pModelo + "', placa = '" + pPlaca + "', id_tipo_placa = '" + pTipoPlaca + "'id_tipo_unidad = '" + pTipoUnidad + "'numero_motor = '" + pNumeroMotor + "'numero_chasis = '" + pNumeroChasis+ "' WHERE id_cliente = '" + pUnidadTransporte + "'"), ModeloConexion.GetConnection());
                res = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
            }
        }

        public static bool EliminarUnidades(int pUnidadTransporte)
        {
            bool res = false;
            try
            {
                string query = "DELETE FROM tb_unidad_transporte WHERE id_unidad_transorte=" + pUnidadTransporte;
                MySqlCommand cmddelet = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                res = Convert.ToBoolean(cmddelet.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
                throw;
            }
        }

        #endregion
    }
}
