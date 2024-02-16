int size = int.Parse(Console.ReadLine());

int rows = size;
int cols = size;

char[,] matrix = new char[rows, cols];
int posRow = 0;
int posCol = 0;

for (int row = 0; row < rows; row++)
{
	string matrixInfo = Console.ReadLine();

	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = matrixInfo[col];

		if (matrix[row,col] == 'S')
		{
			posRow = row;
			posCol = col;
		}
	}
}

string command = string.Empty;
int hits = 0;
int destroyedCruisers = 0;

while (true)
{
	command = Console.ReadLine();

	if (command == "up")
	{
        matrix[posRow, posCol] = '-';
        posRow--;
	}
	else if (command == "down")
	{
        matrix[posRow, posCol] = '-';
        posRow++;
    }
	else if (command == "right")
	{
        matrix[posRow, posCol] = '-';
        posCol++;
    }
	else if (command == "left")
	{
        matrix[posRow, posCol] = '-';
        posCol--;
    }

    if (matrix[posRow,posCol] == '*')
    {
        matrix[posRow, posCol] = '-';
        hits++;
        matrix[posRow, posCol] = 'S';
        if (hits == 3)
        {
            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{posRow}, {posCol}]!");
            break;
        }
    }
    else if (matrix[posRow,posCol] == 'C')
    {
        matrix[posRow, posCol] = '-';
        destroyedCruisers++;
        matrix[posRow, posCol] = 'S';
        if (destroyedCruisers == 3)
        {
            Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
            break;
        }
    }
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