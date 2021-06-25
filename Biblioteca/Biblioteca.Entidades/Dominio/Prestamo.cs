using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    [DataContract]
    public class Prestamo
    {
        private int idCliente;
        private int idEjemplar;
        private int plazo;
        private bool abierto;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucionTentativa;
        private int id;
        private DateTime? fechaDevolucionReal;

        public Prestamo() { }
        public Prestamo(int idCliente, int idEjemplar, int plazo,
                        bool abierto, DateTime fechaPrestamo, 
                        DateTime fechaDevolucionTentativa)
        {
            this.idCliente = idCliente;
            this.idEjemplar = idEjemplar;
            this.plazo = plazo;
            this.abierto = abierto;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaDevolucionTentativa = fechaDevolucionTentativa;
        }
        [DataMember(Name = "idCliente")]
        public int IdCliente { get => idCliente; set => idCliente = value; }
        [DataMember(Name = "idEjemplar")]
        public int IdEjemplar { get => idEjemplar; set => idEjemplar = value; }
        [DataMember(Name = "plazo")]
        public int Plazo { get => plazo; set => plazo = value; }
        [DataMember(Name = "abierto")]
        public bool Abierto { get => abierto; set => abierto = value; }
        [DataMember(Name = "fechaPrestamo")]
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        [DataMember(Name = "fechaDevolucionTentativa")]
        public DateTime FechaDevolucionTentativa { get => fechaDevolucionTentativa; set => fechaDevolucionTentativa = value; }
        [DataMember(Name = "id")]
        public int Id { get => id; set => id = value; }
        [DataMember(Name = "fechaDevolucionReal")]
        public DateTime? FechaDevolucionReal { get => fechaDevolucionReal; set => fechaDevolucionReal = value; }

        public override string ToString()
        {
            string ac = abierto ? "devolver" : "devuelto";
            return $"{this.id}) cliente {this.IdCliente} pidió ejemplar {this.IdEjemplar} - {ac}";
        }

        public string InfoCompleta()
        {
            string ac = abierto ? "devolver" : "devuelto";
            string resultado = $"{this.id}) cliente {this.IdCliente} pidió ejemplar {this.IdEjemplar} - {ac}" +
                $"\nInicio: {this.fechaPrestamo} por {this.plazo} dias (devolucion: {this.fechaDevolucionTentativa})";
            if (!abierto)
            {
                resultado += $"\nDevuelto el {this.fechaDevolucionReal}";
            }
            return resultado;
        }
    }
}
