using System;
using System.Text;

class Program
{
    static string ConvertArayToString<T>(T[] array)
    {
        return string.Format("{0}","{" + string.Join(" ,", array) + "}");
    }

    static void GeneratePermutation(int[] numbers, bool[] used, int index)
    {
        int length = numbers.Length;

        if (index == length)
        {
            Console.WriteLine(ConvertArayToString(numbers));
        }
        else
        {
            for (int i = 0; i < length; i++)
            {
                if (!used[i])
                {
                    numbers[index] = i + 1;
                    used[i] = true;
                    GeneratePermutation(numbers, used, index + 1);
                    used[i] = false;
                }
            }
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var number = new int[n];
        var used = new bool[n];

        GeneratePermutation(number, used, 0);
    }
}
