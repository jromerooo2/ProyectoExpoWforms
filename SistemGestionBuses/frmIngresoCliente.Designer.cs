namespace SistemGestionBuses
{
    partial class frmIngresoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoCliente));
            this.dgvDatosCliente = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipCliente = new System.Windows.Forms.ComboBox();
            this.txtDirCliente = new System.Windows.Forms.TextBox();
            this.txtApeCliente = new System.Windows.Forms.TextBox();
            this.txtCorCliente = new System.Windows.Forms.TextBox();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.btnEliminarClientes = new System.Windows.Forms.Button();
            this.btnActualizarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTelCliente = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatosCliente
            // 
            this.dgvDatosCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCliente.Location = new System.Drawing.Point(12, 287);
            this.dgvDatosCliente.Name = "dgvDatosCliente";
            this.dgvDatosCliente.Size = new System.Drawing.Size(642, 170);
            this.dgvDatosCliente.TabIndex = 58;
            this.dgvDatosCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(244, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 57;
            this.label5.Text = "Correo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(355, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Numero cel";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Direccion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(182, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbTipCliente
            // 
            this.cmbTipCliente.FormattingEnabled = true;
            this.cmbTipCliente.Location = new System.Drawing.Point(247, 145);
            this.cmbTipCliente.Name = "cmbTipCliente";
            this.cmbTipCliente.Size = new System.Drawing.Size(211, 21);
            this.cmbTipCliente.TabIndex = 52;
            this.cmbTipCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtDirCliente
            // 
            this.txtDirCliente.Location = new System.Drawing.Point(10, 91);
            this.txtDirCliente.Multiline = true;
            this.txtDirCliente.Name = "txtDirCliente";
            this.txtDirCliente.Size = new System.Drawing.Size(205, 169);
            this.txtDirCliente.TabIndex = 51;
            this.txtDirCliente.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtApeCliente
            // 
            this.txtApeCliente.Location = new System.Drawing.Point(185, 31);
            this.txtApeCliente.Name = "txtApeCliente";
            this.txtApeCliente.Size = new System.Drawing.Size(131, 20);
            this.txtApeCliente.TabIndex = 50;
            this.txtApeCliente.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtApeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyApellido);
            // 
            // txtCorCliente
            // 
            this.txtCorCliente.Location = new System.Drawing.Point(247, 91);
            this.txtCorCliente.Name = "txtCorCliente";
            this.txtCorCliente.Size = new System.Drawing.Size(211, 20);
            this.txtCorCliente.TabIndex = 49;
            this.txtCorCliente.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(10, 31);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(131, 20);
            this.txtNomCliente.TabIndex = 47;
            this.txtNomCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNomCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyNombre);
            // 
            // btnEliminarClientes
            // 
            this.btnEliminarClientes.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminarClientes.Location = new System.Drawing.Point(336, 229);
            this.btnEliminarClientes.Name = "btnEliminarClientes";
            this.btnEliminarClientes.Size = new System.Drawing.Size(122, 31);
            this.btnEliminarClientes.TabIndex = 46;
            this.btnEliminarClientes.Text = "Eliminar cliente";
            this.btnEliminarClientes.UseVisualStyleBackColor = true;
            this.btnEliminarClientes.Click += new System.EventHandler(this.BtnEliminarCliente_click);
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnActualizarCliente.Location = new System.Drawing.Point(12, 45);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(122, 46);
            this.btnActualizarCliente.TabIndex = 45;
            this.btnActualizarCliente.Text = "Actualizar clientes";
            this.btnActualizarCliente.UseVisualStyleBackColor = true;
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnAcualizar_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarCliente.Location = new System.Drawing.Point(336, 189);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(122, 31);
            this.btnAgregarCliente.TabIndex = 44;
            this.btnAgregarCliente.Text = "Agregar clientes";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(666, 469);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(244, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "Tipo cliente";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 31);
            this.button1.TabIndex = 61;
            this.button1.Text = "Limpiar Campos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnLimCampos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.txtTelCliente);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbTipCliente);
            this.panel1.Controls.Add(this.txtIdCliente);
            this.panel1.Controls.Add(this.btnEliminarClientes);
            this.panel1.Controls.Add(this.btnAgregarCliente);
            this.panel1.Controls.Add(this.txtApeCliente);
            this.panel1.Controls.Add(this.txtCorCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDirCliente);
            this.panel1.Controls.Add(this.txtNomCliente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(174, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 269);
            this.panel1.TabIndex = 78;
            // 
            // txtTelCliente
            // 
            this.txtTelCliente.Location = new System.Drawing.Point(358, 31);
            this.txtTelCliente.Mask = "0000-0000";
            this.txtTelCliente.Name = "txtTelCliente";
            this.txtTelCliente.Size = new System.Drawing.Size(100, 20);
            this.txtTelCliente.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(244, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 18);
            this.label7.TabIndex = 62;
            this.label7.Text = "ID";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(247, 200);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(57, 20);
            this.txtIdCliente.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnActualizarCliente);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 161);
            this.panel2.TabIndex = 79;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(12, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 55);
            this.button2.TabIndex = 62;
            this.button2.Text = "Actualizar Grid de datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnActualizarGrid_click);
            // 
            // frmIngresoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 469);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDatosCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmIngresoCliente";
            this.Text = "frmIngresoCliente";
            this.Load += new System.EventHandler(this.frmIngresoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipCliente;
        private System.Windows.Forms.TextBox txtDirCliente;
        private System.Windows.Forms.TextBox txtApeCliente;
        private System.Windows.Forms.TextBox txtCorCliente;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.Button btnEliminarClientes;
        private System.Windows.Forms.Button btnActualizarCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox txtTelCliente;
    }
}