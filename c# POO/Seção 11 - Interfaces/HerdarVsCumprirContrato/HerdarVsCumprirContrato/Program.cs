using HerdarVsCumprirContrato.Entites.Class;
using HerdarVsCumprirContrato.Entites.Enuns;
using HerdarVsCumprirContrato.Entites.Interface;

namespace HerdarVsCumprirContrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AbastractShape> shapes = new List<AbastractShape>();
            shapes.Add(new Circle(Color.Red,20));
            shapes.Add(new Rectangle(Color.Blue, 20,10));

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
