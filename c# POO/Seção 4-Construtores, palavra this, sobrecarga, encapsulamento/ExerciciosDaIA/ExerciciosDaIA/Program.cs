using ExerciciosDaIA;
using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            //Ex1
            /*
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Personagem p = new Personagem(nome);
            Console.WriteLine($"Dados: ");
            Console.WriteLine(p);
            p.ReceberDano(20);
            Console.WriteLine($"Dados: ");
            Console.WriteLine(p);
            p.SubirNivel();
            Console.WriteLine($"Dados: ");
            Console.WriteLine(p);
            */
            //Ex2
            /*
            ItemInventario i;
            Console.Write("Digite o nome do item: ");
            string nome = Console.ReadLine();
            Console.Write("Você possui uma quantidade de itens (s/n)?: ");
            char alternativa = char.Parse(Console.ReadLine());
            int qtd;
            switch (alternativa) {
                case 'S':
                case 's':
                    Console.Write("Digite a quantidade: ");
                    qtd = int.Parse(Console.ReadLine());
                    i = new ItemInventario(nome, qtd);
                    break;
                default:
                    i = new ItemInventario(nome);
                    break;
            }
            Console.WriteLine(i);
            Console.WriteLine($"{i.Nome} vai usar um usada");
            i.UsarItem();
            Console.WriteLine(i);
            */
            //Ex 3
            Console.WriteLine("Digite o modelo da nave");
            string nave = "MILENIUM FALCOM";
            Nave n = new Nave(nave);
            Console.WriteLine(n);
            n.Acelerar();
            Console.WriteLine();
            Console.WriteLine(n);
            n.Acelerar();
            Console.WriteLine(n);
            n.Frear();
            Console.WriteLine(n);
            n.Abastecer(200);
            Console.WriteLine(n);
        }
    }
}