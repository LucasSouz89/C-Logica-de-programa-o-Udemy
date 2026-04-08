using ClasseAbastrataExercicio.Entites.Class;

namespace ClasseAbastrataExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Campeao> campeoes = new List<Campeao>();
            campeoes.Add(new Assassino("Zed",200));
            campeoes.Add(new Atirador("Jinx",300));

            foreach(var c in campeoes)
            {
                c.UsarUltimate();
                c.AtaqueBasico();
            }
        }
    }
}
