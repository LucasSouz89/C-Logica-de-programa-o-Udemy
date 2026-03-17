using ExerciciosClasses;
using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            //Ex1
            /*
            Pessoa x = new Pessoa();
            Pessoa y = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda pessoa:");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.idade = int.Parse(Console.ReadLine());

            if (x.idade > y.idade) { Console.WriteLine($"Pessoa mais velha: {x.nome}"); } else if (x.idade < y.idade) { Console.WriteLine($"Pessoa mais velha: {y.nome}"); }
        */
            //Ex2
            Salario x = new Salario(), y = new Salario();
            double salarioMedio;
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Salário: ");
            x.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Salário: ");
            y.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            salarioMedio = (x.salario + y.salario) / 2.00;
            Console.WriteLine($"Salário médio = {salarioMedio.ToString("F2",CultureInfo.InvariantCulture)}");
        }

    }
}