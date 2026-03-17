using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture),
                b = double.Parse(vet[1], CultureInfo.InvariantCulture),
                c = double.Parse(vet[2], CultureInfo.InvariantCulture);
            double delta = Math.Pow(b, 2) - (4 * a * c);
            double x1 = (-b + Math.Sqrt(delta)) / (2*a);
            double x2 = (-b - Math.Sqrt(delta)) / (2*a);

            if ((x1 >= 0 || x1 <= 0) && (x2 >= 0 || x2 <= 0)) { Console.WriteLine($"R1 = {x1.ToString("F5", CultureInfo.InvariantCulture)}"); Console.WriteLine($"R2 = {x2.ToString("F5", CultureInfo.InvariantCulture)}"); }
            else Console.WriteLine("Impossivel calcular");
        }
    }
}