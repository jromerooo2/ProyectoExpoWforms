namespace SistemGestionBuses
{
    partial class frmRecuperar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperar));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMetodo2 = new System.Windows.Forms.Button();
            this.btnMetodo1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblIngresoCodigo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblNuevaContra = new System.Windows.Forms.Label();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnRecuPIN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(667, 618);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(279, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnMetodo2
            // 
            this.btnMetodo2.BackColor = System.Drawing.Color.Black;
            this.btnMetodo2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMetodo2.Location = new System.Drawing.Point(279, 227);
            this.btnMetodo2.Margin = new System.Windows.Forms.Padding(2);
            this.btnMetodo2.Name = "btnMetodo2";
            this.btnMetodo2.Size = new System.Drawing.Size(109, 51);
            this.btnMetodo2.TabIndex = 14;
            this.btnMetodo2.Text = "Contacta al Administrador";
            this.btnMetodo2.UseVisualStyleBackColor = false;
            this.btnMetodo2.Click += new System.EventHandler(this.btnMetodo2_Click);
            // 
            // btnMetodo1
            // 
            this.btnMetodo1.BackColor = System.Drawing.Color.Black;
            this.btnMetodo1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMetodo1.Location = new System.Drawing.Point(159, 227);
            this.btnMetodo1.Margin = new System.Windows.Forms.Padding(2);
            this.btnMetodo1.Name = "btnMetodo1";
            this.btnMetodo1.Size = new System.Drawing.Size(109, 51);
            this.btnMetodo1.TabIndex = 13;
            this.btnMetodo1.Text = "Recuperar Por Correo";
            this.btnMetodo1.UseVisualStyleBackColor = false;
            this.btnMetodo1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(155, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 58);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingresa tu usuario y haz click sobre la opcion que escoges para recuperar tu cont" +
    "raseña ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(221, 186);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(224, 20);
            this.txtUser.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(213, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Recupera tu cuenta";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(221, 350);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(224, 20);
            this.txtCode.TabIndex = 16;
            // 
            // lblIngresoCodigo
            // 
            this.lblIngresoCodigo.AutoSize = true;
            this.lblIngresoCodigo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIngresoCodigo.Location = new System.Drawing.Point(123, 304);
            this.lblIngresoCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngresoCodigo.Name = "lblIngresoCodigo";
            this.lblIngresoCodigo.Size = new System.Drawing.Size(420, 28);
            this.lblIngresoCodigo.TabIndex = 17;
            this.lblIngresoCodigo.Text = "Ingresa el Codigo de confirmación";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Black;
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.Location = new System.Drawing.Point(279, 385);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(109, 51);
            this.btnConfirmar.TabIndex = 18;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblNuevaContra
            // 
            this.lblNuevaContra.AutoSize = true;
            this.lblNuevaContra.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNuevaContra.Location = new System.Drawing.Point(224, 456);
            this.lblNuevaContra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuevaContra.Name = "lblNuevaContra";
            this.lblNuevaContra.Size = new System.Drawing.Size(230, 28);
            this.lblNuevaContra.TabIndex = 19;
            this.lblNuevaContra.Text = "Nueva Contraseña";
            // 
            // txtNueva
            // 
            this.txtNueva.Location = new System.Drawing.Point(221, 503);
            this.txtNueva.Margin = new System.Windows.Forms.Padding(2);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.Size = new System.Drawing.Size(224, 20);
            this.txtNueva.TabIndex = 20;
            // 
            // btnNueva
            // 
            this.btnNueva.BackColor = System.Drawing.Color.Black;
            this.btnNueva.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNueva.Location = new System.Drawing.Point(279, 540);
            this.btnNueva.Margin = new System.Windows.Forms.Padding(2);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(109, 51);
            this.btnNueva.TabIndex = 21;
            this.btnNueva.Text = "Confirmar";
            this.btnNueva.UseVisualStyleBackColor = false;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnRecuPIN
            // 
            this.btnRecuPIN.BackColor = System.Drawing.Color.Black;
            this.btnRecuPIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRecuPIN.Location = new System.Drawing.Point(402, 227);
            this.btnRecuPIN.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecuPIN.Name = "btnRecuPIN";
            this.btnRecuPIN.Size = new System.Drawing.Size(109, 51);
            this.btnRecuPIN.TabIndex = 22;
            this.btnRecuPIN.Text = "Recuperar por PIN de seguridad";
            this.btnRecuPIN.UseVisualStyleBackColor = false;
            this.btnRecuPIN.Click += new System.EventHandler(this.btnRecuPIN_Click);
            // 
            // frmRecuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 618);
            this.Controls.Add(this.btnRecuPIN);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.txtNueva);
            this.Controls.Add(this.lblNuevaContra);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblIngresoCodigo);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMetodo2);
            this.Controls.Add(this.btnMetodo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRecuperar";
            this.Text = "Recupera Tu Cuenta";
            this.Load += new System.EventHandler(this.frmRecuperar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMetodo2;
        private System.Windows.Forms.Button btnMetodo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblIngresoCodigo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblNuevaContra;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnRecuPIN;
    }
}