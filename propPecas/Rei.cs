using TabuleiroX;
using propPecas;


namespace propPecas
{
     class Rei : Peca
    {
        private PartidaDeXadrez partida;
        public Rei(Tabuleiroo tab, Cor cor) : base(tab, cor)
        {
            this.partida = partida;
        }
        public override string ToString()
        {
            return "R";
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

            //Norte
            pos.definirValores(posicaoPeca.Linha - 1, posicaoPeca.Coluna);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //Nordeste
            pos.definirValores(posicaoPeca.Linha - 1, posicaoPeca.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //Leste
            pos.definirValores(posicaoPeca.Linha, posicaoPeca.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //Sudeste
            pos.definirValores(posicaoPeca.Linha + 1, posicaoPeca.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //Sul
            pos.definirValores(posicaoPeca.Linha + 1, posicaoPeca.Coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //Sudoeste
            pos.definirValores(posicaoPeca.Linha + 1, posicaoPeca.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //Oeste
            pos.definirValores(posicaoPeca.Linha, posicaoPeca.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //Noroeste
            pos.definirValores(posicaoPeca.Linha - 1, posicaoPeca.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            return mat;
        }




    }

}
