int size = int.Parse(Console.ReadLine());

Queue<string> commands = new Queue<string>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .ToList());

string[,] matrix = new string[size, size];

int squirrelRow = 0;
int squirrelCol = 0;
int hazelnutsToCollect = 0;
int traps = 0;
for (int row = 0; row < size; row++)
{
    string matrixInfo = Console.ReadLine();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = matrixInfo[col].ToString();
        if (matrix[row, col] == "s")
        {
            squirrelRow = row;
            squirrelCol = col;
        }
        else if (matrix[row, col] == "h")
        {
            hazelnutsToCollect++;
        }
        else if (matrix[row, col] == "t")
        {
            traps++;
        }
    }
}

int collectedHazelnuts = 0;
bool isTrapped = false;
bool isOutOfRange = false;
bool isCollectedHEnough = false;
while (commands.Any())
{
    string command = commands.Dequeue();
    if (command == "up" && squirrelRow - 1 >= 0)
    {
        if (matrix[squirrelRow - 1, squirrelCol] == "h")
        {
            hazelnutsToCollect++;
            collectedHazelnuts++;
            matrix[squirrelRow - 1, squirrelCol] = "*";
            if (collectedHazelnuts == 3)
            {
                isCollectedHEnough = true;
                break;
            }
        }
        else if (matrix[squirrelRow - 1, squirrelCol] == "t")
        {
            isTrapped = true;
            break;
        }
        squirrelRow--;
    }
    else if (command == "down" && squirrelRow + 1 < size)
    {
        if (matrix[squirrelRow + 1, squirrelCol] == "h")
        {
            hazelnutsToCollect++;
            collectedHazelnuts++;
            matrix[squirrelRow + 1, squirrelCol] = "*";
            if (collectedHazelnuts == 3)
            {
                isCollectedHEnough = true;
                break;
            }
        }
        else if (matrix[squirrelRow + 1, squirrelCol] == "t")
        {
            isTrapped = true;
            break;
        }
        squirrelRow++;
    }
    else if (command == "left" && squirrelCol - 1 >= 0)
    {
        if (matrix[squirrelRow, squirrelCol - 1] == "h")
        {
            hazelnutsToCollect++;
            collectedHazelnuts++;
            matrix[squirrelRow, squirrelCol - 1] = "*";
            if (collectedHazelnuts == 3)
            {
                isCollectedHEnough = true;
                break;
            }
        }
        else if (matrix[squirrelRow, squirrelCol - 1] == "t")
        {
            isTrapped = true;
            break;
        }
        squirrelCol--;
    }
    else if (command == "right" && squirrelCol + 1 < size)
    {
        if (matrix[squirrelRow, squirrelCol + 1] == "h")
        {
            hazelnutsToCollect++;
            collectedHazelnuts++;
            matrix[squirrelRow, squirrelCol + 1] = "*";
            if (collectedHazelnuts == 3)
            {
                isCollectedHEnough = true;
                break;
            }
        }
        else if (matrix[squirrelRow, squirrelCol + 1] == "t")
        {
            isTrapped = true;
            break;
        }
        squirrelCol++;
    }
    else
    {
        isOutOfRange = true;
    }
}

if (isOutOfRange)
{
    Console.WriteLine("The squirrel is out of the field.");
}

if (isTrapped)
{
    Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
}

if (isCollectedHEnough)
{
    Console.WriteLine("Good job! You have collected all hazelnuts!");
}

if(isTrapped != true && isOutOfRange != true && isCollectedHEnough != true)
{
    Console.WriteLine("There are more hazelnuts to collect.");
}

Console.WriteLine($"Hazelnuts collected: {collectedHazelnuts}");