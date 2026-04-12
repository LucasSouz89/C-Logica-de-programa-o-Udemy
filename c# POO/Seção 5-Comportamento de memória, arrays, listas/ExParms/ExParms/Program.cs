namespace ExParms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            /*
            Situacao p = new Situacao();
            p.MostrarAvisos("Munição baixa", "Zumbi detectado", "Vida crítica");
            p.MostrarAvisos("Munição baixa");
            p.MostrarAvisos();
            */
            //Ex2
            // AplicarDanoArea(50,"Zumbi 1", "Zumbi 2","Zumbi 3", "Mega Zumbi");
            //Ex3
            Jogador j = new Jogador();
            Jogador D = new Jogador();
            j.ColetarLoot("Arthur", "", "Pistola", "Revolver", "");
            D.ColetarLoot("Dutch");


        }
        //Ex2
        public static void AplicarDanoArea(int danoBase,params string[] nomes) {
            Random r = new Random();
            for (int i = 0; i < nomes.Length; i++) {
               
                int dano = r.Next(0,danoBase);
                Console.WriteLine($"O alvo {nomes[i]} recebeu {dano} de dano de explosão!");
            }
        }

        
    }
}
