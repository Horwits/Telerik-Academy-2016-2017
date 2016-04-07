using System;

class Program
{
    static decimal FindMaxSumInArray(int[] numbers, int arrayLength)
    {
        decimal maxSum = decimal.MinValue;
        decimal currentSum = 0;

        for (int index = 0; index < arrayLength; index++)
        {
            currentSum += numbers[index];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
            if (currentSum < 0)
            {
                currentSum = 0;
            }
        }

        return maxSum;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            numbers[i] = currentNum;
        }

        Console.WriteLine(FindMaxSumInArray(numbers, n));
    }
}
