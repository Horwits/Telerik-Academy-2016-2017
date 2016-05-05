using System;

class Program
{
    //TODO: 22.Задачата може да се реши като се направи допълнителен масив със дължина броя на елементите. В този масив ще пазим текущата най-дълга редица с край елемента на този индекс.

    static int CountHowManyNumbersHasToBeRemoved(int[] numbers, int length)
    {
        int removedCounter = 0;
        int[] seq = new int[length];
        var firstNum = numbers[0];
        for (int i = 0, j = 1; i < length - 1; i++)
        {

        }
        return removedCounter;
    }

    //static int CountHowManyNumbersHasToBeRemoved(int[] numbers, int length)
    //{
    //    int removedCounter = 0;
    //    for (int i = 1, j = 0; i < length && j < length - 1; i++, j++)
    //    {
    //        if (numbers[j] <= numbers[i])
    //        {
    //            continue;
    //        }
    //        else
    //        {
    //            removedCounter++;
    //        }
    //    }

    //    return removedCounter;
    //}

    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(CountHowManyNumbersHasToBeRemoved(numbers, n));
    }
}
