using Biblioteca.Negocio;
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
    public partial class frmReportes : Form
    {
        private ClienteNegocio clienteNegocio;
        private EjemplarNegocio ejemplarNegocio;
        private PrestamoNegocio prestamoNegocio;
        private LibroNegocio libroNegocio;

        public frmReportes(ClienteNegocio clienteNegocio, EjemplarNegocio ejemplarNegocio, PrestamoNegocio prestamoNegocio, LibroNegocio libroNegocio)
        {
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

        private void navLibro_Click(object sender, EventArgs e)
        {
            frmLibro frmLib = new frmLibro(clienteNegocio, ejemplarNegocio, prestamoNegocio, libroNegocio);
            frmLib.Show();
            this.Hide();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }
    }
}
