using ExSobreposicao.Ex_1.Entites.Class;
using ExSobreposicao.Ex_2.Entites.Class;
using ExSobreposicao.Ex_3.Entites.Class;

namespace ExSobreposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            Mago Lux = new Mago("Lux",500);
            Lux.UsarUltimate();
            Suporte Soraka = new Suporte("Soraka",500);
            Soraka.UsarUltimate();
            //Ex2
            EscopetaCanoDuplo escopeta = new EscopetaCanoDuplo(20);
            escopeta.Atirar();
            Arma arma = new Arma(100);
            arma.Atirar();
            //Ex3
            Inimigo inimigo = new Inimigo(20);
            inimigo.ReceberDano(5);
            InimigoMutante inimigoMutante = new InimigoMutante(20);
            inimigoMutante.ReceberDano(15);

        }
    }
}
