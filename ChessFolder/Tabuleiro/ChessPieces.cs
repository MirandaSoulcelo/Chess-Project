using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace Tabuleiro
{
    class ChessPiece
    {
        public Position Position{get;set;}
        public Color Color{get; protected set;}
        public int QntdMove{get;protected set;}
        public Board Board{get; protected set;}


        public ChessPiece(Board board, Color color)
        {
             Position = null;
             Board = board;
             Color = color;
             this.QntdMove = 0;        
        }

        public void IncrementarQntdMove()
        {
            QntdMove++;
        }
    }
}