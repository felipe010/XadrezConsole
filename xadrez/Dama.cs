using tabuleiro;

namespace xadrez
{
    class Dama : Peca //É a rainha, mas pra não se confundir, coloquei 'Dama' e a letra 'D' como identificacao
    {
        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }
        public override string ToString()
        {
            return "D";
        }
        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != this.Cor;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.linhas, Tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //Esquerda
            pos.DefinirValores(Posicao.linha, Posicao.coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos)) 
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.linha, pos.coluna - 1);
            }
            //Direita
            pos.DefinirValores(Posicao.linha, Posicao.coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.linha, pos.coluna + 1);
            }
            //Acima
            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.linha - 1, pos.coluna);
            }
            //Abaixo
            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.linha + 1, pos.coluna);
            }

            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.linha - 1, pos.coluna - 1);
            }

            pos.DefinirValores(Posicao.linha - 1, Posicao.coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.linha - 1, pos.coluna + 1);
            }

            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.linha + 1, pos.coluna + 1);
            }

            pos.DefinirValores(Posicao.linha + 1, Posicao.coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.linha + 1, pos.coluna - 1);
            }

            return mat;
        }
    }
}
