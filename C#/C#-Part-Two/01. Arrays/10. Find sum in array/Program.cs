using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        bool isFound = false;

        int currentSum = 0;

        int startIndex = 0,
            endIndex = 0;
        for (int i = 0; i < n; i++)
        {
            currentSum += numbers[i];
            if (currentSum > s)
            {
                i--;
                startIndex = i + 1;
                currentSum = 0;
            }

            if (currentSum == s)
            {
                isFound = true;
                endIndex = i + 1;
                break;
            }
        }

        if (isFound)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                if (i == endIndex - 1)
                {
                    Console.Write(numbers[i]);
                }
                else
                {
                    Console.Write(numbers[i] + ", ");
                }
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("There is no sequence equal to sum.");
        }
    }
}
