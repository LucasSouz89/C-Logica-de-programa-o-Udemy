using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            string[] vet = Console.ReadLine().Split(' ');
            int n1 = int.Parse(vet[0]), n2 = int.Parse(vet[1]), n3 = int.Parse(vet[2]);
            int menor = n1;
            if(menor > n2) { menor = n2;}
            if(menor > n3) { menor = n3;}
            Console.WriteLine($"MENOR = {menor}");

        }
    }
}