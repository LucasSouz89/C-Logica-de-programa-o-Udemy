using System.Collections.Generic;
using System;
namespace Listas {
    internal class Program {
        static void Main(string[] args) {
            /* Criando uma lista e colocando elementos nela
            List<string> list = new List<string>();

            List<int> numeros = new List<int> {24,78,45,89};
            foreach(int numero in numeros) { Console.WriteLine(numero); }
            */
            //Adicionando pessoas
            List<string> nome = new List<string>();
            nome.Add("Lucas");
            nome.Add("Alex");
            nome.Add("Anna");
            nome.Add("Bob");
            for (int i = 0; i < nome.Count; i++) { Console.WriteLine(nome[i]); }
            Console.WriteLine();
            //Adicionando pessoas numa pesocao especifica
            nome.Insert(0, "Maria");
            Console.WriteLine();
            //Mostrar o tamanho da lista
            Console.WriteLine(nome.Count);
            Console.WriteLine();
            //Encontrar o primeiro nome da lista com uma caracacteristica especifica ex 
            string s1 = nome.Find(Teste);
            Console.WriteLine();
            //Encontrar usando um lambda
            s1 = nome.Find(x => x[0] == 'A');
            Console.WriteLine($"Encontar a primeira pessoa que começa com A: {s1}");
            Console.WriteLine();
            //Encontrar o ultimo nome da lista com uma caracacteristica especifica ex
            s1 = nome.FindLast(x=> x[0] == 'A');
            Console.WriteLine($"Encontar a ultima pessoa que começa com A: {s1}");
            Console.WriteLine();
            //Encontrar a posicao da lista que satisfaça a condicao
            int posicao = nome.FindIndex(x => x[0] == 'A');
            Console.WriteLine(posicao);
            Console.WriteLine();
            //Encontrar a ultima posicao da lista que satisfaça a condicao
            posicao = nome.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(posicao);
            Console.WriteLine();
            //Filtrar a lista com a condicao exigida
            List<string> list2 = nome.FindAll(x => x.Length == 5);
            foreach (string n in list2) {  Console.WriteLine(n); }
            Console.WriteLine();
            //Remover da lista
            nome.Remove("Alex");
            foreach (string obj in nome) { Console.WriteLine(obj); }
            Console.WriteLine();
            //Remover todos da lista cque satisfaça a condicao
            nome.RemoveAll(x => x[0] == 'M');
            foreach (string obj in nome) { Console.WriteLine(obj); }
            Console.WriteLine();
            //Remover um elemento pela posicao
            nome.RemoveAt(2);
            foreach (string obj in nome) { Console.WriteLine(obj); }
            Console.WriteLine();
            //Remover elementos entre um arranjo
            nome.RemoveRange(2, 2);
            foreach (string obj in nome) { Console.WriteLine(obj); }
            Console.WriteLine();
        }
        static bool Teste(string s) {
            //Se a primeira letra da palvra s for um "A" maiusculo retorna verdadeiro
            return s[0] == 'A';
        }
    }
}
