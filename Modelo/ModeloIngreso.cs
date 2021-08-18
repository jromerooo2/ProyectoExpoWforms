using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ModeloIngreso
    {
        //Cargar Estado
        public static DataTable CargarEstado()
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_estado_conductor ";
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
                string instruccion = "SELECT * FROM tb_estado_conductor WHERE id_estado_conduc = ?param1";
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
                MySqlCommand cmdtipodoc = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
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

        //Municipio inner
        public static DataTable CargarMunicipioInner(int id)
        {
            DataTable data;
            try
            {
                string instruccion = "SELECT * FROM tb_municipios WHERE id_municipio = ?param1";
                MySqlCommand cmdtipodoc = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
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

        //CRUD
        public static bool RegistrarConductor(string pNombre, string pApellido, string pDUI, string pNIT, string pDireccion, string pTelefono, string pNacimiento,char pGenero,int pEstado,int pCargo,int pMunicipio )
        {
            bool retorno = false;
            try
            {
                //INCERCION
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tb_empleados (nombre_conduc, apellido_conduc, DUI, NIT, direccion_conduc, telefono_conduc, genero_conduc, id_estado_conduc, id_cargo, id_municipio, nacimiento_con) VALUES {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}", pNombre, pApellido, pDUI, pNIT, pDireccion, pTelefono, pNacimiento, pGenero, pEstado, pCargo, pMunicipio), ModeloConexion.GetConnection());
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
    }
}
