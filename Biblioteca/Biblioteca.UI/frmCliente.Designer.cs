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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.navCliente = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.navLibro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.navEjemplar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.navPrestamo = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.navReportes = new System.Windows.Forms.ToolStripTextBox();
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMasInfo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.panelIngresar.SuspendLayout();
            this.panelConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
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
            this.toolStrip1.Size = new System.Drawing.Size(571, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // navCliente
            // 
            this.navCliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navCliente.Name = "navCliente";
            this.navCliente.ReadOnly = true;
            this.navCliente.Size = new System.Drawing.Size(100, 25);
            this.navCliente.Text = "Cliente";
            this.navCliente.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // navLibro
            // 
            this.navLibro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.navLibro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.navLibro.Name = "navLibro";
            this.navLibro.ReadOnly = true;
            this.navLibro.Size = new System.Drawing.Size(100, 25);
            this.navLibro.Text = "Libro";
            this.navLibro.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.navLibro.Click += new System.EventHandler(this.navLibro_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // navEjemplar
            // 
            this.navEjemplar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.navEjemplar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.navEjemplar.Name = "navEjemplar";
            this.navEjemplar.ReadOnly = true;
            this.navEjemplar.Size = new System.Drawing.Size(100, 25);
            this.navEjemplar.Text = "Ejemplar";
            this.navEjemplar.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.navEjemplar.Click += new System.EventHandler(this.navEjemplar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // navPrestamo
            // 
            this.navPrestamo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.navPrestamo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.navPrestamo.Name = "navPrestamo";
            this.navPrestamo.ReadOnly = true;
            this.navPrestamo.Size = new System.Drawing.Size(100, 25);
            this.navPrestamo.Text = "Prestamo";
            this.navPrestamo.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.navPrestamo.Click += new System.EventHandler(this.navPrestamo_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // navReportes
            // 
            this.navReportes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.navReportes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.navReportes.Name = "navReportes";
            this.navReportes.ReadOnly = true;
            this.navReportes.Size = new System.Drawing.Size(100, 25);
            this.navReportes.Text = "Reportes";
            this.navReportes.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.navReportes.Click += new System.EventHandler(this.navReportes_Click);
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.ForeColor = System.Drawing.Color.Navy;
            this.lblIngresar.Location = new System.Drawing.Point(12, 66);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(90, 20);
            this.lblIngresar.TabIndex = 1;
            this.lblIngresar.Text = ">  Ingresar";
            this.lblIngresar.Click += new System.EventHandler(this.lblIngresar_Click);
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.ForeColor = System.Drawing.Color.Navy;
            this.lblConsultar.Location = new System.Drawing.Point(12, 159);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(101, 20);
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
            this.panelIngresar.Location = new System.Drawing.Point(16, 98);
            this.panelIngresar.Name = "panelIngresar";
            this.panelIngresar.Size = new System.Drawing.Size(509, 58);
            this.panelIngresar.TabIndex = 3;
            this.panelIngresar.Visible = false;
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
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(22, 221);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(22, 173);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(22, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(22, 77);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // panelConsultar
            // 
            this.panelConsultar.Controls.Add(this.btnBuscar);
            this.panelConsultar.Controls.Add(this.btnMasInfo);
            this.panelConsultar.Controls.Add(this.btnBorrar);
            this.panelConsultar.Controls.Add(this.listBox1);
            this.panelConsultar.Controls.Add(this.lblResultado);
            this.panelConsultar.Controls.Add(this.lblId);
            this.panelConsultar.Controls.Add(this.textBox1);
            this.panelConsultar.Location = new System.Drawing.Point(16, 182);
            this.panelConsultar.Name = "panelConsultar";
            this.panelConsultar.Size = new System.Drawing.Size(509, 256);
            this.panelConsultar.TabIndex = 4;
            this.panelConsultar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(128, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnMasInfo
            // 
            this.btnMasInfo.BackColor = System.Drawing.Color.Cyan;
            this.btnMasInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasInfo.Location = new System.Drawing.Point(197, 203);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "ID 23, Maria Josefa",
            "ID 234, Juan Domingo",
            "ID 233, Mario Gonzales"});
            this.listBox1.Location = new System.Drawing.Point(22, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 108);
            this.listBox1.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(84, 60);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(132, 13);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado de la Busqueda";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(19, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(67, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "id del Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.panelConsultar);
            this.Controls.Add(this.lblConsultar);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelIngresar);
            this.Name = "frmCliente";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripTextBox navCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox navLibro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox navEjemplar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox navPrestamo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox navReportes;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMasInfo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblResultado;
    }
}

