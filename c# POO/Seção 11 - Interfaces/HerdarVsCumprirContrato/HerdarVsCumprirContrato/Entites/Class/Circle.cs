
using HerdarVsCumprirContrato.Entites.Enuns;
using HerdarVsCumprirContrato.Entites.Interface;
using System.Globalization;


namespace HerdarVsCumprirContrato.Entites.Class
{
    sealed class Circle : AbastractShape
    {
        public double Radius { get;private set; }

        

        public Circle(Color color, double radius) : base(color)
        {
            
           Radius = radius;
            
        }
        public sealed override double Area()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
        public override string ToString()
        {
            return $"Circle {Color} | Radius:{Radius.ToString("F2", CultureInfo.InvariantCulture)},Area: {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
