using System;

class Program
{
    static int[,] GetMatrixFromInput(int n, int m)
    {
        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            var currentInputRow = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(currentInputRow[j]);
            }
        }

        return matrix;
    }

    //private static void PrintMatrix(decimal[,] matrix, int n, int m)
    //{
    //    for (int i = 0; i < n; i++)
    //    {
    //        for (int j = 0; j < m; j++)
    //        {
    //            if (j == n - 1)
    //            {
    //                Console.Write("{0}", matrix[i, j]);
    //            }
    //            else
    //            {
    //                Console.Write("{0} ", matrix[i, j]);
    //            }
    //        }
    //
    //        Console.WriteLine();
    //    }
    //
    //}

    static void Main()
    {
        string heightAndWidth = Console.ReadLine();
        var splitted = heightAndWidth.Split(' ');
        int n = int.Parse(splitted[0]);
        int m = int.Parse(splitted[1]);

        var matrix = GetMatrixFromInput(n, m);

        int maxSum = int.MinValue,
            currentSum = 0;

        for (int row = 0; row < n - 2; row++)
        {
            for (int col = 0; col < m - 2; col++)
            {
                if (col + 2 < m && row + 2 < n)
                {
                    currentSum =
                        matrix[row, col] +
                        matrix[row, col + 1] +
                        matrix[row, col + 2] +
                         matrix[row + 1, col] +
                        matrix[row + 1, col + 1] +
                        matrix[row + 1, col + 2] +
                        matrix[row + 2, col] +
                        matrix[row + 2, col + 1] +
                        matrix[row + 2, col + 2];
                }

                maxSum = Math.Max(maxSum, currentSum);

                currentSum = 0;
            }
        }

        Console.WriteLine(maxSum);
    }
}
