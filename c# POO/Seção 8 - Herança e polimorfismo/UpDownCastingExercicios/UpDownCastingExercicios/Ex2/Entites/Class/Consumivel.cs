using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDownCastingExercicios.Ex2.Entites.Class
{
    internal class Consumivel : Item
    {
        public Consumivel() { }

        public Consumivel(string name) :base(name) { }

        public void Curar() { }
    }
}
