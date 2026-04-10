namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] n = new int[2];
                int sum = 0;

                for (int i = 0; i < n.Length; i++)
                {
                    n[i] = int.Parse(Console.ReadLine());

                }
                int divisao = n[0] / n[1];
                Console.WriteLine(divisao);
            }
            catch (DivideByZeroException) {
                Console.WriteLine("Divisão por zero meu chapa, corrige isso ai meu mano!");
            }
            catch (FormatException) { Console.WriteLine("Numeros nulos ou varaiaveis do tipo string cara?Ta de sacanagem..."); }
        }
    }
}
