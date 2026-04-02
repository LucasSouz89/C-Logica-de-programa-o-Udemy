using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaStringBuilder.Entites.Class
{
    internal class Pallet
    {
        public string Id { get; private set; }
        public string Content { get; private set; }

        public double Weight { get; set; }

        public Pallet() { }
        public Pallet(string id, string content, double weight) {
            Id = id;
            Content = content;
            Weight = weight;
        }
    }
}
