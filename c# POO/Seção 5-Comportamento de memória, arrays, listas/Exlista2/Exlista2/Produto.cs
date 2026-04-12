using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exlista2 {
    internal class Produto {
        private int _id;
        private string _nome;

        private int _quantidade;


        public string Nome { get { return _nome; } private set { if (value.Length > 0) { _nome = value; } } }
        public int Id { get { return _id; }private set { if (value >= 100 && value <= 999) { _id = value; } } }
        public int Quantidade { get { return _quantidade; } private set { if (value > 0) { _quantidade = value; } } }

        public Produto(int id,string nome, int quant) {
            Id = id;
            Nome = nome;
            Quantidade = quant;
        
        }
        public void AdicionarQuantidade(int qtd) {
            Quantidade += qtd;
        }
        public override string ToString() {
            return $"ID:{Id} Nome:{Nome} Quantidade:{Quantidade}";
        }
    }
}
