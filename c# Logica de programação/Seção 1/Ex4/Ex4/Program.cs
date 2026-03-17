using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture),
                a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), 
                area = b * a, 
                perimento = a*2+b*2, 
                diagonal = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
            Console.WriteLine($"AREA = {area.ToString("F4",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {perimento.ToString("F4", CultureInfo.InvariantCulture)}"); 
            Console.WriteLine($"DIAGONAL = {diagonal.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}