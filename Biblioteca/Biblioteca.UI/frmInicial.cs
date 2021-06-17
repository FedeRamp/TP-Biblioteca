using Biblioteca.Entidades;
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
    public partial class frmInicial : Form
    {
        List<Libro> libros;
        LibroNegocio libroNegocio = new LibroNegocio();
        public List<Libro> Libros { get => libros; set => libros = value; } //getter y setter para poder trabajar con esta lista
        public frmInicial()
        {
            InitializeComponent();
        }

        

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            libros = libroNegocio.traerTodos(); //Trae por unica vez los libros de la API al iniciar.

            frmCliente frmCli = new frmCliente();
            frmCli.Owner = this;

            frmLibro frmLib = new frmLibro();
            frmLib.Owner = this;

            frmEjemplar frmEjem = new frmEjemplar(); //Crea nuevo form + this = owner 
            frmEjem.Owner = this;

            frmPrestamo frmPrest = new frmPrestamo();
            frmPrest.Owner = this;

            frmReportes frmRep = new frmReportes();
            frmRep.Owner = this;


            frmCli.Show();
            this.Hide();
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
