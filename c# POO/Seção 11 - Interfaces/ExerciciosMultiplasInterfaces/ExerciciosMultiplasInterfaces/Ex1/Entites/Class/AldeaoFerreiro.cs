using ExerciciosMultiplasInterfaces.Ex1.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosMultiplasInterfaces.Ex1.Entites.Class
{
    internal class AldeaoFerreiro : IComerciante,IFerreiro
    {
       
        public void Negociar(int esmeraldas,string name)
        {
            Console.WriteLine($"Troncando {name} por {esmeraldas} esmeraldas");
        }
        public void ForjarArmadura()
        {
            Console.WriteLine("Batendo cobre na bigorna");
        }
    }
}
