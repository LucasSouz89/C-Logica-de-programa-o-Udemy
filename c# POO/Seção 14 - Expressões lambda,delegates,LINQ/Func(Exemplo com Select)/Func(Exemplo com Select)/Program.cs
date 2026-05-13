using System.Collections.Generic;

namespace Func_Exemplo_com_Select_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900));
            list.Add(new Product("Mouse", 50));
            list.Add(new Product("Tablet", 350));
            list.Add(new Product("HD Case", 80));
            ;
            var newList = list.Select(p => p.Name.ToUpper());
            Console.WriteLine(string.Join("\n",newList));
            
            
        }
        public static string NameUpper(Product product) => product.Name.ToUpper();
    }
}
