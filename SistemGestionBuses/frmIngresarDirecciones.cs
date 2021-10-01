using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using GMap.NET;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace SistemGestionBuses
{
    public partial class frmIngresarDirecciones : Form
    {
        static double lat_ElSalvador = 13.69;
        static double longt_ElSalvador = -89.19;

        public frmIngresarDirecciones()
        {
            InitializeComponent();
        }

        void ColocarDirecciones()
        {
            string direccion_inicio = txtDireccion_inicio.Text;
            string direccion_final = txtDireccion_final.Text;
            string adicional = txtAdicional.Text;
            string referencia1 = txtreferenciaInicio.Text;
            string referencia2 = txtreferenciaFinal.Text;
            string referencia3 = txtreferenciaAdicional.Text;

            gMapControl1.SetPositionByKeywords(direccion_inicio);

            if (!Empty(direccion_inicio, direccion_final, adicional, referencia1, referencia2, referencia3))
            {
                ControladorDirecciones.Save(direccion_inicio, direccion_final, adicional, referencia1, referencia2, referencia3);
            }
        }

        private bool Empty(string txt1, string txt2, string txt3, string txt4, string txt5, string txt6)
        {
            if (!String.IsNullOrWhiteSpace(txt1) && !String.IsNullOrWhiteSpace(txt2) &&
                !String.IsNullOrWhiteSpace(txt3) && !String.IsNullOrWhiteSpace(txt4) &&
                !String.IsNullOrWhiteSpace(txt5) && !String.IsNullOrWhiteSpace(txt6))
            {
                return false;
            }
            else
            {
                return true;
            }            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gMapDirections_Load(object sender, EventArgs e)
        {

        }
        void CargarDepartamentos()
        {
            try
            {
                DataTable dataMunicipio = ControladorIngreso.ObtenerMunicipios();
                cmbDepaInicio.DataSource = dataMunicipio;
                cmbDepaInicio.DisplayMember = "departamento";
                cmbDepaInicio.ValueMember = "id_departamento";

                cmbDepaFinal.DataSource = dataMunicipio;
                cmbDepaFinal.DisplayMember = "departamento";
                cmbDepaFinal.ValueMember = "id_departamento";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los municipios.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }
        void CargarMunicipios()
        {
            try
            {
                DataTable dataMunicipio = ControladorIngreso.ObtenerMunicipios();
                cmbMunicipioFinal.DataSource = dataMunicipio;
                cmbMunicipioFinal.DisplayMember = "municipio";
                cmbMunicipio.ValueMember = "id_municipio";

                cmbMunicipio.DataSource = dataMunicipio;
                cmbMunicipio.DisplayMember = "municipio";
                cmbMunicipio.ValueMember = "id_municipio";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los municipios.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
        }


        GMarkerGoogle marker;
        GMapOverlay overlay;
        static double LatInicial = 13.69;
        static double LongInicial = -89.19;
        private void frmIngresarDirecciones_Load(object sender, EventArgs e)
        {
            CargarDepartamentos();
            CargarMunicipios();
            //Initial Settings
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(lat_ElSalvador , longt_ElSalvador);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.AutoScroll = true;
            gMapControl1.Zoom = 10;

            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LongInicial), GMarkerGoogleType.blue);
            overlay = new GMapOverlay();
            overlay.Markers.Add(marker); //agregando el marker al overlay

            //ahora al mapa xd
            gMapControl1.Overlays.Add(overlay);

        }

        private void btnCargarMapa_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {       
            ColocarDirecciones();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
