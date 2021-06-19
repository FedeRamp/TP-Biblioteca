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

        private void LoadingPage_Shown(object sender, EventArgs e)
        {
            Progresar(0);
            clienteNegocio = new ClienteNegocio();
            Progresar(25);
            ejemplarNegocio = new EjemplarNegocio();
            Progresar(50);
            libroNegocio = new LibroNegocio();
            Progresar(75);
            prestamoNegocio = new PrestamoNegocio();
            Progresar(100);
            Start();
        }

        private void Start()
        {
            frmCliente frmClient = new frmCliente(clienteNegocio, ejemplarNegocio, prestamoNegocio, libroNegocio);
            frmClient.Show();
            this.Hide();

        }

        private void Progresar(int progreso)
        {
            progressBar1.Value = progreso;
        }


    }
}
