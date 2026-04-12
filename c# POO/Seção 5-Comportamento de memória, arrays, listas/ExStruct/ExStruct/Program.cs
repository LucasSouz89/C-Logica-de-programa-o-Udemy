using ExStruct;
using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            //Ex1
            /*
            Posicao3D posicaoOriginal;
            posicaoOriginal.X = 10;
            posicaoOriginal.Y = 20;
            posicaoOriginal.Z = 0;
            Posicao3D posicaoParticula = posicaoOriginal;
            posicaoParticula.X += 5;
            Console.WriteLine(posicaoOriginal);
            Console.WriteLine(posicaoParticula);
            */
            //Ex 2
            CorRGB sangueNormal = new CorRGB(255,0,0);
            CorRGB sangueToxico = sangueNormal;
            sangueToxico = new CorRGB(0, 255, 0);
            Console.WriteLine(sangueNormal);
            Console.WriteLine(sangueToxico);
        }
    }
}