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
    public partial class frmCliente : Form
    {
        private bool ingresarExpandido;
        private bool consultarExpandido;
        private ClienteNegocio clienteNegocio;
        private EjemplarNegocio ejemplarNegocio;
        private PrestamoNegocio prestamoNegocio;
        private LibroNegocio libroNegocio;

        public frmCliente(ClienteNegocio clienteNegocio, EjemplarNegocio ejemplarNegocio, PrestamoNegocio prestamoNegocio, LibroNegocio libroNegocio)
        {
            InitializeComponent();
            ingresarExpandido = false;
            consultarExpandido = false;
            this.clienteNegocio = clienteNegocio;
            this.ejemplarNegocio = ejemplarNegocio;
            this.prestamoNegocio = prestamoNegocio;
            this.libroNegocio = libroNegocio;
        }
        //***CONTROLES NAVEGACION***//
        private void navLibro_Click(object sender, EventArgs e)
        {
            frmLibro frmLib = new frmLibro(clienteNegocio, ejemplarNegocio, prestamoNegocio, libroNegocio);
            frmLib.Show();
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

        private void navReportes_Click(object sender, EventArgs e)
        {
            frmReportes frmRep = new frmReportes(clienteNegocio, ejemplarNegocio, prestamoNegocio, libroNegocio);
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
            } else if (ingresarExpandido)
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

        private void frmCliente_Load(object sender, EventArgs e)
        {
            IniciarClientes();
        }

        private void IniciarClientes()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = clienteNegocio.Traer();
        }

        private void ActualizarClientes()
        {
            clienteNegocio.Update();
            comboBox1.DataSource = clienteNegocio.Traer();
        }

        private void ActualizarPrestamos(Cliente cliente)
        {
            listBox1.DataSource = prestamoNegocio.PrestamosPorCliente(cliente.Id);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.DataSource != null)
            {
                Cliente cliente = (Cliente)comboBox1.SelectedItem;
                ActualizarPrestamos(cliente);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)comboBox1.SelectedItem;
            BorrarCliente(cliente);
        }

        private void BorrarCliente(Cliente cliente)
        {
            ConfirmDelete confirm = new ConfirmDelete();
            confirm.ShowDialog();
            if (confirm.DialogResult == DialogResult.OK)
            {
                clienteNegocio.BorrarCliente(cliente);
                ActualizarClientes();
            }

        }

        private void btnMasInfo_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)comboBox1.SelectedItem;
            MessageBox.Show(cliente.InfoCompleta());
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text;
            DateTime fechaNacimiento = dateTimePicker1.Value;
            try
            {
                int dni = Convert.ToInt32(txtDNI.Text);
                MessageBox.Show( clienteNegocio.InsertarCliente(dni, nombre, apellido, direccion, email, telefono, fechaNacimiento));
                ActualizarClientes();
                LimpiarIngreso();
            }
            catch (OverflowException oe)
            {
                MessageBox.Show("El DNI ingresado es muy largo");
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Utilizar sólo números para el DNI");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }

        private void LimpiarIngreso()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtDNI.Text = "";
            txtTelefono.Text = "";
            dateTimePicker1.Value = DateTime.Today;

        }
    }
}
