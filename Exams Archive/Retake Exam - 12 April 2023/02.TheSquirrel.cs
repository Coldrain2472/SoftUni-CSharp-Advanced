int size = int.Parse(Console.ReadLine());
List<string> directions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

string[,] matrix = new string[size, size];
int rows = size;
int cols = size;
int sqRow = 0;
int sqCol = 0;

int hazelnutsCount = 0;

for (int row = 0; row < rows; row++)
{
    string matrixInfo = Console.ReadLine();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = matrixInfo[col].ToString();

        if (matrix[row, col] == "s")
        {
            sqRow = row;
            sqCol = col;
        }
        if (matrix[row, col] == "h")
        {
            hazelnutsCount++;
        }
    }
}

int collectedHazelnuts = 0;
bool isOutOfArea = false;
bool isTrapped = false;
bool hasCollectedEnoughHazelnuts = false;

while (directions.Count > 0)
{
    string command = directions[0];

    if (command == "up" && sqRow - 1 >= 0)
    {
        if (matrix[sqRow-1,sqCol] == "h")
        {
            collectedHazelnuts++;
            matrix[sqRow - 1, sqCol] = "*";
            if (collectedHazelnuts == 3)
            {
                hasCollectedEnoughHazelnuts = true;
            }
        }
        else if (matrix[sqRow-1,sqCol] == "t")
        {
            isTrapped = true;
        }
        sqRow--;
    }
    else if (command == "down" && sqRow + 1 < rows)
    {
        if (matrix[sqRow + 1, sqCol] == "h")
        {
            collectedHazelnuts++;
            matrix[sqRow + 1, sqCol] = "*";
            if (collectedHazelnuts == 3)
            {
                hasCollectedEnoughHazelnuts = true;
            }
        }
        else if (matrix[sqRow + 1, sqCol] == "t")
        {
            isTrapped = true;
        }
        sqRow++;
    }
    else if (command == "left" && sqCol - 1 >= 0)
    {
        if (matrix[sqRow, sqCol-1] == "h")
        {
            collectedHazelnuts++;
            matrix[sqRow, sqCol - 1] = "*";
            if (collectedHazelnuts == 3)
            {
                hasCollectedEnoughHazelnuts = true;
            }
        }
        else if (matrix[sqRow, sqCol-1] == "t")
        {
            isTrapped = true;
        }
        sqCol--;
    }
    else if (command == "right" && sqCol + 1 < cols)
    {
        if (matrix[sqRow, sqCol + 1] == "h")
        {
            collectedHazelnuts++;
            matrix[sqRow, sqCol + 1] = "*";
            if (collectedHazelnuts == 3)
            {
                hasCollectedEnoughHazelnuts = true;
            }
        }
        else if (matrix[sqRow, sqCol + 1] == "t")
        {
            isTrapped = true;
        }
        sqCol++;
    }
    else
    {
        isOutOfArea = true;
    }

    if (isOutOfArea)
    {
        Console.WriteLine("The squirrel is out of the field.");
        break;
    }
    if (isTrapped)
    {
        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
        break;
    }
    if (hasCollectedEnoughHazelnuts) 
    {
        Console.WriteLine("Good job! You have collected all hazelnuts!");
        break;
    }

    directions.Remove(command);
}

if (!hasCollectedEnoughHazelnuts && !isOutOfArea && !isTrapped)
{
    Console.WriteLine("There are more hazelnuts to collect.");
}

Console.WriteLine($"Hazelnuts collected: {collectedHazelnuts}");