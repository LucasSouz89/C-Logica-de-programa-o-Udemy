using tabuleiro;

namespace tabuleiro
{
    class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tab) : base(cor,tab) 
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
