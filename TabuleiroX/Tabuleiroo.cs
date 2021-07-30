using TabuleiroX;

namespace TabuleiroX
{
    class Tabuleiroo
    {
        public int LinhasTab { get; set; }
        public int ColunasTab { get; set; }
        private Peca[,] pecasTab;

        public Tabuleiroo(int linhasTab, int colunasTab)
        {
            this.LinhasTab = linhasTab;
            this.ColunasTab = colunasTab;
            pecasTab = new Peca[linhasTab, colunasTab];

        }
        public Peca peca (int linha, int coluna)
        {
            return pecasTab[linha, coluna];
        }
        public Peca peca(Posicao pos)
        {
            return pecasTab[pos.Linha, pos.Coluna];
        }


        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabException("Já existe uma peça nessa posição");
            }
            pecasTab[pos.Linha, pos.Coluna] = p;
            p.posicaoPeca = pos;
        }
        public Peca retirarPeca(Posicao pos)
        {
            if(peca(pos)== null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicaoPeca = null;
            pecasTab[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }
        public bool posicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= LinhasTab || pos.Coluna < 0 || pos.Coluna >= ColunasTab){
                return false;
            } return true;
        }
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos)){
                throw new TabException("posição inválida!");
            }
        }

        public override string ToString()
        {
            return LinhasTab
                +","
                +ColunasTab;
        }
    }
}
