using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExRefOut {
    internal class Porta {

        public bool TentarAbrirPorta(int nivelChave, out string mensagemPainel) {
            if (nivelChave == 3) { mensagemPainel = "Acesso Permitido: Laboratório Destrancado"; return true; } else {
                mensagemPainel = "Acesso Negado: Chave Nível 3 Necessária"; return false;
            }
        }
    }
}