namespace TrabajoEstadistica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nmNroIngresado = new System.Windows.Forms.NumericUpDown();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgvEstadistica = new System.Windows.Forms.DataGridView();
            this.lblfiTotal = new System.Windows.Forms.Label();
            this.lblxf = new System.Windows.Forms.Label();
            this.lblx2f = new System.Windows.Forms.Label();
            this.lblx_m2f = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.lblMediana = new System.Windows.Forms.Label();
            this.lblDesviacionTipica = new System.Windows.Forms.Label();
            this.lblDesviacionEstandar = new System.Windows.Forms.Label();
            this.lblVarianza = new System.Windows.Forms.Label();
            this.lblCoeficiente = new System.Windows.Forms.Label();
            this.nmFrecuencia = new System.Windows.Forms.NumericUpDown();
            this.lblIngresarNro = new System.Windows.Forms.Label();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmNroIngresado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadistica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFrecuencia)).BeginInit();
            this.SuspendLayout();
            // 
            // nmNroIngresado
            // 
            this.nmNroIngresado.Location = new System.Drawing.Point(146, 52);
            this.nmNroIngresado.Name = "nmNroIngresado";
            this.nmNroIngresado.Size = new System.Drawing.Size(58, 20);
            this.nmNroIngresado.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(441, 49);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dgvEstadistica
            // 
            this.dgvEstadistica.AllowUserToAddRows = false;
            this.dgvEstadistica.AllowUserToDeleteRows = false;
            this.dgvEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadistica.Location = new System.Drawing.Point(52, 78);
            this.dgvEstadistica.Name = "dgvEstadistica";
            this.dgvEstadistica.ReadOnly = true;
            this.dgvEstadistica.Size = new System.Drawing.Size(856, 150);
            this.dgvEstadistica.TabIndex = 3;
            // 
            // lblfiTotal
            // 
            this.lblfiTotal.AutoSize = true;
            this.lblfiTotal.Location = new System.Drawing.Point(143, 231);
            this.lblfiTotal.Name = "lblfiTotal";
            this.lblfiTotal.Size = new System.Drawing.Size(40, 13);
            this.lblfiTotal.TabIndex = 4;
            this.lblfiTotal.Text = "prueba";
            // 
            // lblxf
            // 
            this.lblxf.AutoSize = true;
            this.lblxf.Location = new System.Drawing.Point(331, 231);
            this.lblxf.Name = "lblxf";
            this.lblxf.Size = new System.Drawing.Size(40, 13);
            this.lblxf.TabIndex = 5;
            this.lblxf.Text = "prueba";
            // 
            // lblx2f
            // 
            this.lblx2f.AutoSize = true;
            this.lblx2f.Location = new System.Drawing.Point(582, 231);
            this.lblx2f.Name = "lblx2f";
            this.lblx2f.Size = new System.Drawing.Size(40, 13);
            this.lblx2f.TabIndex = 6;
            this.lblx2f.Text = "prueba";
            // 
            // lblx_m2f
            // 
            this.lblx_m2f.AutoSize = true;
            this.lblx_m2f.Location = new System.Drawing.Point(773, 231);
            this.lblx_m2f.Name = "lblx_m2f";
            this.lblx_m2f.Size = new System.Drawing.Size(40, 13);
            this.lblx_m2f.TabIndex = 7;
            this.lblx_m2f.Text = "prueba";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(833, 246);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(248, 303);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(82, 13);
            this.lblMedia.TabIndex = 9;
            this.lblMedia.Text = "La media es de:";
            this.lblMedia.Visible = false;
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Location = new System.Drawing.Point(248, 328);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(80, 13);
            this.lblModa.TabIndex = 10;
            this.lblModa.Text = "La moda es de:";
            this.lblModa.Visible = false;
            // 
            // lblMediana
            // 
            this.lblMediana.AutoSize = true;
            this.lblMediana.Location = new System.Drawing.Point(248, 351);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(94, 13);
            this.lblMediana.TabIndex = 11;
            this.lblMediana.Text = "La mediana es de:";
            this.lblMediana.Visible = false;
            // 
            // lblDesviacionTipica
            // 
            this.lblDesviacionTipica.AutoSize = true;
            this.lblDesviacionTipica.Location = new System.Drawing.Point(528, 303);
            this.lblDesviacionTipica.Name = "lblDesviacionTipica";
            this.lblDesviacionTipica.Size = new System.Drawing.Size(135, 13);
            this.lblDesviacionTipica.TabIndex = 12;
            this.lblDesviacionTipica.Text = "La desviación típica es de:";
            this.lblDesviacionTipica.Visible = false;
            // 
            // lblDesviacionEstandar
            // 
            this.lblDesviacionEstandar.AutoSize = true;
            this.lblDesviacionEstandar.Location = new System.Drawing.Point(528, 328);
            this.lblDesviacionEstandar.Name = "lblDesviacionEstandar";
            this.lblDesviacionEstandar.Size = new System.Drawing.Size(149, 13);
            this.lblDesviacionEstandar.TabIndex = 13;
            this.lblDesviacionEstandar.Text = "La desviación estándar es de:";
            this.lblDesviacionEstandar.Visible = false;
            // 
            // lblVarianza
            // 
            this.lblVarianza.AutoSize = true;
            this.lblVarianza.Location = new System.Drawing.Point(528, 351);
            this.lblVarianza.Name = "lblVarianza";
            this.lblVarianza.Size = new System.Drawing.Size(94, 13);
            this.lblVarianza.TabIndex = 14;
            this.lblVarianza.Text = "La varianza es de:";
            this.lblVarianza.Visible = false;
            // 
            // lblCoeficiente
            // 
            this.lblCoeficiente.AutoSize = true;
            this.lblCoeficiente.Location = new System.Drawing.Point(528, 375);
            this.lblCoeficiente.Name = "lblCoeficiente";
            this.lblCoeficiente.Size = new System.Drawing.Size(162, 13);
            this.lblCoeficiente.TabIndex = 15;
            this.lblCoeficiente.Text = "El coeficiente de variacón es de:";
            this.lblCoeficiente.Visible = false;
            // 
            // nmFrecuencia
            // 
            this.nmFrecuencia.Location = new System.Drawing.Point(377, 52);
            this.nmFrecuencia.Name = "nmFrecuencia";
            this.nmFrecuencia.Size = new System.Drawing.Size(58, 20);
            this.nmFrecuencia.TabIndex = 16;
            // 
            // lblIngresarNro
            // 
            this.lblIngresarNro.AutoSize = true;
            this.lblIngresarNro.Location = new System.Drawing.Point(49, 54);
            this.lblIngresarNro.Name = "lblIngresarNro";
            this.lblIngresarNro.Size = new System.Drawing.Size(91, 13);
            this.lblIngresarNro.TabIndex = 17;
            this.lblIngresarNro.Text = "Ingrese el número";
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.AutoSize = true;
            this.lblFrecuencia.Location = new System.Drawing.Point(210, 54);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(161, 13);
            this.lblFrecuencia.TabIndex = 18;
            this.lblFrecuencia.Text = "Indique la frecuencia del número";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 481);
            this.Controls.Add(this.lblFrecuencia);
            this.Controls.Add(this.lblIngresarNro);
            this.Controls.Add(this.nmFrecuencia);
            this.Controls.Add(this.lblCoeficiente);
            this.Controls.Add(this.lblVarianza);
            this.Controls.Add(this.lblDesviacionEstandar);
            this.Controls.Add(this.lblDesviacionTipica);
            this.Controls.Add(this.lblMediana);
            this.Controls.Add(this.lblModa);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblx_m2f);
            this.Controls.Add(this.lblx2f);
            this.Controls.Add(this.lblxf);
            this.Controls.Add(this.lblfiTotal);
            this.Controls.Add(this.dgvEstadistica);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.nmNroIngresado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmNroIngresado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadistica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFrecuencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmNroIngresado;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvEstadistica;
        private System.Windows.Forms.Label lblfiTotal;
        private System.Windows.Forms.Label lblxf;
        private System.Windows.Forms.Label lblx2f;
        private System.Windows.Forms.Label lblx_m2f;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.Label lblMediana;
        private System.Windows.Forms.Label lblDesviacionTipica;
        private System.Windows.Forms.Label lblDesviacionEstandar;
        private System.Windows.Forms.Label lblVarianza;
        private System.Windows.Forms.Label lblCoeficiente;
        private System.Windows.Forms.NumericUpDown nmFrecuencia;
        private System.Windows.Forms.Label lblIngresarNro;
        private System.Windows.Forms.Label lblFrecuencia;
    }
}

