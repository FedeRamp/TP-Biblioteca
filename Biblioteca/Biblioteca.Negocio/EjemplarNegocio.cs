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
    public class EjemplarNegocio
    {
        private List<Ejemplar> ejemplares;


        public EjemplarNegocio()
        {
            ejemplares = EjemplarMapper.TraerTodos();
        }

        public void Update()
        {
            ejemplares = EjemplarMapper.TraerTodos();
        }


        public string Insertar(int idLibro, string observaciones, double precio)
        {
            Ejemplar ejemplar = new Ejemplar(idLibro, observaciones, precio, DateTime.Today, 0);
            TransactionResult tr = EjemplarMapper.Insertar(ejemplar);
            return tr.ToString();

        }

        public List<Ejemplar> TraerPorId(int idLibro)
        {
            return EjemplarMapper.TraerPorId(idLibro);
        }
        public List<Ejemplar> Traer() 
        {
            return ejemplares;
        }

    }
}
