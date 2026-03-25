namespace MatrizEx2 {
    internal class Program {
        static void Main(string[] args) {
            string[] v = Console.ReadLine().Split(' ');
            int M = int.Parse(v[0]), N = int.Parse(v[1]);
            int[,] mat = new int[M, N];
            for (int i = 0; i < M; i++) {
                v = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(v[j]);
                }
            }
            int number = int.Parse(Console.ReadLine());
            


            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    if (mat[i, j] == number) {
                        Console.WriteLine($"Position: {i},{j}");
                        if (j-1 >= 0) { Console.WriteLine($"Left: {mat[i, j - 1]} "); } 
                        if (j+1 < N) { Console.WriteLine($"Rigth: {mat[i, j + 1]} "); } 
                        if (i - 1 >=0 ) { Console.WriteLine($"Up: {mat[i - 1, j]} "); } 
                        if (i + 1 < M) { Console.WriteLine($"Down: {mat[i + 1, j]} "); } 
                            
                    }
                }
            }
        }
    }
}
