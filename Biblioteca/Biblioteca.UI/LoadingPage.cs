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
    public partial class LoadingPage : Form
    {
        private ClienteNegocio clienteNegocio;
        private EjemplarNegocio ejemplarNegocio;
        private LibroNegocio libroNegocio;
        private PrestamoNegocio prestamoNegocio;

        public LoadingPage()
        {
            InitializeComponent();
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {
            
            
        }

        private void Start()
        {
            frmCliente frmClient = new frmCliente(clienteNegocio, ejemplarNegocio, prestamoNegocio, libroNegocio);
            frmClient.Show();
            this.Hide();
        }

        private void LoadingPage_Shown(object sender, EventArgs e)
        {
            clienteNegocio = new ClienteNegocio();
            progressBar1.Value = 25;
            ejemplarNegocio = new EjemplarNegocio();
            progressBar1.Value = 50;
            libroNegocio = new LibroNegocio();
            progressBar1.Value = 75;
            prestamoNegocio = new PrestamoNegocio();
            progressBar1.Value = 100;
            Start();
        }
    }
}
