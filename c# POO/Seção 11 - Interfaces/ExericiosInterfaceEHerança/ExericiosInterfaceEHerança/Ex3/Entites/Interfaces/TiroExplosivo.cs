using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExericiosInterfaceEHerança.Ex3.Entites.Interfaces
{
    internal class TiroExplosivo : IEFeitoTiro
    {
        public int CalcularDano() {  return 100; }
    }
}
