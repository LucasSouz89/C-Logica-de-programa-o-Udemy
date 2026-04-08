using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbastrataExercicio.Entites.Class
{
    sealed class Assassino : Campeao
    {
        public Assassino() { }

        public Assassino(string nome, double mana) : base(nome,mana) { }
        public sealed override void UsarUltimate()
        {
            Mana -= 50;
            Console.WriteLine($"{Nome} ficou invisivel e explodiu o alvo!");
        }
    }
}
