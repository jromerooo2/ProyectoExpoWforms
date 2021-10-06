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

namespace SistemGestionBuses
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
            Task otask = new Task(threaduwu);
            otask.Start(); 
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            MiLoading.Load("pantalla-carga.gif");
            MiLoading.Location = new Point(this.Width / 2 - MiLoading.Width / 2, this.Height / 2 - MiLoading.Height / 2);
        }

        public void threaduwu ()
        {
            Thread.Sleep(3000);
            Close();
        }
    }
}
