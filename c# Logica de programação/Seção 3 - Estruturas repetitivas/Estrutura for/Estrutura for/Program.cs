using System;
using System.Runtime.Serialization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int quantidade = int.Parse(Console.ReadLine()), n , soma = 0;
            for (int i = 0; i < quantidade; i++) {
                n = int.Parse(Console.ReadLine());
                soma += n;
                
            }
            Console.WriteLine(soma);

            for (int i = 4; i >= 0; i--) { Console.WriteLine($"Valor de i :{i}"); }
        }
    }
}