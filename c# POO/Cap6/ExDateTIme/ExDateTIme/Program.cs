using System;
using System.Globalization;
namespace ExDateTIme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            /*
            string dataDoSave = "2005-25-01 23:50:00";
            var diaLimpo = DateTime.ParseExact(dataDoSave, "yyyy-dd-MM HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(diaLimpo);
            */
            //Ex 2
            /*
            Console.Write("Digite a data do descarregamento(ano-mes-dia): ");
            string[] vet = Console.ReadLine().Split('-');
            int ano = int.Parse(vet[0]), mes = int.Parse(vet[1]), dia = int.Parse(vet[2]);
            Console.Write("Digite a hora do descarregamento(hora:minuto:segundo): ");
            vet = Console.ReadLine().Split(':');
            int hora = int.Parse(vet[0]), minuto = int.Parse(vet[1]), segundo = int.Parse(vet[2]);
            var data = new DateTime(ano, mes, dia, hora, minuto, segundo);
            Console.WriteLine(data);
            */
            //Ex 3
            var dataZerada = DateTime.Today;
            Console.WriteLine(dataZerada);
        }
    }
}
