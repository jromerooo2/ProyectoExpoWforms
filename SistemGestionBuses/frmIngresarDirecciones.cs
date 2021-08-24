using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace SistemGestionBuses
{
    public partial class frmIngresarDirecciones : Form
    {
        double lat_ElSalvador = 13.69;
        double longt_ElSalvador = -89.19;

        public frmIngresarDirecciones()
        {
            InitializeComponent();
            gMapDirections.MapProvider = GMapProviders.GoogleMap;
            gMapDirections.Position = new PointLatLng(lat_ElSalvador, longt_ElSalvador);
        }

        void ColocarDirecciones()
        {
            gMapDirections.MapProvider = GMapProviders.GoogleMap;
            string direccion_inicio = txtDireccion_inicio.Text;
            string direccion_final = txtDireccion_final.Text;
            gMapDirections.SetPositionByKeywords(direccion_inicio);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gMapDirections_Load(object sender, EventArgs e)
        {
            gMapDirections.DragButton = MouseButtons.Left;
            gMapDirections.MapProvider = GMapProviders.GoogleMap;
            gMapDirections.SetPositionByKeywords("Chennai, India");
            gMapDirections.Position = new PointLatLng(lat_ElSalvador, longt_ElSalvador);
            //gMapDirections.Position = new Point;
        }

        private void frmIngresarDirecciones_Load(object sender, EventArgs e)
        {
            gMapDirections.MapProvider = GMapProviders.GoogleMap;
            gMapDirections.Position = new PointLatLng(lat_ElSalvador, longt_ElSalvador);
        }

        private void btnCargarMapa_Click(object sender, EventArgs e)
        {
            //13.69
            //-89.19 
            gMapDirections.MapProvider = GMapProviders.GoogleMap;
            
            gMapDirections.MapProvider = GMapProviders.GoogleMap;
            double direccion_inicio_lat = Convert.ToDouble(txtDireccion_inicio.Text);
            double direccion_inicio_longt = Convert.ToDouble(txtDireccion_inicio_longt.Text);
            gMapDirections.Position = new PointLatLng(direccion_inicio_lat, direccion_inicio_longt);
            gMapDirections.Zoom = 10;
            gMapDirections.MaxZoom = 100;
            gMapDirections.MinZoom = 5;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
