using HerdarVsCumprirContrato.Entites.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerdarVsCumprirContrato.Entites.Interface
{
    abstract class AbastractShape : IShape
    {
        public Color Color { get; private set; }

        public AbastractShape(Color color) { Color = color; }
        public abstract double Area();
    }
}
