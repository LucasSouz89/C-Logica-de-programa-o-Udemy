using ExerciciosDaIA;
using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            //Ex1
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
        }
    }
}