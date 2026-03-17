using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            string[] vet = Console.ReadLine().Split(' ');
            int GolInter = int.Parse(vet[0]), GolGremio = int.Parse(vet[1]);
            int PlacarInter = 0, PlacarGremio = 0, empate = 0, numeroJogos = 0;
            if (GolInter > GolGremio) { PlacarInter++; } else if (GolGremio > GolInter) { PlacarGremio++; } else { empate++; }
            numeroJogos++;
            int codigo = 0;
            while (codigo != 2 ) { 
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                codigo = int.Parse(Console.ReadLine());
                switch (codigo) {
                    case 1:
                        vet = Console.ReadLine().Split(' ');
                        GolInter = int.Parse(vet[0]); 
                        GolGremio = int.Parse(vet[1]);
                        if (GolInter > GolGremio) { PlacarInter++; } else if (GolGremio > GolInter) { PlacarGremio++; } else { empate++;}
                        numeroJogos++;
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"{numeroJogos} grenais");
            Console.WriteLine($"Inter:{PlacarInter}");
            Console.WriteLine($"Gremio:{PlacarGremio}");
            Console.WriteLine($"Empates:{empate}");
            if (PlacarInter > PlacarGremio) { Console.WriteLine("Inter venceu mais"); } else if (PlacarGremio > PlacarInter) { Console.WriteLine("Gremio venceu mais"); } else { Console.WriteLine("Empate"); }









        }
        
    }
}