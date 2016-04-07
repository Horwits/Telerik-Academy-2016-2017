using System;

class SpiralMatrix
{
    static void Main()
    {
        /*Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
        
        n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1  2  3  4
        4 3                 8 9 4               12 13 14 5
                            7 6 5               11 16 15 6
                                                10 9  8  7
        */

        string userInput = Console.ReadLine();

        int n;
        bool userInputIsValid = int.TryParse(userInput, out n) && (1 <= n && n <= 20);
        if (userInputIsValid)
        {
            int[,] matrix = new int[n, n];

            FillMatrix(matrix, n);
            PrintMatrix(matrix, n);
        }
        else
        {
            Console.WriteLine("Invalid input number!");
        }
    }

    private static void FillMatrix(int[,] matrix, int n)
    {
        int maxRotations = n * n,
        col = 0,
        row = 0;

        string direction = "right";

        for (int i = 1; i <= maxRotations; i++)
        {
            if (direction == "right" && (col > (n - 1) || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }

            if (direction == "down" && (row > (n - 1) || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }

            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }

            if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "right";
                col++;
                row++;
            }

            matrix[row, col] = i;

            switch (direction)
            {
                case "right":
                    col++;
                    break;
                case "down":
                    row++;
                    break;
                case "left":
                    col--;
                    break;
                case "up":
                    row--;
                    break;
            }
        }
    }

    private static void PrintMatrix(int[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
