using System;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8); //Lembre-se quando você instancia uma matriz, ele joga nulo em todo mundo.

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
