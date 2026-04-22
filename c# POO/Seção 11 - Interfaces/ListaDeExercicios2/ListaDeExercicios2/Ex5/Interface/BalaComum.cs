using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios2.Ex5.Interface
{
    internal class BalaComum : IMunicao
    {
        public int RetornarDano(int dano) 
        { 
            
            return dano*2; 
        }
    }
}
