using MembrosEstaticos;
using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        
        static void Main(string[] args) {
            
            
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine($"Circuferencia: {Circulo.Circuferencia(raio).ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {Circulo.Volume(raio).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Circulo.pi.ToString("F2",CultureInfo.InvariantCulture)}");

        }
        
    }
}