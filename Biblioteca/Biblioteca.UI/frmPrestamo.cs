using Biblioteca.Entidades;
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
    public partial class frmPrestamo : Form
    {
        private bool ingresarExpandido;
        private bool consultarExpandido;
        private ClienteNegocio clienteNegocio;
        private EjemplarNegocio ejemplarNegocio;
        private PrestamoNegocio prestamoNegocio;
        private LibroNegocio libroNegocio;

        public frmPrestamo(ClienteNegocio clienteNegocio, EjemplarNegocio ejemplarNegocio, PrestamoNegocio prestamoNegocio, LibroNegocio libroNegocio)
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

        private void navEjemplar_Click(object sender, EventArgs e)
        {
            frmEjemplar frmEjem = new frmEjemplar(clienteNegocio, ejemplarNegocio, prestamoNegocio, libroNegocio);
            frmEjem.Show();
            this.Hide();
        }

        private void navReportes_Click(object sender, EventArgs e)
        {
            frmReportes frmRep = new frmReportes(clienteNegocio, ejemplarNegocio, prestamoNegocio, libroNegocio);
            frmRep.Show();
            this.Hide();
        }

        //**Asociamiento de EventHandlers**//

        //      EXPANDIR Y CONTRAER ESPACIOS  //
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

        //          FIN EXPANDIR Y CONTRAER //


        // Carga de  DataSources
        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            IniciarClientes();
            IniciarEjemplares();
        }

        private void IniciarClientes()
        {
            comboBox1.DataSource = null;
            comboBox3.DataSource = null;
            comboBox1.DataSource = clienteNegocio.Traer();
            comboBox3.DataSource = clienteNegocio.Traer();

        }

        private void IniciarEjemplares()
        {
            comboBox2.DataSource = null;
            comboBox2.DataSource = ejemplarNegocio.Traer();
        }

        private void ActualizarPrestamos()
        {
            Cliente cliente = (Cliente)comboBox3.SelectedItem;
            listBox1.DataSource = prestamoNegocio.PrestamosPorCliente(cliente.Id);
        }

        private void btnListo_Click(object sender, EventArgs e)
        {       //Insertar nuevo Prestamo
            int plazo = 0;
            if (comboBox1.SelectedIndex != 0 || comboBox2.SelectedIndex != 0 || int.TryParse(txtPlazo.Text, out plazo))
            {
                Cliente cliente = (Cliente)comboBox1.SelectedItem;
                Ejemplar ejemplar = (Ejemplar)comboBox2.SelectedItem;
                prestamoNegocio.InsertarPrestamo(cliente.Id, ejemplar.Id, Convert.ToInt32(txtPlazo.Text));
                prestamoNegocio.Update();
                ActualizarPrestamos();
            } else
            {
                MessageBox.Show("Hay campos obligatorios sin rellenar o llenos incorrectamente");
            }

        }

        private void txtPlazo_KeyPress(object sender, KeyPressEventArgs e)
        { //Handled == true ---> Cancela el KeyPress
            //El método hace que el txtBox solo capture digitos
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {   //Actualiza los elementos de la lista segun el cliente seleccionado
            if (comboBox3.DataSource != null)
            {
                ActualizarPrestamos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = (Prestamo)listBox1.SelectedItem;
            prestamoNegocio.DevolverPrestamo(prestamo);
            prestamoNegocio.Update();
            ActualizarPrestamos();
        }

        private void btnMasInfo_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = (Prestamo)listBox1.SelectedItem;
            MessageBox.Show(prestamo.InfoCompleta());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfirmDelete confirm = new ConfirmDelete();
            confirm.ShowDialog();
            if (confirm.DialogResult == DialogResult.OK)
            {
                Prestamo prestamo = (Prestamo)listBox1.SelectedItem;
                prestamoNegocio.BorrarPrestamo(prestamo);
                prestamoNegocio.Update();
                ActualizarPrestamos();
            }
            
        }
    }
}
