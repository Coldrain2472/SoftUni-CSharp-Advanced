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

string command = string.Empty;

while ((command = Console.ReadLine()) != "END")
{
    string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string typeCommand = input[0];
    if (typeCommand == "swap" && input.Length == 5)
    {
       int rowOne = int.Parse(input[1]);
        int colOne = int.Parse(input[2]);
        int rowTwo = int.Parse(input[3]);
        int colTwo = int.Parse(input[4]);
        if (rowOne < size[0] && rowTwo < size[0] && colOne < size[1] && colTwo < size[1] && rowOne >= 0 && 
            rowTwo >= 0 && colOne >= 0 && colTwo >= 0)
        {
            int thirdVariable = matrix[rowOne, colOne];
            matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
            matrix[rowTwo, colTwo] = thirdVariable;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}