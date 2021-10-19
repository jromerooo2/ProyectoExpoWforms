namespace SistemGestionBuses
{
    partial class frmRecuperarAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperarAdmin));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelBar = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.ElipsePrincipal = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CardAdmin = new Bunifu.Framework.UI.BunifuCards();
            this.btnConfirmarAdmin = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCredencialesAdmin = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtClaveAdmin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRecuperatucuenta = new System.Windows.Forms.Label();
            this.txtUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.CardUsuario = new Bunifu.Framework.UI.BunifuCards();
            this.btnVerContra2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnVerContra1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblConfirmaciónContraseña = new System.Windows.Forms.Label();
            this.txtConfirmacionContra = new System.Windows.Forms.TextBox();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.txtUsuarioRecu = new System.Windows.Forms.TextBox();
            this.btnNuevaContrasena = new System.Windows.Forms.Button();
            this.lblUsuario2 = new System.Windows.Forms.Label();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.btnConfirmarUsuario = new System.Windows.Forms.Button();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.lblDUIEmpleado = new System.Windows.Forms.Label();
            this.lblDatosdeCuenta = new System.Windows.Forms.Label();
            this.lblRenovarContraseña = new System.Windows.Forms.Label();
            this.nfConfirmacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.DragControlMain = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.BtnCambiarIdioma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.CardAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CardUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerContra2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerContra1)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 27);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 94;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(756, 8);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(25, 28);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 98;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // panelBar
            // 
            this.panelBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.panelBar.Controls.Add(this.cmbIdioma);
            this.panelBar.Controls.Add(this.bunifuImageButton5);
            this.panelBar.Controls.Add(this.BtnCambiarIdioma);
            this.panelBar.Controls.Add(this.bunifuImageButton3);
            this.panelBar.Controls.Add(this.bunifuImageButton1);
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(847, 47);
            this.panelBar.TabIndex = 94;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(798, 9);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(27, 28);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 96;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // ElipsePrincipal
            // 
            this.ElipsePrincipal.ElipseRadius = 5;
            this.ElipsePrincipal.TargetControl = this;
            // 
            // CardAdmin
            // 
            this.CardAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CardAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.CardAdmin.BorderRadius = 5;
            this.CardAdmin.BottomSahddow = true;
            this.CardAdmin.color = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.CardAdmin.Controls.Add(this.btnConfirmarAdmin);
            this.CardAdmin.Controls.Add(this.lblUsuario);
            this.CardAdmin.Controls.Add(this.lblCredencialesAdmin);
            this.CardAdmin.Controls.Add(this.lblContraseña);
            this.CardAdmin.Controls.Add(this.txtClaveAdmin);
            this.CardAdmin.Controls.Add(this.pictureBox1);
            this.CardAdmin.Controls.Add(this.lblRecuperatucuenta);
            this.CardAdmin.Controls.Add(this.txtUsuarioAdmin);
            this.CardAdmin.LeftSahddow = false;
            this.CardAdmin.Location = new System.Drawing.Point(0, 42);
            this.CardAdmin.Name = "CardAdmin";
            this.CardAdmin.RightSahddow = true;
            this.CardAdmin.ShadowDepth = 20;
            this.CardAdmin.Size = new System.Drawing.Size(388, 532);
            this.CardAdmin.TabIndex = 50;
            // 
            // btnConfirmarAdmin
            // 
            this.btnConfirmarAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnConfirmarAdmin.BackColor = System.Drawing.Color.Black;
            this.btnConfirmarAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarAdmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmarAdmin.Location = new System.Drawing.Point(143, 375);
            this.btnConfirmarAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmarAdmin.Name = "btnConfirmarAdmin";
            this.btnConfirmarAdmin.Size = new System.Drawing.Size(119, 51);
            this.btnConfirmarAdmin.TabIndex = 32;
            this.btnConfirmarAdmin.Text = "Confirmar";
            this.btnConfirmarAdmin.UseVisualStyleBackColor = false;
            this.btnConfirmarAdmin.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(158, 241);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(69, 19);
            this.lblUsuario.TabIndex = 38;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblCredencialesAdmin
            // 
            this.lblCredencialesAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCredencialesAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.lblCredencialesAdmin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredencialesAdmin.ForeColor = System.Drawing.Color.White;
            this.lblCredencialesAdmin.Location = new System.Drawing.Point(29, 149);
            this.lblCredencialesAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCredencialesAdmin.Name = "lblCredencialesAdmin";
            this.lblCredencialesAdmin.Size = new System.Drawing.Size(329, 76);
            this.lblCredencialesAdmin.TabIndex = 31;
            this.lblCredencialesAdmin.Text = "Ingresa las creedenciales del Administrador";
            this.lblCredencialesAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(139, 303);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(102, 19);
            this.lblContraseña.TabIndex = 37;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtClaveAdmin
            // 
            this.txtClaveAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtClaveAdmin.Location = new System.Drawing.Point(75, 324);
            this.txtClaveAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtClaveAdmin.MaxLength = 50;
            this.txtClaveAdmin.Name = "txtClaveAdmin";
            this.txtClaveAdmin.Size = new System.Drawing.Size(246, 20);
            this.txtClaveAdmin.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // lblRecuperatucuenta
            // 
            this.lblRecuperatucuenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecuperatucuenta.AutoSize = true;
            this.lblRecuperatucuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.lblRecuperatucuenta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperatucuenta.ForeColor = System.Drawing.Color.White;
            this.lblRecuperatucuenta.Location = new System.Drawing.Point(70, 23);
            this.lblRecuperatucuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecuperatucuenta.Name = "lblRecuperatucuenta";
            this.lblRecuperatucuenta.Size = new System.Drawing.Size(241, 28);
            this.lblRecuperatucuenta.TabIndex = 24;
            this.lblRecuperatucuenta.Text = "Recupera tu cuenta";
            // 
            // txtUsuarioAdmin
            // 
            this.txtUsuarioAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuarioAdmin.Location = new System.Drawing.Point(75, 273);
            this.txtUsuarioAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioAdmin.MaxLength = 50;
            this.txtUsuarioAdmin.Name = "txtUsuarioAdmin";
            this.txtUsuarioAdmin.Size = new System.Drawing.Size(246, 20);
            this.txtUsuarioAdmin.TabIndex = 30;
            // 
            // CardUsuario
            // 
            this.CardUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.CardUsuario.BorderRadius = 5;
            this.CardUsuario.BottomSahddow = true;
            this.CardUsuario.color = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.CardUsuario.Controls.Add(this.btnVerContra2);
            this.CardUsuario.Controls.Add(this.btnVerContra1);
            this.CardUsuario.Controls.Add(this.lblConfirmaciónContraseña);
            this.CardUsuario.Controls.Add(this.txtConfirmacionContra);
            this.CardUsuario.Controls.Add(this.lblNuevaContraseña);
            this.CardUsuario.Controls.Add(this.txtUsuarioRecu);
            this.CardUsuario.Controls.Add(this.btnNuevaContrasena);
            this.CardUsuario.Controls.Add(this.lblUsuario2);
            this.CardUsuario.Controls.Add(this.txtDUI);
            this.CardUsuario.Controls.Add(this.btnConfirmarUsuario);
            this.CardUsuario.Controls.Add(this.txtNueva);
            this.CardUsuario.Controls.Add(this.lblDUIEmpleado);
            this.CardUsuario.Controls.Add(this.lblDatosdeCuenta);
            this.CardUsuario.Controls.Add(this.lblRenovarContraseña);
            this.CardUsuario.ForeColor = System.Drawing.Color.Black;
            this.CardUsuario.LeftSahddow = false;
            this.CardUsuario.Location = new System.Drawing.Point(409, 42);
            this.CardUsuario.Name = "CardUsuario";
            this.CardUsuario.RightSahddow = true;
            this.CardUsuario.ShadowDepth = 20;
            this.CardUsuario.Size = new System.Drawing.Size(438, 535);
            this.CardUsuario.TabIndex = 49;
            // 
            // btnVerContra2
            // 
            this.btnVerContra2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerContra2.BackColor = System.Drawing.Color.Transparent;
            this.btnVerContra2.Image = ((System.Drawing.Image)(resources.GetObject("btnVerContra2.Image")));
            this.btnVerContra2.ImageActive = null;
            this.btnVerContra2.Location = new System.Drawing.Point(347, 392);
            this.btnVerContra2.Name = "btnVerContra2";
            this.btnVerContra2.Size = new System.Drawing.Size(25, 28);
            this.btnVerContra2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVerContra2.TabIndex = 100;
            this.btnVerContra2.TabStop = false;
            this.btnVerContra2.Zoom = 10;
            this.btnVerContra2.Click += new System.EventHandler(this.btnVerContra2_Click);
            // 
            // btnVerContra1
            // 
            this.btnVerContra1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerContra1.BackColor = System.Drawing.Color.Transparent;
            this.btnVerContra1.Image = ((System.Drawing.Image)(resources.GetObject("btnVerContra1.Image")));
            this.btnVerContra1.ImageActive = null;
            this.btnVerContra1.Location = new System.Drawing.Point(347, 328);
            this.btnVerContra1.Name = "btnVerContra1";
            this.btnVerContra1.Size = new System.Drawing.Size(25, 28);
            this.btnVerContra1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVerContra1.TabIndex = 99;
            this.btnVerContra1.TabStop = false;
            this.btnVerContra1.Zoom = 10;
            this.btnVerContra1.Click += new System.EventHandler(this.btnVerContra1_Click);
            // 
            // lblConfirmaciónContraseña
            // 
            this.lblConfirmaciónContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfirmaciónContraseña.AutoSize = true;
            this.lblConfirmaciónContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.lblConfirmaciónContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmaciónContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmaciónContraseña.Location = new System.Drawing.Point(106, 380);
            this.lblConfirmaciónContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmaciónContraseña.Name = "lblConfirmaciónContraseña";
            this.lblConfirmaciónContraseña.Size = new System.Drawing.Size(235, 19);
            this.lblConfirmaciónContraseña.TabIndex = 47;
            this.lblConfirmaciónContraseña.Text = "Confirmación de contraseña:";
            // 
            // txtConfirmacionContra
            // 
            this.txtConfirmacionContra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmacionContra.Location = new System.Drawing.Point(110, 401);
            this.txtConfirmacionContra.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmacionContra.MaxLength = 50;
            this.txtConfirmacionContra.Name = "txtConfirmacionContra";
            this.txtConfirmacionContra.Size = new System.Drawing.Size(224, 20);
            this.txtConfirmacionContra.TabIndex = 46;
            this.txtConfirmacionContra.UseSystemPasswordChar = true;
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.lblNuevaContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblNuevaContraseña.Location = new System.Drawing.Point(114, 315);
            this.lblNuevaContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(156, 19);
            this.lblNuevaContraseña.TabIndex = 45;
            this.lblNuevaContraseña.Text = "Nueva contraseña:";
            // 
            // txtUsuarioRecu
            // 
            this.txtUsuarioRecu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuarioRecu.Location = new System.Drawing.Point(110, 103);
            this.txtUsuarioRecu.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioRecu.MaxLength = 50;
            this.txtUsuarioRecu.Name = "txtUsuarioRecu";
            this.txtUsuarioRecu.Size = new System.Drawing.Size(224, 20);
            this.txtUsuarioRecu.TabIndex = 34;
            // 
            // btnNuevaContrasena
            // 
            this.btnNuevaContrasena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevaContrasena.BackColor = System.Drawing.Color.Black;
            this.btnNuevaContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaContrasena.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaContrasena.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevaContrasena.Location = new System.Drawing.Point(161, 446);
            this.btnNuevaContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevaContrasena.Name = "btnNuevaContrasena";
            this.btnNuevaContrasena.Size = new System.Drawing.Size(109, 51);
            this.btnNuevaContrasena.TabIndex = 44;
            this.btnNuevaContrasena.Text = "Confirmar";
            this.btnNuevaContrasena.UseVisualStyleBackColor = false;
            this.btnNuevaContrasena.Click += new System.EventHandler(this.btnNuevaContrasena_Click);
            // 
            // lblUsuario2
            // 
            this.lblUsuario2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario2.AutoSize = true;
            this.lblUsuario2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.lblUsuario2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario2.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario2.Location = new System.Drawing.Point(106, 82);
            this.lblUsuario2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario2.Name = "lblUsuario2";
            this.lblUsuario2.Size = new System.Drawing.Size(69, 19);
            this.lblUsuario2.TabIndex = 39;
            this.lblUsuario2.Text = "Usuario:";
            // 
            // txtDUI
            // 
            this.txtDUI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDUI.Location = new System.Drawing.Point(110, 155);
            this.txtDUI.Margin = new System.Windows.Forms.Padding(2);
            this.txtDUI.MaxLength = 15;
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(224, 20);
            this.txtDUI.TabIndex = 40;
            // 
            // btnConfirmarUsuario
            // 
            this.btnConfirmarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmarUsuario.BackColor = System.Drawing.Color.Black;
            this.btnConfirmarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarUsuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmarUsuario.Location = new System.Drawing.Point(161, 192);
            this.btnConfirmarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmarUsuario.Name = "btnConfirmarUsuario";
            this.btnConfirmarUsuario.Size = new System.Drawing.Size(109, 51);
            this.btnConfirmarUsuario.TabIndex = 35;
            this.btnConfirmarUsuario.Text = "Confirmar";
            this.btnConfirmarUsuario.UseVisualStyleBackColor = false;
            this.btnConfirmarUsuario.Click += new System.EventHandler(this.btnConfirmarUsuario_Click);
            // 
            // txtNueva
            // 
            this.txtNueva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNueva.Location = new System.Drawing.Point(110, 336);
            this.txtNueva.Margin = new System.Windows.Forms.Padding(2);
            this.txtNueva.MaxLength = 50;
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.Size = new System.Drawing.Size(224, 20);
            this.txtNueva.TabIndex = 43;
            this.txtNueva.UseSystemPasswordChar = true;
            // 
            // lblDUIEmpleado
            // 
            this.lblDUIEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDUIEmpleado.AutoSize = true;
            this.lblDUIEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.lblDUIEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUIEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblDUIEmpleado.Location = new System.Drawing.Point(106, 134);
            this.lblDUIEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDUIEmpleado.Name = "lblDUIEmpleado";
            this.lblDUIEmpleado.Size = new System.Drawing.Size(152, 19);
            this.lblDUIEmpleado.TabIndex = 41;
            this.lblDUIEmpleado.Text = "DUI del Empleado:";
            this.lblDUIEmpleado.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblDatosdeCuenta
            // 
            this.lblDatosdeCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatosdeCuenta.AutoSize = true;
            this.lblDatosdeCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.lblDatosdeCuenta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosdeCuenta.ForeColor = System.Drawing.Color.Black;
            this.lblDatosdeCuenta.Location = new System.Drawing.Point(20, 40);
            this.lblDatosdeCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosdeCuenta.Name = "lblDatosdeCuenta";
            this.lblDatosdeCuenta.Size = new System.Drawing.Size(385, 28);
            this.lblDatosdeCuenta.TabIndex = 33;
            this.lblDatosdeCuenta.Text = "Datos de la cuenta a recuperar:";
            // 
            // lblRenovarContraseña
            // 
            this.lblRenovarContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRenovarContraseña.AutoSize = true;
            this.lblRenovarContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.lblRenovarContraseña.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenovarContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblRenovarContraseña.Location = new System.Drawing.Point(20, 259);
            this.lblRenovarContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRenovarContraseña.Name = "lblRenovarContraseña";
            this.lblRenovarContraseña.Size = new System.Drawing.Size(287, 28);
            this.lblRenovarContraseña.TabIndex = 42;
            this.lblRenovarContraseña.Text = "Renueva la contraseña:";
            // 
            // nfConfirmacion
            // 
            this.nfConfirmacion.Text = "notifyIcon1";
            this.nfConfirmacion.Visible = true;
            // 
            // DragControlMain
            // 
            this.DragControlMain.Fixed = true;
            this.DragControlMain.Horizontal = true;
            this.DragControlMain.TargetControl = this.panelBar;
            this.DragControlMain.Vertical = true;
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(253, 10);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(208, 26);
            this.cmbIdioma.TabIndex = 183;
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
            this.BtnCambiarIdioma.Location = new System.Drawing.Point(75, 7);
            this.BtnCambiarIdioma.Name = "BtnCambiarIdioma";
            this.BtnCambiarIdioma.Size = new System.Drawing.Size(172, 30);
            this.BtnCambiarIdioma.TabIndex = 184;
            this.BtnCambiarIdioma.Text = "Seleccionar Idioma:";
            this.BtnCambiarIdioma.UseVisualStyleBackColor = false;
            this.BtnCambiarIdioma.Click += new System.EventHandler(this.BtnCambiarIdioma_Click);
            // 
            // frmRecuperarAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 561);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.CardUsuario);
            this.Controls.Add(this.CardAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecuperarAdmin";
            this.Text = "frmRecuperarAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            this.panelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.CardAdmin.ResumeLayout(false);
            this.CardAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CardUsuario.ResumeLayout(false);
            this.CardUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerContra2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerContra1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private System.Windows.Forms.Panel panelBar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuElipse ElipsePrincipal;
        private Bunifu.Framework.UI.BunifuCards CardUsuario;
        private System.Windows.Forms.Label lblConfirmaciónContraseña;
        private System.Windows.Forms.TextBox txtConfirmacionContra;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.TextBox txtUsuarioRecu;
        private System.Windows.Forms.Button btnNuevaContrasena;
        private System.Windows.Forms.Label lblUsuario2;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Button btnConfirmarUsuario;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Label lblDUIEmpleado;
        private System.Windows.Forms.Label lblDatosdeCuenta;
        private System.Windows.Forms.Label lblRenovarContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtClaveAdmin;
        private System.Windows.Forms.Button btnConfirmarAdmin;
        private System.Windows.Forms.Label lblCredencialesAdmin;
        private System.Windows.Forms.TextBox txtUsuarioAdmin;
        private Bunifu.Framework.UI.BunifuCards CardAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRecuperatucuenta;
        private Bunifu.Framework.UI.BunifuImageButton btnVerContra2;
        private Bunifu.Framework.UI.BunifuImageButton btnVerContra1;
        private System.Windows.Forms.NotifyIcon nfConfirmacion;
        private Bunifu.Framework.UI.BunifuDragControl DragControlMain;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Button BtnCambiarIdioma;
    }
}