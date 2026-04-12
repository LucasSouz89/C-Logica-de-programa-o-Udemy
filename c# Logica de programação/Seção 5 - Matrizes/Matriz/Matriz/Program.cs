using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            //Criar matriz
            //Fazer a declaração
            double[,] A;
            //Faezr a instaciação 3 linhas e 4 colunas
            A = new double[3, 4];
            //Inserir um informçaõ na matriz
            A[1, 2] = 10;
            string[] vet = Console.ReadLine().Split(' ');
            int M = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);

            int[,] numeros = new int[M, N];


            for (int i = 0; i < M; i++) {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    numeros[i, j] = int.Parse(vet[j]);
                }

            }
            int cont = 0;
            //Usando um foreacth

            foreach (int numero in numeros) {

                if (cont == M) { cont = 0; Console.WriteLine($"{numero} "); } else {
                    Console.Write($"{numero} ");
                    cont++;
                }
            }
            //Usar um for mais recomendavel para mostrar os dados da matriz
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    //Usar um Console.Write para apenas colocar as colunas da mesma linha
                    Console.Write($"{numeros[i, j]} ");
                }
                //O Console.WriteLine é usado quando todoas as colunas da linha estão prenchidas e então ele pula a proxima linha
                Console.WriteLine();
            }
        }
    }
}