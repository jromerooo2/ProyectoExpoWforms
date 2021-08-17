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
        static int contador = 0;
        void tryLogIn()
        {
            
            string user = txtUser.Text;
            string password= txtPass.Text;
            if (!Empty(user, password))
            {
                AtributosLogin.username = user;
                AtributosLogin.password = password;
                bool res = ControladorLogin.Login();
                if (res)
                {
                    //mostrar siguiente forms
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos, Intentalo De Nuevo");
                }
            }else
            {
                MessageBox.Show("Ingresa Las credenciales correctas");
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
    }
}
