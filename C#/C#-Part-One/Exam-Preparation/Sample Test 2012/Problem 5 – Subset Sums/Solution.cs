using System;

class Solution
{
    //TODO : fix the solution
    static void Main()
    {
        decimal s = decimal.Parse(Console.ReadLine());

        byte n = byte.Parse(Console.ReadLine());

        var numbers = new decimal[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = decimal.Parse(Console.ReadLine());
        }

        int counter = 0;

        for (int i = 0; i < n; i++)
        {
            var currentNum = numbers[i];
            if (currentNum == s)
            {
                counter++;
            }

            decimal currentSum = 0;
            for (int j = i + 1; j < n; j++)
            {
                currentSum += currentNum + numbers[j];

                if (currentSum == s)
                {
                    counter++;
                }
                else
                {
                    currentSum = 0;
                }
            }
        }

        Console.WriteLine(counter);
    }
}
