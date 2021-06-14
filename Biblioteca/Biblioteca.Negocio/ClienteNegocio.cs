using Biblioteca.Datos.Mappers;
using Biblioteca.Entidades;
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
    }
}
