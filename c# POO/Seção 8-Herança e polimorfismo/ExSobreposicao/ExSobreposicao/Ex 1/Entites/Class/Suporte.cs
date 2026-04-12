using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSobreposicao.Ex_1.Entites.Class
{
    internal class Suporte : Campeao
    {

        public Suporte() { }
        public Suporte(string nome, double mana) : base(nome,mana) { }

        public override void UsarUltimate()
        {
            Console.WriteLine($"{Nome} curou todos os aliados próximos!");
            Mana -= 100;
        } 
        
    }
}
