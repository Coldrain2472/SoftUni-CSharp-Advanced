int size = int.Parse(Console.ReadLine());
string[,] fishingArea = new string[size, size];
int positionRow = -1;
int positionCol = -1;
int fishCount = 0;
for (int row = 0; row < fishingArea.GetLength(0); row++)
{

    string currentRow = Console.ReadLine();
    for (int col = 0; col < fishingArea.GetLength(1); col++)
    {
        if (currentRow[col].ToString() == "S")
        {
            positionRow = row;
            positionCol = col;
            fishingArea[row, col] = "-";
            continue;
        }
        fishingArea[row, col] = currentRow[col].ToString();
    }
}

string input = string.Empty;
while ((input = Console.ReadLine()) != "collect the nets")
{
    if (IsMoveOutOfArea(size, positionRow, positionCol, input))
    {
        if (input == "up" || input == "down")
        {
            positionRow = NewRow(size, input);
        }

        if (input == "left" || input == "right")
        {
            positionCol = NewCol(size, input);
        }
    }
    else
    {
        if (input == "up")
        {
            positionRow--;
        }
        else if (input == "down")
        {
            positionRow++;
        }
        else if (input == "left")
        {
            positionCol--;
        }
        else
        {
            positionCol++;
        }
    }

    if (Char.IsDigit(fishingArea[positionRow, positionCol][0]))
    {
        fishCount += int.Parse(fishingArea[positionRow, positionCol]);
        fishingArea[positionRow, positionCol] = "-";
        continue;
    }

    if (fishingArea[positionRow, positionCol] == "W")
    {
        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{positionRow},{positionCol}]");
        Environment.Exit(0);
    }
}

if (fishCount >= 20)
{
    Console.WriteLine($"Success! You managed to reach the quota!");
}
else
{
    Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - fishCount} tons of fish more.");
}

if (fishCount > 0)
{
    Console.WriteLine($"Amount of fish caught: {fishCount} tons.");
}

fishingArea[positionRow, positionCol] = "S";

for (int i = 0; i < fishingArea.GetLength(0); i++)
{
    for (int j = 0; j < fishingArea.GetLength(1); j++)
    {
        Console.Write(fishingArea[i, j]);
    }
    Console.WriteLine();
}


static int NewCol(int size, string command)
{
    if (command == "left")
    {
        return size - 1;
    }
    return 0;
}

static int NewRow(int size, string command)
{
    if (command == "up")
    {
        return size - 1;
    }
    return 0;
}

static bool IsMoveOutOfArea(int size, int posRow, int posCol, string command)
{
    if (command == "up" && posRow == 0 ||
       command == "down" && posRow == size - 1 ||
       command == "left" && posCol == 0 ||
       command == "right" && posCol == size - 1)
    {
        return true;
    }
    return false;
}