using HerdarVsCumprirContrato.Entites.Enuns;
using HerdarVsCumprirContrato.Entites.Interface;
using System.Globalization;

namespace HerdarVsCumprirContrato.Entites.Class
{
    sealed class Rectangle : AbastractShape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

       

        public Rectangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }
        public sealed override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return $"Retangle {Color} | Width:{Width.ToString("F2", CultureInfo.InvariantCulture)},Height: {Height.ToString("F2", CultureInfo.InvariantCulture)}," +
                $"Area:{Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
