using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exlista2 {
    internal class Zumbi {
        public int Id { get; private set; }
        public string Tipo { get; private set; }

        public double Vida { get; private set; }


        public Zumbi(int id, string tipo, double vida) {
            Id = id;
            Tipo = tipo;
            Vida = vida;
        }
        public void TomarDano(double dano) {
            Vida -= dano;
            if (Vida < 0) { Vida = 0; }
        }
        public override string ToString() {
            return $"Tipo: {Tipo}, Vida{Vida.ToString("F2",CultureInfo.InvariantCulture)}, ID:{Id}";
        }
    }
}
