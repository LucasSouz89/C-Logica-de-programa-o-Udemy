namespace ExTimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            var entrada = new DateTime(2026, 3, 26, 8, 15, 0); 
            var saida = new DateTime(2026, 3, 26, 11, 40, 0);
            
            var tempoDeDoca = saida - entrada;
            Console.WriteLine(tempoDeDoca);
            //Ex2
            var tempoRecargaSegundos = 150.0;
            Console.WriteLine(TimeSpan.FromSeconds(tempoRecargaSegundos));
            //Ex3
            var d = new TimeSpan(0, 8, 20);
            Console.WriteLine(d.TotalSeconds);
            
            //Ex 4
            TimeSpan tempoCaminhao1 = new TimeSpan(1, 45, 0);
            TimeSpan tempoCaminhao2 = new TimeSpan(2, 30, 0);

            TimeSpan tempoTotal = tempoCaminhao1.Add(tempoCaminhao2);
            Console.WriteLine($"A doca ficará ocupada por: {tempoTotal}");

            //Ex 5
            var tempoNormal = new TimeSpan(12, 30, 0);
            var tempoEmCombate = tempoNormal.Divide(3.0);
            Console.WriteLine($"Em combate, o reator vai desligar em: {tempoEmCombate}");

            //Ex 6
            var tempoDeJogo = TimeSpan.FromSeconds(100000);
            Console.WriteLine($"Matemática do Servidor: {tempoDeJogo.TotalHours} horas." );
            Console.WriteLine($"Tela do Jogador: {tempoDeJogo.Days} dias, {tempoDeJogo.Hours} horas e {tempoDeJogo.Minutes} minutos.");
        }
    }
}
