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
    public class PrestamoNegocio
    {
        private List<Prestamo> prestamos = new List<Prestamo>();
        public PrestamoNegocio()
        {
            prestamos = PrestamoMapper.TraerTodos();
        }

        public void Update()
        {
            this.prestamos = PrestamoMapper.TraerTodos();
        }
        public List<Prestamo> ListaPrestamos()
        {
            return this.prestamos;
        }

        public List<Prestamo> PrestamosPorCliente(int idCliente)
        {
            List<Prestamo> resultado = new List<Prestamo>();
            foreach(Prestamo prestamo in prestamos)
            {
                if (prestamo.IdCliente == idCliente)
                    resultado.Add(prestamo);
            }
            return resultado;
        }

        public string InsertarPrestamo(int idCliente, int idEjemplar, int plazo)
        {
            Prestamo prestamo = new Prestamo(idCliente, idEjemplar, plazo, true, DateTime.Today, DateTime.Today.AddDays(plazo));
            TransactionResult tr = PrestamoMapper.Insertar(prestamo);
            return tr.ToString();
        }

        public string DevolverPrestamo(Prestamo prestamo)
        {
            TransactionResult tr = PrestamoMapper.Devolver(prestamo);
            return tr.ToString();
        }

        public string BorrarPrestamo(Prestamo prestamo)
        {
            TransactionResult tr = PrestamoMapper.Borrar(prestamo);
            return tr.ToString();
        }
    }
}
