using System;

class Numbers
{
    static int ReadNumber(int start, int end)
    {
        int number = 0;
        try
        {
            number = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {

            throw new Exception("Exception");
        }

        return number;
    }

    static void PrintArrayNumbersIfOrderedToConsole(int[] numbers)
    {
        int length = numbers.Length;
        for (int i = 1; i < length; i++)
        {
            var currentNumber = numbers[i];
            var prevNumber = numbers[i - 1];

            if (currentNumber < 2 || currentNumber <= prevNumber || currentNumber >= 100)
            {
                throw new Exception("Exception");
            }
        }

        Console.WriteLine("{0} < {1} < {2}", 1, string.Join(" < ", numbers), 100);
    }

    static void Main()
    {
        try
        {
            var length = 10;
            var numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                int currentNumber = ReadNumber(1, 100);
                numbers[i] = currentNumber;
            }

            PrintArrayNumbersIfOrderedToConsole(numbers);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
