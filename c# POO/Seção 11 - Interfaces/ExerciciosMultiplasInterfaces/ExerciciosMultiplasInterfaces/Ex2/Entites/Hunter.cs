using ExerciciosMultiplasInterfaces.Ex2.Entites.Class;
using ExerciciosMultiplasInterfaces.Ex2.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosMultiplasInterfaces.Ex2.Entites
{
    sealed class Hunter : Monstro, IVenenoso
    {
        public Hunter(int vida) : base(vida) { }

        public void CuspirVeneno()
        {
            Console.WriteLine($"Hunter com {Vida} de vida, cuspiu veneno ");
        }
    }
}
