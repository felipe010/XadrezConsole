

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null; //Quando eu crio uma peça, a mesma não tem uma posição ainda.
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }
    }
}
