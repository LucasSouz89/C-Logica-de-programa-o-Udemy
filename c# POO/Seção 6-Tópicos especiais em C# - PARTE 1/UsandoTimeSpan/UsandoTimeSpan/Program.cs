namespace UsandoTimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Time span foi feito para mostrar a duração hora,minuto,segundos
            var t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            //Time span usando um construtor vazio
            var t2 = new TimeSpan();
            Console.WriteLine(t2);
            //Passando o tanho do tick para converter na duração
            var t3 = new TimeSpan(900000000L);
            Console.WriteLine(t3);
            //Usando um constructor com dias
            var t4 = new TimeSpan(23,0, 1, 30);
            Console.WriteLine(t4.Ticks);
            Console.WriteLine(t4);
            //Criando um TimeSpan equivalente ao dia
            var t5 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t5);
            //Criando um TimeSpan equivalente a hora
            t5 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t5);
            //Criando um TimeSpan equivalente aos minutos
            t5 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t5);
            //Criando um TimeSpan equivalente aos segundos
            t5 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t5);
            //Criando um TimeSpan equivalente aos milesegundos
            t5 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(t5);
            //Criando um TimeSpan equivalente aos ticks . DETALHE: Ele só aceita numero inteirolong ex: 5000L
            t5 = TimeSpan.FromTicks(15L);
            Console.WriteLine(t5);
        }
    }
}
