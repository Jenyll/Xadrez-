using System;
using propPecas;
using TabuleiroX;


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
                        Tela.imprimirPartida(partida);


                        Console.WriteLine();
                        Console.Write("origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoOrigem(origem);


                        bool[,] posissoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posissoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }catch(TabException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }

                }
                Console.Clear();
                Tela.imprimirPartida(partida);

               
             } catch (TabException x)
             {
                 Console.WriteLine(x.Message);

             }


        }


    }
}
