using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecoesPersonalizadas.Entites.Exceptions
{
    sealed class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
