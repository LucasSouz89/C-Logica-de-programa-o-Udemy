using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashcodeEqualsExercicios.Ex1
{
    sealed class Produto
    {
        public int CodigoDeBarra { get; set; }

        public string Name { get; set; }

        public Produto(int codigo,string name) 
        {
            CodigoDeBarra = codigo;
            Name = name;
        }
        public override bool Equals(object? obj)
        {
            if(obj is not Produto other) {return false;}
            
            return other.CodigoDeBarra.Equals(CodigoDeBarra);
        }
        public override int GetHashCode()
        {
            return CodigoDeBarra.GetHashCode();
        }
    }
}
