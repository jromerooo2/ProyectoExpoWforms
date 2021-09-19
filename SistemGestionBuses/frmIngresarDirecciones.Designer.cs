namespace SistemGestionBuses
{
    partial class frmIngresarDirecciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresarDirecciones));
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDireccion_inicio_longt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDireccion_final = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMunicipio_inicio = new System.Windows.Forms.ComboBox();
            this.txtDireccion_inicio = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbMunicipio_final = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCargarMapa = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.panel4.Controls.Add(this.txtDireccion_inicio_longt);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.comboBox4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.comboBox3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtDireccion_final);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.cmbMunicipio_inicio);
            this.panel4.Controls.Add(this.txtDireccion_inicio);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.cmbMunicipio_final);
            this.panel4.Location = new System.Drawing.Point(497, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(482, 342);
            this.panel4.TabIndex = 97;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txtDireccion_inicio_longt
            // 
            this.txtDireccion_inicio_longt.Location = new System.Drawing.Point(15, 135);
            this.txtDireccion_inicio_longt.Multiline = true;
            this.txtDireccion_inicio_longt.Name = "txtDireccion_inicio_longt";
            this.txtDireccion_inicio_longt.Size = new System.Drawing.Size(139, 76);
            this.txtDireccion_inicio_longt.TabIndex = 106;
            this.txtDireccion_inicio_longt.Text = "destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(319, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 105;
            this.label3.Text = "Departamento:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(322, 297);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(140, 21);
            this.comboBox4.TabIndex = 104;
            this.comboBox4.Text = "municipio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(163, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 103;
            this.label2.Text = "Departamento:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(166, 297);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(140, 21);
            this.comboBox3.TabIndex = 102;
            this.comboBox3.Text = "municipio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 101;
            this.label1.Text = "Departamento:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(14, 297);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 21);
            this.comboBox2.TabIndex = 100;
            this.comboBox2.Text = "municipio";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(317, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(118, 18);
            this.label18.TabIndex = 99;
            this.label18.Text = "Destino adicional:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 180);
            this.textBox1.TabIndex = 98;
            this.textBox1.Text = "destino";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(317, 225);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(145, 18);
            this.label19.TabIndex = 96;
            this.label19.Text = "Municipio del destino:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(320, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 97;
            this.comboBox1.Text = "municipio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(163, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 18);
            this.label10.TabIndex = 95;
            this.label10.Text = "Destino del viaje:";
            // 
            // txtDireccion_final
            // 
            this.txtDireccion_final.Location = new System.Drawing.Point(167, 40);
            this.txtDireccion_final.Multiline = true;
            this.txtDireccion_final.Name = "txtDireccion_final";
            this.txtDireccion_final.Size = new System.Drawing.Size(141, 171);
            this.txtDireccion_final.TabIndex = 94;
            this.txtDireccion_final.Text = "destino";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(163, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 18);
            this.label9.TabIndex = 84;
            this.label9.Text = "Municipio del destino:";
            // 
            // cmbMunicipio_inicio
            // 
            this.cmbMunicipio_inicio.FormattingEnabled = true;
            this.cmbMunicipio_inicio.Location = new System.Drawing.Point(12, 246);
            this.cmbMunicipio_inicio.Name = "cmbMunicipio_inicio";
            this.cmbMunicipio_inicio.Size = new System.Drawing.Size(140, 21);
            this.cmbMunicipio_inicio.TabIndex = 68;
            this.cmbMunicipio_inicio.Text = "municipio";
            // 
            // txtDireccion_inicio
            // 
            this.txtDireccion_inicio.Location = new System.Drawing.Point(15, 42);
            this.txtDireccion_inicio.Multiline = true;
            this.txtDireccion_inicio.Name = "txtDireccion_inicio";
            this.txtDireccion_inicio.Size = new System.Drawing.Size(139, 76);
            this.txtDireccion_inicio.TabIndex = 88;
            this.txtDireccion_inicio.Text = "destino";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(11, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 18);
            this.label15.TabIndex = 91;
            this.label15.Text = "Municipio de salida:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(10, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 18);
            this.label13.TabIndex = 89;
            this.label13.Text = "Direccion de salida:";
            // 
            // cmbMunicipio_final
            // 
            this.cmbMunicipio_final.FormattingEnabled = true;
            this.cmbMunicipio_final.Location = new System.Drawing.Point(166, 245);
            this.cmbMunicipio_final.Name = "cmbMunicipio_final";
            this.cmbMunicipio_final.Size = new System.Drawing.Size(142, 21);
            this.cmbMunicipio_final.TabIndex = 90;
            this.cmbMunicipio_final.Text = "municipio";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(1366, 768);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(1000, 525);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1000, 541);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 98;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnCargarMapa);
            this.panel1.Location = new System.Drawing.Point(497, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 87);
            this.panel1.TabIndex = 100;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCargarMapa
            // 
            this.btnCargarMapa.Location = new System.Drawing.Point(14, 16);
            this.btnCargarMapa.Name = "btnCargarMapa";
            this.btnCargarMapa.Size = new System.Drawing.Size(140, 58);
            this.btnCargarMapa.TabIndex = 0;
            this.btnCargarMapa.Text = "Cargar Mapa";
            this.btnCargarMapa.UseVisualStyleBackColor = true;
            this.btnCargarMapa.Click += new System.EventHandler(this.btnCargarMapa_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(22, 75);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(451, 446);
            this.gMapControl1.TabIndex = 102;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapDirections_Load);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(484, 55);
            this.label4.TabIndex = 103;
            this.label4.Text = "Ingresa las direcciones:";
            // 
            // frmIngresarDirecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmIngresarDirecciones";
            this.Text = "frmIngresarDirecciones";
            this.Load += new System.EventHandler(this.frmIngresarDirecciones_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDireccion_final;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMunicipio_inicio;
        private System.Windows.Forms.TextBox txtDireccion_inicio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbMunicipio_final;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCargarMapa;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion_inicio_longt;
    }
}