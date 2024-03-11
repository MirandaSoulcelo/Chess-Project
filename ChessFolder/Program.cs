using Chess_Console;
using Tabuleiro;
using Chess_Console.Game;
try
{

ChessMatch match = new ChessMatch();

while(!match.Finish)
{
    Console.Clear();
    Screen.PrintOutScreen(match.Board);
    Console.WriteLine();
    Console.Write("Digite a posição de origem: ");
    Position origem = Screen.ReadChessPosition().ToPosition();
    Console.Write("Digite a posição de Destino: ");
    Position destino = Screen.ReadChessPosition().ToPosition();

    match.ExecutaMovimento(origem, destino);

}




}
catch(ExceptionBoard e)
{
    Console.WriteLine(e.Message);
}

/*ChessPosition pos = new ChessPosition('c', 7);

Console.WriteLine(pos);

Console.WriteLine(pos.ToPosition());*/

Console.ReadKey();