int[] matrixParameters = Console.ReadLine().Split(", ").Select(int.Parse).ToArray(); 
int rows = matrixParameters[0];
int cols = matrixParameters[1];

int[,] matrix = new int[rows, cols];
for (int row = 0; row < rows; row++)
{
	int[] rowValues = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
	for (int col = 0; col < cols; col++)
	{
		matrix[row,col]= rowValues[col];
	}
}

int sum = 0;

for (int row = 0; row < rows; row++)
{
	for (int col = 0; col < cols; col++)
	{
		sum += matrix[row, col];
	}
}

Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);