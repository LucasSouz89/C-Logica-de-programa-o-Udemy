using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashcodeEqualsExercicios.Ex5
{
    internal class Gerente : Funcionario
    {
        public string Setor { get; set; }

        public Gerente(string setor,int cpf) :base(cpf) { Setor = setor; }

        public override bool Equals(object? obj)
        {
            if(obj is not Gerente other) return false;

            return Setor == other.Setor && CPF == other.CPF;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Setor, CPF);
        }
    }
}
