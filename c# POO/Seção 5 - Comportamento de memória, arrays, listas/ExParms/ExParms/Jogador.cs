using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExParms {
    internal class Jogador {
        public void ColetarLoot(string nomeJogador,params string[] itens) {
            if (itens.Length > 0) {
                for (int i = 0; i < itens.Length; i++) {
                    if (itens[i].Length == 0) { Console.WriteLine($"{nomeJogador} não encontrou nada!"); } else { Console.WriteLine($"{nomeJogador}, encontrou {itens[i]}"); }
                }
            } else { Console.WriteLine($"{nomeJogador} não encotrou nada no bau"); }
        }
    }
}
