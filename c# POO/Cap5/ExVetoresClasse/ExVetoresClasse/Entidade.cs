using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExVetoresClasse {
    internal class Entidade {
        public string Nome { get; private set; }
        public int Hp { get;private set; }

        public Entidade(string nome, int hp) {
            Nome = nome;
            Hp = hp;
        }
    }
}
