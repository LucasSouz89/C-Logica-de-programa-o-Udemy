using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSobreposicao.Ex_3.Entites.Class
{
    internal class Inimigo
    {
        public int Vida { get;protected set; }

        public Inimigo() { }
        public Inimigo(int vida) { Vida = vida; }

        public virtual void ReceberDano(int dmg)
        {
            Vida -= dmg;
            if(Vida < 0) Vida = 0;
            Console.WriteLine($"Inimigo tomou dano. Vida:{Vida}");

        }
    }
}
