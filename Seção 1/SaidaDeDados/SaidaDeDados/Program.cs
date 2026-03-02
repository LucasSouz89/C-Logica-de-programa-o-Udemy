using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Ola");
            Console.WriteLine("Mundo");
            int numero = int.Parse(Console.ReadLine());
            double x = 10.56120982109;
            Console.WriteLine(numero);
            Console.WriteLine(x.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine(x.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(x.ToString("F1", CultureInfo.InvariantCulture));

            Console.WriteLine($"Valor do troco é: {x.ToString("F2",CultureInfo.InvariantCulture)}");

            string nome = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());
            char sexo = char.Parse(Console.ReadLine());

            Console.WriteLine($"O/a paciente {nome} tem {idade} e seu sexo é: {sexo}");
        }
    }
}