using System;
using System.Linq;

class Solution
{
    static long[][] matrix;
    static bool isFoundSum = false;
    static long maxSum;
    static long diagonalSum;

    /*Input
    On the first line of the console you will find the number N – the number of rows and columns of the matrix
    On the next N lines you will find exactly N numbers, separated by a space. This are the numbers of the matrix.
    The input data will always be valid and in the described format. There is no need to check it explicitly.
    */
    static void ReadInput()
    {
        var n = int.Parse(Console.ReadLine());
        matrix = new long[n][];

        for (int i = 0; i < n; i++)
        {
            matrix[i] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
        }
    }

    static bool FindPattern(int row, int col)
    {
        var found = matrix[row][col] + 1 == matrix[row][col + 1]
                && matrix[row][col + 1] + 1 == matrix[row][col + 2]
                && matrix[row][col + 2] + 1 == matrix[row + 1][col + 2]
                && matrix[row + 1][col + 2] + 1 == matrix[row + 2][col + 2]
                && matrix[row + 2][col + 2] + 1 == matrix[row + 2][col + 3]
                && matrix[row + 2][col + 3] + 1 == matrix[row + 2][col + 4];

        return found;
    }

    static void CalculateDiagonalSum()
    {
        diagonalSum = 0L;

        for (int i = 0; i < matrix.Length; i++)
        {
            diagonalSum += matrix[i][i];
        }
    }

    static void FindMaxSum()
    {
        maxSum = long.MinValue;
        var currentSum = 0L;
        for (int i = 0; i < matrix.Length - 2; i++)
        {
            for (int j = 0; j < matrix.Length - 4; j++)
            {
                if (FindPattern(i, j))
                {
                    isFoundSum = true;
                    currentSum = matrix[i][j]
                        + matrix[i][j + 1]
                        + matrix[i][j + 2]
                        + matrix[i + 1][j + 2]
                        + matrix[i + 2][j + 2]
                        + matrix[i + 2][j + 3] 
                        + matrix[i + 2][j + 4];

                    maxSum = Math.Max(maxSum, currentSum);
                }
                else
                {
                    continue;
                }
            }
        }
    }

    static void PrintOutput()
    {
        //•	If no patterns are to be found in the matrix – print “NO {sum}”, where sum is the sum of the numbers, that are on the main diagonal of the matrix
        //•	If at least one pattern is found in the matrix – print “YES {sum}”, where sum is the sum of the numbers in the maximal pattern
        if (isFoundSum)
        {
            Console.WriteLine("YES " + maxSum);
        }
        else
        {
            CalculateDiagonalSum();
            Console.WriteLine("NO " + diagonalSum);
        }
    }

    static void Main()
    {
        ReadInput();
        FindMaxSum();
        PrintOutput();
    }
}
