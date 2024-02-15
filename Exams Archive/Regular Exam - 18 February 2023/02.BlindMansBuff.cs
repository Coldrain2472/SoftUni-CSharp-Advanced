int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = dimensions[0];
int cols = dimensions[1];

string[,] matrix = new string[rows, cols];
int playerRow = 0;
int playerCol = 0;
int playersCount = 0;

for (int row = 0; row < rows; row++)
{
    string[] matrixInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = matrixInfo[col];
        if (matrix[row, col] == "B")
        {
            playerRow = row;
            playerCol = col;
        }
        else if (matrix[row, col] == "P")
        {
            playersCount++;
        }
    }
}

string command = string.Empty;
int touchedPlayers = 0;
int movesMade = 0;

while ((command = Console.ReadLine()) != "Finish")
{
    bool moveIsMade = false;
    if (command == "up" && IsPositionValid(playerRow - 1, playerCol, rows, cols))
    {
        if (matrix[playerRow - 1, playerCol] != "O")
        {
            playerRow--;
            movesMade++;
            moveIsMade = true;
        }
    }
    else if (command == "down" && IsPositionValid(playerRow + 1, playerCol, rows, cols))
    {
        if (matrix[playerRow + 1, playerCol] != "O")
        {
            playerRow++;
            movesMade++;
            moveIsMade = true;
        }
    }
    else if (command == "right" && IsPositionValid(playerRow, playerCol + 1, rows, cols))
    {
        if (matrix[playerRow, playerCol + 1] != "O")
        {
            playerCol++;
            movesMade++;
            moveIsMade = true;
        }
    }
    else if (command == "left" && IsPositionValid(playerRow, playerCol - 1, rows, cols))
    {
        if (matrix[playerRow, playerCol - 1] != "O")
        {
            playerCol--;
            movesMade++;
            moveIsMade = true;
        }
    }
    else
    {
        continue;
    }

    if (moveIsMade)
    {
        if (matrix[playerRow, playerCol] == "P")
        {
            touchedPlayers++;
            if (playersCount == touchedPlayers)
            {
                break;
            }
        }
    }
}

Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {touchedPlayers} Moves made: {movesMade}");


static bool IsPositionValid(int row, int col, int rows, int cols)
{
    if (row >= 0 && row < rows && col >= 0 && col < cols)
    {
        return true;
    }
    return false;
}