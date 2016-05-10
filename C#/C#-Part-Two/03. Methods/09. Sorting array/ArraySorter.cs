using System;
using System.Collections;
using System.Collections.Generic;

class ArraySorter
{
    static int[] GenerateIntArray(string[] inputArray)
    {
        int length = inputArray.Length;
        var numbers = new int[length];
        int currentPosition = 0;
        foreach (var number in inputArray)
        {
            numbers[currentPosition] = int.Parse(number);
            currentPosition++;
        }

        return numbers;
    }

    static int ReturnMaxNumber(int[] numbers, int startingIndex)
    {
        int maxNumber = 0;
        int length = numbers.Length;
        for (int i = startingIndex; i < length; i++)
        {
            maxNumber = Math.Max(maxNumber, numbers[i]);
        }

        return maxNumber;
    }

    static void Main()
    {
        var length = int.Parse(Console.ReadLine());
        var inputArray = Console.ReadLine().Split(' ');

        var numbers = GenerateIntArray(inputArray);
        Array.Sort(numbers);
        Console.WriteLine(string.Join(" ", numbers));
        //Console.WriteLine(ReturnMaxNumber(numbers, 3));
        //TODO: finishing the task.
    }
}
