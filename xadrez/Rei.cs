using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != this.Cor;
        }

        public override bool[,] MovimentosPossiveis() 
        {
            bool[,] mat = new bool[Tab.linhas, Tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //Acima
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna);
            if (Tab.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Canto superior direito
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna + 1);
            if (Tab.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Direita
            pos.DefinirValores(Posicao.linha, Posicao.coluna + 1);
            if (Tab.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Canto inferior direito
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna + 1);
            if (Tab.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Abaixo
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna);
            if (Tab.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Canto inferior esquerdo
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna - 1);
            if (Tab.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Esquerda
            pos.DefinirValores(Posicao.linha, Posicao.coluna - 1);
            if (Tab.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Canto superior esquerdo
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna -1);
            if (Tab.PosicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }
    }
}
