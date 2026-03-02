using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < vet.Length; i++) 
                {
                vet[i] = double.Parse(s[i],CultureInfo.InvariantCulture);
            }
            double soma = 0;

            for (int i = 0; i < vet.Length; i++) {
                if (i == vet.Length - 1) { Console.WriteLine($"{vet[i].ToString("F1", CultureInfo.InvariantCulture)}"); } else { Console.Write($"{vet[i].ToString("F1", CultureInfo.InvariantCulture)} "); }
                soma += vet[i];
            }
            double media = soma / N;
            Console.WriteLine(soma.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}