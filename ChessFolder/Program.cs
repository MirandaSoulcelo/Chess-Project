using Chess_Console;
using Tabuleiro;
using Chess_Console.Game;

Board board = new Board(8,8);

board.PlacePiece(new Tower(board, Color.Preta), new Position(0, 0));
board.PlacePiece(new Tower(board, Color.Preta), new Position(1,3));
board.PlacePiece(new King(board, Color.Preta), new Position(2,4));
Screen.PrintOutScreen(board);

Console.ReadKey();