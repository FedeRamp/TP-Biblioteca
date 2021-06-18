using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Biblioteca.Entidades
{
    [DataContract]
    public class Cliente : Persona
    {
        private string direccion;
        private string email;
        private string telefono;
        private DateTime fechaAlta;
        private bool activo;
        private int id;

        public Cliente(int dni, string nombre, string apellido, string direccion, string email, 
            string telefono, DateTime fechaNacimiento, DateTime fechaAlta, bool activo) 
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.direccion = direccion;
            this.email = email;
            this.telefono = telefono; 
            this.FechaNacimiento = fechaNacimiento;
            this.fechaAlta = fechaAlta;
            this.activo = activo;
        }

        public Cliente() { }

        [DataMember(Name = "direccion")]
        public string Direccion { get => direccion; set => direccion = value; }
        [DataMember(Name = "email")]
        public string Email { get => email; set => email = value; }
        [DataMember(Name = "telefono")]
        public string Telefono { get => telefono; set => telefono = value; }
        [DataMember(Name = "fechaAlta")]
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        [DataMember(Name = "activo")]
        public bool Activo { get => activo; set => activo = value; }
        [DataMember(Name = "id")]
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return $"{this.id}) {this.Nombre} {this.Apellido}";
        }

        public string InfoCompleta()
        {
            string ac = Activo ? "activo" : "inactivo";
            return $"{this.id}) {this.Nombre} {this.Apellido}\n" +
                $"{this.direccion}\n{this.email}\n{this.telefono}\nAlta: {this.fechaAlta}\n{ac}";
        }
    }
}
