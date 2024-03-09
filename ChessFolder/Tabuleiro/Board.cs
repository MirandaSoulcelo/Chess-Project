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
    }
}