namespace MatrizEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n,n];
            int negativos = 0;
            for (int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(vet[j]);
                    if (mat[i,j] < 0) { negativos++; }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Negativos: {negativos}");
        }
    }
}
