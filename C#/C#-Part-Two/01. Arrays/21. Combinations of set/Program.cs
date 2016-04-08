using System;

class Program
{
    static string ConvertArayToString<T>(T[] array)
    {
        return string.Format("{0}", "{" + string.Join(" ,", array) + "}");
    }

    static void Combinations(int[] array, int index, int currentNumber, int elements)
    {
        int length = array.Length;
        if (index == length)
        {
            Console.WriteLine(ConvertArayToString(array));
        }
        else
        {
            for (int i = currentNumber; i <= elements; i++)
            {
                array[index] = i;
                Combinations(array, index + 1, i + 1, elements);
            }
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[k];

        Combinations(arr, 0, 1, n);
    }
}
