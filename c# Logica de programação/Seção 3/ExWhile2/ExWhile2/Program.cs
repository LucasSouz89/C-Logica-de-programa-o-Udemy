using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), quantidade=0, total=0,media=0;

            if (valor < 0) { Console.WriteLine("impossivel calcular"); } 
            else {
                while (valor >= 0) {
                    quantidade++;
                    total += valor;
                    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                }

                media = total / quantidade;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}