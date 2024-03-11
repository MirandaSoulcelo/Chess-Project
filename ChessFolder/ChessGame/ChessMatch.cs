using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using Tabuleiro;

namespace Chess_Console.Game
{
    class ChessMatch
    {
        public Board Board{get;private set;}
        private int Turno;
        private Color PlayerAtual;
        public bool Finish{get; private set;}

        public ChessMatch()
        {
            Board = new Board(8,8);
            Turno = 1;
            PlayerAtual = Color.Branca;
            Finish = false;
            PlacePieces();
        }

        public void ExecutaMovimento(Position origem, Position destino)
        {
            ChessPiece p = Board.ToRemovePiece(origem);
            p.IncrementarQntdMove();
            ChessPiece CapturedPiece = Board.ToRemovePiece(destino);
            Board.PlacePiece(p, destino);
        }

        private void PlacePieces()
        {
            Board.PlacePiece(new Tower(Board, Color.Branca), new ChessPosition('c', 1).ToPosition());
            Board.PlacePiece(new Tower(Board, Color.Branca), new ChessPosition('c', 2).ToPosition());
            Board.PlacePiece(new Tower(Board, Color.Branca), new ChessPosition('d', 2).ToPosition());
            Board.PlacePiece(new Tower(Board, Color.Branca), new ChessPosition('e', 2).ToPosition());
            Board.PlacePiece(new Tower(Board, Color.Branca), new ChessPosition('e', 1).ToPosition());
            Board.PlacePiece(new King(Board, Color.Branca), new ChessPosition('d', 1).ToPosition());

            Board.PlacePiece(new Tower(Board, Color.Preta), new ChessPosition('c', 7).ToPosition());
            Board.PlacePiece(new Tower(Board, Color.Preta), new ChessPosition('c', 8).ToPosition());
            Board.PlacePiece(new Tower(Board, Color.Preta), new ChessPosition('d', 7).ToPosition());
            Board.PlacePiece(new Tower(Board, Color.Preta), new ChessPosition('e', 7).ToPosition());
            Board.PlacePiece(new Tower(Board, Color.Preta), new ChessPosition('e', 8).ToPosition());
            Board.PlacePiece(new King(Board, Color.Preta), new ChessPosition('d', 8).ToPosition());
            
        }
    }
}