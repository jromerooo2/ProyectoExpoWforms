using System;
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
    public partial class frmConfig : Form
    {
        int cargou, idu;
        string username;
        public frmConfig(int cargo, string user, int idlogged)
        {
            InitializeComponent();
            cargou = cargo;
            username = user;
            idu = idlogged;        
        }
    }
}
