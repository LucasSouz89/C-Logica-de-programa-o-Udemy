using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]),
                    b = int.Parse(vet[1]);

            while (a !=b) 
                {



                if (a < b) { 
                    Console.WriteLine("Crescente"); 
                } 
                else if (b < a) {
                    Console.WriteLine("Decrecente");
                }
                vet = Console.ReadLine().Split(' ');
                    a = int.Parse(vet[0]);
                    b = int.Parse(vet[1]);
                }




            }

        }
    }
