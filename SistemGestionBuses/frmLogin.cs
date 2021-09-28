using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace SistemGestionBuses
{
    public partial class frmLogin : Form
    {
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
                string user = txtUser.Text;
                string password = txtPass.Text;
                int count = 0;

                AtributosLogin.username = user;
                AtributosLogin.password = password;
                int res = ControladorLogin.Login();
            

            if (res == 1)
                {
                         //mostrar siguiente forms
                        int cargo = ControladorLogin.GetCargo();
                        int idlogged = ControladorLogin.GetId();
                        frmPrincipal next = new frmPrincipal(cargo, user, idlogged);
                        next.Show();
                        Hide();
                }
             if (res == 2)
                {
                        MessageBox.Show("Datos Incorrectos, Intentalo De Nuevo");
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
                frmConfig next = new frmConfig(cargo, user, idlogged);
                next.Show();
                next.BringToFront();
                Hide();
            }

           }

        private bool Empty(string user, string password)
        {
            if (String.IsNullOrWhiteSpace(user) && String.IsNullOrWhiteSpace(password))
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
            if (!Empty(txtUser.Text, txtPass.Text))
            {
                tryLogIn();
            }
            else
            {
                MessageBox.Show("Por favor ingresa datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

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
    }
}
