using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComposicao.Ex1.Class
{
    internal class Guild
    {
        public string Name { get; private set; }

        public Guild() { }
        public Guild(string name) {  Name = name; }
    }
}
