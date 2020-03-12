using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public int linha { get; set; } //Debaixo para cima do 1 ao 8
        public char coluna { get; set; } //Da esquerda para direita 'a' ao 'h'

        public PosicaoXadrez(char coluna, int linha)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        //Converte a entrada solicitação para posição
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a'); //O macete aqui é justamente usar a númeração da tabela  ASCII referente ao caractere em questão, ex: um tipo char -> 'a' na tabela ascii tem o valor 97 (em decimal), logo se eu tentar somar 'a' + 2 o resultado vai ser -> 99, com isso ao instanciar uma posição ocorre a subtração de qualquer caractere por 97 por eu ter informado a letra 'a'
        }

        //Para visualização da posição solicitada
        public override string ToString()
        {
            return "" + coluna + linha;
        }


    }
}
