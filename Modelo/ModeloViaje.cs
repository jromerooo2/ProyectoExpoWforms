using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloViaje
    {
        #region CMB
        //Cargar Unidad Transporte
        public static DataTable CargarUnidadTransporte()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_tipo_unidad ORDER BY tipo_unidad ASC";
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

        //Cargar Metodo Pago
        public static DataTable CargarMetodoPago()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_metodo_pago";
                MySqlCommand cmdMetodoPago = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdMetodoPago);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static DataTable CargarEstadoViaje()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_estado_viaje";
                MySqlCommand cmdEstadoViaje = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdEstadoViaje);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        //Cargar Cliente
        public static DataTable CargarCliente()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_cliente ORDER BY apellidos_cliente ASC";
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
        //Cargar Municipios
        public static DataTable CargarMunicipios()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_municipios ORDER BY municipio ASC";
                MySqlCommand cmdtipomun = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
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
        #endregion

        #region CMBInner
        //Municipio inner
        public static DataTable CargarMunicipioInner(int id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_municipios WHERE id_municipio = ?param1";
                MySqlCommand cmdtipomun = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                cmdtipomun.Parameters.Add(new MySqlParameter("param1", id));
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
        #endregion

        #region CRUD
        public static bool RegistrarViaje(int pidCliente, int pidUnidad_transporte, int pidMetodo_pago, int pidEmpleado, int pidEstado_viaje, int ptarifa, int pidDestino, string pnombre_viaje, string pfecha_viaje)
        {
            bool retorno = false;
            try
            {
                //INCERCION
                MySqlCommand cmdinsertviaje = new MySqlCommand(string.Format("INSERT INTO tb_viajes (nombre_viaje, id_cliente, id_unidad, id_empleado, fecha, tarifa, id_estado_viaje, id_destino, id_metodo_pago) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", pnombre_viaje, pidCliente, pidUnidad_transporte, pidEmpleado, pfecha_viaje, ptarifa, pidEstado_viaje, pidDestino, pidMetodo_pago), ModeloConexion.GetConnection());
                //VERIFICACION
                retorno = Convert.ToBoolean(cmdinsertviaje.ExecuteNonQuery());
                //RETORNO
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        public static bool RegistrarDestino(string pdestino, int pidMunicipio, int pidTipo_destino)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdinsertdestino = new MySqlCommand(string.Format("INSER INTO tb_destino (destino, id_municipio, id_tipo_destino) VALUES ('{0}', '{1}', '{2}')", pdestino, pidMunicipio, pidTipo_destino), ModeloConexion.GetConnection());
                retorno = Convert.ToBoolean(cmdinsertdestino.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }
        #endregion
    }
}
