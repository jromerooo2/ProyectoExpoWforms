﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemGestionBuses
{
    public partial class frmPrincipal : Form
    {
        public static string usuario;
        public static int cargouser;


        public frmPrincipal(int cargo, string user)
        {
            InitializeComponent();

            usuario = user;
            cargouser = cargo;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmUnidades unidades = new frmUnidades();
            unidades.Show();
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmIngresarViaje viajes = new frmIngresarViaje();
            viajes.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "¡Bienvenido " +usuario+ "!";
            if (cargouser  == 1)
            {
                cardUsers.Enabled = false;
                cardEmpleado.Enabled = false;
                cardClientes.Enabled = false;
                cardReportes.Enabled = false;
            }
        }

        private void pictureUsers_Click(object sender, EventArgs e)
        {
            frmUsuarios users = new frmUsuarios(cargouser);
            users.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmIngresoCliente clientes = new frmIngresoCliente();
            clientes.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmIngresoEmpleado empleado = new frmIngresoEmpleado();
            empleado.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmMantenimientos mantenimientos = new frmMantenimientos();
            mantenimientos.Show();
        }

        private void cardUsers_Click(object sender, EventArgs e)
        {
            frmUsuarios users = new frmUsuarios(cargouser);
            users.Show();
        }

        private void bunifuCards1_Click(object sender, EventArgs e)
        {
            frmUnidades unidades = new frmUnidades();
            unidades.Show();
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards3_Click(object sender, EventArgs e)
        {
            frmIngresoEmpleado empleado = new frmIngresoEmpleado();
            empleado.Show();
        }

        private void cardClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void cardClientes_Click(object sender, EventArgs e)
        {
            frmIngresoCliente clientes = new frmIngresoCliente();
            clientes.Show();
        }

        private void cardMantenimientos_Click(object sender, EventArgs e)
        {
            frmMantenimientos mantenimientos = new frmMantenimientos();
            mantenimientos.Show();
        }

        private void bunifuCards2_Click(object sender, EventArgs e)
        {
            frmIngresarViaje viajes = new frmIngresarViaje();
            viajes.Show();
        }

        private void cardUsers_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
