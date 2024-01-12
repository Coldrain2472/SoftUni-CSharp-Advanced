int size = int.Parse(Console.ReadLine()); 
int rows = size; 
int cols = size; 

int[,] square = new int[rows, cols];

for (int row = 0; row < rows; row++) 
{
    int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
    for (int col = 0; col < cols; col++)
    {
        square[row, col] = values[col];
    }
}
int sum = 0;
for (int i = 0; i < square.GetLength(0); i++)
{
    sum+= square[i, i];
}
Console.WriteLine(sum);