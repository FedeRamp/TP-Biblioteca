using Biblioteca.Entidades;
using Biblioteca.Entidades.Modelos;
using Biblioteca.Negocio;
using Biblioteca.UI.ComponentesCustom;
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
    public partial class frmLibro : Form
    {
        private bool ingresarExpandido;
        private bool consultarExpandido;
        private ClienteNegocio clienteNegocio;
        private EjemplarNegocio ejemplarNegocio;
        private PrestamoNegocio prestamoNegocio;
        private LibroNegocio libroNegocio;

        public frmLibro(ClienteNegocio clienteNegocio, EjemplarNegocio ejemplarNegocio, PrestamoNegocio prestamoNegocio,LibroNegocio libroNegocio)
        {
            ingresarExpandido = false;
            consultarExpandido = false;
            this.clienteNegocio = clienteNegocio;
            this.ejemplarNegocio = ejemplarNegocio;
            this.prestamoNegocio = prestamoNegocio;
            this.libroNegocio = libroNegocio;
            InitializeComponent();
        }

        private void navCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmClient = new frmCliente(clienteNegocio, ejemplarNegocio, prestamoNegocio, libroNegocio);
            frmClient.Show();
            this.Hide();
        }

        private void navEjemplar_Click(object sender, EventArgs e)
        {
            frmEjemplar frmEjem = new frmEjemplar(clienteNegocio, ejemplarNegocio, prestamoNegocio, libroNegocio);
            frmEjem.Show();
            this.Hide();
        }

        private void navPrestamo_Click(object sender, EventArgs e)
        {
            frmPrestamo frmPrest = new frmPrestamo(clienteNegocio, ejemplarNegocio, prestamoNegocio, libroNegocio);
            frmPrest.Show();
            this.Hide();
        }

        private void navReportes_Click(object sender, EventArgs e)
        {
            frmReportes frmRep = new frmReportes(clienteNegocio, ejemplarNegocio, prestamoNegocio, libroNegocio);
            frmRep.Show();
            this.Hide();
        }

        //**Asociamiento de EventHandlers**//
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
            try
            {
                lblConsultar.Text = "v Consultar";
                panelConsultar.Visible = true;
                consultarExpandido = true;
                this.lstListaLibros.DataSource = null;
                this.lstListaLibros.DataSource = libroNegocio.traerTodos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnListo_Click(object sender, EventArgs e)
        {
            try
            {
                validar();
                TransactionResult tr = libroNegocio.insertarLibro(txtEdicion.Text, txtPaginas.Text, txtTitulo.Text, txtAutor.Text, txtEditorial.Text, txtTema.Text);
                if (tr.IsOk)
                {
                    MessageBox.Show(tr.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void validar()
        {
            if (txtAutor.Text == null || txtEdicion.Text == null || txtEditorial.Text == null
                 || txtPaginas.Text == null || txtTema.Text == null || txtTitulo == null)
            {
                throw new Exception("Alguno de los parametros obligatorios estan vacios");
            }

        }


        private void txtEdicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txtPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.lstListaLibros.DataSource = null;
            this.lstListaLibros.DataSource = libroNegocio.getTodos();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void frmLibro_Load(object sender, EventArgs e)
        {

        }

        private void btnMasInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Libro libroElegido = (Libro)lstListaLibros.SelectedItem;
                if (libroElegido == null)
                {
                    throw new Exception("La lista de libros se encuentra vacia");
                }
                MessageBox.Show(libroElegido.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}