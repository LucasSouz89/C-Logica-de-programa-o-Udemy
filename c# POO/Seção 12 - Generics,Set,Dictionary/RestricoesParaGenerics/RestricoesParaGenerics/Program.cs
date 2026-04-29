using RestricoesParaGenerics.Class;

namespace RestricoesParaGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter n: ");
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                list.Add(new Product(Console.ReadLine()));
            }
            Console.WriteLine(CalculationService.Max(list));
        }
    }
}
