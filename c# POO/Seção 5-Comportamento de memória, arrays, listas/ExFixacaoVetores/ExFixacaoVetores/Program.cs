using ExFixacaoVetores;
using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            Estudante[] p = new Estudante[10];
            
            int qtd = 0;
            while (qtd <= 0 || qtd > 10) { 
                Console.Write("How many rooms will be rented (1-10)? ");
                int ? number = int.Parse(Console.ReadLine());
                qtd = number.GetValueOrDefault(0);
            }

            for (int i = 0; i < qtd; i++) {
                Console.WriteLine();
                Console.WriteLine($"RENT #{i+1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int ? number = int.Parse(Console.ReadLine());
                int numberRoom = number.GetValueOrDefault(0);
                bool condi = true;
                while (condi) {
                    if (p[numberRoom] == null) {
                        p[numberRoom] = new Estudante(name, email);
                        condi = false;
                    } else {
                        Console.Write("This room is occupied, please choose another: ");
                        number = int.Parse(Console.ReadLine());
                        numberRoom = number.GetValueOrDefault(0);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < p.Length; i++) {
                if (p[i] != null) { Console.WriteLine($"{i}: {p[i]}"); }
            }
        }
    }
}