﻿using System;
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

        ////Cargar Metodo Pago
        //public static DataTable CargarMetodoPago()
        //{
        //    DataTable data;
        //    try
        //    {
        //        string instruccion = "SELECT * FROM tb_metodo_pago";
        //        MySqlCommand cmdMetodoPago = new MySqlCommand(string.Format(instruccion), ModeloConexion.GetConnection());
        //        MySqlDataAdapter adp = new MySqlDataAdapter(cmdMetodoPago);
        //        data = new DataTable();
        //        adp.Fill(data);
        //        return data;
        //    }
        //    catch (Exception)
        //    {
        //        return data = null;
        //    }
        //}
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
        //Incersion de datos
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
        //Actualizar
        public static bool ActualizarViaje(int pId,string pNombre_viaje, int pidCliente, int pidUnidad, int pidConductor, string pfecha_inicio, string ptarifa, int pidEstado_viaje, int pidTipo_viaje, string pfecha_retorno, int pidMunicipio)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdUpViaje = new MySqlCommand(string.Format("UPDATE tb_viajes SET nombre_viaje = '" + pNombre_viaje + "',cliente = '" + pidCliente + "',id_unidad = '" + pidUnidad + "',id_empleado = '" + pidConductor + "',fecha_inicio = '" + pfecha_inicio + "',tarifa = '" + ptarifa + "',id_estado_viaje = '" + pidEstado_viaje + "',id_tipo_viaje = '" + pidTipo_viaje + "',fecha_retorno = '" + pfecha_retorno + "',id_municipio = '" + pidMunicipio + "' WHERE id_viaje = '" + pId + "' "), ModeloConexion.GetConnection());
                retorno = Convert.ToBoolean(cmdUpViaje.ExecuteNonQuery());
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
    }
}
