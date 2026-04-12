using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDownCastingExercicios.Ex1.Entites.Class
{
    internal class Entidade
    {
        public string Nome { get;private set; }
        public int Posicao { get; private set; }

        public Entidade() { }

        public Entidade(string nome,int posicao) { Nome = nome;Posicao = posicao; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Nome} | Posição: {Posicao}");
            return sb.ToString();
        }
    }
}
