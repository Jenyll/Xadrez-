using System;
using TabuleiroX;
using System.Collections.Generic;
using System.Text;

namespace propPecas
{
    class Peao : Peca
    {
        public Peao(Tabuleiroo tab, Cor cor) : base(tab, cor)
        {
        }
        public override string ToString()
        {
            return "P";
        }
        private bool existeInimigo(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null && p.cor != cor;
        }
        private bool livre(Posicao pos)
        {
            return tab.peca(pos) == null;
        }


        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.LinhasTab, tab.ColunasTab];
            Posicao pos = new Posicao(0, 0);
            
            if(cor == Cor.Branca)
            {
                pos.definirValores(posicaoPeca.Linha - 1, posicaoPeca.Coluna);
                if(tab.posicaoValida(pos) && livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(posicaoPeca.Linha - 2, posicaoPeca.Coluna);
                if (tab.posicaoValida(pos) && livre(pos) && qteMovimentos == 0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(posicaoPeca.Linha - 1, posicaoPeca.Coluna - 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(posicaoPeca.Linha - 1, posicaoPeca.Coluna + 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            } else
            {
                pos.definirValores(posicaoPeca.Linha + 1, posicaoPeca.Coluna);
                if (tab.posicaoValida(pos) && livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(posicaoPeca.Linha + 2, posicaoPeca.Coluna);
                if (tab.posicaoValida(pos) && livre(pos) && qteMovimentos == 0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(posicaoPeca.Linha + 1, posicaoPeca.Coluna - 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(posicaoPeca.Linha + 1, posicaoPeca.Coluna + 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }
            return mat;
        }
    }
}