using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            string mensagem = Console.ReadLine();
            string cor1 = Console.ReadLine(), cor2 = Console.ReadLine(), cor3 = Console.ReadLine();
            string[] vet = Console.ReadLine().Split(' ');
            string cor4 = vet[0];
            string cor5 = vet[1];
            string cor6 = vet[2];
            Console.Clear();
            Console.WriteLine(mensagem);
            Console.WriteLine(cor1);
            Console.WriteLine(cor2);
            Console.WriteLine(cor3);
            Console.WriteLine($"{cor4} {cor5} {cor6}");

        }
    }
}