﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace SistemGestionBuses
{
    public partial class frmLogin : Form
    {
        frmLoading loading;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tryLogIn();
        }

        void tryLogIn()
        {
                string user = txtusername.Text;
                string password = txtpassword.Text;
                int count = 0;

                AtributosLogin.username = user;
                AtributosLogin.password = password;
                int res = ControladorLogin.Login();
            

            if (res == 1)
                {
                         //mostrar siguiente forms
                        int cargo = ControladorLogin.GetCargo();
                        int idlogged = ControladorLogin.GetId();
                        CargarPantalla(res, cargo, user, idlogged);
                        Hide();
                }
             if (res == 2)
                {
                        MessageBox.Show("Datos Incorrectos, Intentalo De Nuevo", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        count++;
                        if (count >= 3)
                        {
                            ControladorUsuario.BlockUser(user);
                        }                
                }
            if (res == 3)
            {
                int cargo = ControladorLogin.GetCargo();
                int idlogged = ControladorLogin.GetId();

                ControladorUsuario.PrimerUso(idlogged);
                CargarPantalla(res ,cargo, user, idlogged);
                Hide();
            }

           }

        private bool Empty(string user, string password)
        {
            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperar recu = new frmRecuperar();
            recu.Show();
            recu.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(!Empty(txtusername.Text, txtpassword.Text))
            {
                tryLogIn();
            }
            else
            {
                MessageBox.Show("Por favor ingresa datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        #region Loading
        //Metodos para pantalla de carga
        public async void CargarPantalla(int res, int cargouser, string username, int id)
        {
            this.Hide();
            Mostrar();
            Task otask = new Task(Algo);
            otask.Start();
            await otask;
            Esconder();
            if (res == 1)
            {
                frmPrincipal main = new frmPrincipal(cargouser, username, id);
                main.Show();
            }
            if (res == 3)
            {
                frmConfig main = new frmConfig(cargouser, username, id);
                main.Show();
            }       
        }
        public void Algo()
        {
            Thread.Sleep(3500);
        }

        public void Mostrar()
        {
            loading = new frmLoading();
            loading.Show();
        }
        public void Esconder()
        {
            if (loading != null)
                loading.Close();
        }
        #endregion


        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            PrimerUso();
        }

        void PrimerUso()
        {
            //Comprobar que no existan empleados
            int res = ControladorLogin.comprobarEmpleadosVacio();
            //Comprobar que no existan usuarios
            int res2 = ControladorLogin.comprobarUsuariosVacio();
            if (res == 0 || res2 == 0)
            {
                Hide();
                SendToBack();
                FirstUse primeruso = new FirstUse();
                primeruso.Show();
            }
            else
            {
                Show();
            }
        
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                e.Handled = true;
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                e.Handled = true;
            }
        }
    }
}
