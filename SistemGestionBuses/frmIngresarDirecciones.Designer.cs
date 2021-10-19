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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresarDirecciones));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.lblLatitud = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtlongitud = new System.Windows.Forms.TextBox();
            this.txtlatitud = new System.Windows.Forms.TextBox();
            this.dgvPuntos = new System.Windows.Forms.DataGridView();
            this.cmbViajes = new System.Windows.Forms.ComboBox();
            this.lblViaje = new System.Windows.Forms.Label();
            this.txtreferenciaAdicional = new System.Windows.Forms.TextBox();
            this.lblPuntoref1 = new System.Windows.Forms.Label();
            this.txtreferenciaFinal = new System.Windows.Forms.TextBox();
            this.lblPuntoref = new System.Windows.Forms.Label();
            this.txtreferenciaInicio = new System.Windows.Forms.TextBox();
            this.lblPuntodeReferencia = new System.Windows.Forms.Label();
            this.lblDestinoAdicional = new System.Windows.Forms.Label();
            this.txtAdicional = new System.Windows.Forms.TextBox();
            this.lblDestinoFinal = new System.Windows.Forms.Label();
            this.txtDireccion_final = new System.Windows.Forms.TextBox();
            this.txtDireccion_inicio = new System.Windows.Forms.TextBox();
            this.lblPuntoPartida = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.lblIngresaDirecciones = new System.Windows.Forms.Label();
            this.panelBar = new System.Windows.Forms.Panel();
            this.BtnCambiarIdioma = new System.Windows.Forms.Button();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnAgregarDireccion = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtActiveUser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtCargoStrip = new System.Windows.Forms.ToolStripLabel();
            this.btnLogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.panel4.Controls.Add(this.btnRutas);
            this.panel4.Controls.Add(this.btnEliminar);
            this.panel4.Controls.Add(this.lblLongitud);
            this.panel4.Controls.Add(this.lblLatitud);
            this.panel4.Controls.Add(this.btnAgregar);
            this.panel4.Controls.Add(this.txtlongitud);
            this.panel4.Controls.Add(this.txtlatitud);
            this.panel4.Controls.Add(this.dgvPuntos);
            this.panel4.Controls.Add(this.cmbViajes);
            this.panel4.Controls.Add(this.lblViaje);
            this.panel4.Controls.Add(this.txtreferenciaAdicional);
            this.panel4.Controls.Add(this.lblPuntoref1);
            this.panel4.Controls.Add(this.txtreferenciaFinal);
            this.panel4.Controls.Add(this.lblPuntoref);
            this.panel4.Controls.Add(this.txtreferenciaInicio);
            this.panel4.Controls.Add(this.lblPuntodeReferencia);
            this.panel4.Controls.Add(this.lblDestinoAdicional);
            this.panel4.Controls.Add(this.txtAdicional);
            this.panel4.Controls.Add(this.lblDestinoFinal);
            this.panel4.Controls.Add(this.txtDireccion_final);
            this.panel4.Controls.Add(this.txtDireccion_inicio);
            this.panel4.Controls.Add(this.lblPuntoPartida);
            this.panel4.Location = new System.Drawing.Point(497, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(482, 363);
            this.panel4.TabIndex = 97;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnRutas
            // 
            this.btnRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnRutas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutas.ForeColor = System.Drawing.Color.Black;
            this.btnRutas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRutas.Location = new System.Drawing.Point(330, 207);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Size = new System.Drawing.Size(129, 36);
            this.btnRutas.TabIndex = 119;
            this.btnRutas.Text = "Generar Rutas";
            this.btnRutas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRutas.UseVisualStyleBackColor = false;
            this.btnRutas.Click += new System.EventHandler(this.btnRutas_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(330, 309);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 36);
            this.btnEliminar.TabIndex = 118;
            this.btnEliminar.Text = "Eliminar Punto";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitud.ForeColor = System.Drawing.Color.White;
            this.lblLongitud.Location = new System.Drawing.Point(16, 299);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(69, 17);
            this.lblLongitud.TabIndex = 117;
            this.lblLongitud.Text = "Longitud:";
            // 
            // lblLatitud
            // 
            this.lblLatitud.AutoSize = true;
            this.lblLatitud.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitud.ForeColor = System.Drawing.Color.White;
            this.lblLatitud.Location = new System.Drawing.Point(16, 250);
            this.lblLatitud.Name = "lblLatitud";
            this.lblLatitud.Size = new System.Drawing.Size(57, 17);
            this.lblLatitud.TabIndex = 116;
            this.lblLatitud.Text = "Latitud:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(329, 260);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 36);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar Punto";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtlongitud
            // 
            this.txtlongitud.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlongitud.Location = new System.Drawing.Point(20, 321);
            this.txtlongitud.MaxLength = 100;
            this.txtlongitud.Multiline = true;
            this.txtlongitud.Name = "txtlongitud";
            this.txtlongitud.ReadOnly = true;
            this.txtlongitud.Size = new System.Drawing.Size(134, 24);
            this.txtlongitud.TabIndex = 115;
            // 
            // txtlatitud
            // 
            this.txtlatitud.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlatitud.Location = new System.Drawing.Point(20, 272);
            this.txtlatitud.MaxLength = 100;
            this.txtlatitud.Multiline = true;
            this.txtlatitud.Name = "txtlatitud";
            this.txtlatitud.ReadOnly = true;
            this.txtlatitud.Size = new System.Drawing.Size(134, 24);
            this.txtlatitud.TabIndex = 114;
            // 
            // dgvPuntos
            // 
            this.dgvPuntos.AllowUserToAddRows = false;
            this.dgvPuntos.AllowUserToDeleteRows = false;
            this.dgvPuntos.AllowUserToResizeColumns = false;
            this.dgvPuntos.AllowUserToResizeRows = false;
            this.dgvPuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuntos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.dgvPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.dgvPuntos.Location = new System.Drawing.Point(168, 207);
            this.dgvPuntos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPuntos.Name = "dgvPuntos";
            this.dgvPuntos.ReadOnly = true;
            this.dgvPuntos.RowTemplate.Height = 24;
            this.dgvPuntos.Size = new System.Drawing.Size(140, 138);
            this.dgvPuntos.TabIndex = 112;
            this.dgvPuntos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPuntos_CellContentClick);
            this.dgvPuntos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPuntos_CellMouseClick);
            // 
            // cmbViajes
            // 
            this.cmbViajes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbViajes.FormattingEnabled = true;
            this.cmbViajes.Location = new System.Drawing.Point(20, 221);
            this.cmbViajes.Name = "cmbViajes";
            this.cmbViajes.Size = new System.Drawing.Size(134, 25);
            this.cmbViajes.TabIndex = 111;
            // 
            // lblViaje
            // 
            this.lblViaje.AutoSize = true;
            this.lblViaje.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViaje.ForeColor = System.Drawing.Color.White;
            this.lblViaje.Location = new System.Drawing.Point(16, 199);
            this.lblViaje.Name = "lblViaje";
            this.lblViaje.Size = new System.Drawing.Size(44, 17);
            this.lblViaje.TabIndex = 110;
            this.lblViaje.Text = "Viaje:";
            // 
            // txtreferenciaAdicional
            // 
            this.txtreferenciaAdicional.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreferenciaAdicional.Location = new System.Drawing.Point(320, 129);
            this.txtreferenciaAdicional.MaxLength = 200;
            this.txtreferenciaAdicional.Multiline = true;
            this.txtreferenciaAdicional.Name = "txtreferenciaAdicional";
            this.txtreferenciaAdicional.Size = new System.Drawing.Size(139, 62);
            this.txtreferenciaAdicional.TabIndex = 109;
            // 
            // lblPuntoref1
            // 
            this.lblPuntoref1.AutoSize = true;
            this.lblPuntoref1.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntoref1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoref1.ForeColor = System.Drawing.Color.White;
            this.lblPuntoref1.Location = new System.Drawing.Point(318, 107);
            this.lblPuntoref1.Name = "lblPuntoref1";
            this.lblPuntoref1.Size = new System.Drawing.Size(139, 17);
            this.lblPuntoref1.TabIndex = 108;
            this.lblPuntoref1.Text = "Punto de referencia:";
            // 
            // txtreferenciaFinal
            // 
            this.txtreferenciaFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreferenciaFinal.Location = new System.Drawing.Point(168, 129);
            this.txtreferenciaFinal.MaxLength = 200;
            this.txtreferenciaFinal.Multiline = true;
            this.txtreferenciaFinal.Name = "txtreferenciaFinal";
            this.txtreferenciaFinal.Size = new System.Drawing.Size(139, 62);
            this.txtreferenciaFinal.TabIndex = 107;
            // 
            // lblPuntoref
            // 
            this.lblPuntoref.AutoSize = true;
            this.lblPuntoref.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntoref.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoref.ForeColor = System.Drawing.Color.White;
            this.lblPuntoref.Location = new System.Drawing.Point(164, 107);
            this.lblPuntoref.Name = "lblPuntoref";
            this.lblPuntoref.Size = new System.Drawing.Size(139, 17);
            this.lblPuntoref.TabIndex = 106;
            this.lblPuntoref.Text = "Punto de referencia:";
            // 
            // txtreferenciaInicio
            // 
            this.txtreferenciaInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreferenciaInicio.Location = new System.Drawing.Point(15, 129);
            this.txtreferenciaInicio.MaxLength = 200;
            this.txtreferenciaInicio.Multiline = true;
            this.txtreferenciaInicio.Name = "txtreferenciaInicio";
            this.txtreferenciaInicio.Size = new System.Drawing.Size(139, 62);
            this.txtreferenciaInicio.TabIndex = 105;
            // 
            // lblPuntodeReferencia
            // 
            this.lblPuntodeReferencia.AutoSize = true;
            this.lblPuntodeReferencia.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntodeReferencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntodeReferencia.ForeColor = System.Drawing.Color.White;
            this.lblPuntodeReferencia.Location = new System.Drawing.Point(12, 107);
            this.lblPuntodeReferencia.Name = "lblPuntodeReferencia";
            this.lblPuntodeReferencia.Size = new System.Drawing.Size(139, 17);
            this.lblPuntodeReferencia.TabIndex = 104;
            this.lblPuntodeReferencia.Text = "Punto de referencia:";
            // 
            // lblDestinoAdicional
            // 
            this.lblDestinoAdicional.AutoSize = true;
            this.lblDestinoAdicional.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinoAdicional.ForeColor = System.Drawing.Color.White;
            this.lblDestinoAdicional.Location = new System.Drawing.Point(317, 14);
            this.lblDestinoAdicional.Name = "lblDestinoAdicional";
            this.lblDestinoAdicional.Size = new System.Drawing.Size(125, 17);
            this.lblDestinoAdicional.TabIndex = 99;
            this.lblDestinoAdicional.Text = "Destino adicional:";
            // 
            // txtAdicional
            // 
            this.txtAdicional.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicional.Location = new System.Drawing.Point(321, 34);
            this.txtAdicional.MaxLength = 200;
            this.txtAdicional.Multiline = true;
            this.txtAdicional.Name = "txtAdicional";
            this.txtAdicional.Size = new System.Drawing.Size(141, 71);
            this.txtAdicional.TabIndex = 98;
            // 
            // lblDestinoFinal
            // 
            this.lblDestinoFinal.AutoSize = true;
            this.lblDestinoFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinoFinal.ForeColor = System.Drawing.Color.White;
            this.lblDestinoFinal.Location = new System.Drawing.Point(163, 13);
            this.lblDestinoFinal.Name = "lblDestinoFinal";
            this.lblDestinoFinal.Size = new System.Drawing.Size(150, 17);
            this.lblDestinoFinal.TabIndex = 95;
            this.lblDestinoFinal.Text = "Destino final del viaje:";
            // 
            // txtDireccion_final
            // 
            this.txtDireccion_final.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion_final.Location = new System.Drawing.Point(167, 33);
            this.txtDireccion_final.MaxLength = 200;
            this.txtDireccion_final.Multiline = true;
            this.txtDireccion_final.Name = "txtDireccion_final";
            this.txtDireccion_final.Size = new System.Drawing.Size(141, 71);
            this.txtDireccion_final.TabIndex = 94;
            // 
            // txtDireccion_inicio
            // 
            this.txtDireccion_inicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion_inicio.Location = new System.Drawing.Point(15, 35);
            this.txtDireccion_inicio.MaxLength = 200;
            this.txtDireccion_inicio.Multiline = true;
            this.txtDireccion_inicio.Name = "txtDireccion_inicio";
            this.txtDireccion_inicio.Size = new System.Drawing.Size(139, 69);
            this.txtDireccion_inicio.TabIndex = 88;
            // 
            // lblPuntoPartida
            // 
            this.lblPuntoPartida.AutoSize = true;
            this.lblPuntoPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntoPartida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoPartida.ForeColor = System.Drawing.Color.White;
            this.lblPuntoPartida.Location = new System.Drawing.Point(10, 14);
            this.lblPuntoPartida.Name = "lblPuntoPartida";
            this.lblPuntoPartida.Size = new System.Drawing.Size(123, 17);
            this.lblPuntoPartida.TabIndex = 89;
            this.lblPuntoPartida.Text = "Punto de partida:";
            // 
            // pictureBox2
            // 
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
            // gMapControl1
            // 
            this.gMapControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(18, 115);
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
            this.gMapControl1.Size = new System.Drawing.Size(451, 387);
            this.gMapControl1.TabIndex = 102;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapDirections_Load);
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // lblIngresaDirecciones
            // 
            this.lblIngresaDirecciones.BackColor = System.Drawing.Color.White;
            this.lblIngresaDirecciones.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresaDirecciones.Location = new System.Drawing.Point(17, 58);
            this.lblIngresaDirecciones.Name = "lblIngresaDirecciones";
            this.lblIngresaDirecciones.Size = new System.Drawing.Size(474, 55);
            this.lblIngresaDirecciones.TabIndex = 103;
            this.lblIngresaDirecciones.Text = "Ingresa las direcciones:";
            this.lblIngresaDirecciones.Click += new System.EventHandler(this.label4_Click);
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.panelBar.Controls.Add(this.BtnCambiarIdioma);
            this.panelBar.Controls.Add(this.cmbIdioma);
            this.panelBar.Controls.Add(this.bunifuImageButton5);
            this.panelBar.Controls.Add(this.bunifuImageButton3);
            this.panelBar.Controls.Add(this.bunifuImageButton1);
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(992, 50);
            this.panelBar.TabIndex = 104;
            // 
            // BtnCambiarIdioma
            // 
            this.BtnCambiarIdioma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.BtnCambiarIdioma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCambiarIdioma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.BtnCambiarIdioma.FlatAppearance.BorderSize = 2;
            this.BtnCambiarIdioma.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BtnCambiarIdioma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCambiarIdioma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.BtnCambiarIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiarIdioma.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiarIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.BtnCambiarIdioma.Location = new System.Drawing.Point(103, 9);
            this.BtnCambiarIdioma.Name = "BtnCambiarIdioma";
            this.BtnCambiarIdioma.Size = new System.Drawing.Size(172, 30);
            this.BtnCambiarIdioma.TabIndex = 166;
            this.BtnCambiarIdioma.Text = "Seleccionar Idioma:";
            this.BtnCambiarIdioma.UseVisualStyleBackColor = false;
            this.BtnCambiarIdioma.Click += new System.EventHandler(this.BtnCambiarIdioma_Click);
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(281, 12);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(194, 26);
            this.cmbIdioma.TabIndex = 165;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(912, 9);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(25, 31);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 98;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(943, 9);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(27, 31);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 96;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(18, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 94;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnAgregarDireccion
            // 
            this.btnAgregarDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.btnAgregarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDireccion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDireccion.Location = new System.Drawing.Point(588, 444);
            this.btnAgregarDireccion.Name = "btnAgregarDireccion";
            this.btnAgregarDireccion.Size = new System.Drawing.Size(141, 58);
            this.btnAgregarDireccion.TabIndex = 1;
            this.btnAgregarDireccion.Text = "Agregar Direccion";
            this.btnAgregarDireccion.UseVisualStyleBackColor = false;
            this.btnAgregarDireccion.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(752, 444);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(140, 58);
            this.btnLimpiarCampos.TabIndex = 2;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtActiveUser,
            this.toolStripSeparator1,
            this.txtCargoStrip,
            this.btnLogOut,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 508);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(991, 33);
            this.toolStrip1.TabIndex = 129;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtActiveUser
            // 
            this.txtActiveUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActiveUser.ForeColor = System.Drawing.Color.White;
            this.txtActiveUser.Image = ((System.Drawing.Image)(resources.GetObject("txtActiveUser.Image")));
            this.txtActiveUser.Name = "txtActiveUser";
            this.txtActiveUser.Size = new System.Drawing.Size(103, 30);
            this.txtActiveUser.Text = "active user";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // txtCargoStrip
            // 
            this.txtCargoStrip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoStrip.ForeColor = System.Drawing.Color.White;
            this.txtCargoStrip.Image = ((System.Drawing.Image)(resources.GetObject("txtCargoStrip.Image")));
            this.txtCargoStrip.Name = "txtCargoStrip";
            this.txtCargoStrip.Size = new System.Drawing.Size(114, 30);
            this.txtCargoStrip.Text = "work position";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(32, 30);
            this.btnLogOut.Text = "toolStripButton3";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 30);
            this.toolStripLabel1.Text = "Log Out";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frmIngresarDirecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 541);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.btnAgregarDireccion);
            this.Controls.Add(this.lblIngresaDirecciones);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngresarDirecciones";
            this.Text = "frmIngresarDirecciones";
            this.Load += new System.EventHandler(this.frmIngresarDirecciones_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDestinoAdicional;
        private System.Windows.Forms.TextBox txtAdicional;
        private System.Windows.Forms.Label lblDestinoFinal;
        private System.Windows.Forms.TextBox txtDireccion_final;
        private System.Windows.Forms.TextBox txtDireccion_inicio;
        private System.Windows.Forms.Label lblPuntoPartida;
        private System.Windows.Forms.PictureBox pictureBox2;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label lblIngresaDirecciones;
        private System.Windows.Forms.Panel panelBar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox txtreferenciaAdicional;
        private System.Windows.Forms.Label lblPuntoref1;
        private System.Windows.Forms.TextBox txtreferenciaFinal;
        private System.Windows.Forms.Label lblPuntoref;
        private System.Windows.Forms.TextBox txtreferenciaInicio;
        private System.Windows.Forms.Label lblPuntodeReferencia;
        private System.Windows.Forms.ComboBox cmbViajes;
        private System.Windows.Forms.Label lblViaje;
        private System.Windows.Forms.DataGridView dgvPuntos;
        private System.Windows.Forms.Label lblLatitud;
        private System.Windows.Forms.TextBox txtlongitud;
        private System.Windows.Forms.TextBox txtlatitud;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnAgregarDireccion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel txtActiveUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel txtCargoStrip;
        private System.Windows.Forms.ToolStripButton btnLogOut;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button BtnCambiarIdioma;
        private System.Windows.Forms.ComboBox cmbIdioma;
    }
}