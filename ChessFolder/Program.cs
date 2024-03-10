using Chess_Console;
using Tabuleiro;
using Chess_Console.Game;
try
{
Board board = new Board(8,8);

board.PlacePiece(new Tower(board, Color.Preta), new Position(0, 0));
board.PlacePiece(new Tower(board, Color.Preta), new Position(1,9));
board.PlacePiece(new King(board, Color.Preta), new Position(0,2));
Screen.PrintOutScreen(board);
}
catch(ExceptionBoard e)
{
    Console.WriteLine(e.Message);
}

Console.ReadKey();