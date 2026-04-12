using System;

namespace PropriedadesEOperacoesTimeSpan {
    internal class Program {
        static void Main(string[] args) {
            // --- 🧱 VALORES EXTREMOS E ZERO ---
            // Muito útil para inicializar variáveis em jogos ou loops de verificação
            var t1 = TimeSpan.MaxValue; // Duração máxima suportada pelo C#
            var t2 = TimeSpan.MinValue; // Duração mínima suportada (negativa)
            var t3 = TimeSpan.Zero;     // Duração cravada em 0 (00:00:00)

            Console.WriteLine("MaxValue: " + t1);
            Console.WriteLine("MinValue: " + t2);
            Console.WriteLine("Zero: " + t3 + "\n");

            // --- ⏱️ O CONSTRUTOR COMPLETO ---
            // TimeSpan(dias, horas, minutos, segundos, milissegundos)
            var t4 = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine("TimeSpan original: " + t4 + "\n");

            // --- 🧩 PROPRIEDADES BÁSICAS (Decompõem a duração) ---
            // Elas extraem apenas o valor daquela "casa" específica do relógio (sempre números inteiros)
            Console.WriteLine("Days: " + t4.Days);               // Pega só os 2 dias
            Console.WriteLine("Hours: " + t4.Hours);             // Pega só as 3 horas
            Console.WriteLine("Minutes: " + t4.Minutes);         // Pega só os 5 minutos
            Console.WriteLine("Seconds: " + t4.Seconds);         // Pega só os 7 segundos
            Console.WriteLine("Milliseconds: " + t4.Milliseconds); // Pega só os 11 milissegundos
            Console.WriteLine("Ticks: " + t4.Ticks);             // Total de Ticks que formam esse tempo

            Console.WriteLine("\n--- 🧮 PROPRIEDADES TOTAIS (A MÁGICA) ---");
            // Convertem a duração INTEIRA da variável para aquela unidade de medida específica.
            // Retornam números "quebrados" (double), pois englobam os restos.
            Console.WriteLine("TotalDays: " + t4.TotalDays);               // Pega tudo e converte em dias
            Console.WriteLine("TotalHours: " + t4.TotalHours);             // Pega tudo e converte em horas
            Console.WriteLine("TotalMinutes: " + t4.TotalMinutes);         // Pega tudo e converte em minutos
            Console.WriteLine("TotalSeconds: " + t4.TotalSeconds);         // Converte tudo em segundos (A bala de prata pra fazer os Cooldowns dos feitiços na Unity!)
            Console.WriteLine("TotalMilliseconds: " + t4.TotalMilliseconds); // Converte tudo em milissegundos

            
            Console.WriteLine("\n--- Operações ---");

            // --- Construtor: TimeSpan(horas, minutos, segundos) ---
            // Definindo os objetos que estão na tela da Udemy
            TimeSpan oT1 = new TimeSpan(1, 30, 10); // 1h 30m 10s
            TimeSpan oT2 = new TimeSpan(0, 10, 5);  // 10m 5s

            Console.WriteLine("TimeSpan 1: " + oT1);
            Console.WriteLine("TimeSpan 2: " + oT2 + "\n");

            // --- ➕ SOMA (Add) ---
            // Regra de Ouro: TimeSpan também é IMUTÁVEL! O .Add gera um novo objeto.
            // 1h30m10s + 10m5s = 1h 40m 15s
            TimeSpan sum = oT1.Add(oT2);
            Console.WriteLine("Soma (Add): " + sum);

            // --- ➖ SUBTRAÇÃO (Subtract) ---
            // 1h30m10s - 10m5s = 1h 20m 5s
            TimeSpan dif = oT1.Subtract(oT2);
            Console.WriteLine("Diferença (Subtract): " + dif);

            // --- ✖️ MULTIPLICAÇÃO (Multiply) ---
            // Multiplica o tempo total por um número double (quebrado).
            // Ótimo para jogos: "Efeito da Poção de Velocidade dura 2x mais"
            // t2 (10m5s) * 2.0 = 20m 10s
            TimeSpan mult = oT2.Multiply(2.0);
            Console.WriteLine("Multiplicação (Multiply t2 x 2.0): " + mult);

            // --- ➗ DIVISÃO (Divide) ---
            // Divide o tempo total por um número double.
            // Ex: "O drone minerador aguenta 10 minutos ligado, mas no modo econômico o consumo cai pela metade"
            // t2 (10m5s) / 2.0 = 5m 2s (e 500ms que ficam escondidos na impressão básica)
            TimeSpan div = oT2.Divide(2.0);
            Console.WriteLine("Divisão (Divide t2 / 2.0): " + div);
        }
    }
}