using System;

class Program
{
    static void Main()
    {
        /*
2, 1, 2, 4, 3, 5, 2, 6
14
12, 1, 12, 4, 13, 5, 12, 6
14
        */

        var array = Console.ReadLine();
        int wantedSum = int.Parse(Console.ReadLine());

        var splitted = array.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(splitted);

        int length = splitted.Length;

        decimal currentSum = 0;

        int currentPosition = length - 1,
            currentMax = int.Parse(splitted[currentPosition]);

        while (true)
        {
            currentMax = int.Parse(splitted[currentPosition]);

            if (currentPosition <= 0)
            {
                break;
            }

            if (currentSum == wantedSum)
            {
                break;
            }

            currentSum += currentMax;

            if (currentSum < 0 || currentSum > wantedSum)
            {
                currentSum -= currentMax;
            }

            currentPosition--;
        }

        Console.WriteLine(currentSum == wantedSum ? "yes" : "no");
    }
}
