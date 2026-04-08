using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbastrataExercicio.Entites.Class
{
    sealed class Atirador : Campeao
    {
        public Atirador() { }

        public Atirador(string nome, double mana) : base(nome, mana) { }
        public sealed override void UsarUltimate()
        {
            Mana -= 100;
            Console.WriteLine($"{Nome} disparou um missel global do outro lado do mapa");
        }
    }
}
