using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDownCastingExercicios.Ex4.Entites.Class
{
    internal class Vendedor : NPC
    {

        public Vendedor() { }

        public Vendedor(string name) :base(name){  }

        public void AbrirLoja() { }
    }
}
