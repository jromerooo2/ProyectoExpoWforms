using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
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
            pdfCliente();
        }

        private void pdfCliente()
        {
            PdfWriter pdfw = new PdfWriter("ReporteClientes.pdf");
            PdfDocument pdf = new PdfDocument(pdfw);
            Document document = new Document(pdf, PageSize.LETTER);
            document.SetMargins(60, 20, 55, 20);

            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontC = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = {"Nombres", "Apellidos", "Teléfono" , "Dirección", "Correo Electrónico"};
            document.Close();
            MessageBox.Show("Se ha generado un documento PDF con el reporte.");
        }
    }
}
