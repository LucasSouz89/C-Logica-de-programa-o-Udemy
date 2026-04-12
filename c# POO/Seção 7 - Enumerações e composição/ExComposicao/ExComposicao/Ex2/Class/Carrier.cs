using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComposicao.Ex2.Class
{
    internal class Carrier
    {
        public string Name { get; private set; }

        public Carrier() { }

        public Carrier(string name) { Name = name; }
    }
}
