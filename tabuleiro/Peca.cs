

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.Posicao = null; //Quando eu crio uma peça, a mesma não tem uma posição ainda.
            this.Tab = tab;
            this.Cor = cor;
            this.QteMovimentos = 0;
        }
        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }
        public void DescrementarQteMovimentos()
        {
            QteMovimentos--;
        }
        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Tab.linhas; i++)
            {
                for (int j = 0; j < Tab.colunas; j++)
                {
                    if (mat[i,j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool MovimentoPossivel(Posicao pos)
        {
            return MovimentosPossiveis()[pos.linha, pos.coluna];
        }
        public abstract bool[,] MovimentosPossiveis();
    }
}
