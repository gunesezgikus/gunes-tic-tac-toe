void DrawTicTacToeBoard(string[] gameBoard)
{
    int cellIndex = 0;
    for (int row = 0; row < 3; row++)
    {
        for (int col = 1; col <= 11; col++)
        {
            if (col % 4 == 0)
            {
                Console.Write("|");
            }
            else if (col % 2 == 0)
            {
                if (gameBoard[cellIndex] == "X" || gameBoard[cellIndex] == "O")
                {
                    Console.Write(gameBoard[cellIndex]);
                }
                else
                {
                    Console.Write(" ");
                }
                cellIndex++;
            }
            else
            {
                Console.Write(" ");
            }
        }
        if (row < 2)
        {
            Console.WriteLine();
            Console.WriteLine("---+---+---");
        }
    }
    Console.WriteLine();
}

Console.WriteLine("Welcome to Tic-Tac-Toe!");

int totalMoves = 0;
string[] ticTacToeBoard = new string[9];
DrawTicTacToeBoard(ticTacToeBoard);

do
{
    if (totalMoves != 9)
    {
        string currentPlayer;
        if (totalMoves % 2 == 0)
        {
            currentPlayer = "X";
        }
        else
        {
            currentPlayer = "O";
        }
        Console.Write($"{currentPlayer}'s move > ");

        int userMove = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine();
        if (userMove < 0 || ticTacToeBoard.Length <= userMove || ticTacToeBoard[userMove] == "X" || ticTacToeBoard[userMove] == "O")
        {
            Console.WriteLine("Illegal move! Try again.");
        }
        else
        {
            ticTacToeBoard[userMove] = currentPlayer;
            totalMoves++;
            DrawTicTacToeBoard(ticTacToeBoard);
        }
    }
    else
    {
        totalMoves++;
        Console.WriteLine("Game over!");
    }
} while (totalMoves < 10);