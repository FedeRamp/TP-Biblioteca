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
    public class PrestamoMapper
    {
        static public List<Prestamo> TraerTodos()
        {
            string json2 = WebHelper.Get("Biblioteca/Prestamos");
            List<Prestamo> resultado = MapList(json2);
            return resultado;
        }
        static private List<Prestamo> MapList(string json)
        {
            List<Prestamo> lst = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return lst;
        }
        static public TransactionResult Insertar(Prestamo prestamo)
        {
            NameValueCollection obj = ReverseMap(prestamo);//Convierte el prestamo en un NVC

            string json = WebHelper.Post("Biblioteca/Prestamos", obj);//Devuelve el texto del json del resultado de la operacion

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);//Convertimos el texto a un objeto
            //Devolvemos el objeto TransactionResult
            return lst;
        }

        static public TransactionResult Borrar(Prestamo prestamo)
        {
            NameValueCollection obj = ReverseMap(prestamo);//Convierte el prestamo en un NVC

            string json = WebHelper.Delete("Biblioteca/Prestamos", obj);//Devuelve el texto del json del resultado de la operacion

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);//Convertimos el texto a un objeto
            //Devolvemos el objeto TransactionResult
            return lst;
        }
        static private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idCliente", prestamo.IdCliente.ToString());
            n.Add("idEjemplar", prestamo.IdEjemplar.ToString());
            n.Add("plazo", prestamo.Plazo.ToString());
            n.Add("abierto", prestamo.Abierto.ToString());
            n.Add("fechaPrestamo", prestamo.FechaPrestamo.ToString());
            n.Add("fechaDevolucionTentativa", prestamo.FechaDevolucionTentativa.ToString());
            n.Add("id", prestamo.Id.ToString());
            return n;
        }

        static public TransactionResult Devolver(Prestamo prestamo)
        {
            NameValueCollection nvc = RevMapDevolver(prestamo);
            string json = WebHelper.Put("Biblioteca/Prestamos", nvc);

            TransactionResult tr = JsonConvert.DeserializeObject<TransactionResult>(json);
            return tr;
        }

        static private NameValueCollection RevMapDevolver(Prestamo prestamo)
        {
            NameValueCollection res = new NameValueCollection();
            res.Add("idCliente", prestamo.IdCliente.ToString());
            res.Add("idEjemplar", prestamo.IdEjemplar.ToString());
            res.Add("plazo", prestamo.Plazo.ToString());
            res.Add("abierto", "false");
            res.Add("fechaPrestamo", prestamo.FechaPrestamo.ToString("dd-MM-yyyy"));
            res.Add("fechaDevolucionTentativa", prestamo.FechaDevolucionTentativa.ToString("dd-MM-yyyy"));
            res.Add("fechaDevolucionReal", DateTime.Today.ToString("dd-MM-yyyy"));
            res.Add("id", prestamo.Id.ToString());
            return res;
        }
    }
}
