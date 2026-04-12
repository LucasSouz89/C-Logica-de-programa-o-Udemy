using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosHerança.Ex2.Entites.Class
{
    internal class Item
    {
        public string Name { get; private set; }
        public string Material { get;protected set; }

        public int Durability { get;protected set; }

        public Item() { }

        public Item(string name, string material, int durability)
        {
            Name = name;
            Material = material;
            Durability = durability;
        }
        public void UseItem()
        {
            Durability--;

        }
    }
}
