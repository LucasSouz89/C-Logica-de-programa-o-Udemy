using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosPolimorfismo.Entites.Class
{
    internal class Item
    {
        public string Nome { get;private set;}
        public double PrecoBase { get;protected set; }

        public Item() { }

        public Item(string nome, double precoBase)
        {
            Nome = nome;
            PrecoBase = precoBase;
        }
        public virtual string Inspecionar() {
            return $"{Nome} - {PrecoBase} ptas";
        }
    }
}
