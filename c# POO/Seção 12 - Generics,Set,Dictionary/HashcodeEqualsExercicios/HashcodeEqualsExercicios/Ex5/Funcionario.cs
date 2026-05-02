using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashcodeEqualsExercicios.Ex5
{
    internal class Funcionario
    {
        public int CPF { get; set; }

        public Funcionario(int cpf)
        {
            CPF = cpf;
        }
        public override bool Equals(object? obj)
        {
            if(obj == null) return false;
            if(this.GetType() != obj.GetType()) return false;
            Funcionario other = (Funcionario)obj;
            return CPF == other.CPF;
        }
        public override int GetHashCode()
        {
            return CPF.GetHashCode();
        }
       
    }
}
