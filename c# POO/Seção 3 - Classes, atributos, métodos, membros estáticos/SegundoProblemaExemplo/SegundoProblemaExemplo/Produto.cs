using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SegundoProblemaExemplo {
    internal class Produto {
        public string nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEmEstoque() {
            return preco * quantidade;
        }
        public void AdicionarProdutos(int quantity) {
            quantidade += quantity;
        }
        public void RemoverProdutos(int quantity) {
            quantidade -= quantity;
        }
        public override string ToString() {
            return $"{nome}, ${preco.ToString("F2",CultureInfo.InvariantCulture)}, {quantidade} unidades, total: ${ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture)}";
        }
        
    }
}
