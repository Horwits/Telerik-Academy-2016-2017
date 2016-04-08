using System;

class Program
{
    static void Main()
    {
        string userInput = Console.ReadLine();
        string letter = Console.ReadLine();

        int n;
        bool userInputIsValid = int.TryParse(userInput, out n) && (1 <= n && n <= 20);
        if (userInputIsValid)
        {
            int[,] matrix = new int[n, n];

            if (letter == "a")
            {
                FillMatrixTypeA(matrix, n);
            }
            else if (letter == "d")
            {
                FillMatrixTypeD(matrix, n);
            }

            PrintMatrix(matrix, n);
        }
        else
        {
            Console.WriteLine("Invalid input number!");
        }
    }

    private static void FillMatrixTypeA(int[,] matrix, int n)
    {
        int maxRotations = n * n,
        col = 0,
        row = 0;

        string direction = "down";

        for (int i = 1; i <= maxRotations; i++)
        {
            if (direction == "right" && (col == (n - n) + col || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }

            if (direction == "down" && (row > (n - 1) || matrix[row, col] != 0))
            {
                direction = "right";
                row -= n;
                col++;
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

    private static void FillMatrixTypeD(int[,] matrix, int n)
    {
        int maxRotations = n * n,
        col = 0,
        row = 0;

        string direction = "down";

        for (int i = 1; i <= maxRotations; i++)
        {
            if (direction == "right" && (col > (n - 1) || matrix[row, col] != 0))
            {
                direction = "up";
                col--;
                row--;
            }

            if (direction == "down" && (row > (n - 1) || matrix[row, col] != 0))
            {
                direction = "right";
                row--;
                col++;
            }

            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "down";
                col++;
                row++;
            }

            if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "left";
                col--;
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
