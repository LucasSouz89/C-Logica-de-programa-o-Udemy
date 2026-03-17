using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int segundos = int.Parse(Console.ReadLine());
            int horas = segundos / 3600, mod1 = segundos % 3600;
            int minutos = mod1 / 60, Segundosfinais = mod1 % 60;
            
            Console.WriteLine($"{horas}:{minutos}:{Segundosfinais}");
        }
    }
}