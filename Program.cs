// See https://aka.ms/new-console-template for more information
// Create an array to store the tic-tac-toe board outcomes
using Mission4Assignment;

char[,] board = new char[3, 3]
{
    { ' ', ' ', ' ' },
    { ' ', ' ', ' ' },
    { ' ', ' ', ' ' }
};

// Welcome message
Console.WriteLine("Welcome players to our tic-tac-toe game!");

// Ask for Player 1's Name
Console.WriteLine("Enter the name of Player 1 (X): ");
string player1Name = Console.ReadLine();

// Ask for Player 2's Name
Console.WriteLine("Enter the name of Player 2 (O): ");
string player2Name = Console.ReadLine();

// Print out BLANK board for user reference
// PrintBoard(board);

// Start game loop for two players
bool isPlayer1Turn = true;  // True for Player 1's turn, False for Player 2's turn
while (true)
{
    string currentPlayer = isPlayer1Turn ? player1Name : player2Name; // alternate between players each loop
    char currentMark = isPlayer1Turn ? 'X' : 'O';   // Player 1 gets an X, Player 2 gets an O
    
    
    
    // Prompts users whose turn it is
    Console.WriteLine($"{currentPlayer}'s turn ({currentMark})!");

    int rowInput = -1;
    int colInput = -1;
    
    // Ask user for the ROW they want to select, keep asking if invalid input
    while (rowInput < 0 || rowInput > 2)
    {
        Console.Write("What row would you like to mark? (1, 2, 3): ");
        string rowInputStr = Console.ReadLine();

        if (int.TryParse(rowInputStr, out rowInput) && rowInput >= 1 && rowInput <= 3)
        {
            rowInput--; // Subtract 1 since array index starts at 0
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Row must be between 1 and 3.");
        }
    }

    // Ask user for the COLUMN they want to select, keep asking if invalid input
    while (colInput < 0 || colInput > 2)
    {
        Console.Write($"What column would you like to mark on row {rowInput + 1}? (1, 2, 3): ");
        string colInputStr = Console.ReadLine();

        if (int.TryParse(colInputStr, out colInput) && colInput >= 1 && colInput <= 3)
        {
            colInput--; // Subtract 1 since array index starts at 0
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Column must be between 1 and 3.");
        }
    }
    
    // Ask user for confirmation, if they type "Y", it will store their inputs in the array, if "N" it will
    // Tell them to select a row and column
    Console.WriteLine($"You selected row: {rowInput + 1}, column: {colInput + 1}. Continue? (Y/N): ");
    string confirmation = Console.ReadLine()?.ToUpper(); // convert y or n to uppercase for confirmation
    if (confirmation != "Y")
    {
        Console.WriteLine("Try again.");
        continue; // Go back to the beginning of player's turn.
    }
    
    // Check if the cell they selected is already empty
    if (board[rowInput, colInput] == ' ')
    {
        board[rowInput, colInput] = currentMark;  // Mark this cell with the current player's symbol (X or O)
    }
    else
    {
        Console.WriteLine("Cell is already taken. Try again.");
        continue; // Skip turn, try again
    }

    //Print updated board
     Support support = new Support();
     support.PrintBoard(board);

    // Switch between player's turns
    isPlayer1Turn = !isPlayer1Turn;
}






// User types A2 and that basically selects key 1 value 3.