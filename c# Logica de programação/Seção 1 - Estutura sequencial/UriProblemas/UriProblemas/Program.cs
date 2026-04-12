using System;
using System.Globalization;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            string[] data = Console.ReadLine().Split(' ');
            string DiaNome = data[0];
            int dia = int.Parse(data[1]);
            string[] vet = Console.ReadLine().Split(':');
            int hora = int.Parse(vet[0]);
            int minuto = int.Parse(vet[1]);
            int segundo = int.Parse(vet[2]);

            string[] data2 = Console.ReadLine().Split(' ');
            string DiaNome2 = data2[0];
            int dia2 = int.Parse(data2[1]);
            string[] vet2 = Console.ReadLine().Split(':');
            int hora2 = int.Parse(vet2[0]);
            int minuto2 = int.Parse(vet2[1]);
            int segundo2 = int.Parse(vet2[2]);

            int calculo1 = ((dia*24*60*60)+(hora*60*60)+(minuto*60)+segundo);
            int calculo2 = ((dia2*24*60*60) + (hora2 * 60 * 60) + (minuto2 * 60) + segundo2);
            int resultado = calculo2-calculo1;
            int resultadoDias = resultado / 86400; int mod = resultado % 86400;
            int resultadoHoras = mod / 3600; mod = mod % 3600;
            int resultadoMinutos = mod / 60, segundos = resultado % 60;
            Console.WriteLine($"{resultadoDias} dia(s)");
            Console.WriteLine($"{resultadoHoras} hora(s)");
            Console.WriteLine($"{resultadoMinutos} minuto(s)");
            Console.WriteLine($"{segundos} segundo(s)");

        }
    }
}