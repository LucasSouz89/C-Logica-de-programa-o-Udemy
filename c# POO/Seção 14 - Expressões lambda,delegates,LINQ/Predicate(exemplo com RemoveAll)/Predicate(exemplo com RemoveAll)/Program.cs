using Predicate_exemplo_com_RemoveAll_.Entites;

namespace Predicate_exemplo_com_RemoveAll_
{
    internal class Program
    {
       // public delegate bool Predicate<in T>(T value);
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900));
            list.Add(new Product("Mouse", 50));
            list.Add(new Product("Tablet", 350));
            list.Add(new Product("HD Case", 50));
            //Jeito 1
            list.RemoveAll(p => p.Price < 100);
            //Jeito 2
            list.RemoveAll(ProductTest);

            Console.WriteLine(string.Join("\n",list));
            
        }
        public static bool ProductTest(Product p) => p.Price < 100;
        
            
        
    }
}
