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
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno " + partida.Turno);
                        Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual);

                        Console.WriteLine();
                        Console.WriteLine("Letra + Número");

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                        partida.ValidarPossicaoDeOrigem(origem);

                        //Array de 2 dimenções (2D)
                        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.WriteLine("Letra + Número");

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    
                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

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
