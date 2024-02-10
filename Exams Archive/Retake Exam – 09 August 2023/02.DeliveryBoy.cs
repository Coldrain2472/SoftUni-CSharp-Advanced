int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = dimensions[0];
int cols = dimensions[1];

string[,] matrix = new string[rows, cols];
int boyRowInitial = 0;
int boyColInitial = 0;
int boyRow = 0;
int boyCol = 0;

for (int row = 0; row < rows; row++)
{
    string matrixInfo = Console.ReadLine();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = matrixInfo[col].ToString();

        if (matrix[row, col] == "B")
        {
            boyRowInitial = row;
            boyColInitial = col;
            boyRow = row;
            boyCol = col;
        }
    }
}

bool hasMoved = false;

while (true)
{
    string command = Console.ReadLine();

    if (command == "up")
    {
        if (boyRow > 0)
        {
            if (matrix[boyRow - 1, boyCol] == "*")
            {
                continue;
            }
            if (matrix[boyRow, boyCol] != "R")
            {
                matrix[boyRow, boyCol] = ".";
            }
            boyRow--;
        }
        else
        {
            if (matrix[boyRow, boyCol] == "-")
            {
                matrix[boyRow, boyCol] = ".";
            }
            hasMoved = true;
            Console.WriteLine("The delivery is late. Order is canceled.");
            break;
        }
    }
    if (command == "down")
    {
        if (boyRow < rows-1)
        {
            if (matrix[boyRow + 1, boyCol] == "*")
            {
                continue;
            }
            if (matrix[boyRow, boyCol] != "R")
            {
                matrix[boyRow, boyCol] = ".";
            }
            boyRow++;
        }
        else
        {
            if (matrix[boyRow, boyCol] == "-")
            {
                matrix[boyRow, boyCol] = ".";
            }
            hasMoved = true;
            Console.WriteLine("The delivery is late. Order is canceled.");
            break;
        }
    }
    if (command == "left")
    {
        if (boyCol > 0)
        {
            if (matrix[boyRow, boyCol - 1] == "*")
            {
                continue;
            }
            if (matrix[boyRow, boyCol] != "R")
            {
                matrix[boyRow, boyCol] = ".";
            }
            boyCol--;
        }
        else
        {
            if (matrix[boyRow, boyCol] == "-")
            {
                matrix[boyRow, boyCol] = ".";
            }
            hasMoved = true;
            Console.WriteLine("The delivery is late. Order is canceled.");
            break;
        }
    }
    if (command == "right")
    {
        if (boyCol < cols-1)
        {
            if (matrix[boyRow, boyCol + 1] == "*")
            {
                continue;
            }
            if (matrix[boyRow, boyCol] != "R")
            {
                matrix[boyRow, boyCol] = ".";
            }
            boyCol++;
        }
        else
        {
            if (matrix[boyRow, boyCol] == "-")
            {
                matrix[boyRow, boyCol] = ".";
            }
            hasMoved = true;
            Console.WriteLine("The delivery is late. Order is canceled.");
            break;
        }
    }

    if (matrix[boyRow, boyCol] == "P")
    {
        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
        matrix[boyRow, boyCol] = "R";
        continue;
    }

    if (matrix[boyRow, boyCol] == "A")
    {
        matrix[boyRow, boyCol] = "P";
        Console.WriteLine("Pizza is delivered on time! Next order...");
        break;
    }

}

if (hasMoved)
{
    matrix[boyRowInitial, boyColInitial] = " ";
}
else
{
    matrix[boyRowInitial, boyColInitial] = "B";
}

PrintMatrix(matrix);

static void PrintMatrix(string[,] matrix)
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