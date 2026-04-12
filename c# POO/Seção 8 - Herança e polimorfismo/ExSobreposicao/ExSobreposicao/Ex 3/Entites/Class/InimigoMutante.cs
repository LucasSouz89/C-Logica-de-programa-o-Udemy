using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSobreposicao.Ex_3.Entites.Class
{
    internal class InimigoMutante :  Inimigo
    {
        public InimigoMutante() { }

        public InimigoMutante(int vida) : base(vida) { }

        public override void ReceberDano(int dmg)
        {
            
            if (Vida <= 50) {base.ReceberDano(dmg/2); Console.WriteLine("Dano reduzido pela caraça mutante"); }
            else base.ReceberDano(dmg);
        }
    }
}
