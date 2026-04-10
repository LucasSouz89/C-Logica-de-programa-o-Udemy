using ExercicioResolvidoMetodoAbstrato.Entites.Class;
using ExercicioResolvidoMetodoAbstrato.Entites.Enuns;
using System.Globalization;

namespace ExercicioResolvidoMetodoAbstrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            var qtd = int.Parse(Console.ReadLine());
            List<Shape> list = new List<Shape>();
            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Shape #{i}");
                Console.Write("Retangle or Circle (r/c)? ");
                var option = Console.ReadLine();
                Console.Write("Color (Black/Blue/Red): ");
                var color = Enum.Parse<Color>(Console.ReadLine());
                if (option.ToLower() == "r")
                {
                    Console.Write("Width: ");
                    var width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    var height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(color, width, height));
                }
                else if (option.ToLower() == "c")
                {
                    Console.Write("Radius: ");
                    var radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(color, radius));
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape i in list) 
            {
                Console.WriteLine(i.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
