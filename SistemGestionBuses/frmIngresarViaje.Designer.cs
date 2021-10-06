namespace SistemGestionBuses
{
    partial class frmIngresarViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresarViaje));
            this.cmbUnidadTransporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbTipoDestino = new System.Windows.Forms.ComboBox();
            this.txtTarifaViaje = new System.Windows.Forms.TextBox();
            this.txtNombreViaje = new System.Windows.Forms.TextBox();
            this.cmbConductor = new System.Windows.Forms.ComboBox();
            this.btnCrearViaje = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.dtpFechaRetorno = new System.Windows.Forms.DateTimePicker();
            this.cmbMunicipios = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaPartida = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstadoViaje = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtIDviaje = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ElipseGeneral = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControlGeneral = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.btnActualizarGrid = new System.Windows.Forms.Button();
            this.ElipsePanelGrid = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelBar = new System.Windows.Forms.Panel();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtActiveUser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtCargoStrip = new System.Windows.Forms.ToolStripLabel();
            this.btnLogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelFormularios.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbUnidadTransporte
            // 
            this.cmbUnidadTransporte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidadTransporte.FormattingEnabled = true;
            this.cmbUnidadTransporte.Location = new System.Drawing.Point(15, 192);
            this.cmbUnidadTransporte.Name = "cmbUnidadTransporte";
            this.cmbUnidadTransporte.Size = new System.Drawing.Size(155, 25);
            this.cmbUnidadTransporte.TabIndex = 76;
            this.cmbUnidadTransporte.Text = "unidad transporte";
            this.cmbUnidadTransporte.Click += new System.EventHandler(this.cmbUnidadTransporte_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 74);
            this.label1.TabIndex = 75;
            this.label1.Text = "Viajes";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.btnActualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(16, 293);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(138, 43);
            this.btnActualizar.TabIndex = 74;
            this.btnActualizar.Text = "Actualizar Viaje";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(160, 293);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 43);
            this.btnEliminar.TabIndex = 73;
            this.btnEliminar.Text = "Eliminar Viaje";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // cmbTipoDestino
            // 
            this.cmbTipoDestino.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDestino.FormattingEnabled = true;
            this.cmbTipoDestino.Location = new System.Drawing.Point(14, 138);
            this.cmbTipoDestino.Name = "cmbTipoDestino";
            this.cmbTipoDestino.Size = new System.Drawing.Size(156, 25);
            this.cmbTipoDestino.TabIndex = 67;
            this.cmbTipoDestino.Text = "tipo destino";
            this.cmbTipoDestino.Click += new System.EventHandler(this.cmbTipoDestino_Click);
            // 
            // txtTarifaViaje
            // 
            this.txtTarifaViaje.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarifaViaje.Location = new System.Drawing.Point(13, 257);
            this.txtTarifaViaje.MaxLength = 12;
            this.txtTarifaViaje.Name = "txtTarifaViaje";
            this.txtTarifaViaje.Size = new System.Drawing.Size(158, 22);
            this.txtTarifaViaje.TabIndex = 65;
            this.txtTarifaViaje.Text = "tarifa";
            // 
            // txtNombreViaje
            // 
            this.txtNombreViaje.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreViaje.Location = new System.Drawing.Point(189, 36);
            this.txtNombreViaje.MaxLength = 50;
            this.txtNombreViaje.Name = "txtNombreViaje";
            this.txtNombreViaje.Size = new System.Drawing.Size(164, 22);
            this.txtNombreViaje.TabIndex = 64;
            this.txtNombreViaje.Text = "nombre viaje";
            // 
            // cmbConductor
            // 
            this.cmbConductor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConductor.FormattingEnabled = true;
            this.cmbConductor.Location = new System.Drawing.Point(194, 192);
            this.cmbConductor.Name = "cmbConductor";
            this.cmbConductor.Size = new System.Drawing.Size(159, 25);
            this.cmbConductor.TabIndex = 61;
            this.cmbConductor.Text = "conductor";
            this.cmbConductor.SelectedIndexChanged += new System.EventHandler(this.cmbConductor_SelectedIndexChanged);
            this.cmbConductor.Click += new System.EventHandler(this.cmbConductor_Click);
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnCrearViaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearViaje.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnCrearViaje.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            this.btnCrearViaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            this.btnCrearViaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnCrearViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearViaje.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearViaje.ForeColor = System.Drawing.Color.Black;
            this.btnCrearViaje.Location = new System.Drawing.Point(12, 324);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(158, 43);
            this.btnCrearViaje.TabIndex = 57;
            this.btnCrearViaje.Text = "Crear Viaje";
            this.btnCrearViaje.UseVisualStyleBackColor = false;
            this.btnCrearViaje.Click += new System.EventHandler(this.btnCrearViaje_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnLimpiarCampos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnLimpiarCampos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            this.btnLimpiarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            this.btnLimpiarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(194, 324);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(158, 43);
            this.btnLimpiarCampos.TabIndex = 56;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(986, 561);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelFormularios
            // 
            this.panelFormularios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.panelFormularios.Controls.Add(this.dtpFechaRetorno);
            this.panelFormularios.Controls.Add(this.cmbMunicipios);
            this.panelFormularios.Controls.Add(this.btnLimpiarCampos);
            this.panelFormularios.Controls.Add(this.label10);
            this.panelFormularios.Controls.Add(this.label9);
            this.panelFormularios.Controls.Add(this.dtpFechaPartida);
            this.panelFormularios.Controls.Add(this.btnCrearViaje);
            this.panelFormularios.Controls.Add(this.label12);
            this.panelFormularios.Controls.Add(this.label11);
            this.panelFormularios.Controls.Add(this.label8);
            this.panelFormularios.Controls.Add(this.label7);
            this.panelFormularios.Controls.Add(this.label6);
            this.panelFormularios.Controls.Add(this.label4);
            this.panelFormularios.Controls.Add(this.label3);
            this.panelFormularios.Controls.Add(this.label2);
            this.panelFormularios.Controls.Add(this.cmbUnidadTransporte);
            this.panelFormularios.Controls.Add(this.cmbTipoDestino);
            this.panelFormularios.Controls.Add(this.cmbEstadoViaje);
            this.panelFormularios.Controls.Add(this.cmbCliente);
            this.panelFormularios.Controls.Add(this.txtTarifaViaje);
            this.panelFormularios.Controls.Add(this.txtNombreViaje);
            this.panelFormularios.Controls.Add(this.cmbConductor);
            this.panelFormularios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFormularios.Location = new System.Drawing.Point(608, 115);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(368, 390);
            this.panelFormularios.TabIndex = 77;
            // 
            // dtpFechaRetorno
            // 
            this.dtpFechaRetorno.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaRetorno.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRetorno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaRetorno.Location = new System.Drawing.Point(187, 88);
            this.dtpFechaRetorno.Name = "dtpFechaRetorno";
            this.dtpFechaRetorno.Size = new System.Drawing.Size(157, 22);
            this.dtpFechaRetorno.TabIndex = 100;
            // 
            // cmbMunicipios
            // 
            this.cmbMunicipios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMunicipios.FormattingEnabled = true;
            this.cmbMunicipios.Location = new System.Drawing.Point(194, 254);
            this.cmbMunicipios.Name = "cmbMunicipios";
            this.cmbMunicipios.Size = new System.Drawing.Size(155, 25);
            this.cmbMunicipios.TabIndex = 99;
            this.cmbMunicipios.Text = "unidad transporte";
            this.cmbMunicipios.Click += new System.EventHandler(this.cmbMunicipios_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(191, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 98;
            this.label10.Text = "Municipio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 17);
            this.label9.TabIndex = 96;
            this.label9.Text = "Fecha de inicio del viaje:";
            // 
            // dtpFechaPartida
            // 
            this.dtpFechaPartida.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaPartida.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPartida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPartida.Location = new System.Drawing.Point(14, 88);
            this.dtpFechaPartida.Name = "dtpFechaPartida";
            this.dtpFechaPartida.Size = new System.Drawing.Size(157, 22);
            this.dtpFechaPartida.TabIndex = 95;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(184, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 17);
            this.label12.TabIndex = 87;
            this.label12.Text = "Nombre del viaje";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(195, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 17);
            this.label11.TabIndex = 86;
            this.label11.Text = "Conductor asignado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 17);
            this.label8.TabIndex = 83;
            this.label8.Text = "Unidad de Transporte:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 82;
            this.label7.Text = "Tipo de viaje:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(191, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 81;
            this.label6.Text = "Estado del viaje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(186, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 17);
            this.label4.TabIndex = 79;
            this.label4.Text = "Fecha de retorno del viaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 78;
            this.label3.Text = "Tarifa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "Cliente:";
            // 
            // cmbEstadoViaje
            // 
            this.cmbEstadoViaje.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoViaje.FormattingEnabled = true;
            this.cmbEstadoViaje.Location = new System.Drawing.Point(190, 138);
            this.cmbEstadoViaje.Name = "cmbEstadoViaje";
            this.cmbEstadoViaje.Size = new System.Drawing.Size(158, 25);
            this.cmbEstadoViaje.TabIndex = 59;
            this.cmbEstadoViaje.Text = "estado viaje";
            this.cmbEstadoViaje.Click += new System.EventHandler(this.cmbEstadoViaje_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(12, 36);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(158, 25);
            this.cmbCliente.TabIndex = 58;
            this.cmbCliente.Text = "cliente";
            this.cmbCliente.Click += new System.EventHandler(this.cmbCliente_Click);
            // 
            // txtIDviaje
            // 
            this.txtIDviaje.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDviaje.Location = new System.Drawing.Point(489, 308);
            this.txtIDviaje.Name = "txtIDviaje";
            this.txtIDviaje.ReadOnly = true;
            this.txtIDviaje.Size = new System.Drawing.Size(87, 28);
            this.txtIDviaje.TabIndex = 90;
            this.txtIDviaje.Text = "ID viaje";
            this.txtIDviaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(494, 287);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 18);
            this.label14.TabIndex = 91;
            this.label14.Text = "ID del viaje";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ElipseGeneral
            // 
            this.ElipseGeneral.ElipseRadius = 5;
            this.ElipseGeneral.TargetControl = this;
            // 
            // DragControlGeneral
            // 
            this.DragControlGeneral.Fixed = true;
            this.DragControlGeneral.Horizontal = true;
            this.DragControlGeneral.TargetControl = null;
            this.DragControlGeneral.Vertical = true;
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.panelGrid.Controls.Add(this.dgvViajes);
            this.panelGrid.Controls.Add(this.btnActualizarGrid);
            this.panelGrid.Controls.Add(this.btnEliminar);
            this.panelGrid.Controls.Add(this.txtIDviaje);
            this.panelGrid.Controls.Add(this.btnActualizar);
            this.panelGrid.Controls.Add(this.label14);
            this.panelGrid.Location = new System.Drawing.Point(12, 152);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(588, 353);
            this.panelGrid.TabIndex = 93;
            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
            // 
            // dgvViajes
            // 
            this.dgvViajes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Location = new System.Drawing.Point(16, 17);
            this.dgvViajes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.RowTemplate.Height = 24;
            this.dgvViajes.Size = new System.Drawing.Size(560, 256);
            this.dgvViajes.TabIndex = 93;
            this.dgvViajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajes_CellClick);
            this.dgvViajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajes_CellContentClick);
            // 
            // btnActualizarGrid
            // 
            this.btnActualizarGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.btnActualizarGrid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.btnActualizarGrid.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            this.btnActualizarGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            this.btnActualizarGrid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.btnActualizarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarGrid.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarGrid.ForeColor = System.Drawing.Color.White;
            this.btnActualizarGrid.Location = new System.Drawing.Point(304, 293);
            this.btnActualizarGrid.Name = "btnActualizarGrid";
            this.btnActualizarGrid.Size = new System.Drawing.Size(138, 43);
            this.btnActualizarGrid.TabIndex = 92;
            this.btnActualizarGrid.Text = "Actualizar Grid";
            this.btnActualizarGrid.UseVisualStyleBackColor = false;
            this.btnActualizarGrid.Click += new System.EventHandler(this.button3_Click);
            // 
            // ElipsePanelGrid
            // 
            this.ElipsePanelGrid.ElipseRadius = 5;
            this.ElipsePanelGrid.TargetControl = this.panelGrid;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.panelFormularios;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.panelBar.Controls.Add(this.bunifuImageButton5);
            this.panelBar.Controls.Add(this.bunifuImageButton3);
            this.panelBar.Controls.Add(this.bunifuImageButton1);
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(986, 50);
            this.panelBar.TabIndex = 106;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(906, 9);
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
            this.bunifuImageButton3.Location = new System.Drawing.Point(937, 9);
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 528);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(986, 33);
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
            // frmIngresarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngresarViaje";
            this.Text = "frmIngresarViaje";
            this.Load += new System.EventHandler(this.frmIngresarViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            this.panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.panelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUnidadTransporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbTipoDestino;
        private System.Windows.Forms.TextBox txtTarifaViaje;
        private System.Windows.Forms.TextBox txtNombreViaje;
        private System.Windows.Forms.ComboBox cmbConductor;
        private System.Windows.Forms.Button btnCrearViaje;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaPartida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDviaje;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuElipse ElipseGeneral;
        private Bunifu.Framework.UI.BunifuDragControl DragControlGeneral;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Button btnActualizarGrid;
        private Bunifu.Framework.UI.BunifuElipse ElipsePanelGrid;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ComboBox cmbMunicipios;
        private System.Windows.Forms.Panel panelBar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.DateTimePicker dtpFechaRetorno;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel txtActiveUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel txtCargoStrip;
        private System.Windows.Forms.ToolStripButton btnLogOut;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEstadoViaje;
        private System.Windows.Forms.ComboBox cmbCliente;
    }
}