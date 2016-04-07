using System;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var k = int.Parse(Console.ReadLine());

        var numbers = new int[n];

        var specialSum = 0;
        for (int i = 0; i < n; i++)
        {
            var currentNumber = int.Parse(Console.ReadLine());
            numbers[i] = currentNumber;

            if (currentNumber > k)
            {
                specialSum += currentNumber;
            }
        }

        Console.WriteLine(specialSum);
    }
}
