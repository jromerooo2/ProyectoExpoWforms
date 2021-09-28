using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using Controlador;
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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cardClientes_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pdf(string[] columnas, float[] tamanios, int tipo)
        {
            PdfWriter pdfw = new PdfWriter("Reporte.pdf");
            PdfDocument pdf = new PdfDocument(pdfw);
            Document document = new Document(pdf, PageSize.LETTER.Rotate());
            //document.SetMargins(60, 20, 55, 20);

            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontC = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

           Table tb = new Table(UnitValue.CreatePercentArray(tamanios));
            tb.SetWidth(UnitValue.CreatePercentValue(100));

            foreach(string title in columnas)
            {
                tb.AddHeaderCell(new Cell().Add(new Paragraph(title).SetFont(font)));
            }
            List<string> data = new List<string>();

            switch (tipo)
            {
                case 1:
                    data = ControladorReportes.GetDataCliente();
                    break;
                case 2:
                    data = ControladorReportes.GetDataTransportes();
                    break;
                case 3:
                    data = ControladorReportes.GetDataEmpleados();
                    break;
                default:
                    MessageBox.Show("No se ha podido generar ningun reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }


            for (int i = 0; i < columnas.Length; i++)
            {
                tb.AddCell(new Cell().Add(new Paragraph(data[i].ToString()).SetFont(fontC)));
            }

            document.Add(tb);
            document.Close();
            MessageBox.Show("Se ha generado un documento PDF con el reporte.");
        }

        //Defining array of sizes and columns to grab from BD 
        public string[] columnasCliente = { "Nombres", "Apellidos", "Teléfono", "Dirección", "Correo Electrónico" };
        public float[] tamaniosCliente = { 4, 4, 4, 4, 4 };

        public string[] columnasTransporte = { "Año", "VIN", "Capacidad","Placa", "Tipo Unidad", "Modelo", "Estado","# del Motor", "# del Chasis" };
        public float[] tamaniosTransporte= { 2, 4, 4, 3, 3, 3, 4,3,3 };

        public string[] columnasEmpleado = { "Nombres", "Apellidos", "DUI", "NIT", "Direccion", "Telefóno", "Nacimiento"};
        public float[] tamaniosEmpleado = { 4, 4, 4, 4, 4, 4, 4};



        private void cardClientes_Click(object sender, EventArgs e)
        {
            pdf(columnasCliente, tamaniosCliente, 1);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pdf(columnasCliente, tamaniosCliente, 1);
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards1_Click(object sender, EventArgs e)
        {
            pdf(columnasTransporte, tamaniosTransporte, 2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pdf(columnasTransporte, tamaniosTransporte, 2);
        }

        private void cardEmpleado_Click(object sender, EventArgs e)
        {
            pdf(columnasEmpleado, tamaniosEmpleado, 3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pdf(columnasEmpleado, tamaniosEmpleado, 3);
        }
    }
}
