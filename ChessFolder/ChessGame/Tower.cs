using Tabuleiro;
namespace Chess_Console.Game
{
    class Tower : ChessPiece
    {
        public Tower(Board board, Color color): base(board, color)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}