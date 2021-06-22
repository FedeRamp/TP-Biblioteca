using Biblioteca.Datos.Mappers;
using Biblioteca.Entidades;
using Biblioteca.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class ClienteNegocio
    {
        private List<Cliente> clientes;

        public ClienteNegocio()
        {
            clientes = ClienteMapper.TraerTodos();
        }

        public void Update()
        {
            this.clientes = ClienteMapper.TraerTodos();
        }

        public List<Cliente> Traer()
        {
            return this.clientes;
        }

        public string InsertarCliente(int dni, string nombre, string apellido, string direccion, string email, string telefono, DateTime fechaNacimiento)
        {
            Cliente cliente = new Cliente(dni, nombre, apellido, direccion, email, telefono, fechaNacimiento, DateTime.Today, true);
            TransactionResult tr = ClienteMapper.Insertar(cliente);
            return tr.ToString();
        }

        public string BorrarCliente(Cliente cliente)
        {
            TransactionResult tr = ClienteMapper.Borrar(cliente);
            return tr.ToString();
        }
    }
}
