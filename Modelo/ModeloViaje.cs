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
        public static DataTable CargarTipoUnidadTransporte()
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

        public static string GetActiveTrips(string today)
        {

                List<string> data = new List<string>();
                try
                {
                    string query = "SELECT COUNT(id_viaje) FROM tb_viajes WHERE fecha_inicio = '"+today+"'";
                    MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());

                    MySqlDataReader reader = cmdselect.ExecuteReader();
                    while (reader.Read())
                    {
                        data.Add(reader.GetString(0));
                    }
                    return data[0];
                }
                catch (Exception)
                {

                    return data[0];
                }
         }

        public static DataTable ObtenerCliente()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_cliente";
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
        public static DataTable ObtenerClienteInner(string id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_cliente WHERE id_cliente = ?param1";
                MySqlCommand cmdCli = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                cmdCli.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdCli);
                data = new DataTable();
                adp.Fill(data);
                return data;

            }
            catch (Exception)
            {

                return data = null;
            }
        }
        public static DataTable CargarConductores()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_empleados WHERE id_cargo=1";
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

        public static DataTable CargarEstadoViajeInner(string id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_estado_viaje WHERE id_estado_viaje="+ id;
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

        public static DataTable CargarTipoViajeInner(string id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_tipo_viaje WHERE id_tipo_viaje=" + id;
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

        public static bool EliminarViaje(string text)
        {
            bool res = false;
            try
            {
                string query = "DELETE FROM tb_viajes  WHERE id_viaje=" + text;
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                res = Convert.ToBoolean(cmd.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
                throw;
            }
        }

        public static bool ActualizarViaje(string id_viaje, string nombreViaje, int id_cliente, int id_unidad, int id_conductor, string fecha_partida, string tarifa, int id_estado_viaje, int id_tipo_viaje, string fecha_retorno, int id_municipio)
        {
            bool retorno = false;
            try
            {
                //Proceso de Actualizacion
                MySqlCommand cmdUpEmpleado = new MySqlCommand(string.Format(" UPDATE tb_viajes  SET nombre_viaje = '" + nombreViaje + "',cliente = '" + id_cliente + "',id_unidad ='" + id_unidad+ "',id_empleado='" + id_conductor+ "',fecha_inicio= '" + fecha_partida+ "',tarifa= '" + tarifa+ "',id_estado_viaje = '" + id_estado_viaje+ "',id_tipo_viaje= '" + id_tipo_viaje+ "',fecha_retorno= '" + fecha_retorno+ "',id_municipio= '" + id_municipio+ "' WHERE id_viaje =" + id_viaje), ModeloConexion.GetConnection());
                //Verificar Update
                retorno = Convert.ToBoolean(cmdUpEmpleado.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {

                return retorno;
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

        public static DataTable ObtenerUnidadInner(string id_unidad)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_unidad_transporte WHERE id_unidad_transporte="+id_unidad;
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

        public static DataTable ObtenerEmpleadoInner(string id_empleado)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_empleados WHERE id_empleado=" + id_empleado;
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

        public static DataTable CargarTipoViaje()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_tipo_viaje";
                MySqlCommand cmdtipoviaje = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipoviaje);
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
        public static DataTable CargarMunicipioInner(string id)
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
        public static bool RegistrarViaje(string pNombre_viaje,int pidCliente,int pidUnidad, int pidConductor,string pfecha_inicio, string ptarifa, int pidEstado_viaje, int pidTipo_viaje, string pfecha_retorno, int pidMunicipio)
        {
            bool retorno = false;
            try
            {
                //INCERCION
                MySqlCommand cmdinsertviaje = new MySqlCommand(string.Format("INSERT INTO tb_viajes (nombre_viaje,cliente,id_unidad, id_empleado, fecha_inicio, tarifa, id_estado_viaje, id_tipo_viaje, fecha_retorno, id_municipio) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}', '{9}')", pNombre_viaje, pidCliente, pidUnidad, pidConductor, pfecha_inicio , ptarifa, pidEstado_viaje, pidTipo_viaje, pfecha_retorno, pidMunicipio), ModeloConexion.GetConnection());
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

        public static bool AsignarViajeCliente(int cliente, int viaje)
        {
            bool retorno = false;
            try
            {
                //INCERCION
                MySqlCommand cmdinsertviaje = new MySqlCommand(string.Format("INSERT INTO tb_cliente_viaje (id_viaje, id_cliente) VALUES('{0}','{1}')", viaje, cliente), ModeloConexion.GetConnection());
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

        //Metodo para cargar los datos en el grid de datos
        public static DataTable ObtenerViajes()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tb_viajes";
                MySqlCommand cmdtipomun = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
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

        //public static bool RegistrarDirecciones(int pidViaje, List<string> pdirecciones, List<string> ppuntos_referencia)
        //{
        //    bool retorno = false;
        //        try
        //        {
        //            MySqlCommand cmdinsertdireccion = new MySqlCommand(string.Format("INSERT INTO tb_direccion_detalle (id_viaje, direccion_partida, punto_referencia_partida, direccion_destino, punto_referencia_destino, direccion_adicional, punto_referencia_adicional) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", pidViaje, pdirecciones[0], ppuntos_referencia[0], pdirecciones[1], ppuntos_referencia[1], pdirecciones[2], ppuntos_referencia[2]), ModeloConexion.GetConnection());
        //            retorno = Convert.ToBoolean(cmdinsertdireccion.ExecuteNonQuery());
        //            return retorno;
        //        }
        //        catch (Exception)
        //        {
        //            return retorno;
        //        }
        //}
        #endregion


        public static string ObtenerClienteCompleto(int pid)
        {
            string empleado;
            try
            {
                string instruccion = "SELECT CONCAT (a.apellidos_cliente, ', ' , a.nombres_cliente) AS Cliente FROM tb_cliente a WHERE a.id_cliente = BINARY ?param1;";
                MySqlCommand cmdid = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                cmdid.Parameters.Add(new MySqlParameter("param1", pid));
                empleado = Convert.ToString(cmdid.ExecuteScalar());
                return empleado;
            }
            catch (Exception)
            {
                return empleado = "#Error de carga!";
            }
        }

        public static DataTable ObtenerVistaViajes()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbviajesview";
                MySqlCommand cmdtipomun = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
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

        public static int ObtenerIDviaje(string nametrip)
        {
            int viaje = 0;
            try
            {
                string instruccion = "SELECT (id_viaje) FROM tb_viajes WHERE nombre_viaje = BINARY ?param1;";
                MySqlCommand cmdid = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                cmdid.Parameters.Add(new MySqlParameter("param1", nametrip));
                viaje = Convert.ToInt16(cmdid.ExecuteScalar());
                return viaje;
            }
            catch (Exception)
            {
                return viaje;
            }
        }
    }
}
