using System;

class Numbers
{
    static int ReadNumber(int start, int end)
    {
        int number = 0;
        bool isValid = int.TryParse(Console.ReadLine(), out number);

        if (!isValid || (number < start && number > end))
        {
            throw new Exception("Exception");
        }

        return number;
    }

    static void PrintArrayNumbersIfOrderedToConsole(int [] numbers)
    {
        int length = numbers.Length;
        for (int i = 0; i < length; i++)
        {
            var currentNumber = numbers[i];
            if (i > 0 && currentNumber < numbers[i - 1])
            {
                throw new Exception("Exception");
            }
        }
        
        Console.WriteLine("{0} < {1} < {2}", 0, string.Join(" < ", numbers), 100);
    }

    static void Main()
    {
        try
        {
            var length = 10;

            var numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                int currentNumber = ReadNumber(0, 100);
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
