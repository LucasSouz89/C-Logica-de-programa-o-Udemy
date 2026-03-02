using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int soma = 0;
            int n = int.Parse(Console.ReadLine());
            while (n != 0) {
                soma += n;
                n = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine(soma);

        }
    }
}