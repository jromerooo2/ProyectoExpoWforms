namespace SistemGestionBuses
{
    partial class frmPin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPin));
            this.btnNueva = new System.Windows.Forms.Button();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblIngresoCodigo = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDUICo = new System.Windows.Forms.Label();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.btnIdentidad = new System.Windows.Forms.Button();
            this.lblUsuariorecuperar = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.CardValidacion = new Bunifu.Framework.UI.BunifuCards();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.lblNitCo = new System.Windows.Forms.Label();
            this.panelBar = new System.Windows.Forms.Panel();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.BtnCambiarIdioma = new System.Windows.Forms.Button();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.ElipseMain = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.txtConfirmacionNueva = new System.Windows.Forms.TextBox();
            this.btnVerContra2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnVerContra1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.CardPIN = new Bunifu.Framework.UI.BunifuCards();
            this.DragControlMain = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.nfConfirmacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.CardValidacion.SuspendLayout();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerContra2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerContra1)).BeginInit();
            this.CardPIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNueva
            // 
            this.btnNueva.BackColor = System.Drawing.Color.Black;
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNueva.Location = new System.Drawing.Point(111, 351);
            this.btnNueva.Margin = new System.Windows.Forms.Padding(2);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(152, 51);
            this.btnNueva.TabIndex = 35;
            this.btnNueva.Text = "Confirmar";
            this.btnNueva.UseVisualStyleBackColor = false;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click_1);
            // 
            // txtNueva
            // 
            this.txtNueva.Location = new System.Drawing.Point(54, 223);
            this.txtNueva.Margin = new System.Windows.Forms.Padding(2);
            this.txtNueva.MaxLength = 50;
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.Size = new System.Drawing.Size(267, 20);
            this.txtNueva.TabIndex = 34;
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevaContraseña.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNuevaContraseña.Location = new System.Drawing.Point(71, 175);
            this.lblNuevaContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(233, 28);
            this.lblNuevaContraseña.TabIndex = 33;
            this.lblNuevaContraseña.Text = "Nueva contraseña:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Black;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.Location = new System.Drawing.Point(111, 97);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(152, 51);
            this.btnConfirmar.TabIndex = 32;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblIngresoCodigo
            // 
            this.lblIngresoCodigo.AutoSize = true;
            this.lblIngresoCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblIngresoCodigo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIngresoCodigo.Location = new System.Drawing.Point(16, 19);
            this.lblIngresoCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngresoCodigo.Name = "lblIngresoCodigo";
            this.lblIngresoCodigo.Size = new System.Drawing.Size(342, 28);
            this.lblIngresoCodigo.TabIndex = 31;
            this.lblIngresoCodigo.Text = "Ingresa el PIN de seguridad:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(54, 63);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.MaxLength = 15;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(267, 20);
            this.txtCode.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(222, -273);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Recupera tu cuenta";
            // 
            // lblDUICo
            // 
            this.lblDUICo.AutoSize = true;
            this.lblDUICo.BackColor = System.Drawing.Color.Transparent;
            this.lblDUICo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUICo.ForeColor = System.Drawing.Color.White;
            this.lblDUICo.Location = new System.Drawing.Point(36, 259);
            this.lblDUICo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDUICo.Name = "lblDUICo";
            this.lblDUICo.Size = new System.Drawing.Size(363, 28);
            this.lblDUICo.TabIndex = 37;
            this.lblDUICo.Text = "Ingresa el DUI correspodiente:";
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(105, 305);
            this.txtDUI.Margin = new System.Windows.Forms.Padding(2);
            this.txtDUI.MaxLength = 50;
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(224, 20);
            this.txtDUI.TabIndex = 3;
            // 
            // btnIdentidad
            // 
            this.btnIdentidad.BackColor = System.Drawing.Color.Black;
            this.btnIdentidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIdentidad.Location = new System.Drawing.Point(143, 353);
            this.btnIdentidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnIdentidad.Name = "btnIdentidad";
            this.btnIdentidad.Size = new System.Drawing.Size(152, 51);
            this.btnIdentidad.TabIndex = 38;
            this.btnIdentidad.Text = "Confirmar Identidad";
            this.btnIdentidad.UseVisualStyleBackColor = false;
            this.btnIdentidad.Click += new System.EventHandler(this.btnDUI_Click);
            // 
            // lblUsuariorecuperar
            // 
            this.lblUsuariorecuperar.AutoSize = true;
            this.lblUsuariorecuperar.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuariorecuperar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariorecuperar.ForeColor = System.Drawing.Color.White;
            this.lblUsuariorecuperar.Location = new System.Drawing.Point(29, 22);
            this.lblUsuariorecuperar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuariorecuperar.Name = "lblUsuariorecuperar";
            this.lblUsuariorecuperar.Size = new System.Drawing.Size(370, 28);
            this.lblUsuariorecuperar.TabIndex = 39;
            this.lblUsuariorecuperar.Text = "Ingresa el usuario a recuperar:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(105, 74);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.MaxLength = 50;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(224, 20);
            this.txtUser.TabIndex = 40;
            // 
            // CardValidacion
            // 
            this.CardValidacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.CardValidacion.BorderRadius = 5;
            this.CardValidacion.BottomSahddow = true;
            this.CardValidacion.color = System.Drawing.Color.Maroon;
            this.CardValidacion.Controls.Add(this.txtNIT);
            this.CardValidacion.Controls.Add(this.btnIdentidad);
            this.CardValidacion.Controls.Add(this.txtUser);
            this.CardValidacion.Controls.Add(this.lblUsuariorecuperar);
            this.CardValidacion.Controls.Add(this.txtDUI);
            this.CardValidacion.Controls.Add(this.lblDUICo);
            this.CardValidacion.Controls.Add(this.lblNitCo);
            this.CardValidacion.LeftSahddow = false;
            this.CardValidacion.Location = new System.Drawing.Point(0, 42);
            this.CardValidacion.Name = "CardValidacion";
            this.CardValidacion.RightSahddow = true;
            this.CardValidacion.ShadowDepth = 20;
            this.CardValidacion.Size = new System.Drawing.Size(427, 464);
            this.CardValidacion.TabIndex = 42;
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(105, 187);
            this.txtNIT.Margin = new System.Windows.Forms.Padding(2);
            this.txtNIT.MaxLength = 50;
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(224, 20);
            this.txtNIT.TabIndex = 44;
            // 
            // lblNitCo
            // 
            this.lblNitCo.AutoSize = true;
            this.lblNitCo.BackColor = System.Drawing.Color.Transparent;
            this.lblNitCo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNitCo.ForeColor = System.Drawing.Color.White;
            this.lblNitCo.Location = new System.Drawing.Point(13, 141);
            this.lblNitCo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNitCo.Name = "lblNitCo";
            this.lblNitCo.Size = new System.Drawing.Size(387, 28);
            this.lblNitCo.TabIndex = 43;
            this.lblNitCo.Text = "  Ingresa el NIT correspondiente:";
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.panelBar.Controls.Add(this.cmbIdioma);
            this.panelBar.Controls.Add(this.BtnCambiarIdioma);
            this.panelBar.Controls.Add(this.bunifuImageButton5);
            this.panelBar.Controls.Add(this.bunifuImageButton3);
            this.panelBar.Controls.Add(this.bunifuImageButton1);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(812, 49);
            this.panelBar.TabIndex = 95;
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(274, 12);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(208, 26);
            this.cmbIdioma.TabIndex = 179;
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
            this.BtnCambiarIdioma.Location = new System.Drawing.Point(96, 8);
            this.BtnCambiarIdioma.Name = "BtnCambiarIdioma";
            this.BtnCambiarIdioma.Size = new System.Drawing.Size(172, 30);
            this.BtnCambiarIdioma.TabIndex = 180;
            this.BtnCambiarIdioma.Text = "Seleccionar Idioma:";
            this.BtnCambiarIdioma.UseVisualStyleBackColor = false;
            this.BtnCambiarIdioma.Click += new System.EventHandler(this.BtnCambiarIdioma_Click);
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(732, 11);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(25, 30);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 98;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(763, 9);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(27, 30);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 96;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
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
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 29);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 94;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // ElipseMain
            // 
            this.ElipseMain.ElipseRadius = 5;
            this.ElipseMain.TargetControl = this;
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmarContraseña.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(51, 257);
            this.lblConfirmarContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(273, 28);
            this.lblConfirmarContraseña.TabIndex = 96;
            this.lblConfirmarContraseña.Text = "Confirmar contraseña:";
            // 
            // txtConfirmacionNueva
            // 
            this.txtConfirmacionNueva.Location = new System.Drawing.Point(54, 303);
            this.txtConfirmacionNueva.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmacionNueva.MaxLength = 50;
            this.txtConfirmacionNueva.Name = "txtConfirmacionNueva";
            this.txtConfirmacionNueva.Size = new System.Drawing.Size(267, 20);
            this.txtConfirmacionNueva.TabIndex = 97;
            // 
            // btnVerContra2
            // 
            this.btnVerContra2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerContra2.BackColor = System.Drawing.Color.Transparent;
            this.btnVerContra2.Image = ((System.Drawing.Image)(resources.GetObject("btnVerContra2.Image")));
            this.btnVerContra2.ImageActive = null;
            this.btnVerContra2.Location = new System.Drawing.Point(326, 302);
            this.btnVerContra2.Name = "btnVerContra2";
            this.btnVerContra2.Size = new System.Drawing.Size(25, 28);
            this.btnVerContra2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVerContra2.TabIndex = 102;
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
            this.btnVerContra1.Location = new System.Drawing.Point(326, 223);
            this.btnVerContra1.Name = "btnVerContra1";
            this.btnVerContra1.Size = new System.Drawing.Size(25, 28);
            this.btnVerContra1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVerContra1.TabIndex = 101;
            this.btnVerContra1.TabStop = false;
            this.btnVerContra1.Zoom = 10;
            this.btnVerContra1.Click += new System.EventHandler(this.btnVerContra1_Click);
            // 
            // CardPIN
            // 
            this.CardPIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.CardPIN.BorderRadius = 5;
            this.CardPIN.BottomSahddow = true;
            this.CardPIN.color = System.Drawing.Color.Black;
            this.CardPIN.Controls.Add(this.btnVerContra2);
            this.CardPIN.Controls.Add(this.btnVerContra1);
            this.CardPIN.Controls.Add(this.txtConfirmacionNueva);
            this.CardPIN.Controls.Add(this.btnNueva);
            this.CardPIN.Controls.Add(this.lblConfirmarContraseña);
            this.CardPIN.Controls.Add(this.btnConfirmar);
            this.CardPIN.Controls.Add(this.lblIngresoCodigo);
            this.CardPIN.Controls.Add(this.txtCode);
            this.CardPIN.Controls.Add(this.txtNueva);
            this.CardPIN.Controls.Add(this.lblNuevaContraseña);
            this.CardPIN.LeftSahddow = false;
            this.CardPIN.Location = new System.Drawing.Point(432, 45);
            this.CardPIN.Name = "CardPIN";
            this.CardPIN.RightSahddow = true;
            this.CardPIN.ShadowDepth = 20;
            this.CardPIN.Size = new System.Drawing.Size(380, 461);
            this.CardPIN.TabIndex = 103;
            // 
            // DragControlMain
            // 
            this.DragControlMain.Fixed = true;
            this.DragControlMain.Horizontal = true;
            this.DragControlMain.TargetControl = this.panelBar;
            this.DragControlMain.Vertical = true;
            // 
            // nfConfirmacion
            // 
            this.nfConfirmacion.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nfConfirmacion.Icon = ((System.Drawing.Icon)(resources.GetObject("nfConfirmacion.Icon")));
            this.nfConfirmacion.Text = "Confirmación";
            this.nfConfirmacion.Visible = true;
            // 
            // frmPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 504);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardValidacion);
            this.Controls.Add(this.CardPIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPin";
            this.Text = "frmPin";
            this.Load += new System.EventHandler(this.frmPin_Load);
            this.CardValidacion.ResumeLayout(false);
            this.CardValidacion.PerformLayout();
            this.panelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerContra2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerContra1)).EndInit();
            this.CardPIN.ResumeLayout(false);
            this.CardPIN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblIngresoCodigo;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDUICo;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Button btnIdentidad;
        private System.Windows.Forms.Label lblUsuariorecuperar;
        private System.Windows.Forms.TextBox txtUser;
        private Bunifu.Framework.UI.BunifuCards CardValidacion;
        private System.Windows.Forms.Panel panelBar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuElipse ElipseMain;
        private System.Windows.Forms.TextBox txtConfirmacionNueva;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private Bunifu.Framework.UI.BunifuImageButton btnVerContra2;
        private Bunifu.Framework.UI.BunifuImageButton btnVerContra1;
        private Bunifu.Framework.UI.BunifuCards CardPIN;
        private Bunifu.Framework.UI.BunifuDragControl DragControlMain;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.Label lblNitCo;
        private System.Windows.Forms.NotifyIcon nfConfirmacion;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Button BtnCambiarIdioma;
    }
}