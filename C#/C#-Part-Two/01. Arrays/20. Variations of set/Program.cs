using System;

class Program
{
    static void GenerateVariations(int[] array, int index, int elementsCount)
    {
        int length = array.Length;
        if (index == length)
        {
            PrintResultToConsole(array);
        }
        else
        {
            for (int i = 1; i <= elementsCount; i++)
            {
                array[index] = i;
                GenerateVariations(array, index + 1, elementsCount);
            }
        }
    }

    static void PrintResultToConsole(int[] array)
    {
        Console.WriteLine("{" + string.Join(",", array) + "}");
    }

    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var k = int.Parse(Console.ReadLine());

        var numbers = new int[k];

        GenerateVariations(numbers, 0, n);
    }
}
