﻿using System;
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
    public partial class frmMantenimientos : Form
    {
        public frmMantenimientos()
        {
            InitializeComponent();
        }

        private void frmMantenimientos_Load(object sender, EventArgs e)
        {
            if (ControladorMantenimiento.ReturnVehicleType() != null)
            {
                CmbTipoVehiculo.DataSource = ControladorMantenimiento.ReturnVehicleType();
                CmbTipoVehiculo.ValueMember = "id_tipo_unidad";
                CmbTipoVehiculo.DisplayMember = "tipo_unidad";
            }
        }
    }
}
