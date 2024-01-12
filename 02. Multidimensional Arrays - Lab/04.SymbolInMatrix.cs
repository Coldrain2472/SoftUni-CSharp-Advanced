int size = int.Parse(Console.ReadLine());
int rows = size;
int cols = size;

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    char[] values = Console.ReadLine().ToCharArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = values[col];
    }
}

char specialSymbol = char.Parse(Console.ReadLine());
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        if (specialSymbol == matrix[row, col])
        {
            Console.WriteLine($"({row}, {col})");
            return;
        }
    }
}
Console.WriteLine($"{specialSymbol} does not occur in the matrix");