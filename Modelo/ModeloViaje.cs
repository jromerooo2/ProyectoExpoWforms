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
        public static bool RegistrarViaje(string pNombre_viaje, int pidCliente, int pidUnidad, int pidEmpleado, string pfecha,  string phora, int ptarifa, int pidEstado_viaje, int pidMetodo_pago, int pidTipo_viaje, int pidDirecciones_detalle)
        {
            bool retorno = false;
            try
            {
                //INCERCION
                MySqlCommand cmdinsertviaje = new MySqlCommand(string.Format("INSERT INTO tb_viajes (nombre_viaje, id_cliente, id_unidad, id_emplea) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", pNombre_viaje, pidCliente, pidUnidad, pidEmpleado, pfecha , ptarifa, pidEstado_viaje, pidMetodo_pago, pidTipo_viaje, pidDirecciones_detalle), ModeloConexion.GetConnection());
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

        public static bool RegistrarDirecciones(List<string> pdireccion, List<int> pidMunicipio)
        {
            RegistarDireccionInicio(pdireccion, pidMunicipio);
            RegistrarDireccionFinal(pdireccion, pidMunicipio);
            RegistrarDireccionFinal(pdireccion, pidMunicipio);

            if (RegistarDireccionInicio(pdireccion, pidMunicipio) == true &&
                RegistrarDireccionFinal(pdireccion, pidMunicipio) == true &&
                RegistrarDireccionAdicional(pdireccion, pidMunicipio) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool RegistarDireccionInicio(List<string> pdireccion, List<int> pidMunicipio)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdinsertdireccion = new MySqlCommand(string.Format("INSERT INTO tb_direccion_inicio (direccion_inicio) VALUES ('{0}', '{1}')", pdireccion[0], pidMunicipio[0]), ModeloConexion.GetConnection());
                retorno = Convert.ToBoolean(cmdinsertdireccion.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        public static bool RegistrarDireccionFinal(List<string> pdireccion, List<int> pidMunicipio)
        { 
            bool retorno = false;
            try
            {
                MySqlCommand cmdinsertdireccion = new MySqlCommand(string.Format("INSERT INTO tb_direccion_final (direccion_final) VALUES ('{0}', '{1}')", pdireccion[1], pidMunicipio[1]), ModeloConexion.GetConnection());
                retorno = Convert.ToBoolean(cmdinsertdireccion.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        public static bool RegistrarDireccionAdicional(List<string> pdireccion, List<int> pidMunicipio)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdinsertdireccion = new MySqlCommand(string.Format("INSERT INTO tb_direccion_adicional (direccion_adicional) VALUES ('{0}', '{1}')", pdireccion[2], pidMunicipio[2]), ModeloConexion.GetConnection());
                retorno = Convert.ToBoolean(cmdinsertdireccion.ExecuteNonQuery());
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
