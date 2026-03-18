using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDaIA {
    internal class ItemInventario {
        public string Nome { get; private set; }
        public int Quantidade { get; private set; }

        public ItemInventario(string nome) {
            Nome = nome;
            Quantidade = 1;
        }
        public ItemInventario(string nome, int qtd) : this(nome) {
            Quantidade = qtd;
        }
        public void UsarItem() {
            if (Quantidade > 0) { Quantidade--; }
        }
        public override string ToString() {
            return $"Nome do item: {Nome}\n" +
                $"Quantidade: {Quantidade}";
        }
    }
}
