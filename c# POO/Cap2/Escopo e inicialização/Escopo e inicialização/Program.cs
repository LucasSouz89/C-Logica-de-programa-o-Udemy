using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            /*int x;
            Console.WriteLine(x); Não é possivel ler uma varivel que n tenha um dado
            */
            //Ex 1
            /*
            Console.WriteLine("Digite um preço. EX: 20.00");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = preco *  0.80;
            double desconto2 = preco * 0.95;

            if( preco >= 100.0) Console.WriteLine($"Desconto de 20% aplicado: US${desconto.ToString("F2", CultureInfo.InvariantCulture)}");
            else Console.WriteLine($"Desconto de 5% aplicado: US${desconto2.ToString("F2", CultureInfo.InvariantCulture)}");
            */
            //Ex 2
            double preco = double.Parse(Console.ReadLine());
            double desconto;
            //Uma variavel que foi declarada dentro de um if não pode ser usado fora ou em outro if.

            if (preco > 100) {
                desconto = preco * 0.80;
                Console.WriteLine(desconto.ToString("F2", CultureInfo.InvariantCulture));
            } else {
                desconto = preco * 0.90;
                Console.WriteLine(desconto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}