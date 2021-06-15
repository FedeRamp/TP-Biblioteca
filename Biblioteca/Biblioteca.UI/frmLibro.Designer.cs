﻿
namespace Biblioteca.UI
{
    partial class frmLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibro));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panelConsultar = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnMasInfo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lstListaLibros = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.panelIngresar = new System.Windows.Forms.Panel();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnListo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.navCliente = new System.Windows.Forms.ToolStripButton();
            this.navLibro = new System.Windows.Forms.ToolStripButton();
            this.navEjemplar = new System.Windows.Forms.ToolStripButton();
            this.navPrestamo = new System.Windows.Forms.ToolStripButton();
            this.navReportes = new System.Windows.Forms.ToolStripButton();
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // panelConsultar
            // 
            this.panelConsultar.Controls.Add(this.btnActualizar);
            this.panelConsultar.Controls.Add(this.btnMasInfo);
            this.panelConsultar.Controls.Add(this.btnBorrar);
            this.panelConsultar.Controls.Add(this.lstListaLibros);
            this.panelConsultar.Controls.Add(this.lblResultado);
            this.panelConsultar.Location = new System.Drawing.Point(16, 182);
            this.panelConsultar.Name = "panelConsultar";
            this.panelConsultar.Size = new System.Drawing.Size(509, 256);
            this.panelConsultar.TabIndex = 8;
            this.panelConsultar.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(293, 203);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(84, 46);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnMasInfo
            // 
            this.btnMasInfo.BackColor = System.Drawing.Color.Cyan;
            this.btnMasInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasInfo.Location = new System.Drawing.Point(160, 203);
            this.btnMasInfo.Name = "btnMasInfo";
            this.btnMasInfo.Size = new System.Drawing.Size(90, 46);
            this.btnMasInfo.TabIndex = 12;
            this.btnMasInfo.Text = "Mas Informacion";
            this.btnMasInfo.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Red;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(22, 203);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(90, 46);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // lstListaLibros
            // 
            this.lstListaLibros.FormattingEnabled = true;
            this.lstListaLibros.Location = new System.Drawing.Point(22, 76);
            this.lstListaLibros.Name = "lstListaLibros";
            this.lstListaLibros.Size = new System.Drawing.Size(265, 108);
            this.lstListaLibros.TabIndex = 10;
            this.lstListaLibros.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(19, 47);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(41, 13);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Libros: ";
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.ForeColor = System.Drawing.Color.Navy;
            this.lblConsultar.Location = new System.Drawing.Point(12, 159);
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
            this.lblIngresar.Location = new System.Drawing.Point(12, 66);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(90, 20);
            this.lblIngresar.TabIndex = 5;
            this.lblIngresar.Text = ">  Ingresar";
            this.lblIngresar.Click += new System.EventHandler(this.lblIngresar_Click);
            // 
            // panelIngresar
            // 
            this.panelIngresar.Controls.Add(this.txtTema);
            this.panelIngresar.Controls.Add(this.label6);
            this.panelIngresar.Controls.Add(this.txtEditorial);
            this.panelIngresar.Controls.Add(this.label5);
            this.panelIngresar.Controls.Add(this.txtAutor);
            this.panelIngresar.Controls.Add(this.label4);
            this.panelIngresar.Controls.Add(this.btnListo);
            this.panelIngresar.Controls.Add(this.label3);
            this.panelIngresar.Controls.Add(this.label2);
            this.panelIngresar.Controls.Add(this.label1);
            this.panelIngresar.Controls.Add(this.txtTitulo);
            this.panelIngresar.Controls.Add(this.txtPaginas);
            this.panelIngresar.Controls.Add(this.txtEdicion);
            this.panelIngresar.Location = new System.Drawing.Point(12, 89);
            this.panelIngresar.Name = "panelIngresar";
            this.panelIngresar.Size = new System.Drawing.Size(513, 67);
            this.panelIngresar.TabIndex = 7;
            this.panelIngresar.Visible = false;
            // 
            // txtTema
            // 
            this.txtTema.Location = new System.Drawing.Point(167, 76);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(100, 20);
            this.txtTema.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "tema";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(164, 28);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(100, 20);
            this.txtEditorial.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "editorial";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(22, 178);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "autor";
            // 
            // btnListo
            // 
            this.btnListo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnListo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListo.Location = new System.Drawing.Point(363, 213);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(96, 35);
            this.btnListo.TabIndex = 11;
            this.btnListo.Text = "✔ Listo";
            this.btnListo.UseVisualStyleBackColor = false;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Paginas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "edicion";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(22, 125);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(22, 77);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(100, 20);
            this.txtPaginas.TabIndex = 1;
            this.txtPaginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaginas_KeyPress);
            // 
            // txtEdicion
            // 
            this.txtEdicion.Location = new System.Drawing.Point(22, 29);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(100, 20);
            this.txtEdicion.TabIndex = 0;
            this.txtEdicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdicion_KeyPress);
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
            // navLibro
            // 
            this.navLibro.AutoSize = false;
            this.navLibro.BackColor = System.Drawing.Color.White;
            this.navLibro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.navLibro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.navLibro.Image = ((System.Drawing.Image)(resources.GetObject("navLibro.Image")));
            this.navLibro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navLibro.Name = "navLibro";
            this.navLibro.Size = new System.Drawing.Size(100, 25);
            this.navLibro.Text = "Libro";
            // 
            // navEjemplar
            // 
            this.navEjemplar.AutoSize = false;
            this.navEjemplar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.navEjemplar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.navEjemplar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.navEjemplar.Image = ((System.Drawing.Image)(resources.GetObject("navEjemplar.Image")));
            this.navEjemplar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navEjemplar.Name = "navEjemplar";
            this.navEjemplar.Size = new System.Drawing.Size(100, 25);
            this.navEjemplar.Text = "Ejemplar";
            this.navEjemplar.Click += new System.EventHandler(this.navEjemplar_Click);
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
            // frmLibro
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
            this.Name = "frmLibro";
            this.Text = "Libro";
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
        private System.Windows.Forms.Button btnMasInfo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox lstListaLibros;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Panel panelIngresar;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ToolStripButton navCliente;
        private System.Windows.Forms.ToolStripButton navLibro;
        private System.Windows.Forms.ToolStripButton navEjemplar;
        private System.Windows.Forms.ToolStripButton navPrestamo;
        private System.Windows.Forms.ToolStripButton navReportes;
    }
}