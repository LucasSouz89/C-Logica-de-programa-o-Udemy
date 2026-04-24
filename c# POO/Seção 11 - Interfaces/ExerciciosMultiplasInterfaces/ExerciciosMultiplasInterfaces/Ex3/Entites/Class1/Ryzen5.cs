using ExerciciosMultiplasInterfaces.Ex3.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosMultiplasInterfaces.Ex3.Entites.Class1
{
    internal class Ryzen5 : IProcessador
    {
        public void CalcularFisica()
        {
            Console.WriteLine("Fazendo os calculos do programa");
        }
    }
}
