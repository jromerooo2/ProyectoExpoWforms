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


        private void frmLogin_Load(object sender, EventArgs e)
        {
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
                int cargo = ControladorLogin.GetCargo();
                if (res == 1)
                {
                        //mostrar siguiente forms
                        frmPrincipal next = new frmPrincipal(cargo, user);
                        next.Show();
                        Hide();
                }
                else if (res == 2)
                {
                        MessageBox.Show("Datos Incorrectos, Intentalo De Nuevo");
                        count++;
                        if (count >= 3)
                        {
                            ControladorUsuario.BlockUser(user);
                        }                
                 }      

           }

        private bool Empty(string user, string password)
        {
            if (String.IsNullOrEmpty(user) && String.IsNullOrEmpty(password))
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
            if (!Empty(txtUser.Text, txtPass.Text) )
            {
                tryLogIn();
            }
            else
            {
                MessageBox.Show("Por favor ingresa datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            
        }
    }
}
