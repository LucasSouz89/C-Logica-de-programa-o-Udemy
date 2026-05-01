using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercicios.Ex11.Interface
{
    internal class Cliente : IEntidade
    {
        public int Id { get; set; }

        public override string ToString()
        {
            return "Cliente";
        }
    }
}
