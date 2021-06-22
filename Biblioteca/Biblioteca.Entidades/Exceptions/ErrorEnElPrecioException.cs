using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades.exceptions
{
    public class ErrorEnElPrecioException : Exception
    {
        string _message;

        public ErrorEnElPrecioException(string msg) : base()
        {
            _message = msg;
        }
    }
}
