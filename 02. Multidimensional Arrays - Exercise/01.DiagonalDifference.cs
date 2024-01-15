int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];
int primaryDiagonalSum = 0;
int secondaryDiagonalSum = 0;
for (int row = 0; row < size; row++)
{
    int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = rowValues[col];
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    primaryDiagonalSum += matrix[i, i];
    secondaryDiagonalSum += matrix[i, matrix.GetLength(1) - 1 - i];

}

int finalResult = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
Console.WriteLine(finalResult);