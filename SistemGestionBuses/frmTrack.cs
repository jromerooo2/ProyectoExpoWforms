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
            using (WebSocket ws = new WebSocket("ws://frequent-cultured-timbale.glitch.me/"))
            {
                ws.Connect();
                ws.OnMessage += Ws_OnMessage;
                ws.Send("Hello Server");
            }        

        }

        private void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            MessageBox.Show("Received from server" + e.Data);
        }
    }
}
