using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFixacaoVetores {
    internal class Estudante {
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Estudante(string nome, string email) {
            Nome = nome;
            Email = email;
        }
        public override string ToString() {
            return $"{Nome}, {Email}";
        }
    }
}
