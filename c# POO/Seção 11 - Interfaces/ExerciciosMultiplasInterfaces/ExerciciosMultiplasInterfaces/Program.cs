using ExerciciosMultiplasInterfaces.Ex1.Entites.Class;
using ExerciciosMultiplasInterfaces.Ex2.Entites;
using ExerciciosMultiplasInterfaces.Ex2.Entites.Class;
using ExerciciosMultiplasInterfaces.Ex2.Entites.Interfaces;
using ExerciciosMultiplasInterfaces.Ex3.Entites.Class1;
using ExerciciosMultiplasInterfaces.Ex3.Entites.Interfaces;

namespace ExerciciosMultiplasInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            //AldeaoFerreiro aldeao = new AldeaoFerreiro();
            //aldeao.ForjarArmadura();
            //aldeao.Negociar(15, "Espada de ferro");
            //Ex 2
            //List<Monstro> monstros = new List<Monstro>();
            //monstros.Add(new Hunter(15));
            //monstros.Add(new Nemesis(200));

            //foreach (var monstro in monstros)
            //{
            //    if (monstro is IVenenoso monstroVenenoso) { monstroVenenoso.CuspirVeneno(); }
            //    if (monstro is IExplosivo monstroExplosivo) { monstroExplosivo.Detonar(); }
            //}
            //Ex 3
            List<object> list = new List<object>();
            list.Add(new Rtx3060());
            list.Add(new Ryzen5());
            list.Add(new ApuIntegrada());

            int contador = 0;
            foreach (var item in list) {
                Console.WriteLine($"Peça {contador}");
                if (item is IPlacaDeVideo gpu) { gpu.RenderizarGraficos(); }
                if (item is IProcessador cpu) { cpu.CalcularFisica(); }
                Console.WriteLine();
                contador++;
            }
        }
    }
}