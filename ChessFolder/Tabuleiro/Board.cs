using System.IO.Pipes;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace Tabuleiro
{
    class Board
    {
        public int Linhas{get;set;}
        public int Colunas{get; set;}

        private ChessPiece[,] ChessPieces;

        public Board(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            ChessPieces = new ChessPiece[Linhas, Colunas];
        }

        public ChessPiece Piece(int linha, int coluna)
        {
            return ChessPieces[linha, coluna];
        }



        public ChessPiece Piece(Position pos)
        {
            return ChessPieces[pos.linha, pos.coluna];
        }



        public bool  PieceExist(Position pos)
        {
            ValidationPosition(pos);
            return Piece(pos) != null;
        }



        public void PlacePiece(ChessPiece p, Position pos)
        {
            if(PieceExist(pos))
            {
                throw new ExceptionBoard("Já existe uma peça nessa posição, amigão");
            }

            ChessPieces[pos.linha, pos.coluna] = p;
            p.Position = pos;
        }

        public ChessPiece ToRemovePiece(Position pos)
        {
            if(Piece(pos)== null)
            {
            return null;
            }
            ChessPiece aux = Piece(pos);
            aux.Position = null;
            ChessPieces[pos.linha, pos.coluna] = null;
            return aux;

        }


        public bool ValidPosition(Position pos)
        {
            if(pos.linha < 0 || pos.linha >= Linhas || pos.coluna < 0 || pos.coluna >= Colunas)
            {
                return false;
            }
            return true;
        }
        

        public void ValidationPosition(Position pos)
        {
            if(!ValidPosition(pos))
            {
                throw new ExceptionBoard("Posição inválida");
            }
        }
    }
}