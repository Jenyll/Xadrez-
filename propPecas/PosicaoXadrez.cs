using System;
using TabuleiroX;

namespace propPecas
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        //Isso aqui é pr pr converter o tabuleiro para uma posiçao de matriz// a-a é 0 se for B é o codigo do b - o codigo do a q dá 1.
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }
         

        public override string ToString()
        {
            return ""+coluna +linha;
        }
    }
}
