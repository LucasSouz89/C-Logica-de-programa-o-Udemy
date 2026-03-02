using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.Clear();

            Console.WriteLine(n);
            Console.WriteLine(c);
            Console.WriteLine(d.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"{nome} {c} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}