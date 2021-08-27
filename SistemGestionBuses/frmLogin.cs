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

                AtributosLogin.username = user;
                AtributosLogin.password = password;
                bool res = ControladorLogin.Login();
                if (res)
                {
                    //mostrar siguiente forms
                    frmIngresoConductores next = new frmIngresoConductores();
                    next.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos, Intentalo De Nuevo");
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
