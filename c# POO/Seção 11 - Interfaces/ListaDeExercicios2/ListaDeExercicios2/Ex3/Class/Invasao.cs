using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios2.Ex3.Class
{
    internal class Invasao
    {
        public void GerarZumbis(int quantidade)
        {
            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"Zumbi {i} gerado");
            }
        }
    }
}
