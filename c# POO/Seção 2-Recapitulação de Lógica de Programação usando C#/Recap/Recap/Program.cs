using System;
using System.Globalization;
namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            sbyte va = 100;
            Console.WriteLine(va);
            double deci = 5.30;
            Console.WriteLine(deci.ToString("F2",CultureInfo.InvariantCulture));
            int a,b;
            a = int.MinValue;
            b = int.MaxValue;
            Console.WriteLine($"{a} {b}");

            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine($"{nome} tem {idade} anos e um saldo de $ {saldo.ToString("F2",CultureInfo.InvariantCulture)}");

            string[] produtos = { "Computador", "Mesa de escritorio" };
            byte idade2 = 30;
            int codigo = 5290;
            char genero = 'M';


            double[] precos = { 2100.0, 650.50 };
            double medida = 53.234576;
            Console.WriteLine("Produtos");
            for (int i = 0; i < 2; i++) {
                Console.WriteLine($"{produtos[i]}, cujo preco é {precos[i].ToString("F2")}");
            }
            Console.WriteLine($"Registro: {idade2} anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine($"Medida com oito casas decimais: {medida.ToString("F8")}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida.ToString("F3")}");
            Console.WriteLine($"Separador deciaml inavariant culture: {medida.ToString("F3",CultureInfo.InvariantCulture)}");
        }
    }
}