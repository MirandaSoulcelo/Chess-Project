using Tabuleiro;
namespace Chess_Console.Game
{
    class King : ChessPiece
    {
        public King(Board board, Color color): base(board, color)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}