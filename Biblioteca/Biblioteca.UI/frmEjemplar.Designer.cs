
namespace Biblioteca.UI
{
    partial class frmEjemplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjemplar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.navCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.navLibro = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.navEjemplar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.navPrestamo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.navReportes = new System.Windows.Forms.ToolStripButton();
            this.panelConsultar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNoDisponibles = new System.Windows.Forms.CheckBox();
            this.cbDisponibles = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMasInfo = new System.Windows.Forms.Button();
            this.lblTituloLibro = new System.Windows.Forms.Label();
            this.lblCodigoLibroConsultar = new System.Windows.Forms.Label();
            this.tbCodigoLibroConsultar = new System.Windows.Forms.TextBox();
            this.btnBusquedaAvanzadaConsultar = new System.Windows.Forms.Button();
            this.lstbResultado = new System.Windows.Forms.ListBox();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.panelIngresar = new System.Windows.Forms.Panel();
            this.btnBusquedaAvanzadaIngresar = new System.Windows.Forms.Button();
            this.btnListo = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblCodigoLibroIngresar = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.tbCodigoLibroIngresar = new System.Windows.Forms.TextBox();
            this.lblDatosLibro = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panelConsultar.SuspendLayout();
            this.panelIngresar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navCliente,
            this.toolStripSeparator1,
            this.navLibro,
            this.toolStripSeparator2,
            this.navEjemplar,
            this.toolStripSeparator3,
            this.navPrestamo,
            this.toolStripSeparator4,
            this.navReportes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(571, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // navCliente
            // 
            this.navCliente.AutoSize = false;
            this.navCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.navCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.navCliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navCliente.Image = ((System.Drawing.Image)(resources.GetObject("navCliente.Image")));
            this.navCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navCliente.Name = "navCliente";
            this.navCliente.Size = new System.Drawing.Size(100, 25);
            this.navCliente.Text = "Cliente";
            this.navCliente.Click += new System.EventHandler(this.navCliente_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // navLibro
            // 
            this.navLibro.AutoSize = false;
            this.navLibro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.navLibro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.navLibro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.navLibro.Image = ((System.Drawing.Image)(resources.GetObject("navLibro.Image")));
            this.navLibro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navLibro.Name = "navLibro";
            this.navLibro.Size = new System.Drawing.Size(100, 25);
            this.navLibro.Text = "Libro";
            this.navLibro.Click += new System.EventHandler(this.navLibro_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // navEjemplar
            // 
            this.navEjemplar.AutoSize = false;
            this.navEjemplar.BackColor = System.Drawing.Color.White;
            this.navEjemplar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.navEjemplar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.navEjemplar.Image = ((System.Drawing.Image)(resources.GetObject("navEjemplar.Image")));
            this.navEjemplar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navEjemplar.Name = "navEjemplar";
            this.navEjemplar.Size = new System.Drawing.Size(100, 25);
            this.navEjemplar.Text = "Ejemplar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // navPrestamo
            // 
            this.navPrestamo.AutoSize = false;
            this.navPrestamo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.navPrestamo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.navPrestamo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.navPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("navPrestamo.Image")));
            this.navPrestamo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navPrestamo.Name = "navPrestamo";
            this.navPrestamo.Size = new System.Drawing.Size(100, 25);
            this.navPrestamo.Text = "Prestamo";
            this.navPrestamo.Click += new System.EventHandler(this.navPrestamo_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // navReportes
            // 
            this.navReportes.AutoSize = false;
            this.navReportes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.navReportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.navReportes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.navReportes.Image = ((System.Drawing.Image)(resources.GetObject("navReportes.Image")));
            this.navReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navReportes.Name = "navReportes";
            this.navReportes.Size = new System.Drawing.Size(100, 25);
            this.navReportes.Text = "Reportes";
            this.navReportes.Click += new System.EventHandler(this.navReportes_Click);
            // 
            // panelConsultar
            // 
            this.panelConsultar.Controls.Add(this.label1);
            this.panelConsultar.Controls.Add(this.cbNoDisponibles);
            this.panelConsultar.Controls.Add(this.cbDisponibles);
            this.panelConsultar.Controls.Add(this.btnBuscar);
            this.panelConsultar.Controls.Add(this.btnMasInfo);
            this.panelConsultar.Controls.Add(this.lblTituloLibro);
            this.panelConsultar.Controls.Add(this.lblCodigoLibroConsultar);
            this.panelConsultar.Controls.Add(this.tbCodigoLibroConsultar);
            this.panelConsultar.Controls.Add(this.btnBusquedaAvanzadaConsultar);
            this.panelConsultar.Controls.Add(this.lstbResultado);
            this.panelConsultar.Location = new System.Drawing.Point(25, 170);
            this.panelConsultar.Name = "panelConsultar";
            this.panelConsultar.Size = new System.Drawing.Size(509, 270);
            this.panelConsultar.TabIndex = 8;
            this.panelConsultar.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ejemplares:";
            // 
            // cbNoDisponibles
            // 
            this.cbNoDisponibles.AutoSize = true;
            this.cbNoDisponibles.Checked = true;
            this.cbNoDisponibles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNoDisponibles.Location = new System.Drawing.Point(405, 87);
            this.cbNoDisponibles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbNoDisponibles.Name = "cbNoDisponibles";
            this.cbNoDisponibles.Size = new System.Drawing.Size(95, 17);
            this.cbNoDisponibles.TabIndex = 27;
            this.cbNoDisponibles.Text = "No disponibles";
            this.cbNoDisponibles.UseVisualStyleBackColor = true;
            this.cbNoDisponibles.CheckedChanged += new System.EventHandler(this.cbNoDisponibles_CheckedChanged);
            // 
            // cbDisponibles
            // 
            this.cbDisponibles.AutoSize = true;
            this.cbDisponibles.Checked = true;
            this.cbDisponibles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDisponibles.Location = new System.Drawing.Point(323, 87);
            this.cbDisponibles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDisponibles.Name = "cbDisponibles";
            this.cbDisponibles.Size = new System.Drawing.Size(80, 17);
            this.cbDisponibles.TabIndex = 26;
            this.cbDisponibles.Text = "Disponibles";
            this.cbDisponibles.UseVisualStyleBackColor = true;
            this.cbDisponibles.CheckedChanged += new System.EventHandler(this.cbDisponibles_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(22, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 23);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnMasInfo
            // 
            this.btnMasInfo.BackColor = System.Drawing.Color.Aquamarine;
            this.btnMasInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasInfo.Location = new System.Drawing.Point(22, 219);
            this.btnMasInfo.Name = "btnMasInfo";
            this.btnMasInfo.Size = new System.Drawing.Size(81, 37);
            this.btnMasInfo.TabIndex = 24;
            this.btnMasInfo.Text = "Más Informacion";
            this.btnMasInfo.UseVisualStyleBackColor = false;
            this.btnMasInfo.Click += new System.EventHandler(this.btnMasInfo_Click);
            // 
            // lblTituloLibro
            // 
            this.lblTituloLibro.Location = new System.Drawing.Point(178, 28);
            this.lblTituloLibro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloLibro.Name = "lblTituloLibro";
            this.lblTituloLibro.Size = new System.Drawing.Size(319, 47);
            this.lblTituloLibro.TabIndex = 15;
            this.lblTituloLibro.Text = "Libro:";
            // 
            // lblCodigoLibroConsultar
            // 
            this.lblCodigoLibroConsultar.AutoSize = true;
            this.lblCodigoLibroConsultar.Location = new System.Drawing.Point(20, 11);
            this.lblCodigoLibroConsultar.Name = "lblCodigoLibroConsultar";
            this.lblCodigoLibroConsultar.Size = new System.Drawing.Size(67, 13);
            this.lblCodigoLibroConsultar.TabIndex = 23;
            this.lblCodigoLibroConsultar.Text = "Cod de Libro";
            // 
            // tbCodigoLibroConsultar
            // 
            this.tbCodigoLibroConsultar.Location = new System.Drawing.Point(22, 28);
            this.tbCodigoLibroConsultar.Name = "tbCodigoLibroConsultar";
            this.tbCodigoLibroConsultar.Size = new System.Drawing.Size(100, 20);
            this.tbCodigoLibroConsultar.TabIndex = 22;
            this.tbCodigoLibroConsultar.TextChanged += new System.EventHandler(this.tbCodigoLibroConsultar_TextChanged);
            this.tbCodigoLibroConsultar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoLibroConsultar_KeyPress);
            // 
            // btnBusquedaAvanzadaConsultar
            // 
            this.btnBusquedaAvanzadaConsultar.Location = new System.Drawing.Point(126, 25);
            this.btnBusquedaAvanzadaConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBusquedaAvanzadaConsultar.Name = "btnBusquedaAvanzadaConsultar";
            this.btnBusquedaAvanzadaConsultar.Size = new System.Drawing.Size(28, 24);
            this.btnBusquedaAvanzadaConsultar.TabIndex = 15;
            this.btnBusquedaAvanzadaConsultar.Text = "...";
            this.btnBusquedaAvanzadaConsultar.UseVisualStyleBackColor = true;
            this.btnBusquedaAvanzadaConsultar.Click += new System.EventHandler(this.btnBusquedaAvanzadaConsultar_Click);
            // 
            // lstbResultado
            // 
            this.lstbResultado.FormattingEnabled = true;
            this.lstbResultado.Items.AddRange(new object[] {
            " "});
            this.lstbResultado.Location = new System.Drawing.Point(21, 106);
            this.lstbResultado.Name = "lstbResultado";
            this.lstbResultado.Size = new System.Drawing.Size(477, 108);
            this.lstbResultado.TabIndex = 10;
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.ForeColor = System.Drawing.Color.Navy;
            this.lblConsultar.Location = new System.Drawing.Point(21, 147);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(101, 20);
            this.lblConsultar.TabIndex = 6;
            this.lblConsultar.Text = ">  Consultar";
            this.lblConsultar.Click += new System.EventHandler(this.lblConsultar_Click);
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.ForeColor = System.Drawing.Color.Navy;
            this.lblIngresar.Location = new System.Drawing.Point(21, 54);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(90, 20);
            this.lblIngresar.TabIndex = 5;
            this.lblIngresar.Text = ">  Ingresar";
            this.lblIngresar.Click += new System.EventHandler(this.lblIngresar_Click);
            // 
            // panelIngresar
            // 
            this.panelIngresar.Controls.Add(this.btnBusquedaAvanzadaIngresar);
            this.panelIngresar.Controls.Add(this.lblDatosLibro);
            this.panelIngresar.Controls.Add(this.btnListo);
            this.panelIngresar.Controls.Add(this.lblPrecio);
            this.panelIngresar.Controls.Add(this.lblObservaciones);
            this.panelIngresar.Controls.Add(this.lblCodigoLibroIngresar);
            this.panelIngresar.Controls.Add(this.tbPrecio);
            this.panelIngresar.Controls.Add(this.tbObservaciones);
            this.panelIngresar.Controls.Add(this.tbCodigoLibroIngresar);
            this.panelIngresar.Location = new System.Drawing.Point(25, 86);
            this.panelIngresar.Name = "panelIngresar";
            this.panelIngresar.Size = new System.Drawing.Size(509, 58);
            this.panelIngresar.TabIndex = 9;
            this.panelIngresar.Visible = false;
            // 
            // btnBusquedaAvanzadaIngresar
            // 
            this.btnBusquedaAvanzadaIngresar.Location = new System.Drawing.Point(126, 27);
            this.btnBusquedaAvanzadaIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBusquedaAvanzadaIngresar.Name = "btnBusquedaAvanzadaIngresar";
            this.btnBusquedaAvanzadaIngresar.Size = new System.Drawing.Size(28, 24);
            this.btnBusquedaAvanzadaIngresar.TabIndex = 14;
            this.btnBusquedaAvanzadaIngresar.Text = "...";
            this.btnBusquedaAvanzadaIngresar.UseVisualStyleBackColor = true;
            this.btnBusquedaAvanzadaIngresar.Click += new System.EventHandler(this.btnBusquedaAvanzadaIngresar_Click);
            // 
            // btnListo
            // 
            this.btnListo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnListo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListo.Location = new System.Drawing.Point(22, 165);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(99, 31);
            this.btnListo.TabIndex = 11;
            this.btnListo.Text = "✔ Agregar";
            this.btnListo.UseVisualStyleBackColor = false;
            this.btnListo.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(19, 109);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(19, 61);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 7;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // lblCodigoLibroIngresar
            // 
            this.lblCodigoLibroIngresar.AutoSize = true;
            this.lblCodigoLibroIngresar.Location = new System.Drawing.Point(19, 13);
            this.lblCodigoLibroIngresar.Name = "lblCodigoLibroIngresar";
            this.lblCodigoLibroIngresar.Size = new System.Drawing.Size(69, 13);
            this.lblCodigoLibroIngresar.TabIndex = 6;
            this.lblCodigoLibroIngresar.Text = "Cod del Libro";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(22, 125);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 2;
            this.tbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecio_KeyPress);
            this.tbPrecio.Leave += new System.EventHandler(this.tbPrecio_Leave);
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(22, 77);
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(100, 20);
            this.tbObservaciones.TabIndex = 1;
            // 
            // tbCodigoLibroIngresar
            // 
            this.tbCodigoLibroIngresar.Location = new System.Drawing.Point(22, 29);
            this.tbCodigoLibroIngresar.Name = "tbCodigoLibroIngresar";
            this.tbCodigoLibroIngresar.Size = new System.Drawing.Size(100, 20);
            this.tbCodigoLibroIngresar.TabIndex = 0;
            this.tbCodigoLibroIngresar.TextChanged += new System.EventHandler(this.tbCodigoLibroIngresar_TextChanged);
            this.tbCodigoLibroIngresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoLibroIngresar_KeyPress);
            // 
            // lblDatosLibro
            // 
            this.lblDatosLibro.Location = new System.Drawing.Point(178, 21);
            this.lblDatosLibro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosLibro.Name = "lblDatosLibro";
            this.lblDatosLibro.Size = new System.Drawing.Size(306, 169);
            this.lblDatosLibro.TabIndex = 13;
            this.lblDatosLibro.Text = "Libro:";
            // 
            // frmEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.panelIngresar);
            this.Controls.Add(this.panelConsultar);
            this.Controls.Add(this.lblConsultar);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEjemplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.frmEjemplar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelConsultar.ResumeLayout(false);
            this.panelConsultar.PerformLayout();
            this.panelIngresar.ResumeLayout(false);
            this.panelIngresar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel panelConsultar;
        private System.Windows.Forms.ListBox lstbResultado;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.ToolStripButton navCliente;
        private System.Windows.Forms.ToolStripButton navLibro;
        private System.Windows.Forms.ToolStripButton navEjemplar;
        private System.Windows.Forms.ToolStripButton navPrestamo;
        private System.Windows.Forms.ToolStripButton navReportes;
        private System.Windows.Forms.Panel panelIngresar;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblCodigoLibroIngresar;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.TextBox tbCodigoLibroIngresar;
        private System.Windows.Forms.Button btnBusquedaAvanzadaConsultar;
        private System.Windows.Forms.Button btnBusquedaAvanzadaIngresar;
        private System.Windows.Forms.Label lblCodigoLibroConsultar;
        private System.Windows.Forms.TextBox tbCodigoLibroConsultar;
        private System.Windows.Forms.Label lblTituloLibro;
        private System.Windows.Forms.Button btnMasInfo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbNoDisponibles;
        private System.Windows.Forms.CheckBox cbDisponibles;
        private System.Windows.Forms.Label lblDatosLibro;
    }
}