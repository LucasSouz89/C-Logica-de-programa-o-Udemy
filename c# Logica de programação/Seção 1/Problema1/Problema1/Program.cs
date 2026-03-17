using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite o primeiro numero: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo numero: ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = (x+y)/2;
            Console.WriteLine($"Media: {media.ToString("F2", CultureInfo.InvariantCulture)} ");



        }
    }
}