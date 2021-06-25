using Biblioteca.Entidades;
using Biblioteca.Entidades.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Datos.Mappers
{
    public class LibroMapper
    {

        static private List<Libro> MapList(string json)
        {
            List<Libro> lst = JsonConvert.DeserializeObject<List<Libro>>(json);
            return lst;
        }

        static private Libro MapObjectCliente(string json)
        {
            Libro cli = JsonConvert.DeserializeObject<Libro>(json);
            return cli;
        }

        static private NameValueCollection ReverseMap(Libro libro)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("edicion", libro.Edicion.ToString());
            n.Add("paginas", libro.Paginas.ToString());
            n.Add("titulo", libro.Titulo);
            n.Add("autor", libro.Autor);
            n.Add("editorial", libro.Editorial);
            n.Add("tema", libro.Tema);
            return n;
        }

        static public TransactionResult insertarLibro(Libro libro)
        {
            NameValueCollection obj = ReverseMap(libro);

            string json = WebHelper.Post("Biblioteca/Libros", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            if (!lst.IsOk)
            {
                throw new Exception("No se pudo ingresar el libro para el id libro: " + libro.Id);
            }
            else
            {
                return lst;
            }
        }

        static public List<Libro> traerTodos()
        {
            try
            {
                string url = "Biblioteca/Libros/";
                string json2 = WebHelper.Get(url);
                List<Libro> resultado = MapList(json2);
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al traer libro");
            }
        }
    }
}