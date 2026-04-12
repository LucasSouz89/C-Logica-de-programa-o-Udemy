using ExercicioResolvidoMetodoAbstrato.Entites.Enuns;

namespace ExercicioResolvidoMetodoAbstrato.Entites.Class
{
    sealed class Rectangle : Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle() { }

        public Rectangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }
        public sealed override double Area()
        {
            return Width * Height;
        }
    }
}
