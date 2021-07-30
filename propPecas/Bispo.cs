using System;
using TabuleiroX;
using System.Collections.Generic;
using System.Text;

namespace propPecas
{
    class Bispo : Peca 
    {
        public Bispo(Tabuleiroo tab, Cor cor) : base( tab, cor)
        {
        }
        public override string ToString()
        {
            return "B";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.LinhasTab, tab.ColunasTab];
            Posicao pos = new Posicao(0, 0);

            
            //Nordeste
            pos.definirValores(posicaoPeca.Linha - 1, posicaoPeca.Coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna - 1);
            }
            //Sudeste
            pos.definirValores(posicaoPeca.Linha +1, posicaoPeca.Coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna - 1);
            }
            //Sudoeste
            pos.definirValores(posicaoPeca.Linha + 1, posicaoPeca.Coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna - 1);
            }
            //Noroeste
            pos.definirValores(posicaoPeca.Linha - 1, posicaoPeca.Coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.Linha - 1, pos.Coluna - 1);
            }
            return mat;
        }
    }
}
