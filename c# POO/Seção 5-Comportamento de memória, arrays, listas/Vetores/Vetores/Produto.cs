using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores {
    internal class Produto {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
        public override string ToString() {
            return $"{Nome}, preco: ${Preco.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
