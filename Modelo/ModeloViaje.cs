using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModeloViaje
    {
        //Metodos para cargar los combobox al cargar el forms
        #region ComboboxLoad
        public static DataTable CargarMunicipios()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_municipios";
                MySqlCommand cmdTipoEmpresa = new MySqlCommand(string.Format(instruccion)/*, ModeloConexion.ObtenerConexion())*/);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdTipoEmpresa);
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

        //Metodos para cargar el valor en el textbox en los combobox
        #region ComboboxToTextBoxLoad
        public static object CargarTipoEmpresaInner(string id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tbtipo_empresa WHERE id_tipo_empresa = ?param1";
                MySqlCommand cmdtipodoc = new MySqlCommand(string.Format(instruccion)/*, ModeloConexion.ObtenerConexion()*/);
                cmdtipodoc.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdtipodoc);
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

        //Metodos del CRUD de viajes
        #region CRUD
        //Metodo Create tipo de dato bool
        public static bool AgregarEmpresa(string nombreE, string correo, string nit, string nombreRe, int idTipo, int idEstado, string direccion)
        {
            bool res = false;
            try
            {
                MySqlCommand cmandquery = new MySqlCommand(string.Format("INSERT INTO tbempresa(empresa, correo, nit, representante_legal,id_tipo_empresa, id_estado, direccion) VALUES('{0}','{1}','{2}','{3}','{4}','{5}', '{6}')", nombreE, correo, nit, nombreRe, idTipo, idEstado, direccion)/*, ModeloConexion.ObtenerConexion()*/);
                res = Convert.ToBoolean(cmandquery.ExecuteNonQuery());
                return res;
            }
            catch (Exception)
            {
                return res;
            }

        }

        //Metodo Update tipo de dato bool
        public static bool ActualizarEmpresa(int pid_empresa, string pempresa, string pcorreo, string pnit, string prepresentanteLegal, int pid_tipo_empresa, int pid_estado, string pdireccion)
        {
            bool retorno = false;
            try
            {
                //Incersion de los datos
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbempresa SET empresa = '" + pempresa + "', correo = '" + pcorreo + "', nit = '" + pnit + "', representante_legal = '" + prepresentanteLegal + "', id_tipo_empresa = '" + pid_tipo_empresa + "', id_estado = '" + pid_estado + "',  direccion = '" + pdireccion + "' WHERE id_empresa = '" + pid_empresa + "' ")/*, ModeloConexion.ObtenerConexion()*/);
                //Verificacion de la incersion
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                //Retorno
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        //Metodo Delete tipo de dato bool
        public static bool EliminarEmpresa(int pid)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddelete = new MySqlCommand(string.Format("DELETE FROM tbempresa WHERE id_empresa = '" + pid + "'")/*, ModeloConexion.ObtenerConexion()*/);
                retorno = Convert.ToBoolean(cmddelete.ExecuteNonQuery());
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