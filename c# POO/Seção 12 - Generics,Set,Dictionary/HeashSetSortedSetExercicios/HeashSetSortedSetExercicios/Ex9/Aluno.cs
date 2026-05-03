using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeashSetSortedSetExercicios.Ex9
{
    internal class Aluno : IComparable<Aluno>
    {
        public string Nome { get; set; }

        public double Nota { get; set; }

        public Aluno(string nome,double nota) { Nome = nome; Nota = nota; }

        public int CompareTo(Aluno other)
        {
            int resultado = Nota.CompareTo(other.Nota);
            if (resultado == 0) { resultado = Nome.CompareTo(other.Nome); }
            return resultado;
        }
        public override string ToString() { return $"{Nome}, nota: {Nota.ToString("F2",CultureInfo.InvariantCulture)}"; }
    }
}
