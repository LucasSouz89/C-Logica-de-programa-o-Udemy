using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicosSobreConjutos.Class
{
    class User
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public User(string line) 
        {
            string[] vet = line.Split(' ');
            Name = vet[0];
            Date = DateTime.Parse(vet[1],CultureInfo.InvariantCulture);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is not User other) return false;
            
            return Name.Equals(other.Name);
        }
    }
}
