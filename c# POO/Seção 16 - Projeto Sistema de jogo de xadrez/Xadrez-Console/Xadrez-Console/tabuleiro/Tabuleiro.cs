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

        public Peca peca(int linha,int coluna) => _pecas[linha,coluna];
        
        public bool ExistePeca(Posicao pos) 
        {
            ValidarPosicao(pos);
            return peca(pos) != null; 
        }

        public Peca peca(Posicao pos) => _pecas[pos.Linha, pos.Coluna];
        public void ColocarPeca(Peca p,Posicao pos)
        {
            if (ExistePeca(pos)) { throw new TabuleiroException("Já existe uma peça nessa posição"); }
            _pecas[pos.Linha,pos.Coluna] = p;
            p.Posicao = pos;
        }
        public Peca RetirarPeca(Posicao pos)
        {
            if (peca(pos) == null) { return null; }
            Peca aux = peca(pos);
            aux.Posicao = null;
            _pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }
        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas) return false;
            return true;
        }
        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos)) throw new TabuleiroException("Posição inválida");
        }
        
    }
}
