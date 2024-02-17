int size = int.Parse(Console.ReadLine());

char[,] matrix = new char[size, size];
int rows = size;
int cols = size;
int posRow = -1;
int posCol = -1;
int enemies = 0;
int repairPoints = 0;

for (int row = 0; row < rows; row++)
{
    string matrixInfo = Console.ReadLine();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = matrixInfo[col];
        if (matrix[row, col] == 'J')
        {
            posRow = row;
            posCol = col;
            matrix[row, col] = '-';
        }
        if (matrix[row, col] == 'E')
        {
            enemies++;
        }
        if (matrix[row, col] == 'R')
        {
            repairPoints++;
        }
    }
}

int armor = 300;
int killedEnemies = 0;
while (true)
{
    string command = Console.ReadLine();

    if (command == "up")
    {
        posRow--;
    }
    else if (command == "down")
    {
        posRow++;
    }
    else if (command == "left")
    {
        posCol--;
    }
    else if (command == "right")
    {
        posCol++;
    }

    if (matrix[posRow, posCol] == '-')
    {
        continue;
    }
    else if (matrix[posRow, posCol] == 'R')
    {
        armor = 300;
        matrix[posRow, posCol] = '-';
    }
    else if (matrix[posRow, posCol] == 'E')
    {
        killedEnemies++;
        enemies--;
        matrix[posRow, posCol] = '-';
        if (enemies > 0)
        {
            armor -= 100;
            if (armor == 0)
            {
                matrix[posRow, posCol] = 'J';
                break;
            }
        }
        else if (enemies == 0)
        {
            matrix[posRow, posCol] = 'J';
            break;
        }
    }
}

if (enemies == 0)
{
    Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
}
else if (armor == 0)
{
    Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{posRow}, {posCol}]!");
}

PrintMatrix(matrix);

static void PrintMatrix(char[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col]);
        }

        Console.WriteLine();
    }
}