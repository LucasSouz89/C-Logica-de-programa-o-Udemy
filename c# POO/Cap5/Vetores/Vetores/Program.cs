using System;
using System.Globalization;
using Vetores;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            //ex1
            /*
            int n = int.Parse(Console.ReadLine());
            double soma= 0;
            double[] vet = new double[n];

            for (int i = 0; i < vet.Length; i++) {
                vet[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                soma += vet[i];
            }
            double media = soma/vet.Length;
            Console.WriteLine($"AVERAGE HEIGHT = {media.ToString("F2",CultureInfo.InvariantCulture)}");
            */
            int n = int.Parse(Console.ReadLine());
            double soma = 0;
            Produto[] vet = new Produto[n];

            for (int i = 0; i < vet.Length; i++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
               
                vet[i] = new Produto(nome,preco);
                soma += vet[i].Preco;
            }
            for (int i = 0; i < vet.Length; i++) {
                Console.WriteLine(vet[i]);
            }
            double media = soma/vet.Length;
            Console.WriteLine($"AVERAGE PRICE = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}