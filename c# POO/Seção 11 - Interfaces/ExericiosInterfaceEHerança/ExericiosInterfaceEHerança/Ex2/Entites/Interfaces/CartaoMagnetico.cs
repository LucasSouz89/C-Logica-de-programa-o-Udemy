using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExericiosInterfaceEHerança.Ex2.Entites.Interfaces
{
    internal class CartaoMagnetico : IDestravavel
    {
        public string Usar()
        {
            return "Passando o cartão no leitor eletrônico. Bipe verde!";
        }
    }
}
