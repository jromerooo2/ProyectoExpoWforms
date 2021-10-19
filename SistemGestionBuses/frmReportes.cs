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
using System.Data;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Document = iTextSharp.text.Document;
using PdfWriter = iTextSharp.text.pdf.PdfWriter;
using Paragraph = iTextSharp.text.Paragraph;
using SistemGestionBuses.Properties;
using SistemGestionBuses.Idiomas;
using System.Threading;

namespace SistemGestionBuses
{
    public partial class frmReportes : Form
    {
        public static int idlogged;
        public static string cargostring;
        public static string username;
        public static int idcargo;
        public frmReportes(string user, string cargo, int cargoid, int iduser)
        {
            InitializeComponent();
            username = user;
            txtActiveUser.Text = username;
            cargostring = cargo;
            txtCargoStrip.Text = cargostring;
            idlogged = iduser;
            idcargo = cargoid;
            CargarIdioma();
            llenarIdioma();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cardClientes_Paint(object sender, PaintEventArgs e)
        {
        }
        #region pdfclientes
        private void pdf(string[] columnas, float[] tamanios)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter w = PdfWriter.GetInstance(doc, new FileStream(@"ReporteClientes.pdf", FileMode.Create));
            doc.Open();
            PdfContentByte content = w.DirectContent;

            //setting font type, font size and font color
            iTextSharp.text.Font font = iTextSharp.text.FontFactory.GetFont(
        FontFactory.TIMES_ROMAN, 30, BaseColor.BLUE);
            Paragraph prg = new iTextSharp.text.Paragraph();
            prg.Alignment = Element.ALIGN_CENTER; // adjust the alignment of the heading
            prg.Add(new Chunk("Clientes ", font)); //adding a heading to the PDF
            doc.Add(prg); //add the component we created to the document
            DataTable data = ControladorReportes.GetDataCliente();
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].HeaderText = "Nombre";
            dataGridView1.Columns[1].HeaderText = "Apellido";
            dataGridView1.Columns[2].HeaderText = "Teléfono";
            dataGridView1.Columns[3].HeaderText = "Tipo Cliente";
            dataGridView1.Columns[4].HeaderText = "Dirección";
            dataGridView1.Columns[5].HeaderText = "Email";


            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                PdfPCell cell = new PdfPCell(); //create object from the pdfpcell class
                cell.BackgroundColor = BaseColor.LIGHT_GRAY; //set color of cells to gray
                cell.AddElement(new Chunk(dataGridView1.Columns[j].HeaderText.ToUpper()));
                table.AddCell(cell);
            }
            //add actual rows from grid to table
            for (int i = 0; i < data.Rows.Count; i++)
            {
                table.WidthPercentage = 100; //set width of the table
                for (int k = 0; k < data.Columns.Count; k++)
                {
                    if (dataGridView1[k, i].Value != null)
                        // get the value of   each cell in the dataTable tblemp
                        table.AddCell(new Phrase(dataGridView1[k, i].Value.ToString()));
                }
            }
            //add the table to document
            doc.Add(table);
            doc.Close();
        }
        #endregion pdfclientes
        //Defining array of sizes and columns to grab from BD 
        public string[] columnasCliente = { "Nombres", "Apellidos", "Teléfono", "Dirección", "Correo Electrónico" };
        public float[] tamaniosCliente = { 4, 4, 4, 4, 4 };

        public string[] columnasTransporte = { "Año", "VIN", "Capacidad","Placa", "Tipo Unidad", "Modelo", "Estado","# del Motor", "# del Chasis" };
        public float[] tamaniosTransporte= { 2, 4, 4, 3, 3, 3, 4,3,3 };

        public string[] columnasEmpleado = { "Nombres", "Apellidos", "DUI", "NIT", "Direccion", "Telefóno", "Nacimiento"};
        public float[] tamaniosEmpleado = { 4, 4, 4, 4, 4, 4, 4};


        private void cardClientes_Click(object sender, EventArgs e)
        {
            pdf(columnasCliente, tamaniosCliente);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pdf(columnasCliente, tamaniosCliente);
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards1_Click(object sender, EventArgs e)
        {
            //pdf(columnasTransporte, tamaniosTransporte, 2);
            pdfTransporte(columnasTransporte, tamaniosTransporte);
        }
        #region pdftransporte
        private void pdfTransporte(string[] columnas, float[] tamanios)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter w = PdfWriter.GetInstance(doc, new FileStream(@"ReporteTransporte.pdf", FileMode.Create));
            doc.Open();
            PdfContentByte content = w.DirectContent;


            //setting font type, font size and font color
            iTextSharp.text.Font font = iTextSharp.text.FontFactory.GetFont(
        FontFactory.TIMES_ROMAN, 30, BaseColor.BLUE);
            Paragraph prg = new iTextSharp.text.Paragraph();
            prg.Alignment = Element.ALIGN_CENTER; // adjust the alignment of the heading
            prg.Add(new Chunk("Transportes ", font)); //adding a heading to the PDF
            doc.Add(prg); //add the component we created to the document
            DataTable data = ControladorReportes.GetDataTransportes();
            dataGridView1.DataSource = data;
            //"Año", "VIN", "Placa", "Tipo Unidad", "Modelo", "Estado","# del Motor", "# del Chasis"
            dataGridView1.Columns[0].HeaderText = "# De Unidad";
            dataGridView1.Columns[1].HeaderText = "Año";
            dataGridView1.Columns[2].HeaderText = "VIN";
            dataGridView1.Columns[3].HeaderText = "Capacidad";
            dataGridView1.Columns[4].HeaderText = "Placa";
            dataGridView1.Columns[5].HeaderText = "Tipo de Placa";
            dataGridView1.Columns[6].HeaderText = "Tipo Unidad";
            dataGridView1.Columns[7].HeaderText = "Modelo";
            dataGridView1.Columns[8].HeaderText = "Marca";
            dataGridView1.Columns[9].HeaderText = "Estado Unidad";
            dataGridView1.Columns[10].HeaderText = "# de motor";
            dataGridView1.Columns[11].HeaderText = "# del Chasis";

            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                PdfPCell cell = new PdfPCell(); //create object from the pdfpcell class
                cell.BackgroundColor = BaseColor.LIGHT_GRAY; //set color of cells to gray
                cell.AddElement(new Chunk(dataGridView1.Columns[j].HeaderText.ToUpper()));
                table.AddCell(cell);
            }
            //add actual rows from grid to table
            for (int i = 0; i < data.Rows.Count; i++)
            {
                table.WidthPercentage = 100; //set width of the table
                for (int k = 0; k < data.Columns.Count; k++)
                {
                    if (dataGridView1[k, i].Value != null)
                        // get the value of   each cell in the dataTable tblemp
                        table.AddCell(new Phrase(dataGridView1[k, i].Value.ToString()));
                }
            }
            //add the table to document
            doc.Add(table);
            doc.Close();


        }
        #endregion pdftransporte
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pdfTransporte(columnasTransporte, tamaniosTransporte);
        }

        private void cardEmpleado_Click(object sender, EventArgs e)
        {
            pdfEmpleado(columnasEmpleado, tamaniosEmpleado);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pdfEmpleado(columnasEmpleado, tamaniosEmpleado);
        }


        #region pdfempleado
        private void pdfEmpleado(string[] columnas, float[] tamanios)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter w = PdfWriter.GetInstance(doc, new FileStream(@"ReporteEmpleados.pdf", FileMode.Create));
            doc.Open();
            PdfContentByte content = w.DirectContent;

            //setting font type, font size and font color
            iTextSharp.text.Font font = iTextSharp.text.FontFactory.GetFont(
        FontFactory.TIMES_ROMAN, 30, BaseColor.BLUE);
            Paragraph prg = new iTextSharp.text.Paragraph();
            prg.Alignment = Element.ALIGN_CENTER; // adjust the alignment of the heading
            prg.Add(new Chunk("Empleados ", font)); //adding a heading to the PDF
            doc.Add(prg); //add the component we created to the document

            DataTable data = ControladorReportes.GetDataEmpleados();
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].HeaderText = "Nombres";
            dataGridView1.Columns[1].HeaderText = "Apellidos";
            dataGridView1.Columns[2].HeaderText = "DUI";
            dataGridView1.Columns[3].HeaderText = "NIT";
            dataGridView1.Columns[4].HeaderText = "Teléfono";
            dataGridView1.Columns[5].HeaderText = "Cargo";


            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                PdfPCell cell = new PdfPCell(); //create object from the pdfpcell class
                cell.BackgroundColor = BaseColor.LIGHT_GRAY; //set color of cells to gray
                cell.AddElement(new Chunk(dataGridView1.Columns[j].HeaderText.ToUpper()));
                table.AddCell(cell);
            }
            //add actual rows from grid to table
            for (int i = 0; i < data.Rows.Count; i++)
            {
                table.WidthPercentage = 100; //set width of the table
                for (int k = 0; k < data.Columns.Count; k++)
                {
                    if (dataGridView1[k, i].Value != null)
                        // get the value of   each cell in the dataTable tblemp
                        table.AddCell(new Phrase(dataGridView1[k, i].Value.ToString()));
                }
            }
            //add the table to document
            doc.Add(table);
            doc.Close();



        }
        #endregion pdfempleado

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cardEmpleado_Paint(object sender, PaintEventArgs e)
        {

        }

        //CambiarIdioma
        public void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Idioma);

            lblReportesPDF.Text = Res.lblReportesPDF;
            lblTarjetasReportes.Text = Res.lblTarjetasreportes;
            lblUnidades.Text = Res.lblClientesReportes;
            lblUnidades.Text = Res.lblUnidadesReportes;
            lblEmpleados.Text = Res.lblEmpleadosReportes;
        }

        public void llenarIdioma()
        {
            cmbIdioma.DataSource = Idioma.ObtenerIdiomas();
            cmbIdioma.ValueMember = "CultureInfo";
            cmbIdioma.DisplayMember = "CargarNombre_Pais";
        }

        private void BtnCambiarIdioma_Click(object sender, EventArgs e)
        {
            Settings.Default.Idioma = cmbIdioma.SelectedValue.ToString();
            CargarIdioma();
        }
    }
}
