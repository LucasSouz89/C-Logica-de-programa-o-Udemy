namespace foreacth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i < numeros.Length; i++) {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine();
            foreach (int numero in numeros) {
                Console.WriteLine(numero);
            }
        }
    }
}
