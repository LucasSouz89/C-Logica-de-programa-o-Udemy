using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosPolimorfismo.Ex_2.Entites.Class
{
    internal class Magia
    {
        public string Nome { get;private set; }
        public double DanoBase { get;protected set; }

        public Magia() { }

        public Magia(string nome, double danoBase) 
        {
            Nome = nome;
            DanoBase = danoBase;
        }
        public virtual string Conjurar()
        {
            return $"{Nome} cunjurado(a)\n" +
                $"Causou {DanoBase} de dano";
        }
    }
}
