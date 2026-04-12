using ExEnumerators.Entities;
using ExEnumerators.Entities.Enums;
namespace ExEnumerators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            string txt = CargoPriority.Normal.ToString();
            Console.WriteLine($"Prioridade da carga atual: {txt}");
            //Ex 2
            string estadoDoSave = "Attack";
            var estadoAtual = Enum.Parse<BossState>(estadoDoSave);
            Console.WriteLine($"O Boss foi carregado no estado: {estadoAtual}");
            //Ex3
            var name = "Miner-01";
            var batteery = 45;
            var currentTask = DroneTask.Returning;
            var Drone = new Drone(name,batteery,currentTask);
            Console.WriteLine(Drone);
        }
    }
}
