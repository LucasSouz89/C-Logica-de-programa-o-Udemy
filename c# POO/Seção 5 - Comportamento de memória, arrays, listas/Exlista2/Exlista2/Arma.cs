using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exlista2 {
    internal class Arma {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public double DanoBase { get; private set; }

        public Arma(int id, string name, double dano) {
            Id = id;
            Name = name;
            DanoBase = dano;
        }
        public void MelhorDano(double pct) {
            DanoBase += DanoBase * pct / 100.00;
        }

        public override string ToString() {
            return $"Arma {Name}, ID:{Id}, Dano:{DanoBase.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
