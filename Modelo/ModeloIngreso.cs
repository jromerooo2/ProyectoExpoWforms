﻿using System;
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
                string instruccion = "SELECT * FROM tb_estado_conductor WHERE id_estado_empleado = ?param1";
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
        //Igreso datos cliente
        public static bool AgregarCliente(string pNomCliente, string pApeCliente, string pTelCliente, string pDirCliente, string pCorCliente, int pTipCliente)
        {
            bool retorno = false;
            try
            {
                //INCERCION
                MySqlCommand cmdinsertar = new MySqlCommand(string.Format("INSERT INTO tb_empleados (nombres_cliente, apellidos_cliente, direccion_cliente, telefono_cliente, correo_cliente, id_tipo_cliente) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", pNomCliente, pApeCliente, pTelCliente,pDirCliente,pCorCliente,pTipCliente), ModeloConexion.GetConnection());
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
    }
}