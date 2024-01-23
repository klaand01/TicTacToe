using Boolean.CSharp.Main;

Board board = new Board();

Circle playerO = new Circle("Klara", board);
Xes playerX = new Xes("Kalle", board);

List<Marker> players = new List<Marker>();
players.Add(playerO);
players.Add(playerX);

string input = "";
Console.WriteLine("Welcome to a game of TicTacToe!\n");
Console.WriteLine("TYPE INPUT 1-9 (enter):");
board.DrawBoard();
Console.WriteLine("\n");

int index = -1;
string message = "";

while (!board.PlayerHaveWon())
{
    index++;
    index %= 2;

    Console.WriteLine("\n" + players[index].GetName() + "'s turn:");
    input = Console.ReadLine();
    message = players[index].AddMarker(int.Parse(input));

    if (message != "")
    {
        index--;
        Console.WriteLine(message);
    }
}

Console.WriteLine("\nCONGRATULATIONS! " + players[index].GetName() + " won!");