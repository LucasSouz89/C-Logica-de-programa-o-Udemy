using Linq_com_Lambda_Exercicios.Entites;
using System.Globalization;

namespace Linq_com_Lambda_Exercicios
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
            var itensDeLuxo = loots.Where(x => x.Price > 1000).Select(x => $"Item de luxo: {x.Name}");
            Console.WriteLine(string.Join("\n",itensDeLuxo));
            Console.WriteLine();
            //Ex 2
            var itemEncontrado = (loots.FirstOrDefault(x => x.Name == "Excalibur"));
            var situacao = (itemEncontrado != null) ? $"{itemEncontrado.Name} foi achado" : "Item não encontrado";
            Console.WriteLine(situacao);
            Console.WriteLine();
            //Ex3
            var itensOrdenados = loots.OrderByDescending(x => x.Price).ThenBy(x => x.Name);
            Console.WriteLine(string.Join("\n",itensOrdenados));
            Console.WriteLine();
            //Ex 4
            Console.WriteLine(string.Join("\n", itensOrdenados.Skip(3).Take(3)));
            Console.WriteLine();
            //Ex 5
            var itensFiltrados = loots.Where(x => x.Category.Tier == 2).Select(x=> new {LootName = x.Name, RarityName = x.Category.Name });
            Console.WriteLine(string.Join("\n", itensFiltrados));
            Console.WriteLine();
            //Ex 6
            var itemMaisCaro = loots.Max(x => x.Price);
            Console.WriteLine($"Preço mais caro: {itemMaisCaro}");
            var itemMaisBarato = loots.Min(x => x.Price);
            Console.WriteLine($"Preço mais barato: {itemMaisBarato}");
            //Ex7
            var venderItens = loots.Where(x=> x.Category.Tier == 1).Sum(x=>x.Price);
            Console.WriteLine($"Preço total o tier 1: {venderItens.ToString("F2",CultureInfo.InvariantCulture)}");
            //Ex 8
            Console.WriteLine();
            var precoMedio = loots.Where(x => x.Category.Tier == 5).Select(x => x.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine(precoMedio.ToString("F2",CultureInfo.InvariantCulture));
            //Ex 9
            var itensAgrupados = loots.GroupBy(x => x.Category);
            foreach(var tier in itensAgrupados)
            {
                Console.WriteLine($"Categoria {tier.Key.Name}");
                foreach(var item in tier)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
            var anunciarItens = loots.Where(x=> x.Category.Tier == 3).Select(x=> x.Name).Aggregate((x,y) => x + ", " + y);
            Console.WriteLine(anunciarItens);
        }
    }
}
