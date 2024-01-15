int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = size[0];
int cols = size[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] values = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = values[col];
    }
}

int maxSquareSum = int.MinValue;
int maxSquareRow = 0;
int maxSquareCol = 0;

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        int currentSquareSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

        if (currentSquareSum > maxSquareSum)
        {
            maxSquareSum = currentSquareSum;
            maxSquareRow = row;
            maxSquareCol = col;

        }
    }
}

Console.WriteLine($"{matrix[maxSquareRow, maxSquareCol]} {matrix[maxSquareRow, maxSquareCol + 1]}");
Console.WriteLine($"{matrix[maxSquareRow + 1, maxSquareCol]} {matrix[maxSquareRow + 1, maxSquareCol + 1]}");
Console.WriteLine(maxSquareSum);