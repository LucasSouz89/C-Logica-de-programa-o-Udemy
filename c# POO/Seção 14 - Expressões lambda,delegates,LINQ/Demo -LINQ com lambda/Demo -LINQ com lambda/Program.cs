using Demo__LINQ_com_lambda.Entites;
using System.Globalization;
using System.Linq;

namespace Demo__LINQ_com_lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. CONFIGURAÇÃO DA BASE DE DADOS (Mock)
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Eletronics", 1);
            Category c4 = new Category(3, "Eletronics2", 3);

            List<Product> products = new List<Product>();
            products.Add(new Product(1, "Computer", 1100.0, c2));
            products.Add(new Product(2, "Hammer", 90.0, c1));
            products.Add(new Product(3, "TV", 1700.0, c3));
            products.Add(new Product(4, "Notebook", 1300.0, c2));
            products.Add(new Product(5, "Saw", 80.0, c1));
            products.Add(new Product(6, "Tablet", 700.0, c4));
            products.Add(new Product(7, "Camera", 700.0, c3));
            products.Add(new Product(8, "Printer", 350.0, c3));
            products.Add(new Product(9, "MacBook", 1800.0, c2));
            products.Add(new Product(10, "Sound Bar", 700.0, c3));
            products.Add(new Product(11, "Level", 70.0, c1));

            // ==========================================================
            // TESTES DE LINQ (Filtros, Projeções e Paginação)
            // ==========================================================

            Console.WriteLine("TIER 1 AND PRICE < 900");
            var productsFilter = products.Where(x => x.Price < 900 && x.Category.Tier == 1);
            Console.WriteLine(string.Join("\n", productsFilter));
            Console.WriteLine();

            Console.WriteLine("NAME OF PRODUCTS FROM TOOLS");
            productsFilter = products.Where(x => x.Category.Name == "Tools");
            Console.WriteLine(string.Join("\n", productsFilter.Select(x => x.Name)));
            Console.WriteLine();

            Console.WriteLine("WHEN FIRST LETTER OF PRODUCTS IS C");
            productsFilter = products.Where(x => x.Name[0] == 'C');
            Console.WriteLine(string.Join("\n", productsFilter.Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name })));
            Console.WriteLine();

            Console.WriteLine("TIER 1 AND ORDER BY DESCENDING PRICE");
            productsFilter = products.Where(x => x.Category.Tier == 1).OrderByDescending(x => x.Price).ThenBy(x => x.Name);
            Console.WriteLine(string.Join("\n", productsFilter));
            Console.WriteLine();

            Console.WriteLine("TIER 1 AND ORDER BY DESCENDING PRICE, SKIP 2 TAKE 4");
            productsFilter = productsFilter.Skip(2).Take(4);
            Console.WriteLine(string.Join("\n", productsFilter));
            Console.WriteLine();

            // ==========================================================
            // OPERAÇÕES DE ELEMENTO ÚNICO
            // ==========================================================

            var productsFilter2 = products.First();
            Console.WriteLine($"First on the list: {productsFilter2}");

            productsFilter2 = products.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine($"First or default: {productsFilter2}");

            productsFilter2 = products.Where(x => x.Category.Tier == 3).SingleOrDefault();
            Console.WriteLine($"Single or default: {productsFilter2}");

            productsFilter2 = products.Where(x => x.Category.Tier > 3).SingleOrDefault();
            Console.WriteLine($"Single or default: {productsFilter2}");
            Console.WriteLine();

            // ==========================================================
            // MATEMÁTICA E AGREGAÇÃO (Business Intelligence)
            // ==========================================================

            // MAX e MIN: Varrem a lista inteira e retornam os extremos absolutos.
            Console.WriteLine($"Max price: {products.Max(x => x.Price)}");
            Console.WriteLine($"Min price: {products.Min(x => x.Price)}");

            // SUM: Soma todos os preços dos produtos que passaram no filtro (Tier 1).
            Console.WriteLine($"Product category 1 Sum prices: {products.Where(x => x.Category.Tier == 1).Sum(x => x.Price)}");

            // AVERAGE: Calcula a média de preços. Note o encadeamento com .ToString para formatar as casas decimais.
            Console.WriteLine($"Product category 1 average prices: {(products.Where(x => x.Category.Tier == 1).Average(x => x.Price)).ToString("F2", CultureInfo.InvariantCulture)}");

            // PROGRAMAÇÃO DEFENSIVA (DefaultIfEmpty): 
            // O Tier 5 não existe. Tentar tirar a média (Average) de uma lista vazia causaria um erro (Exception).
            // O DefaultIfEmpty(0.0) garante que, se a lista for vazia, ele injeta um '0.0' para a conta não quebrar.
            Console.WriteLine($"Product category 5 average prices if default or empty: {products.Where(x => x.Category.Tier == 5).Select(x => x.Price).DefaultIfEmpty(0.0).Average()}");
            Console.WriteLine();

            // ==========================================================
            // AGGREGATE E GROUP BY (Operações Complexas)
            // ==========================================================

            // AGGREGATE: É uma função acumuladora customizada (como o Reduce no JavaScript).
            // Ele tenta pegar as strings e juntar todas usando uma quebra de linha \n.
            // O "No value" é a "Semente" (Seed). Se a busca (Tier 5) for vazia, ele retorna a semente como fallback.
            var productsFilter3 = products.Where(x => x.Category.Tier == 5)
                                          .Select(x => $"Product tier {x.Category.Tier}: {x.Name} ${x.Price} id:{x.Category.Id} ")
                                          .Aggregate("No value", (x, y) => $"{x}\n{y}");
            Console.WriteLine(productsFilter3);

            // GROUP BY: Pega uma lista reta e transforma em vários "lotes" ou "grupos".
            // Aqui, estamos agrupando por Categoria. O resultado não é mais uma lista simples de produtos,
            // mas sim uma coleção de GRUPOS (IGrouping), onde cada grupo tem uma CHAVE (A Categoria) e os VALORES (Os Produtos).
            var productsFilter4 = products.GroupBy(p => p.Category);

            // Por causa do agrupamento, precisamos de 2 loops:
            // 1º Loop varre as categorias (Os lotes)
            foreach (IGrouping<Category, Product> product in productsFilter4)
            {
                // Imprime a CHAVE do agrupamento (Ex: Category: Computers)
                Console.WriteLine($"Category: {product.Key.Name}");

                // 2º Loop varre os produtos que estão DENTRO daquele lote específico
                foreach (Product p in product)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}