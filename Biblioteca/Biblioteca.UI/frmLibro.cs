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
        private bool ingresarExpandido = false;
        private bool consultarExpandido = true;
        private LibroNegocio _libroNegocio;

        public frmLibro()
        {
            _libroNegocio = new LibroNegocio();
            InitializeComponent();
        }

        private void navCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmClient = new frmCliente();
            frmClient.Show();
            this.Hide();
        }

        private void navEjemplar_Click(object sender, EventArgs e)
        {
            frmEjemplar frmEjem = new frmEjemplar();
            frmEjem.Show();
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
                this.lstListaLibros.DataSource = _libroNegocio.traerTodos();
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
                TransactionResult tr = _libroNegocio.insertarLibro(txtEdicion.Text, txtPaginas.Text, txtTitulo.Text, txtAutor.Text, txtEditorial.Text, txtTema.Text);

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
            this.lstListaLibros.DataSource = _libroNegocio.traerTodos();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ConfirmDelete confirm = new ConfirmDelete();
            confirm.ShowDialog();
            if(confirm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Borrra3");
            } else if(confirm.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Cancela2");
            }
        }
    }
}