using Boolean.CSharp.Main;

Board board = new Board();
board.DrawBoard();

Circle playerO = new Circle("Klara");
Xes playerX = new Xes("Kalle");

//board.AddMarker(playerO, 5);
board.AddMarker(playerO, 9);
board.AddMarker(playerO, 6);
board.AddMarker(playerO, 3);