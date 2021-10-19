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
using SistemGestionBuses.Properties;
using SistemGestionBuses.Idiomas;
using System.Threading;

namespace SistemGestionBuses
{
    public partial class frmAsignarViaje : Form
    {
        //Variable datatable para la source del data grid
        DataTable vistaviajes;
        public static int idlogged;
        public static string cargostring;
        public static string username;
        public static int idcargo;
        //cliente
        public static int idclient;
        public static string clientestring;
        //idviaje
        public static int idviaje;


        public frmAsignarViaje(string user, string cargo, int cargoid, int iduser, int clienteid)
        {
            InitializeComponent();
            username = user;
            txtActiveUser.Text = username;
            cargostring = cargo;
            txtCargoStrip.Text = cargostring;
            idlogged = iduser;
            idcargo = cargoid;
            //Cargar cliente
            idclient = clienteid;
            clientestring = ControladorViaje.CargarNombreCliente(idclient);
            txtCliente.Text = clientestring;
            //getCliente();
            CargarGrid();
            //Enabled
            btnAsignar.Enabled = false;
            CargarIdioma();
            llenarIdiomas_Combobox();
        }

        //Metodo para cargar el grid de datos
        void CargarGrid()
        {
            vistaviajes = ControladorViaje.CargarVistaViaje();
            dgvViajes.DataSource = vistaviajes;
            dgvViajes.Columns[0].HeaderText = "Viaje";
            dgvViajes.Columns[1].HeaderText = "Tarifa";
            dgvViajes.Columns[2].HeaderText = "Tipo viaje";
            dgvViajes.Columns[3].HeaderText = "Destino";
            dgvViajes.Columns[4].HeaderText = "Destino Adicional";
        }

        //Metodo para insertar los datos en la tabla cliente-viaje
        void AsignarViaje()
        {
            bool res = ControladorViaje.AsignarViajeClienteControl(idclient, idviaje);
            if (res == true)
            {
                string viajestring = txtNombreViaje.Text;
                MessageBox.Show("Se le asigno el viaje: " + viajestring +" a: " + clientestring, "Confirmación de asignación de viajes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El cliente ya tiene asignado un viaje, si quieres modificarlo, ingresa a la interfaz de 'Viajes asignados'", "Asignado previamente", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //Metodo para obtener el nombre y apellido del cliente
        void getCliente()
        {          
           clientestring = ControladorViaje.CargarNombreCliente(idclient);
           txtCliente.Text = clientestring;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ControladorLogin.LogOut(idlogged);
            frmLogin login = new frmLogin();
            login.Show();
            Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dgvViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int fila = dgvViajes.CurrentRow.Index;
            txtNombreViaje.Text = dgvViajes[0, fila].Value.ToString();
            txtTarifa.Text = dgvViajes[1, fila].Value.ToString();
            txtTipoViaje.Text = dgvViajes[2, fila].Value.ToString();
            txtDirecFinal.Text = dgvViajes[3, fila].Value.ToString();
            txtDirecAdicional.Text = dgvViajes[4, fila].Value.ToString();

            //viaje
            string nombreviaje = txtNombreViaje.Text;
            idviaje = ControladorViaje.getID(nombreviaje);
            txtID.Text = idviaje.ToString();

            //enabled
            btnAsignar.Enabled = true;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            AsignarViaje();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataView dv = vistaviajes.DefaultView;
            dv.RowFilter = "nombre_viaje LIKE '" + txtBuscar.Text + "%'";
            dgvViajes.DataSource = dv;
        }

        //Cambiar Idioma
        public void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Idioma);

                lblAsignarViaje.Text = Res.lblAsignaciondeViaje;
                lblSelecciondeviaje.Text = Res.lblSeleccionViaje;
                lblCliente.Text = Res.lblCliente;
                lblNombreViaje.Text = Res.lblNombreViaje;
                lblTarifa.Text = Res.lblTarifa;
                lblTipoViaje.Text = Res.lblTipoViaje;
                lblDireccionFinal.Text = Res.lblDireccionFinal;
                lblDireccionadicional.Text = Res.lblDireccionAdicional;
                btnAsignar.Text = Res.BtnAsignarViaje;
                BtnCambiarIdioma.Text = Res.btnCambiarIdioma;
        }

        public void llenarIdiomas_Combobox()
        {
            cmbIdioma.DataSource = Idioma.ObtenerIdiomas();
            cmbIdioma.ValueMember = "CultureInfo";
            cmbIdioma.DisplayMember = "CargarNombre_Pais";
        }

        private void BtnCambiarIdioma_Click(object sender, EventArgs e)
        {
            Settings.Default.Idioma = cmbIdioma.SelectedValue.ToString();
            CargarIdioma();
        }
    }
}
