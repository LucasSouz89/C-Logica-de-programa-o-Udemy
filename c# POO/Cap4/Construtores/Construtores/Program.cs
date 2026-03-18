using Construtores;
using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            /*
            Produto p3 = new Produto { nome = "Gaveta", preco = 200, quantidade = 3 };
            Produto p2 = new Produto();
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            

            double ValorTotal = p3.ValorTotalEmEstoque();
            Console.WriteLine($"Dados do produto: {p3}");
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p3.AdicionarProdutos(qte);
            Console.WriteLine($"Dados do produto: {p3}");
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p3.RemoverProdutos(qte);
            Console.WriteLine($"Dados do produto: {p3}");
            Console.WriteLine(p3);
            */
            Produto p = new Produto("TV",900, 10);
            string nome = "TV";
            
            nome = Console.ReadLine();
            p.Nome = nome;
            Console.WriteLine(p);
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            
        }
    }
}