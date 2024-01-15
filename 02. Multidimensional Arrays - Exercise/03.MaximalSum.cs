int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int[,] matrix = new int[size[0], size[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] rowValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = rowValues[col];
    }
}

int biggestSum = int.MinValue;
int biggestSumRow = 0;
int biggestSumCol = 0;

for (int row = 0; row < matrix.GetLength(0)-2; row++)
{
    for (int col = 0; col < matrix.GetLength(1)-2; col++)
    {
        int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
            matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
            matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

        if (currentSum > biggestSum)
        {
            biggestSum = currentSum;
            biggestSumRow = row;
            biggestSumCol = col;
        }
    }
}
Console.WriteLine($"Sum = {biggestSum}");
for (int row = biggestSumRow; row <= biggestSumRow+2; row++)
{
    for (int col = biggestSumCol; col <= biggestSumCol+2; col++)
    {
        Console.Write($"{matrix[row, col]} " );
    }
    Console.WriteLine();
}