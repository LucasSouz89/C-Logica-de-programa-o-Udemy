using Compariosn.Entites;

namespace Compariosn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Notebook", 1200.00));
            products.Add(new Product("Tablet", 450.00));
            // products.Sort(CompareProducts);
            // Comparison<Product> comp = (p1,p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            Comparison<Product> comp;
            products.Sort(comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
            Console.WriteLine(string.Join(" | ",products));
        }
        //public static int CompareProducts(Product p1,Product p2) =>
        //    p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        
    }
}
