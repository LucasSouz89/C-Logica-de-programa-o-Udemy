using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            string[] vet = Console.ReadLine().Split(' ');
            int M = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);
            int[, ] matriz = new int[M, N];
            int[] vetNumeros = new int[M];
            
            for (int i = 0; i < M; i++) {
                vetNumeros[i] = 0;
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i,j] = int.Parse(vet[j]);
                    vetNumeros[i] += matriz[i,j];
                }
                
            }
            foreach(int numero in vetNumeros) {
                Console.WriteLine(numero);
            }
        }
    }
}