using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    [DataContract]
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private DateTime fechaNacimiento;

        [DataMember(Name = "nombre")]
        public string Nombre { get => nombre; set => nombre = value; }

        [DataMember(Name = "apellido")]
        public string Apellido { get => apellido; set => apellido = value; }
        
        [DataMember(Name = "DNI")]
        public int Dni { get => dni; set => dni = value; }

        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}
