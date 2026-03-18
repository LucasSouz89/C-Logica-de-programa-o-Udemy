using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Dynamic;

namespace Construtores {
    public class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        

        public string Nome {
            get { return _nome; }
            set { if (value != null && value.Length > 1) { _nome = value; } }
        }
        public Produto() {
            _nome = "TV";
            Preco = 900.00;
            Quantidade = 5;
        }
        public Produto(string nome, double preco) : this() {
            _nome = nome;
            Preco = preco;
            
        }
        public Produto(string nome, double preco, int quantidade) : this(nome,preco){
            
            Quantidade = quantidade;
        }
        
        
        
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantity) {
            Quantidade += quantity;
        }
        public void RemoverProdutos(int quantity) {
            Quantidade -= quantity;
        }
        public override string ToString() {
            return $"{_nome}, ${Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, total: ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
