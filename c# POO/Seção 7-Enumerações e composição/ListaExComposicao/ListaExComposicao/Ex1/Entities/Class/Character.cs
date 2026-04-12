using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExComposicao.Ex1.Entities.Class
{
    internal class Character
    {
        public string Name { get;private set; }
        public int Level { get; private set; }

        public Character() { }
        public Character(string name, int level)
        {
            Name = name;
            Level = level;
        }
        public override string ToString()
        {
            return $"Nome {Name} |Level {Level}";
        }
    }
}
