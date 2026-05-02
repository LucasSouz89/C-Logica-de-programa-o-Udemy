using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashcodeEqualsExercicios.Ex3
{
    internal class Usuario
    {
        public string UserName { get; set; }

        public override bool Equals(object? obj)
        {
            if(obj is not Usuario other) return false;
            return UserName.Equals(other.UserName,StringComparison.OrdinalIgnoreCase);
        }
        public override int GetHashCode()
        {
            return StringComparison.OrdinalIgnoreCase.GetHashCode();
        }
    }
}
