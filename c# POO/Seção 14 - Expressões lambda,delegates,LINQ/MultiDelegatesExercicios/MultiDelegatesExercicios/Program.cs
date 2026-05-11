namespace MultiDelegatesExercicios
{
    internal class Program
    {
        delegate void SystemNotification(string message);
        delegate void PlayerAction();
        delegate int MathTrick(int x, int y);
        delegate void OnDamageReceived(int damage);
        static void Main(string[] args)
        {
            //Ex 1
            SystemNotification op = Program.ShowOnScreen;
            op += Program.SaveToLogFile;
            op("Usuario entrou no sistema");
            Console.WriteLine();
            //Ex 2
            PlayerAction actions = Attack;
            actions += Defend;
            actions += Heal;
            actions();
            actions -= Defend;
            Console.WriteLine();
            actions();
            //Ex 3
            MathTrick math = Multiply;
            math += Sum;
            Console.WriteLine(math(2,3));
            Console.WriteLine();
            
            //Ex4

            foreach (var x in math.GetInvocationList())
            {
                if(x is MathTrick obj) Console.WriteLine(obj(2,3));
            }
            Console.WriteLine();
            //Ex 5
            
            OnDamageReceived eventlog = d => Console.WriteLine($"Log rápido: {d} de dano.");
            eventlog += UpdateUI;
            eventlog += PlayerSound;
            eventlog += SaveHistory;
            eventlog(15);



        }
        public static void ShowOnScreen(string message) => Console.WriteLine(message);
        public static void SaveToLogFile(string message) => Console.WriteLine(message);

        public static void Attack() => Console.WriteLine("Atacando");
        public static void Defend() => Console.WriteLine("Defendendo");
        public static void Heal() => Console.WriteLine("Curando");

        public static int Multiply(int x, int y) => x * y;
        public static int Sum(int x, int y) => x + y;
        public static void UpdateUI(int d) => Console.WriteLine($"Interface: HP reduzido em {d} pontos.");
        public static void PlayerSound(int d) => Console.WriteLine($"Áudio: Tocando som de impacto (Volume proporcional a {d}).");

        public static void SaveHistory(int d) => Console.WriteLine($"Log: Dano de {d} registrado no histórico da partida.");
    }
}
