int[] dimensions = Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = dimensions[0];
int cols = dimensions[1];

char[,] matrix = new char[rows, cols];
int mouseRow = 0;
int mouseCol = 0;
int cheeseCount = 0;
for (int row = 0; row < rows; row++)
{
    string matrixInfo = Console.ReadLine();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = matrixInfo[col];
        if (matrix[row, col] == 'M')
        {
            mouseRow = row;
            mouseCol = col;
        }
        else if (matrix[row, col] == 'C')
        {
            cheeseCount++;
        }
    }
}

string command = string.Empty;
int cheeseEaten = 0;
while ((command = Console.ReadLine()) != "danger")
{
    bool moveIsMade = false;
    if (command == "up" && IsPositionValid(mouseRow - 1, mouseCol, rows, cols))
    {
        if (matrix[mouseRow - 1, mouseCol] != '@')
        {
            matrix[mouseRow, mouseCol] = '*';
            mouseRow--;
            moveIsMade = true;
        }
    }
    else if (command == "down" && IsPositionValid(mouseRow + 1, mouseCol, rows, cols))
    {
        if (matrix[mouseRow + 1, mouseCol] != '@')
        {
            matrix[mouseRow, mouseCol] = '*';
            mouseRow++;
            moveIsMade = true;
        }
    }
    else if (command == "right" && IsPositionValid(mouseRow, mouseCol + 1, rows, cols))
    {
        if (matrix[mouseRow, mouseCol + 1] != '@')
        {
            matrix[mouseRow, mouseCol] = '*';
            mouseCol++;
            moveIsMade = true;
        }
    }
    else if (command == "left" && IsPositionValid(mouseRow, mouseCol - 1, rows, cols))
    {
        if (matrix[mouseRow, mouseCol - 1] != '@')
        {
            matrix[mouseRow, mouseCol] = '*';
            mouseCol--;
            moveIsMade = true;
        }
    }
    else
    {
        Console.WriteLine("No more cheese for tonight!");
        PrintMatrix(matrix, rows, cols);
        return;
    }

    if (moveIsMade)
    {
        if (matrix[mouseRow, mouseCol] == 'C')
        {
            cheeseEaten++;
            if (cheeseCount == cheeseEaten)
            {
                matrix[mouseRow, mouseCol] = 'M';
                Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                PrintMatrix(matrix, rows, cols);
                return;
            }
        }
        else if (matrix[mouseRow, mouseCol] == 'T')
        {
            matrix[mouseRow, mouseCol] = 'M';
            Console.WriteLine("Mouse is trapped!");
            PrintMatrix(matrix, rows, cols);
            return;
        }

        matrix[mouseRow, mouseCol] = 'M';
    }
}

Console.WriteLine("Mouse will come back later!");
PrintMatrix(matrix, rows, cols);


static bool IsPositionValid(int row, int col, int rows, int cols)
{
    if (row >= 0 && row < rows && col >= 0 && col < cols)
    {
        return true;
    }
    return false;
}

static void PrintMatrix(char[,] matrix, int rowsCount, int colsCount)
{
    for (int row = 0; row < rowsCount; row++)
    {
        for (int col = 0; col < colsCount; col++)
        {
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
}
