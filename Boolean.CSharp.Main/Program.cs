using Boolean.CSharp.Main;

//Setting up
Board board = new Board();
string name = "";

Console.WriteLine("Player O name (can't be empty):");
while (name == "")
    name = Console.ReadLine();
Circle playerO = new Circle(name, board);
name = "";

Console.WriteLine("\nPlayer X name (can't be empty):");
while (name == "")
    name = Console.ReadLine();
Xes playerX = new Xes(name, board);

List<Marker> players = new List<Marker>();
players.Add(playerO);
players.Add(playerX);



//First inputs for the players
string input = "";
Console.WriteLine("\nWelcome to a game of TicTacToe!\n");
Console.WriteLine("TYPE INPUT 1-9 (enter):");
board.DrawBoard();
Console.WriteLine("\n");



//The game loop
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
        Console.WriteLine("\n" + message);
    }
}

Console.WriteLine("\nCONGRATULATIONS! " + players[index].GetName() + " won!");