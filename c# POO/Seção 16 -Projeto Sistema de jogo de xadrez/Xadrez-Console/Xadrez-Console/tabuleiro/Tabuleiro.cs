using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] _pecas;

        public Tabuleiro(int linha,int coluna) 
        {
            Linhas = linha;
            Colunas = coluna;
            _pecas = new Peca[linha,coluna];
        }

        public Peca peca(int linha,int coluna)
        {
            return  _pecas[linha,coluna];
        }
        public void ColocarPeca(Peca p,Posicao pos)
        {
            _pecas[pos.Linha,pos.Coluna] = p;
            p.Posicao = pos;
        }
    }
}
