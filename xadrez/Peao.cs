using tabuleiro;

namespace xadrez
{
    class Peao : Peca
    {
        private PartidaDeXadrez partida;
        public Peao(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        {
            this.partida = partida;
        }

        public override string ToString()
        {
            return "P";
        }
        private bool ExisteInimigo(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p != null && p.Cor != Cor;
        }
        private bool Livre(Posicao pos)
        {
            return Tab.Peca(pos) == null;
        }        
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.linhas, Tab.colunas];

            Posicao pos = new Posicao(0, 0);

            if (Cor == Cor.Branca)
            {
                pos.DefinirValores(Posicao.linha - 1, Posicao.coluna);
                if (Tab.PosicaoValida(pos) && Livre(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.DefinirValores(Posicao.linha - 2, Posicao.coluna);
                Posicao p2 = new Posicao(Posicao.linha - 1, Posicao.coluna);
                if (Tab.PosicaoValida(p2) && Livre(p2) && Tab.PosicaoValida(pos) && Livre(pos) && QteMovimentos == 0)
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.DefinirValores(Posicao.linha - 1, Posicao.coluna - 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.DefinirValores(Posicao.linha - 1, Posicao.coluna + 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                // #JogadaEspecial En Passant
                if (Posicao.linha == 3)
                {
                    Posicao esquerda = new Posicao(Posicao.linha, Posicao.coluna - 1); //Posicao da peca vulneravel
                    if (Tab.PosicaoValida(esquerda) && ExisteInimigo(esquerda) && Tab.Peca(esquerda) == partida.VulneravelEnPassant)
                    {
                        mat[esquerda.linha - 1, esquerda.coluna] = true;
                    }
                    Posicao direita = new Posicao(Posicao.linha, Posicao.coluna + 1);
                    if (Tab.PosicaoValida(direita) && ExisteInimigo(direita) && Tab.Peca(direita) == partida.VulneravelEnPassant)
                    {
                        mat[direita.linha - 1, direita.coluna] = true;
                    }
                }
            }
            else
            {
                pos.DefinirValores(Posicao.linha + 1, Posicao.coluna);
                if (Tab.PosicaoValida(pos) && Livre(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.DefinirValores(Posicao.linha + 2, Posicao.coluna);
                Posicao p2 = new Posicao(Posicao.linha + 1, Posicao.coluna);
                if (Tab.PosicaoValida(p2) && Livre(p2) && Tab.PosicaoValida(pos) && Livre(pos) && QteMovimentos == 0)
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.DefinirValores(Posicao.linha + 1, Posicao.coluna - 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.DefinirValores(Posicao.linha + 1, Posicao.coluna + 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                // #JogadaEspecial En Passant
                if (Posicao.linha == 4)
                {
                    Posicao esquerda = new Posicao(Posicao.linha, Posicao.coluna - 1);
                    if (Tab.PosicaoValida(esquerda) && ExisteInimigo(esquerda) && Tab.Peca(esquerda) == partida.VulneravelEnPassant)
                    {
                        mat[esquerda.linha + 1, esquerda.coluna] = true;
                    }
                    Posicao direita = new Posicao(Posicao.linha, Posicao.coluna + 1);
                    if (Tab.PosicaoValida(direita) && ExisteInimigo(direita) && Tab.Peca(direita) == partida.VulneravelEnPassant)
                    {
                        mat[direita.linha + 1, direita.coluna] = true;
                    }
                }
            }
            return mat;
        }
    }
}