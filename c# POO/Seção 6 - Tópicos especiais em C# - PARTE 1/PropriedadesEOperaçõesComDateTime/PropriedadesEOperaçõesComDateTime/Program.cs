using System;

namespace PropriedadesEOperacoesComDateTime {
    internal class Program {
        static void Main(string[] args) {
            var d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            var e = DateTime.Now;
            Console.WriteLine("Original: " + d + "\n");

            Console.WriteLine("--- 🔍 PROPRIEDADES ---");
            Console.WriteLine("1) Date: " + d.Date); // Retorna a data com o horário zerado (00:00:00)
            Console.WriteLine("2) Month: " + d.Month);
            Console.WriteLine("3) Year: " + d.Year);
            Console.WriteLine("4) Day: " + d.Day);
            Console.WriteLine("5) DayOfWeek: " + d.DayOfWeek); // Dia da semana (ex: Wednesday)
            Console.WriteLine("6) DayOfYear: " + d.DayOfYear); // Qual dia do ano é esse (ex: 227)
            Console.WriteLine("7) Hour: " + d.Hour);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Second: " + d.Second);
            Console.WriteLine("10) Millisecond: " + d.Millisecond);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) Kind: " + d.Kind); // Se é fuso horário Local, UTC ou não especificado

            // ⚠️ O Pulo do Gato: TimeOfDay não devolve texto, ele devolve um TimeSpan!
            Console.WriteLine("13) TimeOfDay: " + d.TimeOfDay);

            Console.WriteLine("\n--- 🎨 FORMATAÇÃO NATIVA ---");
            Console.WriteLine("ToLongDateString: " + d.ToLongDateString());   // "quarta-feira, 15 de agosto de 2001"
            Console.WriteLine("ToShortDateString: " + d.ToShortDateString()); // "15/08/2001"
            Console.WriteLine("ToLongTimeString: " + d.ToLongTimeString());   // "13:45:58"
            Console.WriteLine("ToShortTimeString: " + d.ToShortTimeString()); // "13:45"
            Console.WriteLine("ToString customizado: " + d.ToString("yyyy|MM|dd HH:mm:ss.fff"));

            Console.WriteLine("\n--- ➕ OPERAÇÕES (A MÁGICA) ---");
            // REGRA DE OURO: DateTime é imutável! Você não altera o 'd', você cria uma nova variável com o resultado.
            DateTime d2 = d.AddHours(2); // Soma 2 horas (Bom pra simular fuso horário)
            DateTime d3 = d.AddMinutes(3); // Soma 3 minutos
            DateTime d4 = d.AddDays(7); // Clássico: Emitir boleto com vencimento para daqui a 7 dias
            TimeSpan d5 = e.Subtract(d); // Subtrai o ultimo horario pelo primeiro

            Console.WriteLine("Data original: " + d);
            Console.WriteLine("Adicionando 2 horas: " + d2);
            Console.WriteLine("Adicionando 3 minutos: " + d3);
            Console.WriteLine("Adicionando 7 dias: " + d4);
            Console.WriteLine($"Calculando o tempo entre o ultimo horario e o primeiro: {d5}");

            
        }
    }
}