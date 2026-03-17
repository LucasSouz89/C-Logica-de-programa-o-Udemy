using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                int multi = n * i;
                Console.WriteLine($"{i} x {n} = {multi}");
            }
        }
    }
}