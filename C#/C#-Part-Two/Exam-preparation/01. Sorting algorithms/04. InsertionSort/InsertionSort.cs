using System;
using System.Collections.Generic;

class InsertionSort
{
    static void InsertionSortAlgorithm<T>(IList<T> elements) where T : IComparable<T>
    {
        int length = elements.Count;
        for (int i = 0; i < length - 1; i++)
        {
            int index = i + 1;
            while (index > 0)
            {
                var currentElement = elements[index - 1];
                var prevElement = elements[index];

                if (currentElement.CompareTo(prevElement) > 0)
                {
                    var temp = currentElement;
                    elements[index - 1] = prevElement;
                    elements[index] = temp;
                }

                index--;
            }
        }
    }

    static void Main()
    {
        var numbers = new List<int>() { 12, 34, 1, 4, 200, 14 };

        InsertionSortAlgorithm(numbers);

        Console.WriteLine(string.Join(" ", numbers));
    }
}
