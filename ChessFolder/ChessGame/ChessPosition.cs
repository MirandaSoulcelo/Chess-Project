using Tabuleiro;

namespace Chess_Console.Game
{
    class ChessPosition
    {
        public char Coluna{get;set;}
        public int Linha{get;set;}


        public ChessPosition(char coluna, int linha)
        {
            this.Coluna = coluna;
            this.Linha = linha; 
        }
        public Position ToPosition()
        {
            return new Position(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}