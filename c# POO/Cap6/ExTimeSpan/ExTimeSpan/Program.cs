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
            Console.Beep(1500, 400);
        }
    }
}
