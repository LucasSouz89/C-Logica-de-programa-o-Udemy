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
            /*
            //Ex 3
            var dataZerada = DateTime.Today;
            Console.WriteLine(dataZerada);
            */
            //Ex 4
            var saidaMatriz = new DateTime(2026, 3, 26, 8, 0, 0);
            var chegadaFilial = new DateTime(2026, 3, 26, 10, 45, 0);
            var limiteDeTempo = new TimeSpan(2, 30, 0);

            var sitauacao = (chegadaFilial.Subtract(saidaMatriz) <= limiteDeTempo) ? "Viagem no prazo!" : "Alerta: Caminhão atrasado!";
            Console.WriteLine(sitauacao);

            //Ex 5
            var horaQueBebeu = DateTime.Now;
            var minutos = TimeSpan.FromMinutes(8);
            var horaQueAcaba = horaQueBebeu + minutos;
            Console.WriteLine($"O efeito acaba exatamente às: {horaQueAcaba}");
            //Ex 6
            var tempoTotalSegundos = 9500.0;
            var tempoDoSpeedrun = TimeSpan.FromSeconds(tempoTotalSegundos);
            Console.WriteLine($"O Speedrun durou: {tempoDoSpeedrun.Hours} horas, {tempoDoSpeedrun.Minutes} minutos e {tempoDoSpeedrun.Seconds} segundos.");
        }
    }
}
