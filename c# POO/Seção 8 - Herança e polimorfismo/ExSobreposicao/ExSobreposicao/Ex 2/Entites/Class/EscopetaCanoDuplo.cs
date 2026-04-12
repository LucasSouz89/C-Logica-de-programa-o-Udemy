using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExSobreposicao.Ex_2.Entites.Class;

namespace ExSobreposicao.Ex_2.Entites.Class
{
    internal class EscopetaCanoDuplo : Arma
    {
        public EscopetaCanoDuplo() { }

        public EscopetaCanoDuplo(int municao): base(municao) { }

        public override void Atirar()
        {
            base.Atirar();
            base.Atirar();
            Console.WriteLine("BOOM! Disparo duplo estraçalhou o alvo!");
            Console.WriteLine($"Municao {Municao}");
        }

    }
}
