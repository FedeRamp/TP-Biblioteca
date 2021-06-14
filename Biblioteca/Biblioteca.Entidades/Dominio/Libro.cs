using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    [DataContract]
    public class Libro
    {
        private int edicion;
        private int paginas;
        private string titulo;
        private string autor;
        private string editorial;
        private string tema;
        private int id;

        public Libro() { }

        public Libro(int edicion, int paginas, string titulo, 
                     string autor, string editorial, string tema,
                     int id)
        {
            this.edicion = edicion;
            this.paginas = paginas;
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.tema = tema;
            this.id = id;
        }

        [DataMember (Name = "edicion")]
        public int Edicion { get => edicion; set => edicion = value; }
        [DataMember(Name = "paginas")]
        public int Paginas { get => paginas; set => paginas = value; }
        [DataMember(Name = "titulo")]
        public string Titulo { get => titulo; set => titulo = value; }
        [DataMember(Name = "autor")]
        public string Autor { get => autor; set => autor = value; }
        [DataMember(Name = "editorial")]
        public string Editorial { get => editorial; set => editorial = value; }
        [DataMember(Name = "tema")]
        public string Tema { get => tema; set => tema = value; }
        [DataMember(Name = "id")]
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return $"{this.id}) {this.titulo} por {this.autor} {this.edicion}ed. Editorial {this.editorial}";
        }

        public string InfoCompleta()
        {
            return $"{this.id}) {this.titulo} por {this.autor} {this.edicion}ed. Editorial {this.editorial}" +
                $"{this.paginas} pags.\nTema: {this.tema}";
        }
    }
}
