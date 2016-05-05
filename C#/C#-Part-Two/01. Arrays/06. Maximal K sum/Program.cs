using System;

class Program
{
    static int FindMaxKSum(int[] numbers, int k)
    {
        int maxSum = 0;
        Array.Sort(numbers);

        int length = numbers.Length;
        for (int i = length - k; i < length; i++)
        {
            maxSum += numbers[i];
        }

        return maxSum;
    }

    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var k = int.Parse(Console.ReadLine());

        var numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            var currentNumber = int.Parse(Console.ReadLine());
            numbers[i] = currentNumber;
        }

        Console.WriteLine(FindMaxKSum(numbers, k));
    }
}
