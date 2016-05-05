using System;

class Program
{
    static int[] SwapElements(int[] array, int from, int to)
    {
        int fromValue = array[from];
        array[from] = array[to];
        array[to] = fromValue;

        return array;
    }

    static int[] SelectionSort(int[] numbers, int length)
    {
        for (int j = 0; j < length - 1; j++)
        {
            int currentMinOnPosition = j;
            for (int i = j + 1; i < length; i++)
            {
                if (numbers[i] < numbers[currentMinOnPosition])
                {
                    currentMinOnPosition = i;
                }
            }

            if (currentMinOnPosition != j)
            {
                SwapElements(numbers, j, currentMinOnPosition);
            }
        }

        return numbers;
    }

    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var numbers = new int[n];

        for (int k = 0; k < n; k++)
        {
            var currentNumber = int.Parse(Console.ReadLine());
            numbers[k] = currentNumber;
        }

        numbers = SelectionSort(numbers, n);

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}
