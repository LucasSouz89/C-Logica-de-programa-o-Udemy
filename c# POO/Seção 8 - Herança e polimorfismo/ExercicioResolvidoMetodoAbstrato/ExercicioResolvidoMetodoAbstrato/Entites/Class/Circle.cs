
using ExercicioResolvidoMetodoAbstrato.Entites.Enuns;


namespace ExercicioResolvidoMetodoAbstrato.Entites.Class
{
    sealed class Circle : Shape
    {
        public double Radius { get;private set; }

        public Circle() { }

        public Circle(Color color, double radius) : base(color)
        {
            
           Radius = radius;
            
        }
        public sealed override double Area()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
    }
}
