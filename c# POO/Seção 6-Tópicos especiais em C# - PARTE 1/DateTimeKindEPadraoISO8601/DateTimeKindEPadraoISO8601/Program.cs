using System;

namespace DateTimeKindEPadraoISO8601 {
    internal class Program {
        static void Main(string[] args) {
            // --- 🌍 O TIPO DA DATA (Kind) ---
            // Local: Pega o fuso horário da sua máquina (Ex: UTC-3 no Brasil)
            // Utc: Horário Global (Greenwich/Londres). A âncora do tempo mundial.
            // Unspecified: Não sabe o que é. O C# não aplica fuso horário nisso.
            var d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            var d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            var d3 = new DateTime(2000, 8, 15, 13, 5, 58); // Unspecified

            Console.WriteLine("--- Testando d1 (Local) ---");
            Console.WriteLine("Kind: " + d1.Kind);
            Console.WriteLine("Local: " + d1.ToLocalTime()); // Não muda nada, já é local
            Console.WriteLine("UTC: " + d1.ToUniversalTime()); // Soma 3 horas (no caso do Brasil) para chegar no UTC

            Console.WriteLine("\n--- Testando d2 (UTC) ---");
            Console.WriteLine("Kind: " + d2.Kind);
            Console.WriteLine("Local: " + d2.ToLocalTime()); // Subtrai 3 horas para virar horário do Brasil
            Console.WriteLine("UTC: " + d2.ToUniversalTime()); // Não muda nada, já é UTC

            // --- 🌐 O PADRÃO WEB (ISO 8601) ---
            // É o formato universal que toda API, banco de dados e servidor do mundo entende.
            // Formato: yyyy-MM-ddTHH:mm:ssZ (O 'T' separa a data da hora, o 'Z' indica que é UTC)

            Console.WriteLine("\n--- Parse de ISO 8601 ---");
            var d4 = DateTime.Parse("2000-08-15 13:05:58"); // Sem o Z no final. Ele cria como Local por padrão.
            Console.WriteLine("Parse sem Z: " + d4);

            var d5 = DateTime.Parse("2000-08-15T13:05:58Z"); // Com o Z. Ele entende que é UTC e já converte pra sua hora Local!
            Console.WriteLine("Parse com Z: " + d5);

            // --- ⚠️ A GRANDE PEGADINHA (A formatação manual) ---
            Console.WriteLine("\n--- Transformando em String ISO 8601 ---");

            // JEITO ERRADO: Se a data não estiver em UTC de verdade, você está mentindo pro servidor ao colocar o 'Z' no final da string.
            Console.WriteLine("Jeito Errado: " + d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));

            // JEITO CERTO: Você OBRIGA a data a se converter para Universal Time ANTES de transformar em texto com o 'Z'. 
            // Assim, você garante que não vai corromper o banco de dados.
            Console.WriteLine("Jeito Certo: " + d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}