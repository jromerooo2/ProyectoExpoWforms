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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresarViaje));
            this.cmbUnidadTransporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbMunicipios = new System.Windows.Forms.ComboBox();
            this.cmbTipoDestino = new System.Windows.Forms.ComboBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtTarifaViaje = new System.Windows.Forms.TextBox();
            this.txtNombreViaje = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dtpFechaViaje = new System.Windows.Forms.DateTimePicker();
            this.cmbConductor = new System.Windows.Forms.ComboBox();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.cmbEstadoViaje = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnCrearViaje = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUnidadTransporte
            // 
            this.cmbUnidadTransporte.FormattingEnabled = true;
            this.cmbUnidadTransporte.Location = new System.Drawing.Point(35, 421);
            this.cmbUnidadTransporte.Name = "cmbUnidadTransporte";
            this.cmbUnidadTransporte.Size = new System.Drawing.Size(140, 21);
            this.cmbUnidadTransporte.TabIndex = 76;
            this.cmbUnidadTransporte.Text = "unidad transporte";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 74);
            this.label1.TabIndex = 75;
            this.label1.Text = "Viajes";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(593, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 67);
            this.button2.TabIndex = 74;
            this.button2.Text = "Actualizar Viaje";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(687, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 67);
            this.button1.TabIndex = 73;
            this.button1.Text = "Eliminar Viaje";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(206)))), ((int)(((byte)(237)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(147)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.dataGridView1.Location = new System.Drawing.Point(387, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Size = new System.Drawing.Size(550, 284);
            this.dataGridView1.TabIndex = 72;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(386, 118);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(87, 20);
            this.textBox5.TabIndex = 71;
            this.textBox5.Text = "ID destino";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(386, 164);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(87, 20);
            this.textBox4.TabIndex = 70;
            this.textBox4.Text = "ID viaje";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // cmbMunicipios
            // 
            this.cmbMunicipios.FormattingEnabled = true;
            this.cmbMunicipios.Location = new System.Drawing.Point(194, 366);
            this.cmbMunicipios.Name = "cmbMunicipios";
            this.cmbMunicipios.Size = new System.Drawing.Size(158, 21);
            this.cmbMunicipios.TabIndex = 68;
            this.cmbMunicipios.Text = "municipio";
            // 
            // cmbTipoDestino
            // 
            this.cmbTipoDestino.FormattingEnabled = true;
            this.cmbTipoDestino.Location = new System.Drawing.Point(35, 366);
            this.cmbTipoDestino.Name = "cmbTipoDestino";
            this.cmbTipoDestino.Size = new System.Drawing.Size(140, 21);
            this.cmbTipoDestino.TabIndex = 67;
            this.cmbTipoDestino.Text = "tipo destino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(194, 215);
            this.txtDestino.Multiline = true;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(157, 123);
            this.txtDestino.TabIndex = 66;
            this.txtDestino.Text = "destino";
            // 
            // txtTarifaViaje
            // 
            this.txtTarifaViaje.Location = new System.Drawing.Point(35, 164);
            this.txtTarifaViaje.Name = "txtTarifaViaje";
            this.txtTarifaViaje.Size = new System.Drawing.Size(140, 20);
            this.txtTarifaViaje.TabIndex = 65;
            this.txtTarifaViaje.Text = "tarifa";
            // 
            // txtNombreViaje
            // 
            this.txtNombreViaje.Location = new System.Drawing.Point(193, 119);
            this.txtNombreViaje.Name = "txtNombreViaje";
            this.txtNombreViaje.Size = new System.Drawing.Size(158, 20);
            this.txtNombreViaje.TabIndex = 64;
            this.txtNombreViaje.Text = "nombre viaje";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.progressBar1.Location = new System.Drawing.Point(35, 90);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(646, 10);
            this.progressBar1.TabIndex = 63;
            // 
            // dtpFechaViaje
            // 
            this.dtpFechaViaje.CustomFormat = "dd/mm/yyyy";
            this.dtpFechaViaje.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaViaje.Location = new System.Drawing.Point(35, 215);
            this.dtpFechaViaje.Name = "dtpFechaViaje";
            this.dtpFechaViaje.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaViaje.TabIndex = 62;
            // 
            // cmbConductor
            // 
            this.cmbConductor.FormattingEnabled = true;
            this.cmbConductor.Location = new System.Drawing.Point(194, 164);
            this.cmbConductor.Name = "cmbConductor";
            this.cmbConductor.Size = new System.Drawing.Size(157, 21);
            this.cmbConductor.TabIndex = 61;
            this.cmbConductor.Text = "conductor";
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Location = new System.Drawing.Point(35, 265);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(140, 21);
            this.cmbMetodoPago.TabIndex = 60;
            this.cmbMetodoPago.Text = "metodo pago";
            // 
            // cmbEstadoViaje
            // 
            this.cmbEstadoViaje.FormattingEnabled = true;
            this.cmbEstadoViaje.Location = new System.Drawing.Point(35, 318);
            this.cmbEstadoViaje.Name = "cmbEstadoViaje";
            this.cmbEstadoViaje.Size = new System.Drawing.Size(140, 21);
            this.cmbEstadoViaje.TabIndex = 59;
            this.cmbEstadoViaje.Text = "estado viaje";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(35, 118);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(140, 21);
            this.cmbCliente.TabIndex = 58;
            this.cmbCliente.Text = "cliente";
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearViaje.Location = new System.Drawing.Point(193, 411);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(157, 38);
            this.btnCrearViaje.TabIndex = 57;
            this.btnCrearViaje.Text = "Crear Viaje";
            this.btnCrearViaje.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(499, 117);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(88, 67);
            this.btnLimpiarCampos.TabIndex = 56;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(949, 502);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // frmIngresarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 502);
            this.Controls.Add(this.cmbUnidadTransporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbMunicipios);
            this.Controls.Add(this.cmbTipoDestino);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtTarifaViaje);
            this.Controls.Add(this.txtNombreViaje);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dtpFechaViaje);
            this.Controls.Add(this.cmbConductor);
            this.Controls.Add(this.cmbMetodoPago);
            this.Controls.Add(this.cmbEstadoViaje);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.btnCrearViaje);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmIngresarViaje";
            this.Text = "frmIngresarViaje";
            this.Load += new System.EventHandler(this.frmIngresarViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUnidadTransporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbMunicipios;
        private System.Windows.Forms.ComboBox cmbTipoDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtTarifaViaje;
        private System.Windows.Forms.TextBox txtNombreViaje;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DateTimePicker dtpFechaViaje;
        private System.Windows.Forms.ComboBox cmbConductor;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.ComboBox cmbEstadoViaje;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnCrearViaje;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}