using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using Tabuleiro;

namespace Chess_Console
{
    class Screen
    {
        public static void PrintOutScreen(Board Board)
        {
            for(int i=0; i<Board.Linhas; i++)
            {
                Console.Write( 8 - i + " ");
               
                for(int j=0; j<Board.Colunas; j++)
                {   
                    
                    if(Board.Piece(i,j) == null)
                {
                    Console.Write("- ");
                   
                }
                     else
                    {
                        PrintOutPiece(Board.Piece(i,j));
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void PrintOutPiece(ChessPiece piece)
        {
            if(piece.Color == Color.Branca)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;//tipo do c# que pega a cor do sistema
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(piece);
                Console.ForegroundColor = aux;//veja: salvei a cor do sistema em aux, para que após imprimir a peça na cor que escolhi, a cor do sistema volte para o padrão que foi salvo em aux

            }
        }
    }
}