using System;
using System.Collections.Generic;

class BubbleSort
{
    static void BubbleSortAlgorithm<T>(IList<T> elements)
        where T : IComparable<T>
    {
        int length = elements.Count;
        for (int i = length - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                var curent = elements[j];
                var next = elements[j + 1];
                if (curent.CompareTo(next) > 0)
                {
                    elements[j] = next;
                    elements[j + 1] = curent;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        var numbers = new List<int>() { 12, 34, 1, 4, 200, 14 };

        BubbleSortAlgorithm(numbers);

        Console.WriteLine(string.Join(" ", numbers));
    }
}
