using ExerciciosMultiplasInterfaces.Ex2.Entites.Class;
using ExerciciosMultiplasInterfaces.Ex2.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosMultiplasInterfaces.Ex2.Entites
{
    sealed class Nemesis : Monstro,IExplosivo,IVenenoso
    {
        public Nemesis(int vida) : base(vida) { }

        public void Detonar()
        {
            Console.WriteLine($"Nemesis com {Vida} de vida jogou um missel no jogador!");
        }
        public void CuspirVeneno() { Console.WriteLine($"Nemesis com {Vida} vida, atacou com o tentaculo no jogador"); }

    }
}
