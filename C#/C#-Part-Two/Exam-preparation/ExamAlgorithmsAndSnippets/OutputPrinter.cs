using System;

public class OutputPrinter
{
    static void PrintMatrix(int[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    static void PrintArray<T>(T[] array)
        where T : IComparable<T>
    {
        Console.WriteLine(string.Join(" ", array));
    }
}
