using Demo_LINQ_com_notação_similar_à_SQL.Entites;
using System.Globalization;
using System.Linq;

namespace Demo_LINQ_com_notação_similar_à_SQL
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
            // TESTES DE LINQ: QUERY SYNTAX (Similar ao SQL)
            // ==========================================================

            Console.WriteLine("TIER 1 AND PRICE < 900");
            // TRANSIÇÃO: Em vez de usar products.Where(), iniciamos com "from [apelido] in [lista]"
            // O "where" entra na linha de baixo, e encerramos obrigatoriamente com o "select".
            var productsFilter = from p in products
                                 where p.Category.Tier == 1 && p.Price < 900
                                 select p;

            Console.WriteLine(string.Join("\n", productsFilter));
            Console.WriteLine();


            Console.WriteLine("NAME OF PRODUCTS FROM TOOLS");
            // PROJEÇÃO (Select): Aqui nós não retornamos o objeto inteiro "p", 
            // pedimos apenas a string "p.Name". Equivalente a .Select(x => x.Name)
            var productsTool = from p in products
                               where p.Category.Name == "Tools"
                               select p.Name;

            Console.WriteLine(string.Join("\n", productsTool));
            Console.WriteLine();


            Console.WriteLine("WHEN FIRST LETTER OF PRODUCTS IS C");
            // OBJETO ANÔNIMO: Funciona perfeitamente na Query Syntax.
            // Basta colocar o "new { }" na frente do select.
            var productsFirstLetterC = from p in products
                                       where p.Name[0] == 'C'
                                       select new
                                       {
                                           p.Name,
                                           p.Price,
                                           CategoryName = p.Category.Name
                                       };

            Console.WriteLine(string.Join("\n", productsFirstLetterC));
            Console.WriteLine();


            Console.WriteLine("TIER 1 AND ORDER BY DESCENDING PRICE");
            // ORDENAÇÃO: Equivalente ao .OrderByDescending().ThenBy()
            // DICA DE SÊNIOR: Você pode colocar as ordenações na mesma linha separadas por vírgula.
            // Use as palavras "descending" ou "ascending" para definir a direção.
            var productsTier1OrderByDescending = from x in products
                                                 where x.Category.Tier == 1
                                                 orderby x.Price descending, x.Name ascending
                                                 select x;

            Console.WriteLine(string.Join("\n", productsTier1OrderByDescending));
            Console.WriteLine();


            Console.WriteLine("TIER 1 AND ORDER BY DESCENDING PRICE, SKIP 2 TAKE 4");
            // SINTAXE MISTA: Funções de paginação (Skip/Take) NÃO existem na Query Syntax pura.
            // Para usá-las, nós envelopamos a Query entre parênteses () e colamos a Lambda no final.
            var productsSkipTake = (from x in productsFilter select x).Skip(2).Take(4);

            Console.WriteLine(string.Join("\n", productsFilter));
            Console.WriteLine();

            // ==========================================================
            // OPERAÇÕES DE ELEMENTO ÚNICO E MATEMÁTICA
            // Estas operações NÃO possuem sintaxe SQL nativa no C#. 
            // Continuamos usando a Method Syntax (Lambda) com parênteses, ou envelopando a Query.
            // ==========================================================

            var productsFilter2 = products.First();
            Console.WriteLine($"First on the list: {productsFilter2}");

            // Exemplo de Sintaxe Mista para buscar um único elemento:
            var productsFirtsORDefault = (from x in products select x).FirstOrDefault();
            Console.WriteLine($"First or default: {productsFirtsORDefault}");

            productsFilter2 = products.Where(x => x.Category.Tier == 3).SingleOrDefault();
            Console.WriteLine($"Single or default: {productsFilter2}");

            productsFilter2 = products.Where(x => x.Category.Tier > 3).SingleOrDefault();
            Console.WriteLine($"Single or default: {productsFilter2}");
            Console.WriteLine();

            Console.WriteLine($"Max price: {products.Max(x => x.Price)}");
            Console.WriteLine($"Min price: {products.Min(x => x.Price)}");
            Console.WriteLine($"Product category 1 Sum prices: {products.Where(x => x.Category.Tier == 1).Sum(x => x.Price)}");
            Console.WriteLine($"Product category 1 average prices: {(products.Where(x => x.Category.Tier == 1).Average(x => x.Price)).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Product category 5 average prices if default or empty: {products.Where(x => x.Category.Tier == 5).Select(x => x.Price).DefaultIfEmpty(0.0).Average()}");
            Console.WriteLine();

            // ==========================================================
            // AGGREGATE E GROUP BY 
            // ==========================================================

            var productsFilter3 = products.Where(x => x.Category.Tier == 5)
                                          .Select(x => $"Product tier {x.Category.Tier}: {x.Name} ${x.Price} id:{x.Category.Id} ")
                                          .Aggregate("No value", (x, y) => $"{x}\n{y}");
            Console.WriteLine(productsFilter3);

            // GROUP BY na Query Syntax: 
            // O formato é "group [elemento] by [critério de agrupamento]"
            var productsFilter4 = from p in products
                                  group p by p.Category;


            // O laço de repetição duplo continua o mesmo para ler os dados agrupados
            foreach (IGrouping<Category, Product> product in productsFilter4)
            {
                Console.WriteLine($"Category: {product.Key.Name}");

                foreach (Product p in product)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}