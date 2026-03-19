using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExVetoresClasse {
    internal class Arma {
        public string Nome { get; private set; }
        public int Dano { get; private set; }

        public Arma(string nome, int dano) {
            Nome = nome;
            Dano = dano;
        }

    }
}
