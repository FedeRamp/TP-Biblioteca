﻿
namespace Biblioteca.UI
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
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
            this.lblIngresar = new System.Windows.Forms.Label();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.panelIngresar = new System.Windows.Forms.Panel();
            this.btnListo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panelConsultar = new System.Windows.Forms.Panel();
            this.btnMasInfo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblId = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panelIngresar.SuspendLayout();
            this.panelConsultar.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(761, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // navCliente
            // 
            this.navCliente.AutoSize = false;
            this.navCliente.BackColor = System.Drawing.Color.White;
            this.navCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.navCliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navCliente.Image = ((System.Drawing.Image)(resources.GetObject("navCliente.Image")));
            this.navCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navCliente.Name = "navCliente";
            this.navCliente.Size = new System.Drawing.Size(100, 25);
            this.navCliente.Text = "Cliente";
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
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.ForeColor = System.Drawing.Color.Navy;
            this.lblIngresar.Location = new System.Drawing.Point(16, 81);
            this.lblIngresar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(114, 25);
            this.lblIngresar.TabIndex = 1;
            this.lblIngresar.Text = ">  Ingresar";
            this.lblIngresar.Click += new System.EventHandler(this.lblIngresar_Click);
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.ForeColor = System.Drawing.Color.Navy;
            this.lblConsultar.Location = new System.Drawing.Point(16, 196);
            this.lblConsultar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(128, 25);
            this.lblConsultar.TabIndex = 2;
            this.lblConsultar.Text = ">  Consultar";
            this.lblConsultar.Click += new System.EventHandler(this.lblConsultar_Click);
            // 
            // panelIngresar
            // 
            this.panelIngresar.Controls.Add(this.btnListo);
            this.panelIngresar.Controls.Add(this.label6);
            this.panelIngresar.Controls.Add(this.label3);
            this.panelIngresar.Controls.Add(this.label4);
            this.panelIngresar.Controls.Add(this.label2);
            this.panelIngresar.Controls.Add(this.label1);
            this.panelIngresar.Controls.Add(this.txtDireccion);
            this.panelIngresar.Controls.Add(this.txtTelefono);
            this.panelIngresar.Controls.Add(this.txtEmail);
            this.panelIngresar.Controls.Add(this.txtApellido);
            this.panelIngresar.Controls.Add(this.txtNombre);
            this.panelIngresar.Location = new System.Drawing.Point(21, 121);
            this.panelIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelIngresar.Name = "panelIngresar";
            this.panelIngresar.Size = new System.Drawing.Size(679, 71);
            this.panelIngresar.TabIndex = 3;
            this.panelIngresar.Visible = false;
            // 
            // btnListo
            // 
            this.btnListo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnListo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListo.Location = new System.Drawing.Point(484, 262);
            this.btnListo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(128, 43);
            this.btnListo.TabIndex = 11;
            this.btnListo.Text = "✔ Listo";
            this.btnListo.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(29, 272);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(132, 22);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(29, 213);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(132, 22);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(29, 154);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(29, 95);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 22);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(29, 36);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // panelConsultar
            // 
            this.panelConsultar.Controls.Add(this.btnMasInfo);
            this.panelConsultar.Controls.Add(this.comboBox1);
            this.panelConsultar.Controls.Add(this.button2);
            this.panelConsultar.Controls.Add(this.listBox1);
            this.panelConsultar.Controls.Add(this.lblId);
            this.panelConsultar.Location = new System.Drawing.Point(21, 224);
            this.panelConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelConsultar.Name = "panelConsultar";
            this.panelConsultar.Size = new System.Drawing.Size(679, 315);
            this.panelConsultar.TabIndex = 4;
            this.panelConsultar.Visible = false;
            // 
            // btnMasInfo
            // 
            this.btnMasInfo.BackColor = System.Drawing.Color.Aquamarine;
            this.btnMasInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasInfo.Location = new System.Drawing.Point(29, 234);
            this.btnMasInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMasInfo.Name = "btnMasInfo";
            this.btnMasInfo.Size = new System.Drawing.Size(108, 46);
            this.btnMasInfo.TabIndex = 22;
            this.btnMasInfo.Text = "Más Informacion";
            this.btnMasInfo.UseVisualStyleBackColor = false;
            this.btnMasInfo.Click += new System.EventHandler(this.btnMasInfo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 39);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(236, 242);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 28);
            this.button2.TabIndex = 19;
            this.button2.Text = "Eliminar cliente";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(29, 94);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(352, 132);
            this.listBox1.TabIndex = 10;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(25, 20);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(51, 17);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Cliente";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 554);
            this.Controls.Add(this.panelConsultar);
            this.Controls.Add(this.lblConsultar);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelIngresar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelIngresar.ResumeLayout(false);
            this.panelIngresar.PerformLayout();
            this.panelConsultar.ResumeLayout(false);
            this.panelConsultar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Panel panelIngresar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Panel panelConsultar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripButton navCliente;
        private System.Windows.Forms.ToolStripButton navLibro;
        private System.Windows.Forms.ToolStripButton navEjemplar;
        private System.Windows.Forms.ToolStripButton navPrestamo;
        private System.Windows.Forms.ToolStripButton navReportes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnMasInfo;
    }
}

