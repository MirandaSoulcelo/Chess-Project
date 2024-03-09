using Tabuleiro;

namespace Chess_Console
{
    class Screen
    {
        public static void PrintOutScreen(Board Board)
        {
            for(int i=0; i<Board.Linhas; i++)
            {
                for(int j=0; j<Board.Colunas; j++)
                {   if(Board.Piece(i,j) == null)
                {
                    Console.Write("- ");
                   
                }
                     else
                    {
                        Console.Write(Board.Piece(i,j) + " ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}