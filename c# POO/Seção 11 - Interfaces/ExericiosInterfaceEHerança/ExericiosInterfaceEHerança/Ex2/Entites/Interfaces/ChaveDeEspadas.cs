using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExericiosInterfaceEHerança.Ex2.Entites.Interfaces
{
    internal class ChaveDeEspadas : IDestravavel
    {
        public string Usar()
        {
            return "Girando a chave de metal na fechadura antiga...";
        }
    }
}
