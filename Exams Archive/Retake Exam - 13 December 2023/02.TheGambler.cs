int size = int.Parse(Console.ReadLine());

string[,] matrix = new string[size, size];
int playerRow = 0;
int playerCol = 0;

int money = 100;

for (int row = 0; row < size; row++)
{
    string matrixInfo = Console.ReadLine();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = matrixInfo[col].ToString();

        if (matrix[row, col] == "G")
        {
            playerRow = row;
            playerCol = col;
        }
    }
}

string command = string.Empty;
bool isOutOfRange = false;
bool isJackPotHit = false;

while ((command = Console.ReadLine()) != "end")
{
    if (command == "up" && playerRow - 1 >= 0)
    {
        if (matrix[playerRow - 1, playerCol] == "W")
        {
            money += 100;
        }
        else if (matrix[playerRow - 1, playerCol] == "P")
        {
            money -= 200;
        }
        else if (matrix[playerRow - 1, playerCol] == "J")
        {
            isJackPotHit = true;
            matrix[playerRow, playerCol] = "-";
            playerRow--;
            matrix[playerRow, playerCol] = "G";
            break;
        }

        matrix[playerRow, playerCol] = "-";
        playerRow--;
        matrix[playerRow, playerCol] = "G";
    }
    else if (command == "down" && playerRow + 1 < size)
    {
        if (matrix[playerRow + 1, playerCol] == "W")
        {
            money += 100;
        }
        else if (matrix[playerRow + 1, playerCol] == "P")
        {
            money -= 200;
        }
        else if (matrix[playerRow + 1, playerCol] == "J")
        {
            isJackPotHit = true;
            matrix[playerRow, playerCol] = "-";
            playerRow++;
            matrix[playerRow, playerCol] = "G";
            break;
        }

        matrix[playerRow, playerCol] = "-";
        playerRow++;
        matrix[playerRow, playerCol] = "G";
    }
    else if (command == "left" && playerCol - 1 >= 0)
    {
        if (matrix[playerRow, playerCol - 1] == "W")
        {
            money += 100;
        }
        else if (matrix[playerRow, playerCol - 1] == "P")
        {
            money -= 200;
        }
        else if (matrix[playerRow, playerCol - 1] == "J")
        {
            isJackPotHit = true;
            matrix[playerRow, playerCol] = "-";
            playerCol--;
            matrix[playerRow, playerCol] = "G";
            break;
        }
        matrix[playerRow, playerCol] = "-";
        playerCol--;
        matrix[playerRow, playerCol] = "G";
    }
    else if (command == "right" && playerCol + 1 < size)
    {
        if (matrix[playerRow, playerCol + 1] == "W")
        {
            money += 100;
        }
        else if (matrix[playerRow, playerCol + 1] == "P")
        {
            money -= 200;
        }
        else if (matrix[playerRow, playerCol + 1] == "J")
        {
            isJackPotHit = true;
            matrix[playerRow, playerCol] = "-";
            playerCol++;
            matrix[playerRow, playerCol] = "G";
            break;
        }
        matrix[playerRow, playerCol] = "-";
        playerCol++;
        matrix[playerRow, playerCol] = "G";
    }
    else
    {
        isOutOfRange = true;
        break;
    }
    

    if (money <= 0)
    {
        break;
    }

}

if (isOutOfRange || money <= 0)
{
    Console.WriteLine("Game over! You lost everything!");
    Environment.Exit(0);
}

if (isJackPotHit)
{
    money += 100_000;
    Console.WriteLine("You win the Jackpot!");
    Console.WriteLine($"End of the game. Total amount: {money}$");
}
else
{
    Console.WriteLine($"End of the game. Total amount: {money}$");
}

if (money > 0)
{
    PrintMatrix(matrix);
}

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