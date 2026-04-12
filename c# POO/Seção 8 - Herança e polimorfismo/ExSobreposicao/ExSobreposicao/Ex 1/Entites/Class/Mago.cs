using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSobreposicao.Ex_1.Entites.Class
{
    internal class Mago : Campeao
    {
        public Mago() { }
        public Mago(string nome, double mana) :  base(nome, mana)
        {
            
        }
        public override void UsarUltimate()
        {
            Console.WriteLine($"{Nome} conjurou uma explosão mágica devastadora em área!");
            Mana -= 100;
        }
    }
}
