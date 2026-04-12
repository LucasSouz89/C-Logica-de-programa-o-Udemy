namespace ExRefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            /*
            int vidaJogador = 40;
            UsarPocao(ref vidaJogador, 30);
            */
            /*
            Porta p = new Porta();
            string logDaPorta;
            int NivelDaPorta = int.Parse(Console.ReadLine());
            if (NivelDaPorta == 3) { p.TentarAbrirPorta(NivelDaPorta, out logDaPorta); } else { p.TentarAbrirPorta(NivelDaPorta, out logDaPorta); }
            Console.WriteLine(logDaPorta);
            */
            //Ex3
            int meuDano = 10;
            bool resultadoDoFerreiro;
            MelhorarArma(ref meuDano, out resultadoDoFerreiro);
            if (resultadoDoFerreiro) { Console.WriteLine("Sua arma quebrou"); } else { Console.WriteLine($"Sua arma esta inteira com {meuDano} de dano"); }
        }
        public static void UsarPocao(ref int hpAtual, int cura) {
            //Ex2
           hpAtual += cura;
        }
        public static void MelhorarArma(ref int dano, out bool quebrou) {
            Random r = new Random();
            int number = r.Next(1,10);
            if (number == 1) { dano = 0; quebrou = true; } else { dano += 15; quebrou = false; }

        }
    }
}
