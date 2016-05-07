using System;

class Program
{
    static string[,] GetMatrixFromInput(int n, int m)
    {
        var matrix = new string[n, m];

        for (int i = 0; i < n; i++)
        {
            var currentInputRow = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = currentInputRow[j];
            }
        }

        return matrix;
    }

    static int GetLongestColumnSequenceLength(string[,] matrix)
    {
        int length = 1,
            maxLength = 1,
            col = 0,
            row = 0;

        while (true)
        {
            if (row == matrix.GetLength(0) - 1)
            {
                col++;
                if (col == matrix.GetLength(1) - 1)
                {
                    break;
                }

                row = 0;

                length = 1;
                continue;
            }

            var currentElement = matrix[row, col];
            var nextElement = matrix[row + 1, col];

            if (currentElement == nextElement)
            {
                length++;
            }
            else
            {
                length = 1;
            }

            maxLength = Math.Max(length, maxLength);

            row++;
        }

        return maxLength;
    }

    static int GetLongestRowSequenceLength(string[,] matrix)
    {
        int length = 1,
            maxLength = 1,
            col = 0,
            row = 0;

        while (true)
        {
            if (col == matrix.GetLength(1) - 1)
            {
                row++;
                if (row == matrix.GetLength(0) - 1)
                {
                    break;
                }

                col = 0;

                length = 1;
                continue;
            }

            var currentElement = matrix[row, col];
            var nextElement = matrix[row, col + 1];

            if (currentElement == nextElement)
            {
                length++;
            }
            else
            {
                length = 1;
            }

            maxLength = Math.Max(length, maxLength);

            col++;
        }

        return maxLength;
    }

    static int GetLongestLeftDiagonalSequenceLength(string[,] matrix)
    {
        int length = 1,
            maxLength = 1,
            col = 0,
            row = 0;

        while (row + 1 < matrix.GetLength(0))
        {
            var currentElement = matrix[row, col];
            var nextElement = matrix[row + 1, col + 1];

            if (currentElement == nextElement)
            {
                length++;
            }
            else
            {
                length = 1;
            }

            maxLength = Math.Max(length, maxLength);

            row++;
            col++;
        }

        return maxLength;
    }

    static int GetLongestRightDiagonalSequenceLength(string[,] matrix)
    {
        int length = 1,
            maxLength = 1,
            col = matrix.GetLength(1) - 1,
            row = 0;

        while (row + 1 < matrix.GetLength(0))
        {
            var currentElement = matrix[row, col];
            var nextElement = matrix[row + 1, col - 1];

            if (currentElement == nextElement)
            {
                length++;
            }
            else
            {
                length = 1;
            }

            maxLength = Math.Max(length, maxLength);

            row++;
            col--;
        }

        return maxLength;
    }

    static void Main()
    {
        string heightAndWidth = Console.ReadLine();
        var splitted = heightAndWidth.Split(' ');
        int n = int.Parse(splitted[0]);
        int m = int.Parse(splitted[1]);

        var matrix = GetMatrixFromInput(n, m);

        var longestCol = GetLongestColumnSequenceLength(matrix);
        var longestRow = GetLongestRowSequenceLength(matrix);
        var longestLeftDiagonal = GetLongestLeftDiagonalSequenceLength(matrix);
        var longestRightDiagonal = GetLongestRightDiagonalSequenceLength(matrix);

        //Console.WriteLine(longestCol);
        //Console.WriteLine(longestRow);
        //Console.WriteLine(longestLeftDiagonal);
        //Console.WriteLine(longestRightDiagonal);

        var result = Math.Max(Math.Max(longestCol, longestRow), Math.Max(longestLeftDiagonal,longestRightDiagonal));
        Console.WriteLine(result);
    }
}
