using ExericiosInterfaceEHerança.Ex3.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExericiosInterfaceEHerança.Ex3.Entites.Class
{
    abstract class Arma
    {

        public string Nome { get;private set; }
        protected readonly IEFeitoTiro _efeitoTiro;

        public Arma(string nome,IEFeitoTiro efeitoTiro) { _efeitoTiro = efeitoTiro;Nome = nome; }

        public abstract void PuxarGatilho();
    }
}
