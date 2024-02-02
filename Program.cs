//Grant and Ava
using Mission04_Team0310;
using System.ComponentModel.Design;

class Driver
{
    public static void Main()
    {
        //Create a new object 
        supportingclass sc = new supportingclass();

        //Welcome the user to the game. Initialize variables
        Console.WriteLine("Hello Players! Welcome to our game! ");
        int currentPlayer = 0;
        bool gameOver = false;

        //Create the game board array
        char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        //Do loop to play the game until someone wins or a draw
        while (gameOver == false)
        {
            sc.PrintBoard(board);
            GetUserChoice(currentPlayer, board);
            gameOver = CheckForGameEnd(currentPlayer, board);
            currentPlayer += 1;
        }
;
    }


    //This method gets the Users choice.
    static void GetUserChoice(int currentPlayer, char[] board)
    {
        if (currentPlayer % 2 == 0)
        {
            Console.WriteLine("O's turn! Where would you like to play?");
        }
        else
        {
            Console.WriteLine("X's turn! Where would you like to play?");
        }

        int choice;

        // Keep prompting the user until a valid input is provided
        while (true)
        {
            // Try to parse the input
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9)
            {
                // Check if the selected square is not already occupied
                if (board[choice - 1] != 'X' && board[choice - 1] != 'O')
                {
                    // Record the player's choice depending on which player is going
                    board[choice - 1] = (currentPlayer % 2 == 0) ? 'O' : 'X';
                    break; // Break out of the loop when a valid input is provided
                }
                else
                {
                    Console.WriteLine("Invalid input. The chosen square is already occupied. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer between 1 and 9.");
            }
        }
    }

    //This method checks to see if the game has ended
    static bool CheckForGameEnd(int currentPlayer, char[] board)
    {
        supportingclass sc = new supportingclass();

        bool gameOver = sc.CheckForWinner(board);

        if (gameOver == true)
        {
            sc.PrintBoard(board);

            if (currentPlayer % 2 == 0)
            {
                Console.WriteLine($"\nO's win!");
            }
            else
            {
                Console.WriteLine($"\nX's win!");
            }
        }

        //Checks for a draw
        else if (Array.TrueForAll(board, c => c == 'X' || c == 'O'))
        {
            sc.PrintBoard(board);
            Console.WriteLine("\nIt's a draw!");
            gameOver = true;
        }

        return gameOver;
    }
}