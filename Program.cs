using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 5));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 3));

            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 5));
            tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(4, 3));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

            PosicaoXadrez pos = new PosicaoXadrez('c', 7); //Retorno -> 1, 2 (linha e coluna)
            /*Seguindo a explicação na classe 'PosicaoXadres.cs' instanciei uma nova posição inserindo os valores 'c' e 7 (coluna e linha), O valor 7 (ref linha) é subtraido de 8 (8 porque a matriz tem uma contagem de 0 ao 7) log o valor da é o resultado 1, E 'c' (minusculo) na tabela ASCII tem o valor de 99, e estou fazendo uma subtração com a letra 'a' que tem valor 97 na tabela, logo o valor vai ser 2 */

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}
