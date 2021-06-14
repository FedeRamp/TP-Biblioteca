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
        public frmReportes()
        {
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

        private void navLibro_Click(object sender, EventArgs e)
        {
            frmLibro frmLib = new frmLibro();
            frmLib.Show();
            this.Hide();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }
    }
}
