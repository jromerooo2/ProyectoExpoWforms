using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Modelo;

namespace Modelo
{
    public class ModeloIngreso
    {
        #region COMBO BOX - INNER JOIN 
        //Cargar Estado
        public static DataTable CargarEstado()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_estado_empleado";
                MySqlCommand cmdtipoest = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipoest);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }



        //Estado inner
        public static DataTable CargarEstadoInner(int id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_estado_empleado WHERE id_estado_empleado = ?param1";
                MySqlCommand cmdtipoest = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                cmdtipoest.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipoest);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            { 
                return data = null;
            }
        }
        //Cargar genero
        public static DataTable CargarGenero()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_genero ";
                MySqlCommand cmdtipogen = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipogen);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        //Genero inner
        public static DataTable CargarGeneroInner(int id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_genero WHERE id_genero = ?param1";
                MySqlCommand cmdtipogen = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                cmdtipogen.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipogen);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        //Cargar Cargo
        public static DataTable CargarCargo()
        {
            DataTable data;
            try
            { 
                string instruccion = "SELECT * FROM tb_cargo ";
                MySqlCommand cmdtipocar = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipocar);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        //Cargo inner
        public static DataTable CargarCargoInner(int id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_cargo WHERE id_cargo = ?param1";
                MySqlCommand cmdtipocar = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                cmdtipocar.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipocar);
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
                MySqlCommand cmdtipomun= new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
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

        public static DataTable ObtenerDepartamento()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_departamentos ORDER BY departamento ASC";
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

        public static DataTable ObtenerViajes()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_viajes";
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
        //Cargar Empleados
        public static DataTable ObtenerListaEmpleados()
        {
            DataTable data;
            try
            {
                string instuccion = "SELECT * FROM dbsistemaviajes.tb_empleados;";
                MySqlCommand cmdListaEmpleado = new MySqlCommand(string.Format(instuccion),
                    ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdListaEmpleado);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {

                return data = null;
            }
        }

        //Cargar Clientes
        public static DataTable ObtenerListaCliente()
        {
            DataTable data;
            try
            {
                string instuccion = "SELECT * FROM dbsistemaviajes.tb_cliente;";
                MySqlCommand cmdListaClientes = new MySqlCommand(string.Format(instuccion),
                    ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdListaClientes);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {

                return data = null;
            }
        }

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

        //Cargar tipo cliente 
        public static DataTable CargarTipoCliente()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_tipo_cliente ";
                MySqlCommand cmdTipCliente = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdTipCliente);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        // Cargar Tipo Cliente Inner
        public static DataTable CargarTipoClienteInner(int id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_tipo_cliente WHERE id_tipo_cliente = ?param1";
                MySqlCommand cmdTipCliente = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                cmdTipCliente.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdTipCliente);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        //Cargarcliente
        public static DataTable CargarClientes()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_cliente";
                MySqlCommand cmdClientes = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdClientes);
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

        #region CRUD Empleado
        //CRUD Empleado
        public static bool RegistrarEmpleado(string pNombre, string pApellido, string pDUI, string pNIT, string pDireccion, string pTelefono, int pGenero,int pEstado,int pCargo,int pMunicipio, string pNacimiento )
        {
            bool retorno = false;
            try
            {
                //INCERCION
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_empleados (nombres_empleado, apellidos_empleado, DUI, NIT, direccion_empleado, telefono_empleado, id_genero, id_estado_empleado, id_cargo, id_municipio, nacimiento_empleado) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", pNombre, pApellido, pDUI, pNIT, pDireccion, pTelefono, pGenero, pEstado, pCargo, pMunicipio, pNacimiento), ModeloConexion.GetConnection());
                //VERIFICACION
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                //RETORNO
                return retorno;
            }
            catch(Exception)
            {
                return retorno;
            }   
        }

        //Update Empleado
        public static bool ActualizarEmpleado(int pId,string pNombre, string pApellido, string pDUI, string pNIT, string pDireccion, string pTelefono, int pGenero, int pEstado, int pCargo, int pMunicipio, string pNacimiento)
        {
            bool retorno = false;
            try
            {
                //Proceso de Actualizacion
                MySqlCommand cmdUpEmpleado = new MySqlCommand(string.Format(" UPDATE tb_empleados SET nombres_empleado = '" + pNombre + "',apellidos_empleado = '" + pApellido + "',DUI = '" + pDUI + "',NIT = '" + pNIT + "',direccion_empleado = '" + pDireccion + "',telefono_empleado = '" + pTelefono + "',id_genero = '" + pGenero + "',id_estado_empleado = '" + pEstado + "',id_cargo = '" + pCargo + "',id_municipio = '" + pMunicipio + "',nacimiento_empleado = '" + pNacimiento + "'WHERE id_empleado = '"+pId+"' "), ModeloConexion.GetConnection());
                //Verificar Update
                retorno = Convert.ToBoolean(cmdUpEmpleado.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {

                return retorno;
            }
        }
        //Eliminar Empleado
        public static bool EliminarEmpleado(int pId)
        {
            bool retorno;
            try
            {
                string query = "DELETE FROM tb_empleados WHERE id_empleado = '" + pId + "'";
                MySqlCommand cmdEli = new MySqlCommand(string.Format(query),
                                                        ModeloConexion.GetConnection());
                retorno = Convert.ToBoolean(cmdEli.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {

                return retorno = false;
            }
        }
        #endregion

        #region CRUD Cliente
        //Igreso datos cliente
        public static bool AgregarCliente(string pNomCliente, string pApeCliente, string pTelCliente, string pDirCliente, string pCorCliente, int pTipCliente)
        {
            bool retorno = false;
            try
            {
                //INCERCION
                MySqlCommand cmdinsertar = new MySqlCommand(string.Format("INSERT INTO tb_cliente (nombres_cliente, apellidos_cliente, telefono_cliente, direccion_cliente, correo_cliente, id_tipo_cliente) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", pNomCliente, pApeCliente, pTelCliente, pDirCliente, pCorCliente, pTipCliente), ModeloConexion.GetConnection());
                //VERIFICACION
                retorno = Convert.ToBoolean(cmdinsertar.ExecuteNonQuery());
                //RETORNO
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        //Actualizar Cliente
        public static bool ActualizarCliente(int pIdCliente, string pNomCliente, string pApeCliente, string pTelCliente, string pDirCliente, string pCorCliente, int pTipCliente)
        {
            bool res = false;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tb_cliente SET nombres_cliente = '"+pNomCliente+"', apellidos_cliente = '"+pApeCliente+"', telefono_cliente = '"+pTelCliente+"', id_tipo_cliente = '"+pTipCliente+"', direccion_cliente = '"+pDirCliente+"', correo_cliente = '"+ pCorCliente + "' WHERE id_cliente = '"+pIdCliente+"' "), ModeloConexion.GetConnection());
                res = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
            }
        }

        //Eliminar Cliente
        public static bool EliminarCliente(int IdCliente)
        {
            bool res = false;
            try
            {
                string query = "DELETE FROM tb_cliente WHERE id_Cliente="+ IdCliente;
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                res = Convert.ToBoolean(cmd.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
            }
        }
        #endregion


        #region CRUD Conductor
        public static int ObtenerIDEmpleado(string pdui, string pnit)
        {
            int id;
            try
            {
                string instruccion = "SELECT id_empleado FROM tb_empleados a WHERE a.DUI = ?param1 AND a.NIT = BINARY ?param2";
                MySqlCommand cmdid = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                cmdid.Parameters.Add(new MySqlParameter("param1", pdui));
                cmdid.Parameters.Add(new MySqlParameter("param2", pnit));
                id = Convert.ToInt32(cmdid.ExecuteScalar());
                return id;
            }
            catch (Exception)
            {
                return id = 0;
            }
        }

        public static int ObtenerIDEmpleadoFirstUse(string nombre_empleado)
        {
            int id;
            try
            {
                string instruccion = "SELECT id_empleado FROM tb_empleados a WHERE a.nombres_empleado = BINARY ?param1";
                MySqlCommand cmdid = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                cmdid.Parameters.Add(new MySqlParameter("param1", nombre_empleado));
                id = Convert.ToInt32(cmdid.ExecuteScalar());
                return id;
            }
            catch (Exception)
            {
                return id = 0;
            }
        }

        public static string ObtenerNombreConduc(int pid)
        {
            string empleado;
            try
            {              
                string instruccion = "SELECT CONCAT (a.apellidos_empleado, ', ' , a.nombres_empleado) AS Empleado FROM tb_empleados a WHERE a.id_empleado = BINARY ?param1;";
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

        //CREATE
        public static bool RegistrarConductor(int pid_empleado, string plicencia, int pid_tipo_licencia, string pfecha_exp_licencia)
        {
            bool retorno = false;
            try
            { 
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_conductores (id_empleado, numero_licencia, fecha_exp_licencia, id_tipo_licencia) VALUES ('{0}', '{1}', '{2}', '{3}')", pid_empleado, plicencia, pfecha_exp_licencia, pid_tipo_licencia), ModeloConexion.GetConnection());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        //UPDATE Conductor
        public static bool ActualizarConductor(int id_conductor ,int id_empleado,string licencia, int id_tipo_licencia, string fecha_exp)
        {
            bool res = false;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tb_conductores SET id_empleado = '" + id_empleado + "', numero_licencia = '" + licencia + "', fecha_exp_licencia = '" + fecha_exp + "', id_tipo_licencia = '" + id_tipo_licencia + "' WHERE id_conductores = '" + id_conductor + "' "), ModeloConexion.GetConnection());
                res = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
            }
        }

        //DELETE conductor
        public static bool EliminarConductor(int id)
        {
            bool res = false;
            try
            {
                string query = "DELETE FROM tb_conductores WHERE id_conductores = '"+ id +"'";
                MySqlCommand cmd = new MySqlCommand(string.Format(query), ModeloConexion.GetConnection());
                res = Convert.ToBoolean(cmd.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
            }
        }

        //DGV
        public static DataTable ObtenerListaConductores()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tbconductoresview";
                MySqlCommand cmdtipoest = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipoest);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        //CMB tipo licencia
        public static DataTable ObtenerTipoLicencia()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_tipo_licencia";
                MySqlCommand cmdtipoest = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipoest);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }


        //Inner Join tipo de licencia
        public static DataTable ObtenerTipoLicenciaInner(string id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_tipo_licencia WHERE tipo_licencia = ?param1";
                MySqlCommand cmdtipoest = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                cmdtipoest.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipoest);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        //cmb departamentos
        public static DataTable GetDepartamentos()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_departamentos";
                MySqlCommand cmdtipoest = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipoest);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }


        public static bool SaveDir(int id_viaje, string partida, string final, string adicional, string puntorefinicio, string pfinal, string padicional)
        {
            bool retorno = false;
            try
            {

                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_direccion_detalle(id_viaje, direccion_partida,punto_referencia_partida,direccion_destino, punto_referencia_destino ,direccion_adicional, punto_referencia_adicional) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",id_viaje, partida, puntorefinicio, final, pfinal, adicional, padicional),  ModeloConexion.GetConnection() );

                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());

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
