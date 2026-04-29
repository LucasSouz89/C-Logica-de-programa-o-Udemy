using Generics.Problema1;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PrintService<int> print = new PrintService<int>();
                Console.Write("How many values? ");
                int qtd = int.Parse(Console.ReadLine());
                for (int i = 0; i < qtd; i++)
                {
                    print.AddValue(int.Parse(Console.ReadLine()));
                }
                print.Print();
                int a = print.First();
                int b = a + 2;
                Console.WriteLine(b);
                print.First();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            
        }
    }
}
