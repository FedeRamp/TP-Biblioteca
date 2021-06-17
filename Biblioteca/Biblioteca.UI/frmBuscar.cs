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
    public partial class frmBuscar : Form
    {
        List<Libro> aMostrar;
        List<Libro> libros = new List<Libro>();
        LibroNegocio libroNegocio = new LibroNegocio();
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            libros = ((frmEjemplar)Owner).Libros;
            lstBuscar.DataSource = libros;
        }

        private void MostrarLista()
        {
            bool tituloChecked = false;
            bool autorChecked = false;
            bool editorialChecked = false;
            aMostrar = new List<Libro>();

            

            foreach (var item in clbBuscarPor.CheckedItems)
            {
                if (item.ToString() == "Título")
                {
                    tituloChecked = true;
                }
                if (item.ToString() == "Autor")
                {
                    autorChecked = true;
                }
                if (item.ToString() == "Editorial")
                {
                    editorialChecked = true;
                }
            }
            if (tituloChecked || autorChecked || editorialChecked)
            {
                foreach (Libro l in libros)
                {
                    bool agregado = false;
                
                    if (tituloChecked)
                    {
                        if (l.Titulo != null && l.Titulo.ToUpper().Contains(tbBuscar.Text.ToUpper()))
                        {
                            aMostrar.Add(l);
                            agregado = true;
                        }
                    }
                    if (autorChecked && !agregado)
                    {
                        if (l.Autor != null && l.Autor.ToUpper().Contains(tbBuscar.Text.ToUpper()))
                        {
                            aMostrar.Add(l);
                            agregado = true;
                        }
                    }
                    if (editorialChecked && !agregado)
                    {
                        if (l.Editorial != null && l.Editorial.ToUpper().Contains(tbBuscar.Text.ToUpper()))
                        {
                            aMostrar.Add(l);
                        }
                    }
                }

                lstBuscar.DataSource = null;
                lstBuscar.DataSource = aMostrar;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbBuscar.Text.Length > 1) { MostrarLista(); }
                else { MessageBox.Show("Ingrese al menos 2 caracteres"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void lstBuscar_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                EnviarCodigo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                EnviarCodigo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EnviarCodigo()
        {
            Libro libro = (Libro)lstBuscar.SelectedItem;
            ((frmEjemplar)Owner).TraerCodigo(libro.Id);

            Owner.Show();
            this.Close();
        }

        private void lstBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBuscar.SelectedIndex > -1)
            {
                MostrarDatos();
            }
        }

        private void MostrarDatos()
        {
            Libro libro = (Libro)lstBuscar.SelectedItem;
            lblDatosLibro.Text = $"Codigo: {libro.Id}" + "\n" + "\n" + "\n"
                + $"Título: {libro.Titulo}" + "\n" + "\n"
                + $"Autor: {libro.Autor}" + "\n" + "\n"
                + $"Editorial: {libro.Editorial}" + "\n" + "\n"
                + $"Edición: {libro.Edicion}" + "\n" + "\n"
                + $"Tema: {libro.Tema}" + "\n" + "\n"
                + $"Paginas: {libro.Paginas}" + "\n" + "\n";
        }
    }
}
