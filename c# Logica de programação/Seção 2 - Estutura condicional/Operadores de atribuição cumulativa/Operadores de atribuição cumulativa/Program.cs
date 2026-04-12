using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int minutos = int.Parse(Console.ReadLine());
            double valor = 50;
            int minutosExcedentes = minutos - 100;
             if (minutos > 100) { 
                valor += (minutosExcedentes*2);}
            Console.WriteLine($"Valor a pagar: R$ {valor.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}