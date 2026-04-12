using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            int negativos = 0;

            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                    if (matriz[i,j] < 0) {  negativos++; }
                }
            }
            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < n; i++) {
                Console.Write(matriz[i,i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine($"QUANTIDADE DE NEGATIVOS = {negativos}");
        }
    }
}