using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSobreposicao.Ex_1.Entites.Class
{
    internal class Campeao
    {
        public string Nome { get;private set; }

        public double Mana { get;protected set; }

        public Campeao() { }

        public Campeao(string nome, double mana)
        {
            Nome = nome;
            Mana = mana;
        }
        public virtual void UsarUltimate()
        {
            Console.WriteLine($"{Nome} usou uma habilidade básica");
            Mana -= 100;
        }
    }
}
