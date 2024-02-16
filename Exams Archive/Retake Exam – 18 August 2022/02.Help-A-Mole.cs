using System;

class MoleGame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char[,] matrix = new char[n, n];
        int moleRow = -1;
        int moleCol = -1;
        int totalPoints = 0;

        for (int i = 0; i < n; i++)
        {
            string row = Console.ReadLine();
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = row[j];
                if (row[j] == 'M')
                {
                    moleRow = i;
                    moleCol = j;
                }
            }
        }

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "End")
            {
                break;
            }

            MoveMole(matrix, ref moleRow, ref moleCol, command, ref totalPoints);

            if (totalPoints >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {totalPoints} points.");
                PrintMatrix(matrix, moleRow, moleCol);
                return;
            }
        }

        Console.WriteLine("Too bad! The Mole lost this battle!");
        Console.WriteLine($"The Mole lost the game with a total of {totalPoints} points.");
        PrintMatrix(matrix, moleRow, moleCol);
    }

    static void MoveMole(char[,] matrix, ref int moleRow, ref int moleCol, string command, ref int totalPoints)
    {
        matrix[moleRow, moleCol] = '-'; 

        int newRow = moleRow;
        int newCol = moleCol;

        switch (command)
        {
            case "up":
                newRow--;
                break;
            case "down":
                newRow++;
                break;
            case "left":
                newCol--;
                break;
            case "right":
                newCol++;
                break;
        }

        if (!IsValidPosition(newRow, newCol, matrix.GetLength(0)))
        {
            Console.WriteLine("Don't try to escape the playing field!");
            return;
        }

        char currentCell = matrix[newRow, newCol];

        if (char.IsDigit(currentCell))
        {
            int points = int.Parse(currentCell.ToString());
            totalPoints += points;
        }
        else if (currentCell == 'S')
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'S' && (i != newRow || j != newCol))
                    {
                        moleRow = i;
                        moleCol = j;
                        totalPoints -= 3;
                        matrix[newRow, newCol] = '-';
                        matrix[moleRow, moleCol] = '-';
                        return;
                    }
                }
            }
        }

        matrix[newRow, newCol] = 'M';
        moleRow = newRow;
        moleCol = newCol;
    }

    static bool IsValidPosition(int row, int col, int n)
    {
        return row >= 0 && row < n && col >= 0 && col < n;
    }

    static void PrintMatrix(char[,] matrix, int moleRow, int moleCol)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}