using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDaIA {
    internal class Personagem {
        private string _nome;
        public int Vida { get; private set; }
        public int Nivel { get; private set; }

        public string Nome {
            get { return _nome; }
            set { if (value != null) { _nome = value; } }
        }
        public Personagem(string nome) {
            Nome = nome;
            Vida = 100;
            Nivel = 1;
        }
        public void ReceberDano(int dano) {
            Vida -= dano;
            if (Vida < 0) {  Vida = 0; }
        }
        public void SubirNivel() {
            Nivel++;
            Vida = 100;
        }
        public override string ToString() {
            return $"Nome: {_nome} \n" +
                $"Nivel: {Nivel}\n" +
                $"Vida: {Vida}";
        }
    }
}
