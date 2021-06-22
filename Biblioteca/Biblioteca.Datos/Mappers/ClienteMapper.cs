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
    public class ClienteMapper
    {
        static public List<Cliente> TraerTodos()
        {
            string json2 = WebHelper.Get("cliente");
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }
        static private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lst;
        }
        static public TransactionResult Insertar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);//Convierte el prestamo en un NVC

            string json = WebHelper.Post("cliente", obj);//Devuelve el texto del json del resultado de la operacion

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);//Convertimos el texto a un objeto
            //Devolvemos el objeto TransactionResult
            return lst;
        }

        static public TransactionResult Borrar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);//Convierte el prestamo en un NVC

            string json = WebHelper.Delete("cliente", obj);//Devuelve el texto del json del resultado de la operacion

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);//Convertimos el texto a un objeto
            //Devolvemos el objeto TransactionResult
            return lst;
        }
        static private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("DNI", cliente.Dni.ToString());
            n.Add("nombre", cliente.Nombre.ToString());
            n.Add("apellido", cliente.Apellido.ToString());
            n.Add("email", cliente.Email.ToString());
            n.Add("telefono", cliente.Telefono.ToString());
            n.Add("fechaNacimiento", cliente.FechaNacimiento.ToString("dd-MM-yyyy"));
            n.Add("fechaAlta", DateTime.Today.ToString("dd-MM-yyyy"));
            n.Add("activo", cliente.Activo.ToString());
            n.Add("id", "0");
            return n;
        }
    }
}
