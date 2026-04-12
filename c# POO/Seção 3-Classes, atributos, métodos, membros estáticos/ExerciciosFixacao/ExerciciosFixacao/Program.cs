using ExerciciosFixacao;
using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            //Ex1
            /*
            Retangulo r = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo");
            r.altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            r.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(r);
            */
            //Ex2
            Funcionario f = new Funcionario();
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Funcionario: {f}");
            Console.Write($"Digite a porcentagem para aumentar o salário: ");
            double pct = double.Parse(Console.ReadLine());
            f.AumentarSalario(pct);
            Console.WriteLine($"Dados atualizados: {f}");
            //Ex3
            /*
            Aluno a = new Aluno();
            Console.Write("Nome do aluno: ");
            a.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno");
            a.nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(a);
            */
        }
    }
}