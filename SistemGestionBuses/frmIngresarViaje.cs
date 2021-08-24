﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using MySql.Data.MySqlClient;

namespace SistemGestionBuses
{
    public partial class frmIngresarViaje : Form
    {
        public frmIngresarViaje()
        {
            InitializeComponent();
            CargarDatosCMB();
        }

        public bool Vacio()
        {
            if (txtNombreViaje.Text.Trim() == "" &&
            txtTarifaViaje.Text.Trim() == "" &&
            cmbCliente.SelectedIndex == 0 &&
            cmbConductor.SelectedIndex == 0 &&
            cmbEstadoViaje.SelectedIndex == 0 &&
            cmbMetodoPago.SelectedIndex == 0 &&
            cmbTipoDestino.SelectedIndex == 0 &&
            cmbCliente.SelectedIndex == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        void CargarGridDatos()
        {
            
        }

        //Metodo para limpiar los campos
        void LimpiarCampos()
        {
            txtNombreViaje.Clear();
            txtTarifaViaje.Clear();
            txtIDviaje.Clear();
            cmbCliente.SelectedValue = 1;
            cmbConductor.SelectedValue = 1;
            cmbEstadoViaje.SelectedValue = 1;
            cmbMetodoPago.SelectedValue = 1;
            cmbTipoDestino.SelectedValue = 1;
            cmbUnidadTransporte.SelectedValue = 1;
            dtpFechaViaje.Value = Convert.ToDateTime("01 / 01 / 2021");
        }

        void CargarDatosCMB()
        {
            try
            {
                CargarClientes();
                CargarUnidadTransporte();
                //CargarMunicipios();
                //CargarConductor();
                CargarMetodoPago();
                CargarEstadoViaje();
                CargarTipoViaje();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los combobox.", "Error de carga",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }
        //Region de todos los metodos para cargar los combobox

        #region CMB
        void CargarClientes()
        {
            try
            {
                DataTable dataClientes = ControladorViaje.ObtenerCliente();
                cmbCliente.DataSource = dataClientes;
                cmbCliente.DisplayMember = "nombres_cliente AND apellidos_cliente";
                cmbCliente.ValueMember = "id_cliente";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los clientes.", "Error de carga",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

        //void CargarMunicipios()
        //{
        //    try
        //    {
        //        DataTable dataMunicipio = ControladorViaje.ObtenerMunicipios();
        //        cmbMunicipio_inicio.DataSource = dataMunicipio;
        //        cmbMunicipio_inicio.DisplayMember = "municipio";
        //        cmbMunicipio_inicio.ValueMember = "id_municipio";

        //        DataTable dataMunicipio2 = ControladorViaje.ObtenerMunicipios();
        //        cmbMunicipio_final.DataSource = dataMunicipio2;
        //        cmbMunicipio_final.DisplayMember = "municipio";
        //        cmbMunicipio_final.ValueMember = "id_municipio";
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Error al cargar los municipios.", "Error de carga",
        //                                         MessageBoxButtons.OK,
        //                                         MessageBoxIcon.Error);
        //    }
        //}

        void CargarUnidadTransporte()
        {
            try
            {
                DataTable dataTransporte = ControladorViaje.ObtenerTipoUnidadTransporte();
                cmbUnidadTransporte.DataSource = dataTransporte;
                cmbUnidadTransporte.DisplayMember = "tipo_unidad";
                cmbUnidadTransporte.ValueMember = "id_tipo_unidad";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las unidades de transporte.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }

        void CargarMetodoPago()
        {
            try
            {
                DataTable dataMetodoPago = ControladorViaje.ObtenerMetodoPago();
                cmbMetodoPago.DataSource = dataMetodoPago;
                cmbMetodoPago.DisplayMember = "metodo_pago";
                cmbMetodoPago.ValueMember = "id_metodo_pago";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los metodos de pago.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }

        void CargarEstadoViaje()
        {
            try
            {
                DataTable dataMetodoPago = ControladorViaje.ObtenerEstadoViaje();
                cmbEstadoViaje.DataSource = dataMetodoPago;
                cmbEstadoViaje.DisplayMember = "estado_viaje";
                cmbEstadoViaje.ValueMember = "id_estado_viaje";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los metodos de pago.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }

        void CargarTipoViaje()
        {
            try
            {
                DataTable dataTipoViaje = ControladorViaje.ObtenerTipoViaje();
                cmbTipoDestino.DataSource = dataTipoViaje;
                cmbTipoDestino.DisplayMember = "tipo_viaje";
                cmbTipoDestino.ValueMember = "id_tipo_viaje";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los tipos de viaje.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }
        #endregion



        //void EnvioDatos()
        //{
        //    string nombreViaje, fecha, hora;
        //    int id_unidad, id_empleado, id_estado_viaje, id_metodo_pago, id_tipo_viaje, id_cliente, tarifa, id_direccion_detalle;
        //    nombreViaje = txtNombreViaje.Text;
        //    fecha = dtpFechaViaje.Text;
        //    hora = dtpHoraViaje.Text;
        //    tarifa = Convert.ToInt32(txtTarifaViaje.Text);
        //    id_unidad = Convert.ToInt32(cmbUnidadTransporte.SelectedValue);
        //    id_metodo_pago = Convert.ToInt32(cmbMetodoPago.SelectedValue);
        //    id_estado_viaje = Convert.ToInt32(cmbEstadoViaje.SelectedValue);
        //    id_tipo_viaje = Convert.ToInt32(cmbTipoDestino.SelectedValue);
        //    id_empleado = Convert.ToInt32(cmbConductor.SelectedValue);
        //    id_cliente = Convert.ToInt32(cmbCliente.SelectedValue);

        //    id_direccion_detalle = Convert.ToInt16(txtIDdirecciones.Text);

        //    ControladorViaje objViaje = new ControladorViaje(id_cliente, id_unidad, id_metodo_pago, id_empleado, id_municipios, id_estado_viaje, tarifa, hora, id_tipo_viaje, nombreViaje, id_direccion_detalle, fecha, direcciones);
        //    bool respuesta_direcciones = objViaje.EnviarDatos_ControllerDirecciones();
        //    if (respuesta_direcciones == true)
        //    {
        //        bool res = objViaje.EnviarDatos_ControllerViaje();
        //        if (res)
        //        {
        //            MessageBox.Show("Viaje registrado exitosamente", "Confirmación de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        }
        //        else
        //        {
        //            MessageBox.Show("Oops!, ocurrió un error al registrar el viaje, consulte con el administrador del sistema.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Oops!, ocurrió un error al registrar una de las direcciones, consulte con el administrador del sistema.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void frmIngresarViaje_Load(object sender, EventArgs e)
        {
            CargarDatosCMB();
            LimpiarCampos();
        }

        private void btnCrearViaje_Click(object sender, EventArgs e)
        {
            Vacio();
            if (Vacio() == true)
            {
                MessageBox.Show("Todos los campos son requeridos", "Campos vaios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //EnvioDatos();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            MySqlConnection objvalor;
            objvalor = ControladorConexion.GetConn();
            if (objvalor != null)
            {
                MessageBox.Show("La conexión se estableció con exito.", "Comprobación de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al establecer conexión.", "Comprobación de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtIDviaje_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
