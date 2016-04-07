using System;

class Program
{
    static int CountHowManyNumbersHasToBeRemoved(int[] numbers, int length)
    {
        int removedCounter = 0;
        for (int i = 1, j = 0; i < length && j < length - 1; i++, j++)
        {
            if (numbers[j] <= numbers[i])
            {
                continue;
            }
            else
            {
                removedCounter++;
            }
        }

        return removedCounter;
    }

    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Clear();
        Console.WriteLine(CountHowManyNumbersHasToBeRemoved(numbers, n));
    }
}
