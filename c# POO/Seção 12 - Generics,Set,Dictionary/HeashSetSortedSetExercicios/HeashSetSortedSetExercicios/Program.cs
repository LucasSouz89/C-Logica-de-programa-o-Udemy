using HeashSetSortedSetExercicios.Ex8;
using HeashSetSortedSetExercicios.Ex9;

namespace HeashSetSortedSetExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            //HashSet<string> emails = new HashSet<string>();
            //for (int i = 0; i < 20; i++) {
            //    bool inseriu = emails.Add("lucas@gmail.com");
            //    Console.WriteLine(inseriu);
            //}
            //foreach (string email in emails) {
            //    Console.WriteLine(email);
            //}
            //Ex 2
            //SortedSet<int> pontuacaoes = new SortedSet<int>() {20,1,1,35,18,76,35,53 };
            //foreach (int i in pontuacaoes) { Console.WriteLine(i); }
            //Ex 3
            //HashSet<string> ipsBloqueados = new HashSet<string>();
            //ipsBloqueados.Add("192.168.0.1");
            //ipsBloqueados.Add("192.168.0.2");
            //ipsBloqueados.Add("192.168.0.3");
            //Console.Write("Digite o ip bloqueado: ");
            //string situacao = (ipsBloqueados.Contains(Console.ReadLine())) ? "Esse ip esta bloqueado" : "Esse ip não existe";
            //Console.WriteLine(situacao);
            ////Ex4
            //SortedSet<int> pontuacaoes = new SortedSet<int>() { 20, 1, 1, 35, 18, 76, 35, 53 };
            //Console.WriteLine(pontuacaoes.Min);
            //Console.WriteLine(pontuacaoes.Max);
            //Ex 5
            //int[] manha = { 1, 2, 8, 7 };
            //int[] tarde = { 1, 6, 8, 4 };
            //HashSet<int> uniao = new HashSet<int>(manha);
            //uniao.UnionWith(tarde);
            //foreach (var item in uniao)
            //{
            //    Console.WriteLine(item);
            //}
            //Ex 6
            //HashSet<string> filmesLucas = new HashSet<string>() {"John wick","Spider-man","Sonic" };
            //HashSet<string> filmesMaria = new HashSet<string>() { "John wick", "Titanic", "Sonic","Duro de matar" };
            //HashSet<string> intersecao = new HashSet<string>(filmesLucas);
            //intersecao.IntersectWith(filmesMaria);
            //foreach (var item in intersecao)
            //{
            //    Console.WriteLine(item);
            //}
            //Ex7
            //HashSet<string> produtosNoCarrinho = new HashSet<string>() { "TV", "Notebook", "Mouse" };
            //HashSet<string> estoqueDisponivel = new HashSet<string>() { "TV", "Mouse" };
            //HashSet<string> produtosCarrinhoNaoDisponivel = new HashSet<string>(produtosNoCarrinho);
            //produtosCarrinhoNaoDisponivel.ExceptWith(estoqueDisponivel);
            //foreach (var item in produtosCarrinhoNaoDisponivel)
            //{
            //    Console.WriteLine(item);
            //}
            //EX 8
            //Produto p1 = new Produto(1, "TV");
            //Produto p2 = new Produto(1, "Televisão");

            //HashSet<Produto> produtos = new HashSet<Produto>();
            //produtos.Add(p1);
            //produtos.Add(p2);
            //Console.WriteLine(produtos.Count);
            //EX 9
            //SortedSet<Aluno> alunos = new SortedSet<Aluno>();
            //alunos.Add(new Aluno("Bananilson farofa",10.00));
            //alunos.Add(new Aluno("Carlinhos horse", 5.00));
            //alunos.Add(new Aluno("Abatakan", 8.00));
            //alunos.Add(new Aluno("Lule", 8.00));
            //foreach (var item in alunos)
            //{
            //    Console.WriteLine(item);
            //}
            //EX 10
            Console.WriteLine("List");
            List<int> numeros = new List<int>() { 50, 10, 25, 10, 99, 50, 2, 8 };
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("HashSet");
            HashSet<int> set = new HashSet<int>(numeros);
            foreach (var item in set) { Console.WriteLine(item); }
            Console.WriteLine();
            Console.WriteLine("SortedSet");
            SortedSet<int> set2 = new SortedSet<int>(set);
            foreach (var item in set2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
