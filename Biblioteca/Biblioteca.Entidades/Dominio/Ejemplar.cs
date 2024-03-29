﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    [DataContract]
    public class Ejemplar
    {
        private int idLibro;
        private string observaciones;
        private double precio;
        private DateTime fechaAlta;
        private int id;
        private string nombreLibro;

        public Ejemplar() { }

        public Ejemplar(int idLibro, string observaciones, double precio, 
                        DateTime fechaAlta, int id)
        {
            this.idLibro = idLibro;
            this.observaciones = observaciones;
            this.precio = precio;
            this.fechaAlta = fechaAlta;
            this.id = id;
        }

        [DataMember(Name = "idLibro")]
        public int IdLibro { get => idLibro; set => idLibro = value; }
        [DataMember(Name = "observaciones")]
        public string Observaciones { get => observaciones; set => observaciones = value; }
        [DataMember(Name = "precio")]
        public double Precio { get => precio; set => precio = value; }
        [DataMember(Name = "fechaAlta")]
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        [DataMember(Name = "id")]
        public int Id { get => id; set => id = value; }
        public string NombreLibro { get => nombreLibro; set => nombreLibro = value; }

        public override string ToString()
        {
            return $"{this.id}) Libro: {this.idLibro} ${this.precio}";
        }

        public string InfoCompleta()
        {
            return $"{this.id})\n\n{this.nombreLibro}\n\n(id: {this.idLibro})\n\nPrecio: ${this.precio}\n\n" +
                $"{this.observaciones}\n\nAlta: {this.fechaAlta}";
        }
    }
}
