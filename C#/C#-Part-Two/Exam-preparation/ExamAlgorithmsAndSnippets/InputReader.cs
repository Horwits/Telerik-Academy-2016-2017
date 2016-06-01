using System;
using System.Linq;

public class InputReader
{
    //read n lines -> first read the number n and ..
    public static void ReadNLines()
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var currentLine = Console.ReadLine();
        }

    }

    //read a row of numbers and split it to array of numbers
    public static void ReadRowOfNumbers()
    {
        var numbers = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
    }

    //read a row of strings
    public static void ReadRowOfStrings()
    {
        var elements = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }

    //read a number and fill a matrix with dimantions equal to that number
    public static void ReadMatrix()
    {
        var n = int.Parse(Console.ReadLine());
        var matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    //read matrix from ..
    public static void ReadMatrixFromSeparatedLine()
    {
        var n = int.Parse(Console.ReadLine());
        var matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            var row = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = row[j];
            }
        }
    }
}
