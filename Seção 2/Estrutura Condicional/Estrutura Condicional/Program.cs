using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite as horas");
            int x = int.Parse(Console.ReadLine());
            if (x >=5 && x <12) {
                Console.WriteLine("Bom dia!");
            } else if (x >=12 && x < 19) {
                Console.WriteLine("Boa tarde");
            } else if ((x >= 19 && x <=24) ||(x>= 0 && x < 5)) {
                Console.WriteLine("Boa noite");
            } else { Console.WriteLine("Digite uma tecla valida"); }
            
        }
    }
}