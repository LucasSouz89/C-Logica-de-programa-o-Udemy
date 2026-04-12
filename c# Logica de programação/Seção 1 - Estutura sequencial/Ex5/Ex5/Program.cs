using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            string[] vet = Console.ReadLine().Split(' ');
            string nome1 = vet[0];
            double idade1 = double.Parse(vet[1],CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            string nome2 = vet2[0];
            double idade2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            double media = (idade1 + idade2)/2;
            Console.WriteLine($"A idade média de {nome1} e {nome2} é de {media.ToString("F1", CultureInfo.InvariantCulture)} anos");
        }
    }
}