using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using System.Windows.Forms;

namespace SistemGestionBuses
{
    public partial class frmTrack : Form
    {
        public frmTrack()
        {
            InitializeComponent();
        }

        private void frmTrack_Load(object sender, EventArgs e)
        {
            WebSocket ws = new WebSocket("ws://simple-websocket-server-echo.glitch.me/");
        }
    }
}
