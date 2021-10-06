﻿namespace SistemGestionBuses
{
    partial class frmUnidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnidades));
            this.ElipseFormulario = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbEstadoUnidad = new System.Windows.Forms.ComboBox();
            this.txtNombreUnidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoPlaca = new System.Windows.Forms.ComboBox();
            this.txtNumeroChasis = new System.Windows.Forms.TextBox();
            this.txtNumeroMotor = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCrearUnidad = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoUnidad = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.btnActualizarGrid = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIDunidad = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvUnidades = new System.Windows.Forms.DataGridView();
            this.DragControlGeneral = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelBar = new System.Windows.Forms.Panel();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.ElipseGeneral = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipsePanelGrid = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtActiveUser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtCargoStrip = new System.Windows.Forms.ToolStripLabel();
            this.btnLogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panelFormularios.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).BeginInit();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipseFormulario
            // 
            this.ElipseFormulario.ElipseRadius = 5;
            this.ElipseFormulario.TargetControl = this.panelFormularios;
            // 
            // panelFormularios
            // 
            this.panelFormularios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.panelFormularios.Controls.Add(this.label13);
            this.panelFormularios.Controls.Add(this.cmbEstadoUnidad);
            this.panelFormularios.Controls.Add(this.txtNombreUnidad);
            this.panelFormularios.Controls.Add(this.label10);
            this.panelFormularios.Controls.Add(this.label8);
            this.panelFormularios.Controls.Add(this.cmbTipoPlaca);
            this.panelFormularios.Controls.Add(this.txtNumeroChasis);
            this.panelFormularios.Controls.Add(this.txtNumeroMotor);
            this.panelFormularios.Controls.Add(this.txtCapacidad);
            this.panelFormularios.Controls.Add(this.txtVIN);
            this.panelFormularios.Controls.Add(this.txtAnio);
            this.panelFormularios.Controls.Add(this.label4);
            this.panelFormularios.Controls.Add(this.label3);
            this.panelFormularios.Controls.Add(this.btnLimpiarCampos);
            this.panelFormularios.Controls.Add(this.label9);
            this.panelFormularios.Controls.Add(this.btnCrearUnidad);
            this.panelFormularios.Controls.Add(this.label12);
            this.panelFormularios.Controls.Add(this.label11);
            this.panelFormularios.Controls.Add(this.label7);
            this.panelFormularios.Controls.Add(this.label6);
            this.panelFormularios.Controls.Add(this.label5);
            this.panelFormularios.Controls.Add(this.label2);
            this.panelFormularios.Controls.Add(this.cmbTipoUnidad);
            this.panelFormularios.Controls.Add(this.cmbMarca);
            this.panelFormularios.Controls.Add(this.txtPlaca);
            this.panelFormularios.Controls.Add(this.cmbModelo);
            this.panelFormularios.Location = new System.Drawing.Point(12, 146);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(379, 392);
            this.panelFormularios.TabIndex = 97;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(13, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 18);
            this.label13.TabIndex = 107;
            this.label13.Text = "Estado de la unidad:";
            // 
            // cmbEstadoUnidad
            // 
            this.cmbEstadoUnidad.FormattingEnabled = true;
            this.cmbEstadoUnidad.Location = new System.Drawing.Point(9, 299);
            this.cmbEstadoUnidad.Name = "cmbEstadoUnidad";
            this.cmbEstadoUnidad.Size = new System.Drawing.Size(166, 21);
            this.cmbEstadoUnidad.TabIndex = 6;
            // 
            // txtNombreUnidad
            // 
            this.txtNombreUnidad.BackColor = System.Drawing.Color.White;
            this.txtNombreUnidad.ForeColor = System.Drawing.Color.Black;
            this.txtNombreUnidad.Location = new System.Drawing.Point(199, 300);
            this.txtNombreUnidad.Name = "txtNombreUnidad";
            this.txtNombreUnidad.ReadOnly = true;
            this.txtNombreUnidad.Size = new System.Drawing.Size(163, 20);
            this.txtNombreUnidad.TabIndex = 12;
            this.txtNombreUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(198, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 18);
            this.label10.TabIndex = 105;
            this.label10.Text = "Tipo de placa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(198, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 18);
            this.label8.TabIndex = 105;
            this.label8.Text = "Nombre de la unidad:";
            // 
            // cmbTipoPlaca
            // 
            this.cmbTipoPlaca.FormattingEnabled = true;
            this.cmbTipoPlaca.Location = new System.Drawing.Point(196, 246);
            this.cmbTipoPlaca.Name = "cmbTipoPlaca";
            this.cmbTipoPlaca.Size = new System.Drawing.Size(166, 21);
            this.cmbTipoPlaca.TabIndex = 11;
            // 
            // txtNumeroChasis
            // 
            this.txtNumeroChasis.Location = new System.Drawing.Point(197, 195);
            this.txtNumeroChasis.MaxLength = 17;
            this.txtNumeroChasis.Name = "txtNumeroChasis";
            this.txtNumeroChasis.Size = new System.Drawing.Size(167, 20);
            this.txtNumeroChasis.TabIndex = 10;
            // 
            // txtNumeroMotor
            // 
            this.txtNumeroMotor.Location = new System.Drawing.Point(12, 247);
            this.txtNumeroMotor.MaxLength = 17;
            this.txtNumeroMotor.Name = "txtNumeroMotor";
            this.txtNumeroMotor.Size = new System.Drawing.Size(167, 20);
            this.txtNumeroMotor.TabIndex = 5;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(12, 195);
            this.txtCapacidad.MaxLength = 3;
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(167, 20);
            this.txtCapacidad.TabIndex = 4;
            this.txtCapacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacidad_KeyPress);
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(12, 138);
            this.txtVIN.MaxLength = 17;
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(167, 20);
            this.txtVIN.TabIndex = 3;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(12, 87);
            this.txtAnio.MaxLength = 4;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(167, 20);
            this.txtAnio.TabIndex = 2;
            this.txtAnio.TextChanged += new System.EventHandler(this.txtAnio_TextChanged);
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnio_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 98;
            this.label4.Text = "Número de motor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(194, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 97;
            this.label3.Text = "Número de chasis";
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
            this.btnLimpiarCampos.Location = new System.Drawing.Point(197, 329);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(166, 43);
            this.btnLimpiarCampos.TabIndex = 14;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 18);
            this.label9.TabIndex = 96;
            this.label9.Text = "VIN:";
            // 
            // btnCrearUnidad
            // 
            this.btnCrearUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnCrearUnidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearUnidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnCrearUnidad.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            this.btnCrearUnidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            this.btnCrearUnidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnCrearUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUnidad.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUnidad.ForeColor = System.Drawing.Color.Black;
            this.btnCrearUnidad.Location = new System.Drawing.Point(9, 329);
            this.btnCrearUnidad.Name = "btnCrearUnidad";
            this.btnCrearUnidad.Size = new System.Drawing.Size(170, 43);
            this.btnCrearUnidad.TabIndex = 13;
            this.btnCrearUnidad.Text = "Agregar unidad";
            this.btnCrearUnidad.UseVisualStyleBackColor = false;
            this.btnCrearUnidad.Click += new System.EventHandler(this.btnCrearUnidad_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(194, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 18);
            this.label12.TabIndex = 87;
            this.label12.Text = "Modelo de la unidad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(194, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 18);
            this.label11.TabIndex = 86;
            this.label11.Text = "Matricula/ Placa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(194, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 82;
            this.label7.Text = "Tipo de la unidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 18);
            this.label6.TabIndex = 81;
            this.label6.Text = "Capacidad de la unidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 80;
            this.label5.Text = "Año de la unidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "Marca de la unidad:";
            // 
            // cmbTipoUnidad
            // 
            this.cmbTipoUnidad.FormattingEnabled = true;
            this.cmbTipoUnidad.Location = new System.Drawing.Point(197, 138);
            this.cmbTipoUnidad.Name = "cmbTipoUnidad";
            this.cmbTipoUnidad.Size = new System.Drawing.Size(166, 21);
            this.cmbTipoUnidad.TabIndex = 9;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(12, 36);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(167, 21);
            this.cmbMarca.TabIndex = 1;
            this.cmbMarca.Click += new System.EventHandler(this.cmbMarca_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(196, 85);
            this.txtPlaca.MaxLength = 15;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(167, 20);
            this.txtPlaca.TabIndex = 8;
            // 
            // cmbModelo
            // 
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(197, 36);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(166, 21);
            this.cmbModelo.TabIndex = 7;
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
            this.btnActualizarGrid.Location = new System.Drawing.Point(301, 303);
            this.btnActualizarGrid.Name = "btnActualizarGrid";
            this.btnActualizarGrid.Size = new System.Drawing.Size(138, 43);
            this.btnActualizarGrid.TabIndex = 17;
            this.btnActualizarGrid.Text = "Actualizar Grid";
            this.btnActualizarGrid.UseVisualStyleBackColor = false;
            this.btnActualizarGrid.Click += new System.EventHandler(this.btnActualizarGrid_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.panelGrid.Controls.Add(this.btnActualizarGrid);
            this.panelGrid.Controls.Add(this.btnEliminar);
            this.panelGrid.Controls.Add(this.txtIDunidad);
            this.panelGrid.Controls.Add(this.btnActualizar);
            this.panelGrid.Controls.Add(this.label14);
            this.panelGrid.Controls.Add(this.dgvUnidades);
            this.panelGrid.Location = new System.Drawing.Point(408, 146);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(607, 365);
            this.panelGrid.TabIndex = 99;
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
            this.btnEliminar.Location = new System.Drawing.Point(157, 303);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 43);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar Unidad";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtIDunidad
            // 
            this.txtIDunidad.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDunidad.Location = new System.Drawing.Point(475, 318);
            this.txtIDunidad.Name = "txtIDunidad";
            this.txtIDunidad.ReadOnly = true;
            this.txtIDunidad.Size = new System.Drawing.Size(87, 28);
            this.txtIDunidad.TabIndex = 90;
            this.txtIDunidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnActualizar.Location = new System.Drawing.Point(13, 303);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(138, 43);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar Unidad";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(472, 297);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 18);
            this.label14.TabIndex = 91;
            this.label14.Text = "ID de la unidad";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvUnidades
            // 
            this.dgvUnidades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.dgvUnidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidades.Location = new System.Drawing.Point(13, 18);
            this.dgvUnidades.Name = "dgvUnidades";
            this.dgvUnidades.RowHeadersVisible = false;
            this.dgvUnidades.Size = new System.Drawing.Size(574, 262);
            this.dgvUnidades.TabIndex = 82;
            this.dgvUnidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidades_CellClick);
            // 
            // DragControlGeneral
            // 
            this.DragControlGeneral.Fixed = true;
            this.DragControlGeneral.Horizontal = true;
            this.DragControlGeneral.TargetControl = this.panelBar;
            this.DragControlGeneral.Vertical = true;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.panelBar.Controls.Add(this.bunifuImageButton5);
            this.panelBar.Controls.Add(this.bunifuImageButton3);
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(1037, 50);
            this.panelBar.TabIndex = 105;
            this.panelBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBar_Paint_1);
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(957, 9);
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
            this.bunifuImageButton3.Location = new System.Drawing.Point(988, 9);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(27, 31);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 96;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // ElipseGeneral
            // 
            this.ElipseGeneral.ElipseRadius = 5;
            this.ElipseGeneral.TargetControl = this;
            // 
            // ElipsePanelGrid
            // 
            this.ElipsePanelGrid.ElipseRadius = 5;
            this.ElipsePanelGrid.TargetControl = this.panelGrid;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 67);
            this.label1.TabIndex = 96;
            this.label1.Text = "Unidades de transporte.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1037, 596);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 94;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 563);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1037, 33);
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
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            // frmUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 596);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUnidades";
            this.Text = "Form1";
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            this.panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).EndInit();
            this.panelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipseFormulario;
        private System.Windows.Forms.Button btnActualizarGrid;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIDunidad;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvUnidades;
        private Bunifu.Framework.UI.BunifuDragControl DragControlGeneral;
        private Bunifu.Framework.UI.BunifuElipse ElipseGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse ElipsePanelGrid;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.TextBox txtNumeroMotor;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCrearUnidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoUnidad;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.TextBox txtNombreUnidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTipoPlaca;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbEstadoUnidad;
        private System.Windows.Forms.TextBox txtNumeroChasis;
        private System.Windows.Forms.Panel panelBar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel txtActiveUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel txtCargoStrip;
        private System.Windows.Forms.ToolStripButton btnLogOut;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}