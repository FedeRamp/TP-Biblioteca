using Biblioteca.Entidades;
using Biblioteca.Entidades.exceptions;
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
        private bool libroEncontrado;
        private ClienteNegocio clienteNegocio;
        private EjemplarNegocio ejemplarNegocio;
        private PrestamoNegocio prestamoNegocio;
        private LibroNegocio libroNegocio;
        List<Libro> libros;
        List<Ejemplar> ejemplaresId;
        List<Prestamo> prestamos;
        internal List<Libro> Libros { get => libros; }

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

        internal void TraerCodigo(int idLibro, TextBox textbox)
        {
            textbox.Text = idLibro.ToString();
        }

        private void frmEjemplar_Load(object sender, EventArgs e)
        {
            libros = libroNegocio.traerTodos; //CORROBORAR EL ACCESO A LA LISTA.
        }

        private void btnBusquedaAvanzadaIngresar_Click(object sender, EventArgs e)
        {
            Form frmBusc = new frmBuscar();
            frmBusc.Owner = this;
            ((frmBuscar)frmBusc).Textbox = tbCodigoLibroIngresar; //TextBox a llenar con el código seleccionado.
            frmBusc.Show();
        }

        private void tbCodigoLibroIngresar_TextChanged(object sender, EventArgs e)
        {
            foreach (Libro libro in libros)
            {
                if (tbCodigoLibroIngresar.Text == libro.Id.ToString())
                {
                    lblDatosLibro.Text = libro.InfoCompletaLabel();
                    libroEncontrado = true;
                    break;
                }
                else
                {
                    lblDatosLibro.Text = "Libro:";
                    libroEncontrado = false;
                }
            }
        }


        private void btnBusquedaAvanzadaConsultar_Click(object sender, EventArgs e)
        {
            Form frmBusc = new frmBuscar();
            frmBusc.Owner = this;
            ((frmBuscar)frmBusc).Textbox = tbCodigoLibroConsultar; //TextBox a llenar con el código seleccionado.
            frmBusc.Show();
        }

        private void tbCodigoLibroConsultar_TextChanged(object sender, EventArgs e)
        {
            lstbResultado.DataSource = null;
            ejemplaresId = new List<Ejemplar>();

            foreach (Libro libro in libros)
            {
                if (tbCodigoLibroConsultar.Text == libro.Id.ToString())
                {
                    lblTituloLibro.Text = $"Libro: {libro.Titulo}";
                    break;
                }
                else
                {
                    lblTituloLibro.Text = "Libro: ";
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tbCodigoLibroConsultar.Text != string.Empty)
            {
                try
                {
                    ejemplaresId = ejemplarNegocio.TraerPorId(Convert.ToInt32(tbCodigoLibroConsultar.Text));
                    AsignarNombreLibro();
                    MostrarEjemplares();
                    if (ejemplaresId.Count == 0)
                    {
                        MessageBox.Show("No se han encontrado ejemplares.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void AsignarNombreLibro()
        {
            foreach (Ejemplar ej in ejemplaresId)
            {
                ej.NombreLibro = lblTituloLibro.Text;
            }
        }
        private void MostrarEjemplares()
        {
            
            if (ejemplaresId.Count > 0) 
            {
                if (cbDisponibles.Checked && cbNoDisponibles.Checked)
                {
                    lstbResultado.DataSource = null;
                    lstbResultado.DataSource = ejemplaresId;
                }
                else
                {
                    prestamos = prestamoNegocio.ListaPrestamos();
                    List<Ejemplar> yaPrestados = new List<Ejemplar>();
                    List<Ejemplar> noPrestados = new List<Ejemplar>();
                                       
                    foreach (Ejemplar ej in ejemplaresId)
                    {
                        bool prestado = false;
                        foreach (Prestamo pres in prestamos)
                        {
                            if (ej.Id == pres.IdEjemplar && pres.Abierto)
                            {
                                yaPrestados.Add(ej);
                                prestado = true;
                                break;
                            }
                        }
                        if (!prestado)
                        {
                            noPrestados.Add(ej);
                        }
                    }
                    
                    if (cbDisponibles.Checked)
                    {
                        lstbResultado.DataSource = null;
                        lstbResultado.DataSource = noPrestados;
                    }
                    if (cbNoDisponibles.Checked)
                    {
                        lstbResultado.DataSource = null;
                        lstbResultado.DataSource = yaPrestados;
                    }
                    if (!cbDisponibles.Checked && !cbNoDisponibles.Checked)
                    {
                        cbDisponibles.CheckState = CheckState.Checked;
                        cbNoDisponibles.CheckState = CheckState.Checked;                        
                    }
                }
            }            
        }

        private void cbDisponibles_CheckedChanged(object sender, EventArgs e)
        {
            MostrarEjemplares();
        }

        private void cbNoDisponibles_CheckedChanged(object sender, EventArgs e)
        {
            MostrarEjemplares();
        }

        private void btnMasInfo_Click(object sender, EventArgs e)
        {
            try 
            {
                Ejemplar ejemplar = (Ejemplar)lstbResultado.SelectedItem;

                string disponibilidad = MostrarDisponibilidad(ejemplar);

                MessageBox.Show(ejemplar.InfoCompleta() + $"\n\nEstado: {disponibilidad}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }     
            
        }
        private string MostrarDisponibilidad(Ejemplar ejemplar)
        {
            
                prestamos = prestamoNegocio.ListaPrestamos();
                string disponibilidad = "DISPONIBLE";

                foreach (Prestamo pres in prestamos)
                {
                    if (ejemplar == null)
                    {
                        throw new Exception("La lista de ejemplares esta vacia, intente con otro codigo");
                    }
                    if (ejemplar.Id == pres.IdEjemplar && pres.Abierto)
                    {
                        disponibilidad = "NO DISPONIBLE";
                        break;
                    }
                    
                }

                return disponibilidad;
            
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbObservaciones.Text == string.Empty || tbPrecio.Text == string.Empty || tbCodigoLibroIngresar.Text == string.Empty)
            {
                MessageBox.Show("Complete todos los campos.","Completar", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }            
            else
            {
                if (!libroEncontrado)
                {
                    MessageBox.Show("Libro no encontrado.\nIntente con un Código diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {   
                    var result = MessageBox.Show("¿Confirma el alta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            MessageBox.Show(AgregarEjemplar());

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }                    
                }               
            }                
        }
        private string AgregarEjemplar()
        {         
          
           int idLibro = Convert.ToInt32(tbCodigoLibroIngresar.Text);
           string observaciones = tbObservaciones.Text;
           double precio = ValidarPrecio();

           return ejemplarNegocio.Insertar(idLibro, observaciones, precio);
        }

        private void tbCodigoLibroIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void tbCodigoLibroConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!tbPrecio.Text.Contains(","))
            {
                if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == Convert.ToChar(","))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }              

            }            
        }

        private double ValidarPrecio()
        {
            double precio;
            if (!Double.TryParse(tbPrecio.Text, out precio))
            {
                throw new ErrorEnElPrecioException("Error en el precio.");
            }

            return precio;
        }

        private void tbPrecio_Leave(object sender, EventArgs e)
        {
            try
            {
                if (tbPrecio.Text.Contains(","))
                {
                    tbPrecio.Text = Math.Round(ValidarPrecio(), 2).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
