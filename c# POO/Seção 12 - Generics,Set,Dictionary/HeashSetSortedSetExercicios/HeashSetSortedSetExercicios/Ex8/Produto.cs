using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeashSetSortedSetExercicios.Ex8
{
    sealed class Produto
    {
        public int ID { get; private set; }
        public string Name { get;private set; }

        public Produto(int id,string name) { ID = id;Name = name; }

        public override bool Equals(object? obj)
        {
            if(obj is not  Produto other) return false;
            return other.ID == ID;
        }
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
