using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), 
                altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture), 
                preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * altura;
            preco = area * preco;
            Console.WriteLine($"AREA = {area.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PRECO = {preco.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}