using System;
using System.Globalization;

namespace DateTimeExemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            //Mostra a data atual
            Console.WriteLine(d1);
            //Mostra os ticks de toda a data moderna
            Console.WriteLine(d1.Ticks);
            
            //Ano,mes,dia no construtor
            var d2 = new DateTime(2018,11,25);
            Console.WriteLine(d2);
            //Ano,mes,dia,horas,minutos,segundos
            var d3 = new DateTime(2018, 11, 25,20,45, 03);
            Console.WriteLine(d3);
            //Ano,mes,dia,horas,minutos,segundos,milesegundos
            var d4 = new DateTime(2018, 11, 25, 20, 45, 03,500);

            //Mostra a data no dia atual mas o horario é zerado
            var d5 = DateTime.Today;
            Console.WriteLine(d5);

            //Mostra o horario na linha de greenwicth
            var d6 = DateTime.UtcNow;
            Console.WriteLine(d6);
            //Converte a data para o formato abaixo
            var d7 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d7);
            d7 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d7);
            //Usando o formato que o Brasil usa
            var d8 = DateTime.Parse("15/08/2000", new CultureInfo("pt-BR"));
            Console.WriteLine(d8);
            d8 = DateTime.Parse("15/08/2000 13:05:58", new CultureInfo("pt-BR"));
            Console.WriteLine(d8);
            //Trocar a data por um formato personalizado
            var d9 = DateTime.ParseExact("2000-08-15","yyyy-MM-dd",CultureInfo.InvariantCulture);
            Console.WriteLine(d9);
            d9 = DateTime.ParseExact("15/08/2000 20:56:30", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d9);
        }
    }
}
