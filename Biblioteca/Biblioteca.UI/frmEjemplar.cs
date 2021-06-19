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
    public partial class frmEjemplar : Form
    {
        private bool ingresarExpandido;
        private bool consultarExpandido;
        private ClienteNegocio clienteNegocio;
        private EjemplarNegocio ejemplarNegocio;
        private PrestamoNegocio prestamoNegocio;
        private LibroNegocio libroNegocio;

        public frmEjemplar(ClienteNegocio clienteNegocio, EjemplarNegocio ejemplarNegocio, PrestamoNegocio prestamoNegocio, LibroNegocio libroNegocio)
        {
            InitializeComponent();
            ingresarExpandido = false;
            consultarExpandido = false;
            this.clienteNegocio = clienteNegocio;
            this.ejemplarNegocio = ejemplarNegocio;
            this.prestamoNegocio = prestamoNegocio;
            this.libroNegocio = libroNegocio;
        }

        private void navLibro_Click(object sender, EventArgs e)
        {
            frmLibro frmLib = new frmLibro(clienteNegocio, ejemplarNegocio, prestamoNegocio, libroNegocio);
            frmLib.Show();
            this.Hide();
        }

        private void navCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmClient = new frmCliente(clienteNegocio, ejemplarNegocio, prestamoNegocio, libroNegocio);
            frmClient.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            ConfirmDelete confirm = new ConfirmDelete();
            confirm.ShowDialog();
            if (confirm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Borrra3");
            }
            else if (confirm.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Cancela2");
            }
        }

        private void frmEjemplar_Load(object sender, EventArgs e)
        {

        }
    }
}
