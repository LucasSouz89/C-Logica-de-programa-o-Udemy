
using ExercicioResolvidoMetodoAbstrato.Entites.Enuns;
using System.Formats.Asn1;

namespace ExercicioResolvidoMetodoAbstrato.Entites.Class
{
    abstract class Shape
    {
        public Color Color { get; protected set; }

        public Shape() { }

        public Shape(Color color) {
            Color = color;
        }
        public abstract double Area();

    }
}
