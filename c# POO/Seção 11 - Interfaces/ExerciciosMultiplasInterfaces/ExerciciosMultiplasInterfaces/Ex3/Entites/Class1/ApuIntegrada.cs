using ExerciciosMultiplasInterfaces.Ex3.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosMultiplasInterfaces.Ex3.Entites.Class1
{
    sealed class ApuIntegrada : IPlacaDeVideo,IProcessador
    {
        public void RenderizarGraficos()
        {
            Console.WriteLine("Rederenrizando graficos");
        }
        public void CalcularFisica() { Console.WriteLine("Calculando fisica"); }


    }
}
