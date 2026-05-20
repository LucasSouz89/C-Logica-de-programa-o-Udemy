using Exercicios_LINQ_com_notação_SLQ.Entites;
using System.Globalization;

namespace Exercicios_LINQ_com_notação_SLQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category r1 = new Category(1, "Common", 1);
            Category r2 = new Category(2, "Rare", 2);
            Category r3 = new Category(3, "Legendary", 3);
            Category r4 = new Category(4, "Mythic", 4);

            List<Product> loots = new List<Product>()
            {
            new Product(1, "Iron Sword", 150.0, r1),
            new Product(2, "Steel Shield", 250.0, r1),
            new Product(3, "Elven Bow", 800.0, r2),
            new Product(4, "Healing Potion", 50.0, r1),
            new Product(5, "Mana Potion", 80.0, r1),
            new Product(6, "Dragon Scale Armor", 3500.0, r3),
            new Product(7, "Ring of Power", 5000.0, r3),
            new Product(8, "Magic Wand", 900.0, r2),
            new Product(9, "Thief Dagger", 300.0, r1),
            new Product(10, "Excalibur", 10000.0, r4)
            };
            //Ex 1
            var tierRaro = from x in loots
                           where x.Category.Name == "Rare"
                           select x;
            Console.WriteLine(string.Join("\n",tierRaro));
            //Ex 2
            Console.WriteLine();
            var itensBaratos = from x in loots
                               where x.Price < 400 && x.Category.Tier == 1
                               select x.Name;
            Console.WriteLine(string.Join("\n", itensBaratos));
            Console.WriteLine();
            //Ex3
            var itensComLetraM = from x in loots
                                where x.Name[0] == 'M'
                                select x;
            Console.WriteLine(string.Join("\n", itensComLetraM));
            Console.WriteLine();
            //Ex 4
            var itensOrdenadoPreco = from x in loots
                                     orderby x.Price ascending
                                     select x;
            Console.WriteLine(string.Join("\n", itensOrdenadoPreco));
            Console.WriteLine();
            //Ex5
            var itensOrdenadoPreco2 = from x in loots
                                      orderby x.Category.Tier ascending,x.Name descending
                                      select x;
            Console.WriteLine(string.Join("\n", itensOrdenadoPreco2));
            Console.WriteLine();
            //Ex 6
            var itensFiltrados = from x in loots
                                 where x.Category.Tier == 3
                                 select new { NomeDaArma = x.Name, Preco = x.Price };
            Console.WriteLine(string.Join("\n", itensFiltrados));
            Console.WriteLine();

        //Ex 7
            var itensAgrupados = from x in loots
                                 group x by x.Category;
            
            foreach(var itens in itensAgrupados)
            {
                Console.WriteLine($"Categoria {itens.Key.Name}");
                foreach (var item in itens) { Console.WriteLine(item); }
                Console.WriteLine();
            }
            Console.WriteLine();
            //Ex 8
            var acharItem = ((from x in loots
                              where x.Name == "Steel Shield"
                              select x).FirstOrDefault() != null) ? $"Item achado" : "item não achado";
            Console.WriteLine(acharItem);
            Console.WriteLine();
            
            Console.WriteLine(string.Join("\n", itensOrdenadoPreco.Skip(4).Take(2)));
            Console.WriteLine();
            var somarItens = (from x in loots
                             where x.Category.Tier == 1
                             select x).Sum(x => x.Price);
            Console.WriteLine(somarItens.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
