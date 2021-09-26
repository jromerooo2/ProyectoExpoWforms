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
    public partial class frmIngresoConductores : Form
    {
        public static string nombres;
        public static string apellidos;
        public frmIngresoConductores(string pnombres, string papellidos)
        {
            InitializeComponent();
            nombres = pnombres;
            apellidos = papellidos;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreConduc_TextChanged(object sender, EventArgs e)
        {

        }

        void getNamesDriver()
        {
            //ControladorIngreso.CargarNombresConduc();
        }

        private void frmIngresoConductores_Load(object sender, EventArgs e)
        {
            getNamesDriver();
        }
    }
}
