using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_fixação.Exceptions
{
    sealed class ExceptionDomain : ApplicationException
    {
        public ExceptionDomain(string message) : base(message) { }
    }
}
