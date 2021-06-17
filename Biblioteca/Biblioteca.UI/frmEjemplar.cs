using Biblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.UI
{
    public partial class frmEjemplar : Form
    {
        private bool ingresarExpandido = false;
        private bool consultarExpandido = true;

        //pendiente form main que traiga la lista y trabajar siempre con referencias?
        List<Libro> libros;
        public List<Libro> Libros { get => libros; set => libros = value; }

        public frmEjemplar()
        {
            InitializeComponent();
        }

        private void navLibro_Click(object sender, EventArgs e)
        {
            frmLibro frmLib = new frmLibro();
            frmLib.Show();
            this.Hide();
        }

        private void navCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmClient = new frmCliente();
            frmClient.Show();
            this.Hide();
        }

        private void navPrestamo_Click(object sender, EventArgs e)
        {
            frmPrestamo frmPrest = new frmPrestamo();
            frmPrest.Show();
            this.Hide();
        }

        private void navReportes_Click(object sender, EventArgs e)
        {
            frmReportes frmRep = new frmReportes();
            frmRep.Show();
            this.Hide();
        }

        private void lblIngresar_Click(object sender, EventArgs e)
        {
            if (!ingresarExpandido)
            {
                ExpandirMenuIngresar();
                ContraerMenuConsultar();
            }
            else if (ingresarExpandido)
            {
                ContraerMenuIngresar();
            }
        }

        private void lblConsultar_Click(object sender, EventArgs e)
        {
            if (!consultarExpandido)
            {
                ExpandirMenuConsultar();
                ContraerMenuIngresar();
            }
            else if (consultarExpandido)
            {
                ContraerMenuConsultar();
            }
        }

        private void ExpandirMenuConsultar()
        {
            lblConsultar.Text = "v Consultar";
            panelConsultar.Visible = true;
            consultarExpandido = true;
        }

        private void ContraerMenuConsultar()
        {
            lblConsultar.Text = "> Consultar";
            panelConsultar.Visible = false;
            consultarExpandido = false;
        }

        private void ExpandirMenuIngresar()
        {
            lblIngresar.Text = "v Ingresar";
            panelIngresar.Height = 250;
            int finDelPanel = panelIngresar.Location.Y + panelIngresar.Height;
            lblConsultar.Location = new Point(lblIngresar.Location.X, finDelPanel);
            panelIngresar.Visible = true;
            ingresarExpandido = true;
        }

        private void ContraerMenuIngresar()
        {
            lblIngresar.Text = "> Ingresar";
            panelIngresar.Height = 60;
            int finDelPanel = panelIngresar.Location.Y + panelIngresar.Height;
            lblConsultar.Location = new Point(lblIngresar.Location.X, finDelPanel);
            panelIngresar.Visible = false;
            ingresarExpandido = false;
        }

        internal void TraerCodigo(int idLibro)
        {
            tbCodigoLibro.Text = idLibro.ToString();
        }

        private void frmEjemplar_Load(object sender, EventArgs e)
        {
            libros = ((frmInicial)Owner).Libros;
        }

        private void btnBusquedaAvanzada2_Click(object sender, EventArgs e)
        {
            Form frmBuscar = new frmBuscar();
            frmBuscar.Owner = this;
            frmBuscar.Show();
        }

        private void tbCodigoLibro_TextChanged(object sender, EventArgs e)
        {
            foreach (Libro libro in libros)
            {
                if (tbCodigoLibro.Text == libro.Id.ToString())
                {
                    lblDatosLibro.Text = $"Codigo: {libro.Id}" + "\n" + "\n" + "\n"
                    + $"Título: {libro.Titulo}" + "\n" + "\n"
                    + $"Autor: {libro.Autor}" + "\n" + "\n"
                    + $"Editorial: {libro.Editorial}" + "\n" + "\n"
                    + $"Edición: {libro.Edicion}" + "\n" + "\n"
                    + $"Tema: {libro.Tema}" + "\n" + "\n"
                    + $"Paginas: {libro.Paginas}" + "\n" + "\n";

                    break;
                }
                else
                {
                    lblDatosLibro.Text = "Libro:";
                }
            }
        }
    }
}
