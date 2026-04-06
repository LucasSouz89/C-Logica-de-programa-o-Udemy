using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSobreposicao.Ex_2.Entites.Class
{
    internal class Arma
    {
        public int Municao { get;protected set; }


        public Arma() { }

        public Arma(int municao)
        {
            Municao = municao;
        }

        public virtual void Atirar()
        {
            Municao -= 1;
        }
    }
}
