using System;

class RandomNumbersGenerator
{
    public static int[] GenerateTenRandomNumbers(int startInterval, int endInterval)
    {
        var numbers = new int[10];
        var number = 0;
        var randomNumber = new Random();
        for (int i = 0; i < 10; i++)
        {
            number = randomNumber.Next(startInterval, endInterval);
            for (int j = 0; j < 10; j++)
            {
                numbers[i] = number;
            }
        }

        return numbers;
    }

    static void Main()
    {
        int start = 100;
        int end = 200;

        var numbers = GenerateTenRandomNumbers(start, end);
        Console.WriteLine(string.Join(" ", numbers));
    }
}
