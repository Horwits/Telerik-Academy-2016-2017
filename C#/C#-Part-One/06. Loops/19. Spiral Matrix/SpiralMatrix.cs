//using System;

//class SpiralMatrix
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[n, n];
//        bool[,] usedPlaces = new bool[n, n];
//        int currentValue = 1;
//        int currentRow = 0;
//        int currentCol = 0;
//        string direction = "right";
//        while (currentValue <= n * n)
//        {
//            matrix[currentRow, currentCol] = currentValue;
//            usedPlaces[currentRow, currentCol] = true;
//            currentValue++;
//            if (direction == "right")
//            {
//                if (currentCol == n - 1 || usedPlaces[currentRow, currentCol + 1] == true)
//                {
//                    direction = "down";
//                    currentRow++;
//                }
//                else
//                {
//                    currentCol++;
//                }

//            }
//            else if (direction == "down")
//            {
//                if (currentRow == n - 1 || usedPlaces[currentRow + 1, currentCol] == true)
//                {
//                    direction = "left";
//                    currentCol--;
//                }
//                else
//                {
//                    currentRow++;
//                }
//            }
//            else if (direction == "left")
//            {
//                if (currentCol == 0 || usedPlaces[currentRow, currentCol - 1] == true)
//                {
//                    direction = "up";
//                    currentRow--;
//                }
//                else
//                {
//                    currentCol--;
//                }
//            }
//            else if (direction == "up")
//            {
//                if (currentRow == 0 || usedPlaces[currentRow - 1, currentCol] == true)
//                {
//                    direction = "right";
//                    currentCol++;
//                }
//                else
//                {
//                    currentRow--;
//                }
//            }
//        }

//        for (int row = 0; row < matrix.GetLength(0); row++)
//        {
//            for (int col = 0; col < matrix.GetLength(1); col++)
//            {
//                Console.Write("{0} ", matrix[row, col]);
//            }

//            Console.WriteLine();
//        }

//        Console.WriteLine();
//    }
//}

using System;

class SpiralMatrix
{
    static void Main()
    {
        string userInput = Console.ReadLine();

        int n;
        bool userInputIsValid = int.TryParse(userInput, out n);
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
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}
