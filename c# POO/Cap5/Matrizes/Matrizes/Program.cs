namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanho = int.Parse(Console.ReadLine());
            int[,] matriz = new int[tamanho,tamanho];

            for (int i = 0; i < tamanho; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < tamanho; j++) {
                    matriz[i,j] = int.Parse(vet[j]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < tamanho; i++) {
                for (int j = 0; j < tamanho; j++) {
                    Console.Write(matriz[i,j]+ " ");
                }
                Console.WriteLine();
            }
            //Mostrar em int o tamnho abosluto da matriz
            Console.WriteLine(matriz.Length);
            //Mostra o tipo de dimensão da matriz, se for um vetor: 1, se for uma matriz: 2 se for u
            Console.WriteLine(matriz.Rank);
            //Mostra a (Quantidade de Linhas)
            Console.WriteLine(matriz.GetLength(0));
            //Mostra a Quantidade de colunas
            Console.WriteLine(matriz.GetLength(1));
        }
    }
}
