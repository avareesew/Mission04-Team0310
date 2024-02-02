using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission04_Team0310
{
    internal class supportingclass
    { 
        // Method that receives the board array and prints the board based on the information passed to it
        public void PrintBoard(char[] board)
        {
            Console.WriteLine($"\n {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} \n");
        }

        // Method to check for a winner
        public bool CheckForWinner(char[] board)
        {
            // Check rows, columns, and diagonals for a winner
            for (int i = 0; i < 3; i++)
            {
                // Check rows
                if (board[i * 3] == board[i * 3 + 1] && board[i * 3 + 1] == board[i * 3 + 2])
                    return true;

                // Check columns
                if (board[i] == board[i + 3] && board[i + 3] == board[i + 6])
                    return true;
            }

            // Check diagonals
            if (board[0] == board[4] && board[4] == board[8])
                return true;

            if (board[2] == board[4] && board[4] == board[6])
                return true;

            return false;
        }
    }
}
