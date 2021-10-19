namespace SistemGestionBuses
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAñadirImg = new System.Windows.Forms.Button();
            this.userImg = new System.Windows.Forms.PictureBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAcciones = new System.Windows.Forms.Label();
            this.dgvOnlineUsers = new System.Windows.Forms.DataGridView();
            this.lblConectados = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtActiveUser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtCargoStrip = new System.Windows.Forms.ToolStripLabel();
            this.btnLogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelBar = new System.Windows.Forms.Panel();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.BtnCambiarIdioma = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnlineUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.btnRestablecer);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.BtnActualizar);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Location = new System.Drawing.Point(29, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 205);
            this.panel1.TabIndex = 73;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnRestablecer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRestablecer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnRestablecer.FlatAppearance.BorderSize = 2;
            this.btnRestablecer.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnRestablecer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRestablecer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.btnRestablecer.Location = new System.Drawing.Point(90, 148);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(111, 48);
            this.btnRestablecer.TabIndex = 20;
            this.btnRestablecer.Text = "Restablecer Contraseña";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.btnLimpiar.Location = new System.Drawing.Point(154, 24);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 53);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 2;
            this.BtnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.BtnEliminar.Location = new System.Drawing.Point(154, 90);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(111, 48);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "Eliminar Usuario";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.BtnActualizar.FlatAppearance.BorderSize = 2;
            this.BtnActualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.BtnActualizar.Location = new System.Drawing.Point(22, 90);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(111, 48);
            this.BtnActualizar.TabIndex = 17;
            this.BtnActualizar.Text = "Modificar Usuario";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnAgregar.Enabled = false;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.BtnAgregar.FlatAppearance.BorderSize = 2;
            this.BtnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.BtnAgregar.Location = new System.Drawing.Point(22, 26);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(111, 49);
            this.BtnAgregar.TabIndex = 15;
            this.BtnAgregar.Text = "Agregar Usuario";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.btnAñadirImg);
            this.panel2.Controls.Add(this.userImg);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbCargo);
            this.panel2.Controls.Add(this.lblCargo);
            this.panel2.Controls.Add(this.lblCorreo);
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.lblNombreUsuario);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.cmbEmpleado);
            this.panel2.Controls.Add(this.lblEmpleado);
            this.panel2.Location = new System.Drawing.Point(319, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 205);
            this.panel2.TabIndex = 74;
            // 
            // btnAñadirImg
            // 
            this.btnAñadirImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnAñadirImg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAñadirImg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.btnAñadirImg.FlatAppearance.BorderSize = 2;
            this.btnAñadirImg.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAñadirImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAñadirImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.btnAñadirImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirImg.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.btnAñadirImg.Location = new System.Drawing.Point(573, 154);
            this.btnAñadirImg.Name = "btnAñadirImg";
            this.btnAñadirImg.Size = new System.Drawing.Size(121, 34);
            this.btnAñadirImg.TabIndex = 20;
            this.btnAñadirImg.Text = "Añadir Imagen";
            this.btnAñadirImg.UseVisualStyleBackColor = false;
            this.btnAñadirImg.Click += new System.EventHandler(this.button2_Click);
            // 
            // userImg
            // 
            this.userImg.Location = new System.Drawing.Point(563, 51);
            this.userImg.Name = "userImg";
            this.userImg.Size = new System.Drawing.Size(131, 93);
            this.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImg.TabIndex = 72;
            this.userImg.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(588, 16);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(42, 24);
            this.txtId.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.label7.Location = new System.Drawing.Point(559, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 68;
            this.label7.Text = "ID";
            // 
            // cmbCargo
            // 
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(38, 115);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(232, 26);
            this.cmbCargo.TabIndex = 66;
            this.cmbCargo.SelectedIndexChanged += new System.EventHandler(this.cmbCargo_SelectedIndexChanged);
            this.cmbCargo.Click += new System.EventHandler(this.cmbCargo_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.lblCargo.Location = new System.Drawing.Point(34, 95);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(48, 20);
            this.lblCargo.TabIndex = 65;
            this.lblCargo.Text = "Cargo";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.lblCorreo.Location = new System.Drawing.Point(312, 94);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(139, 20);
            this.lblCorreo.TabIndex = 64;
            this.lblCorreo.Text = "Correo Electrónico";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(316, 115);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ShortcutsEnabled = false;
            this.txtCorreo.Size = new System.Drawing.Size(202, 24);
            this.txtCorreo.TabIndex = 63;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(34, 41);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(143, 20);
            this.lblNombreUsuario.TabIndex = 50;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(34, 63);
            this.txtUser.MaxLength = 50;
            this.txtUser.Name = "txtUser";
            this.txtUser.ShortcutsEnabled = false;
            this.txtUser.Size = new System.Drawing.Size(236, 24);
            this.txtUser.TabIndex = 45;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(316, 62);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(202, 26);
            this.cmbEmpleado.TabIndex = 22;
            this.cmbEmpleado.Click += new System.EventHandler(this.cmbEmpleado_Click);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.lblEmpleado.Location = new System.Drawing.Point(312, 41);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(78, 20);
            this.lblEmpleado.TabIndex = 21;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.BackColor = System.Drawing.Color.White;
            this.lblUsuarios.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.lblUsuarios.Location = new System.Drawing.Point(317, 329);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(154, 43);
            this.lblUsuarios.TabIndex = 72;
            this.lblUsuarios.Text = "Usuarios";
            this.lblUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(325, 375);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(666, 187);
            this.dgvUsuarios.TabIndex = 71;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1046, 609);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblAcciones
            // 
            this.lblAcciones.AutoSize = true;
            this.lblAcciones.BackColor = System.Drawing.Color.White;
            this.lblAcciones.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.lblAcciones.Location = new System.Drawing.Point(28, 64);
            this.lblAcciones.Name = "lblAcciones";
            this.lblAcciones.Size = new System.Drawing.Size(159, 43);
            this.lblAcciones.TabIndex = 77;
            this.lblAcciones.Text = "Acciones";
            this.lblAcciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvOnlineUsers
            // 
            this.dgvOnlineUsers.AllowUserToAddRows = false;
            this.dgvOnlineUsers.AllowUserToDeleteRows = false;
            this.dgvOnlineUsers.AllowUserToResizeColumns = false;
            this.dgvOnlineUsers.AllowUserToResizeRows = false;
            this.dgvOnlineUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOnlineUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.dgvOnlineUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOnlineUsers.Location = new System.Drawing.Point(29, 375);
            this.dgvOnlineUsers.Name = "dgvOnlineUsers";
            this.dgvOnlineUsers.ReadOnly = true;
            this.dgvOnlineUsers.Size = new System.Drawing.Size(284, 187);
            this.dgvOnlineUsers.TabIndex = 78;
            // 
            // lblConectados
            // 
            this.lblConectados.AutoSize = true;
            this.lblConectados.BackColor = System.Drawing.Color.White;
            this.lblConectados.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.lblConectados.Location = new System.Drawing.Point(22, 330);
            this.lblConectados.Name = "lblConectados";
            this.lblConectados.Size = new System.Drawing.Size(201, 43);
            this.lblConectados.TabIndex = 79;
            this.lblConectados.Text = "Conectados";
            this.lblConectados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblConectados.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(218, 334);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 80;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(477, 334);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 81;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 576);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1046, 33);
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.panelBar.Controls.Add(this.bunifuImageButton5);
            this.panelBar.Controls.Add(this.bunifuImageButton3);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(1046, 53);
            this.panelBar.TabIndex = 130;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(966, 9);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(25, 33);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 98;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(997, 9);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(27, 33);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 96;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(860, 319);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(131, 50);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 73;
            this.pbImage.TabStop = false;
            this.pbImage.Visible = false;
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(813, 70);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(208, 26);
            this.cmbIdioma.TabIndex = 187;
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
            this.BtnCambiarIdioma.Location = new System.Drawing.Point(635, 67);
            this.BtnCambiarIdioma.Name = "BtnCambiarIdioma";
            this.BtnCambiarIdioma.Size = new System.Drawing.Size(172, 30);
            this.BtnCambiarIdioma.TabIndex = 188;
            this.BtnCambiarIdioma.Text = "Seleccionar Idioma:";
            this.BtnCambiarIdioma.UseVisualStyleBackColor = false;
            this.BtnCambiarIdioma.Click += new System.EventHandler(this.BtnCambiarIdioma_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 609);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.BtnCambiarIdioma);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblConectados);
            this.Controls.Add(this.dgvOnlineUsers);
            this.Controls.Add(this.lblAcciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnlineUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblAcciones;
        private System.Windows.Forms.DataGridView dgvOnlineUsers;
        private System.Windows.Forms.Label lblConectados;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.PictureBox userImg;
        private System.Windows.Forms.Button btnAñadirImg;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel txtActiveUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel txtCargoStrip;
        private System.Windows.Forms.ToolStripButton btnLogOut;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelBar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Button BtnCambiarIdioma;
    }
}