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

        public static int cargouser;
        public static int IdUserLogged;
        public static string cargostring;
        public static string username;

        public frmIngresarDirecciones(int cargo, int idUser, string cargo_string, string user)
        {
            InitializeComponent();
            cargouser = cargo;
            IdUserLogged = idUser;
            username = user;
            cargostring = cargo_string;
            txtActiveUser.Text = username;
            txtCargoStrip.Text = cargostring;
        }

        void ColocarDirecciones()
        {
            string direccion_inicio = txtDireccion_inicio.Text;
            string direccion_final = txtDireccion_final.Text;
            int id_viaje = Convert.ToInt32(cmbViajes.SelectedValue);
            string adicional = txtAdicional.Text;
            string referencia1 = txtreferenciaInicio.Text;
            string referencia2 = txtreferenciaFinal.Text;
            string referencia3 = txtreferenciaAdicional.Text;       

            if (!Empty(direccion_inicio, direccion_final, adicional, referencia1, referencia2, referencia3))
            {
                bool res = ControladorDirecciones.Save(id_viaje,direccion_inicio, direccion_final, adicional, referencia1, referencia2, referencia3);
                if (res)
                {
                    MessageBox.Show("Dirección registrada exitosamente", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido ingresar la dirección, si este problema persiste por favor contacta al administrador.", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos .", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Empty(string txt1, string txt2, string txt3, string txt4, string txt5, string txt6)
        {
            if (!String.IsNullOrWhiteSpace(txt1) && !String.IsNullOrWhiteSpace(txt2) &&
                !String.IsNullOrWhiteSpace(txt4) && !String.IsNullOrWhiteSpace(txt5))
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





        GMarkerGoogle marker;
        GMapOverlay overlay;
        static double LatInicial = 13.69;
        static double LongInicial = -89.19;
        DataTable dt;
        private void frmIngresarDirecciones_Load(object sender, EventArgs e)
        {
             dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descripción", typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));           
            dt.Rows.Add( "Punto",LatInicial, LongInicial);
            dgvPuntos.DataSource = dt;

            dgvPuntos.Columns[1].Visible = false;
            dgvPuntos.Columns[2].Visible = false;



            CargarViajes();
            //Initial Settings
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position= new PointLatLng(lat_ElSalvador, longt_ElSalvador);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.AutoScroll = true;
            gMapControl1.Zoom = 10;

            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LongInicial), GMarkerGoogleType.purple);
            overlay = new GMapOverlay("Markers");
            overlay.Markers.Add(marker); //agregando el marker al overlay
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format("Ubicación \n Latitud: {0} \n Longitud: {1}", LatInicial, LongInicial);

            //ahora al mapa xd
            gMapControl1.Overlays.Add(overlay);

        }

        private void CargarViajes()
        {
            try
            {
                DataTable dataMunicipio = ControladorIngreso.ObtenerViajes();
                cmbViajes.DataSource = dataMunicipio;
                cmbViajes.DisplayMember = "nombre_viaje";
                cmbViajes.ValueMember = "id_viaje";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los municipios.", "Error de carga",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
            }
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
        public int filseleccionada;
        private void dgvPuntos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvPuntos.CurrentRow.Index;
            if (i >= 0 && dgvPuntos[0, i].Value.ToString() != "")
            {
                filseleccionada = e.RowIndex;
            txtlatitud.Text = dgvPuntos.Rows[filseleccionada].Cells[1].Value.ToString();
            txtlongitud.Text = dgvPuntos.Rows[filseleccionada].Cells[2].Value.ToString();
            marker.Position = new PointLatLng(Convert.ToDouble(txtlatitud.Text), Convert.ToDouble(txtlongitud.Text));
            gMapControl1.Position = marker.Position;
            }
            else
            {
                MessageBox.Show("Selecciona un cliente", "Selección no valida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            txtlatitud.Text = lat.ToString();
            txtlongitud.Text = lng.ToString();
            marker.Position = new PointLatLng(Math.Round(lat, 2), Math.Round(lng, 2));
            marker.ToolTipText = string.Format("Ubicacion: \n  Latitud: {0} \n  Longitud: {1} ", lat, lng);
        }

        private void dgvPuntos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dt.Rows.Add("Punto",txtlatitud.Text, txtlongitud.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvPuntos.Rows.RemoveAt(filseleccionada);
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            GMapOverlay ruta = new GMapOverlay("capa rutas");
            List<PointLatLng> puntos = new List<PointLatLng>();
            double lat, lng;
            for (int filas = 0; filas < dgvPuntos.Rows.Count; filas++)
            {
                lat = Convert.ToDouble(dgvPuntos.Rows[filas].Cells[1].Value);
                lng = Convert.ToDouble(dgvPuntos.Rows[filas].Cells[2].Value);
                puntos.Add(new PointLatLng(lat, lng));
            }
            GMapRoute puntosruta = new GMapRoute(puntos,"Ruta");
            ruta.Routes.Add(puntosruta);
            gMapControl1.Overlays.Add(ruta);
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
        }
    }
}
