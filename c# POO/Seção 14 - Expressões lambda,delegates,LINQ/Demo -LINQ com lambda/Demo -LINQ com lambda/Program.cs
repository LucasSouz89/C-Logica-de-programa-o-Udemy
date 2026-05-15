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
            // Instanciando as categorias primeiro, pois os produtos dependem delas (Relação de Composição)
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Eletronics", 1);
            Category c4 = new Category(3, "Eletronics2", 3);

            // Populando a lista de produtos
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
            // TESTES DE LINQ (Consultas Declarativas)
            // ==========================================================

            Console.WriteLine("TIER 1 AND PRICE < 900");
            // WHERE COM MÚLTIPLAS CONDIÇÕES: Usa o operador lógico && (E). 
            // Ambas as condições precisam ser verdadeiras para o produto passar no filtro.
            var productsFilter = products.Where(x => x.Price < 900 && x.Category.Tier == 1);
            Console.WriteLine(string.Join("\n", productsFilter));
            Console.WriteLine();

            Console.WriteLine("NAME OF PRODUCTS FROM TOOLS");
            // ATUALIZAÇÃO DA VARIÁVEL: Reaproveitando a variável 'productsFilter' para uma nova busca.
            productsFilter = products.Where(x => x.Category.Name == "Tools");
            // PROJEÇÃO (Select) DIRETO NO PRINT: Extrai apenas a propriedade 'Name' (string) 
            // sem alterar a tipagem original da variável productsFilter. Excelente sacada!
            Console.WriteLine(string.Join("\n", productsFilter.Select(x => x.Name)));
            Console.WriteLine();

            Console.WriteLine("WHEN FIRST LETTER OF PRODUCTS IS C");
            // FILTRO DE CARACTERES: Strings funcionam como arrays de char, então x.Name[0] pega a primeira letra.
            productsFilter = products.Where(x => x.Name[0] == 'C');
            // OBJETOS ANÔNIMOS (new { ... }): Cria uma estrutura de dados "fantasma" na memória apenas com os dados necessários.
            // Ideal para montar relatórios ou enviar dados resumidos via API (escondendo o Id, por exemplo).
            Console.WriteLine(string.Join("\n", productsFilter.Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name })));
            Console.WriteLine();

            Console.WriteLine("TIER 1 AND ORDER BY DESCENDING PRICE");
            // ORDENAÇÃO COMPOSTA (Method Chaining): 
            // 1º Filtra (Where) -> 2º Ordena do mais caro para o mais barato (OrderByDescending) -> 
            // 3º Critério de desempate: se o preço for igual, ordena alfabeticamente pelo Nome (ThenBy).
            productsFilter = products.Where(x => x.Category.Tier == 1).OrderByDescending(x => x.Price).ThenBy(x => x.Name);
            Console.WriteLine(string.Join("\n", productsFilter));
            Console.WriteLine();

            Console.WriteLine("TIER 1 AND ORDER BY DESCENDING PRICE, SKIP 2 TAKE 4");
            // MOTOR DE PAGINAÇÃO: Essencial para sites de e-commerce!
            // Skip(2): Pula os 2 primeiros resultados da lista.
            // Take(4): Captura apenas os próximos 4 resultados e ignora o resto.
            productsFilter = productsFilter.Skip(2).Take(4);
            Console.WriteLine(string.Join("\n", productsFilter));
            Console.WriteLine();

            // ==========================================================
            // OPERAÇÕES DE ELEMENTO ÚNICO
            // ==========================================================

            // FIRST: Pega o primeirão da lista. 
            // PERIGO: Se a lista estiver vazia, gera uma exceção (trava o programa).
            var productsFilter2 = products.First();
            Console.WriteLine($"First on the list: {productsFilter2}");

            // FIRST OR DEFAULT: Busca segura. Tenta pegar o primeiro que custe > 3000. 
            // Se não achar nada, em vez de dar erro, ele retorna o valor padrão (no caso de objetos, 'null').
            productsFilter2 = products.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine($"First or default: {productsFilter2}"); // Vai imprimir vazio pois é null

            // SINGLE OR DEFAULT: O cão de guarda do Banco de Dados.
            // Busca o item Tier 3. Ele GARANTE que só exista 1. Se achar 0, retorna 'null'. 
            // Se achar 2 ou mais, ele GERA UM ERRO DE PROPÓSITO para avisar que a regra de negócio foi violada.
            productsFilter2 = products.Where(x => x.Category.Tier == 3).SingleOrDefault();
            Console.WriteLine($"Single or default: {productsFilter2}");

            // Tentando usar SingleOrDefault em uma condição que retorna NADA. Resultado esperado: null.
            productsFilter2 = products.Where(x => x.Category.Tier > 3).SingleOrDefault();
            Console.WriteLine($"Single or default: {productsFilter2}");
            Console.WriteLine();
        }
    }
}