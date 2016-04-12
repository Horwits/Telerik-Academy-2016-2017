using System;

class MathUtils
{
    static int ReturnMinimalNumber(string[] numbers)
    {
        int min = int.Parse(numbers[0]);
        foreach (var number in numbers)
        {
            int currentNumber = int.Parse(number);
            if (currentNumber < min)
            {
                min = currentNumber;
            }
        }
        return min;
    }

    static int ReturnMaximalNumber(string[] numbers)
    {
        int max = int.MinValue;
        foreach (var number in numbers)
        {
            int currentNumber = int.Parse(number);
            if (currentNumber > max)
            {
                max = currentNumber;
            }
        }
        return max;
    }

    static decimal ReturnAverageNumber(string[] numbers)
    {
        int length = numbers.Length;

        var sum = ReturnSumNumber(numbers);

        decimal average = sum / length;
        return average;
    }

    static decimal ReturnSumNumber(string[] numbers)
    {
        decimal sum = 0;
        foreach (var number in numbers)
        {
            int currentNumber = int.Parse(number);
            sum += currentNumber;
        }

        return sum;
    }

    static decimal ReturnProductNumber(string[] numbers)
    {
        decimal product = 1;
        foreach (var number in numbers)
        {
            int currentNumber = int.Parse(number);
            product *= currentNumber;
        }

        return product;
    }

    static void Main()
    {
        var input = Console.ReadLine().Split(' ');

        Console.WriteLine(ReturnMinimalNumber(input));

        Console.WriteLine(ReturnMaximalNumber(input));

        Console.WriteLine(ReturnAverageNumber(input));

        Console.WriteLine(ReturnSumNumber(input));

        Console.WriteLine(ReturnProductNumber(input));
    }
}
