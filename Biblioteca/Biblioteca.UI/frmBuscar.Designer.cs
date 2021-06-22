
namespace Biblioteca.UI
{
    partial class frmBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDatosLibro = new System.Windows.Forms.Label();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lblBusquedaPor = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstBuscar = new System.Windows.Forms.ListBox();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.clbBuscarPor = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDatosLibro);
            this.panel1.Controls.Add(this.lblEncabezado);
            this.panel1.Location = new System.Drawing.Point(356, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 471);
            this.panel1.TabIndex = 25;
            // 
            // lblDatosLibro
            // 
            this.lblDatosLibro.Location = new System.Drawing.Point(5, 69);
            this.lblDatosLibro.Name = "lblDatosLibro";
            this.lblDatosLibro.Size = new System.Drawing.Size(275, 391);
            this.lblDatosLibro.TabIndex = 12;
            this.lblDatosLibro.Text = "Seleccione un libro.";
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Location = new System.Drawing.Point(3, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(253, 43);
            this.lblEncabezado.TabIndex = 11;
            this.lblEncabezado.Text = "LIBRO:";
            this.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBusquedaPor
            // 
            this.lblBusquedaPor.AutoSize = true;
            this.lblBusquedaPor.Location = new System.Drawing.Point(11, 9);
            this.lblBusquedaPor.Name = "lblBusquedaPor";
            this.lblBusquedaPor.Size = new System.Drawing.Size(101, 17);
            this.lblBusquedaPor.TabIndex = 24;
            this.lblBusquedaPor.Text = "Busqueda por:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(93, 459);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(240, 41);
            this.btnSeleccionar.TabIndex = 23;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 459);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 41);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(11, 136);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(322, 51);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lstBuscar
            // 
            this.lstBuscar.FormattingEnabled = true;
            this.lstBuscar.ItemHeight = 16;
            this.lstBuscar.Location = new System.Drawing.Point(12, 193);
            this.lstBuscar.Name = "lstBuscar";
            this.lstBuscar.Size = new System.Drawing.Size(318, 260);
            this.lstBuscar.TabIndex = 20;
            this.lstBuscar.SelectedIndexChanged += new System.EventHandler(this.lstBuscar_SelectedIndexChanged);
            this.lstBuscar.DoubleClick += new System.EventHandler(this.lstBuscar_DoubleClick);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(11, 98);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(319, 22);
            this.tbBuscar.TabIndex = 19;
            // 
            // clbBuscarPor
            // 
            this.clbBuscarPor.CheckOnClick = true;
            this.clbBuscarPor.FormattingEnabled = true;
            this.clbBuscarPor.Items.AddRange(new object[] {
            "Título",
            "Autor",
            "Editorial"});
            this.clbBuscarPor.Location = new System.Drawing.Point(11, 29);
            this.clbBuscarPor.Name = "clbBuscarPor";
            this.clbBuscarPor.Size = new System.Drawing.Size(319, 72);
            this.clbBuscarPor.TabIndex = 18;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBusquedaPor);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lstBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.clbBuscarPor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscar";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDatosLibro;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label lblBusquedaPor;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lstBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.CheckedListBox clbBuscarPor;
    }
}