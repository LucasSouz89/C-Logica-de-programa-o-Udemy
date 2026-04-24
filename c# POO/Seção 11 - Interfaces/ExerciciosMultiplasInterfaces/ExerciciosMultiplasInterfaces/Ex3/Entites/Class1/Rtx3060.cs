using ExerciciosMultiplasInterfaces.Ex3.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosMultiplasInterfaces.Ex3.Entites.Class1
{
    internal class Rtx3060 : IPlacaDeVideo
    {
        public void RenderizarGraficos()
        {
            Console.WriteLine("Renderizando gráficos");
        }
    }
}
