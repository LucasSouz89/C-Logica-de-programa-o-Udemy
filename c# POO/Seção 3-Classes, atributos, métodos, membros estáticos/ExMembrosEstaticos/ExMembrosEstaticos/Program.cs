using ExMembrosEstaticos;
using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total = ConvesorDeMoeda.Total(dolar, qtd);
            Console.WriteLine($"Valor a ser pago em reais = {total.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}