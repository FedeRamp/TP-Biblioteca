using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades.exceptions
{
    public class LibroNotFoundException : Exception
    {
        string _message;

        public LibroNotFoundException(string msg) : base()
        {
            _message = msg;
        }
    }
}
