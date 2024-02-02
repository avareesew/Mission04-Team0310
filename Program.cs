//Grant and Ava
//Welcome the user to the game. Initialize variables
using Mission04_Team0310;
using System.ComponentModel.Design;
//Create a new object 
supportingclass sc = new supportingclass();

Console.WriteLine("Hello Players! Welcome to our game! ");
static int currentPlayer = 0;
static bool gameOver = false;
static int winner = 0;

//Create the game board array
static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

do
{
    sc.PrintBoard();
    GetUserChoice();
    CheckForGameEnd();

} while (gameOver == false);

static void GetUserChoice()
{
    Console.WriteLine('Where would you like to play? ')
    int choice = int.Parse(Console.ReadLine());

    if (board[choice - 1] != 'X' && board[choice - 1] != 'O' && board[choice - 1] >= '1' && board[choice - 1] <= '9') ;
    {
        if (currentPlayer == 0)
        {
            board[choice - 1] = 'O';
            currentPlayer = 1;
        }
        else
        {
            board[choice - 1] = 'X';
            currentPlayer = 0;
        }
 
    }

    else
    {
        Console.WriteLine("Invalid input, try again");
        GetUserChoice();
    }
}

static void CheckForGameEnd()
{
    gameOver = sc.CheckForWinner(board);

    if (gameOver == true)
    {
        sc.PrintBoard();

        if (currentPlayer == 0)
        {
            int winner = 1;
            Console.WriteLine($"Player {winner} wins");
        }
        else
        {
            int winner = 0;
            Console.WriteLine($"Player {winner} wins");
        }
    }

    else if (Array.TrueForAll(board, c => c == 'X' || c == 'O'))
    {
        sc.PrintBoard();
        Console.WriteLine("It's a draw!");
        gameOver = true;
    }
}
