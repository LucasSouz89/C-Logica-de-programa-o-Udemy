namespace ExExpressãoCondicionalTernaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            /*
            var hpInimigo = 120;
            var resultadoMundo = (hpInimigo <= 150) ? "Executado" : "Sobreviveu";
            Console.WriteLine(resultadoMundo);
            */
            //Ex 2
            /*
            var danoD20 = 16;
            var armaduraGoblin = 14;
            var hitBox = (danoD20 >= armaduraGoblin) ? "Dano aplicado" : "Errou o dano";
            Console.WriteLine(hitBox);
            */
            //Ex 3
            var diamantesNoInventario = 2;
            var podeCraftar = diamantesNoInventario >= 3;
            Console.WriteLine($"Posso craftar os diamantes? {podeCraftar}");
            
            int hp = 15;
            string statusJogador = (hp > 20) ? "Saudávael": "Sangrando";


        }
    }
}
