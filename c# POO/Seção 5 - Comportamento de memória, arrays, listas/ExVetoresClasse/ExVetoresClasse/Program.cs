using ExVetoresClasse;
using System;
using System.Security.Cryptography;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            /*
             //ex 1
            Console.Write("Digite a quantidade de armas: ");
            int qtd = int.Parse(Console.ReadLine());
            Arma[] armas = new Arma[qtd];
            
            Console.WriteLine($"Digite o nome e o dano da arma (mesma linha) : ");
            for (int i = 0; i < armas.Length; i++) {
                Console.Write($"Arma {i + 1}: ");
                string[] vet = Console.ReadLine().Split(' ');
                
                string nome = vet[0];
                int dano = int.Parse(vet[1]);
                armas[i] = new Arma(nome, dano);
            }
            

            int maiorDano = 0;
            string nomeMaiorDano = "";
            for (int i = 0; i < armas.Length; i++) {
                if (i == 0) { maiorDano = armas[i].Dano; nomeMaiorDano = armas[i].Nome; } 
                else {
                    if (maiorDano < armas[i].Dano) { maiorDano = armas[i].Dano; nomeMaiorDano = armas[i].Nome; }
                }
            }
            Console.WriteLine($"A melhor arma é a {nomeMaiorDano} com {maiorDano} dano!");
            */
            //Ex2
            /*
            int N = int.Parse(Console.ReadLine());
            Entidade[] e = new Entidade[N];

            string[] entidade = { "Cachorro", "Zumbi", "Humano" };
            int vivos = 0;
            int humanos = 0;
            int cachorros = 0;
            Random rnd = new Random();
            for (int i = 0; i < e.Length; i++) {
                int vida = rnd.Next(0, 20);
                int escolha = rnd.Next(0, entidade.Length);
                string nome = entidade[escolha];

                e[i] = new Entidade(nome, vida);
                if (e[i].Nome == "Zumbi" && e[i].Hp > 0) { vivos++; } else if (e[i].Nome == "Cachorro" && e[i].Hp > 0) { cachorros++; } else if (e[i].Nome == "Humano" && e[i].Hp > 0) { humanos++; }
            }
            Console.WriteLine($"Ameaças ativas no radar: {vivos}");
            Console.WriteLine($"Humanos {humanos}");
            Console.WriteLine($"Cachorros {cachorros}");
            */
            //Ex 3
            Item[] item = new Item[5];
            Console.Write("Digite a quantidade de itens encontrados: ");
            int qtd = int.Parse(Console.ReadLine());
            

            for (int i  = 0; i < qtd; i++) {
                Console.Write("Digite o nome do item: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a posicao para guardar o item (1-5)");
                int posicao = int.Parse(Console.ReadLine())-1;
                
                
                    while ((posicao < 0 || posicao > 4) || item[posicao] != null ) {
                        Console.WriteLine("Digite a posicao para guardar o item (1-5)");
                        posicao = int.Parse(Console.ReadLine()) - 1;
                        
                    }
                    

                item[posicao] = new Item(nome);
            }
            for (int i = 0; i < item.Length; i++) {
                if (item[i] != null) {
                    Console.WriteLine(item[i].Nome);
                }
            }
        }
    }
}