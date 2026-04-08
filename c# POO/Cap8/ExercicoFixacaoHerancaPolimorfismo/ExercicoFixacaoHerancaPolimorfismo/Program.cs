using ExercicoFixacaoHerancaPolimorfismo.Entites;
using System.Globalization;

namespace ExercicoFixacaoHerancaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            ProductList(products);
            checklist(products);

        }
        public static void ProductList(List<Product> p) {
            Console.Write("Enter the number of products: ");
            var qtd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtd; i++) {
                Console.WriteLine($"Product #{i} data");
                Console.Write("Common,used or imported (c/u/i)? ");
                var option = Console.ReadLine();
                
                while(option != "c" && option != "u" && option != "i")
                {
                    Console.Write("Common,used or imported (c/u/i)? ");
                    option = Console.ReadLine();
                }
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Price: ");
                var price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (option == "c")
                {
                    p.Add(new Product(name, price));
                }
                else if (option == "u") {
                    Console.Write("Manufacture date(DD/MM/YYYY): ");
                    var inputDate = Console.ReadLine();
                    DateTime date = DateTime.Parse(inputDate);
                    p.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Custom fee: ");
                    var fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    p.Add(new ImportedProduct(name, price, fee));
                }

            }
            Console.WriteLine();
        }
        public static void checklist(List<Product> products) 
        {
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product p in products) {
                Console.WriteLine(p.priceTag());            
            }
        }
    }
}
