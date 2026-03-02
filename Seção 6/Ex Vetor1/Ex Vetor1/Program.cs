using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];
            string[] numeros = Console.ReadLine().Split(' ');
            for (int i = 0; i < vet.Length; i++) {
                vet[i] = int.Parse(numeros[i]);
            }
            for(int i = 0; i< vet.Length; i++) {
                if (vet[i] < 0) { Console.WriteLine(vet[i]); }
            }
        }
    }
}