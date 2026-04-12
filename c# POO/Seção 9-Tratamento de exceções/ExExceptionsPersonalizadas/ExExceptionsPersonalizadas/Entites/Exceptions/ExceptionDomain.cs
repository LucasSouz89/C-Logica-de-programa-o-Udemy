using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExExceptionsPersonalizadas.Entites.Exceptions
{
    sealed class ExceptionDomain : ApplicationException
    {
        public ExceptionDomain(string message) : base(message) { }
    }
}
