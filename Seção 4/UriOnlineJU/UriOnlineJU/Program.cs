using System;
using System.Globalization;


namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            int numero = int.Parse(Console.ReadLine());
            int cont = 6;

            if (numero % 2 == 0) { numero += 1; }

            for (int i = 0; i < cont; i++) {
                Console.WriteLine(numero);
                numero += 2;
                
                    
            }
        }
    }
}