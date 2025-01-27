using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4Assignment
{
    public class Support
    {

        public void PrintBoard(string[,] board)
        {
            Console.WriteLine("   1   2   3");

            for (int i = 0; i < board.GetLength(0); i++)
            {

                Console.Write((i + 1) + ": ");

                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + ' ');
                    
                    // Add separator between columns
                    if (j < 2) Console.Write("| ");
                }

                //print new line for next row
                Console.WriteLine();
                
                // Add separator between rows
                if (i < 2) Console.WriteLine("  ---+---+---");
            }
        }

        public string CheckBoard(string[,] board)
        {
            string winnerMsg = "";


            for (int i = 0; i < board.GetLength(0); i++)
            {
                // check the rows for a winner
                if ((board[i, 0] == board[i, 1]) && (board[i, 1] == board[i, 2]) && (board[i, 0] != " "))
                {
                    winnerMsg = ($"{board[i, 0]} is the winner");
                    break;
                }
                // check the columns for a winner
                else if ((board[0, i] == board[1, i]) && (board[1, i] == board[2, i]) && (board[0, i] != " "))
                {
                    winnerMsg = ($"{board[0, i]} is the winner");
                    break;
                }
                // check the diagonals for a winner
                else if ((board[0, 0] == board[1, 1]) && (board[1, 1] == board[2, 2]) && (board[1, 1] != " "))
                {
                    winnerMsg = ($"{board[1, 1]} is the winner");
                    break;
                }
                else if ((board[2, 0] == board[1, 1]) && (board[1, 1] == board[0, 2]) && (board[1, 1] != " "))
                {
                    winnerMsg = ($"{board[1, 1]} is the winner");
                    break;
                }
                else
                {
                    winnerMsg = "Next player's turn";
                }
            }
            return winnerMsg;
        }
    }
}

