using ExericiosInterfaceEHerança.Ex2.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExericiosInterfaceEHerança.Ex2.Entites.Class
{
    internal class Porta
    {
        private readonly IDestravavel _destravavel;

        public Porta(IDestravavel destravavel)
        {
            _destravavel = destravavel;
        }

        public void TentarAbrir()
        {
            Console.WriteLine(_destravavel.Usar());
        }
    }
}
