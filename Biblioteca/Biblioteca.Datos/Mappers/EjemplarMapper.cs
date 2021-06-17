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
    public class EjemplarMapper
    {
        static public List<Ejemplar> TraerTodos()
        {
            string json2 = WebHelper.Get("Biblioteca/Ejemplares");
            List<Ejemplar> resultado = MapList(json2);
            return resultado;
        }
        static public Ejemplar TraerEjemplar(int idLibro)
        {
            string json2 = WebHelper.Get($"Biblioteca/Ejemplares/{idLibro}");
            Ejemplar resultado = MapObject(json2);
            return resultado;
        }
        static private List<Ejemplar> MapList(string json)
        {
            List<Ejemplar> lst = JsonConvert.DeserializeObject<List<Ejemplar>>(json);
            return lst;
        }
        static private Ejemplar MapObject(string json)
        {
            Ejemplar ej = JsonConvert.DeserializeObject<Ejemplar>(json);
            return ej;
        }

        static public TransactionResult Insertar(Ejemplar ejemplar)
        {
            NameValueCollection obj = ReverseMap(ejemplar);//Convierte el ejemplar en un NVC

            string json = WebHelper.Post("Biblioteca/Ejemplares", obj);//Devuelve el texto del json del resultado de la operacion

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);//Convertimos el texto a un objeto
            //Devolvemos el objeto TransactionResult
            return lst;
        }

        static private NameValueCollection ReverseMap(Ejemplar ejemplar)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idLibro", ejemplar.IdLibro.ToString());
            n.Add("Observaciones", ejemplar.Observaciones);
            n.Add("Precio", ejemplar.Precio.ToString());
            n.Add("FechaAlta", ejemplar.FechaAlta.ToString());
            n.Add("id", ejemplar.Id.ToString());
            return n;
        }
    }
}
